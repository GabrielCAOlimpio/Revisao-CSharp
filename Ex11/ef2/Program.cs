using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;
using Facebook.Models;
using Facebook.Data;




var builder = WebApplication.CreateBuilder(args);



builder.Services.AddDbContext<FacebookContext>(opt => 
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); // Aqui é onde a interface gráfica é criada
}




app.MapGet("/users", async (int? page, int? take, FacebookContext db) =>
{
    // Coalesce: se vier nulo, assume o padrão
    int p = page ?? 1;
    int t = take ?? 10;

    // Validações básicas
    if (p <= 0) p = 1;
    if (t <= 0) t = 10;
    if (t > 50) t = 50; // Limite de segurança para não sobrecarregar o banco

    var users = await db.users
        .OrderBy(u => u.Id) // SEMPRE ordene antes de Skip/Take
        .Select(u => new 
        {
            u.Id,
            Name = u.Username,
            DataDeCriacao = u.CreatedAt.Date,
            u.Email
        })
        .Skip((p - 1) * t)
        .Take(t)
        .ToListAsync();

    return Results.Ok(users);
});

app.MapGet("/users/{id:int}", async (int id, FacebookContext db) =>
{
    var user = await db.users
        .Where(c => c.Id == id)
        .AsNoTracking()
        .Select(c => new
        {
            Username = c.Username,
            Email = c.Email,
            Posts = c.Posts.Select(c => c.Content).ToList()
        })
        .FirstOrDefaultAsync();

    

    if (user == null)
        return Results.NotFound("Erro! Não foi possivel encontrar um usuario com esse id");

    return Results.Ok(user);

});

app.MapPost("/users", async (UserDTO userDTO, FacebookContext db) =>
{
    using var transaction = await db.Database.BeginTransactionAsync();

    try
    {
        if (userDTO == null)
            return Results.BadRequest("Erro! Usuário não pode ser null!");

        if (string.IsNullOrEmpty(userDTO.username) || string.IsNullOrEmpty(userDTO.email))
            return Results.BadRequest("Erro! Username e Email são obrigatórios!");

        var newUser = new User 
        { 
            Username = userDTO.username, 
            Email = userDTO.email 
        };

        await db.users.AddAsync(newUser);

        await db.SaveChangesAsync();

        await transaction.CommitAsync();

        return Results.Created($"/users/{newUser.Id}", newUser); 
    }
    catch (System.Exception)
    {
        await transaction.RollbackAsync();
        return Results.Problem("Erro interno ao processar o cadastro.");
    }   
});





app.Run();



public record UserDTO(string username, string email);