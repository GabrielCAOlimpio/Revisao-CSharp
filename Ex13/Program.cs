using GestaoFinacaMinimalAPI.DTOs.Faturamento;
using GestaoFinacaMinimalAPI.DTOs.Gastos;
using GestaoFinacaMinimalAPI.Interfaces.Repositories;
using GestaoFinacaMinimalAPI.Interfaces.Services;
using GestaoFinacaMinimalAPI.Repositories;
using GestaoFinacaMinimalAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IFaturamentoRepository,FaturamentoRepository>();
builder.Services.AddScoped<IFaturamentoService,FaturamentoService>();

builder.Services.AddScoped<IGastosRepository,GastosRepository>();
builder.Services.AddScoped<IGastosService, GastosService>();


builder.Services.AddOpenApi();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    app.MapScalarApiReference(opt =>
    {
        opt
            .WithTitle("Gestão Financeira API")
            .WithTheme(ScalarTheme.DeepSpace)
            .WithDefaultHttpClient(ScalarTarget.CSharp, ScalarClient.HttpClient);
    });
}


app.MapGet("/", () => Results.Redirect("/scalar/v1"));

app.MapGet("/faturamentos", async ([FromServices] IFaturamentoService service) =>
{
    try
    {
        var faturamentos = await service.GetFaturamentosAsync();
        return Results.Ok(faturamentos);
    }
    catch (System.ArgumentException ex)
    {
        return Results.BadRequest(ex.Message);
    }
    catch (System.Exception)
    {
        return Results.Problem("Ocorreu um erro interno ao obter os faturamentos. Tente novamente mais tarde.");
    }
});

app.MapGet("/gastos", async ([FromServices] IGastosService service) =>
{
    try
    {
        var gastos = await service.GetGastosAsync();
        return Results.Ok(gastos);        
    }
    catch (System.ArgumentException ex)
    {
        return Results.BadRequest(ex.Message);
    }
    catch (System.Exception)
    {
        return Results.Problem("Ocorreu um erro interno ao obter os gastos. Tente novamente mais tarde.");
    }
});

//Posts
app.MapPost("/faturamento", async ([FromBody] FaturamentoRequestDTO dto, [FromServices] IFaturamentoService service) =>
{
    try
    {
        await service.CriarFaturamentoAsync(dto);
        return Results.Created();
    }
    catch (System.ArgumentException ex)
    {
        return Results.BadRequest(ex.Message);
    }
    catch(System.Exception)
    {
        return Results.Problem("Ocorreu um erro interno ao criar o faturamento. Tente novamente mais tarde.");
    }
});

app.MapPost("/gastos", async ([FromBody] GastosRequestDTO dto, [FromServices] IGastosService service) =>
{
    try
    {
        await service.AddGastosAsync(dto);
        return Results.Created();
    }
    catch (System.ArgumentException ex)
    {
        return Results.BadRequest(ex.Message);
    }
    catch(System.Exception)
    {
        return Results.Problem("Ocorreu um erro interno ao criar o gasto. Tente novamente mais tarde.");
    }
});

//Puts
app.MapPut("/faturamento/{id}", async (string id, [FromBody] FaturamentoRequestDTO dto, [FromServices] IFaturamentoService service) =>
{
    try
    {
        await service.EditarFaturamentoAsync(id, dto);
        return Results.NoContent();
    }
    catch (System.ArgumentException ex)
    {
        return Results.BadRequest(ex.Message);
    }
    catch (KeyNotFoundException ex)
    {
        return Results.NotFound(ex.Message);
    }
    catch (System.Exception)
    {
        return Results.Problem("Ocorreu um erro interno ao editar o faturamento. Tente novamente mais tarde.");
    }
});
app.MapPut("/gastos/{id}", async (string id, [FromBody] GastosRequestDTO dto, [FromServices] IGastosService service) =>
{
    try
    {
        await service.EditarGastosAsync(id, dto);
        return Results.NoContent();
    }
    catch (System.ArgumentException ex)
    {
        return Results.BadRequest(ex.Message);
    }
    catch (KeyNotFoundException ex)
    {
        return Results.NotFound(ex.Message);
    }
    catch (System.Exception)
    {
        return Results.Problem("Ocorreu um erro interno ao editar o gasto. Tente novamente mais tarde.");
    }
});

//Deletes
app.MapDelete("/faturamento/{id}", async (string id, [FromServices] IFaturamentoService service) =>
{
    try
    {
        await service.ExcluirFaturamentoAsync(id);
        return Results.NoContent();
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(ex.Message);
    }
    catch (KeyNotFoundException ex)
    {
        return Results.NotFound(ex.Message);
    }
    catch (System.Exception)
    {
        return Results.Problem("Ocorreu um erro interno ao excluir o faturamento. Tente novamente mais tarde.");
    }
});

app.MapDelete("/gastos/{id}", async (string id, [FromServices] IGastosService service) =>
{
    try
    {
        await service.ExcluirGastosAsync(id);
        return Results.NoContent();
    }
    catch (KeyNotFoundException ex)
    {
        return Results.NotFound(ex.Message);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(ex.Message);
    }
    catch (System.Exception)
    {
        return Results.Problem($"Ocorreu um erro interno ao excluir os gastos. Tente novamente mais tarde.");
    }
});



app.UseHttpsRedirection();

app.Run();

