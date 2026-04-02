using GestaoFinacaMinimalAPI.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
    { 
    }

    public DbSet<Faturamento> Faturamentos {get;set;}
    public DbSet<Gastos> Gastos { get;set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Faturamento>
        (
            f =>
            {
                f.HasKey(fat => fat.Id);
                f.Property(fat => fat.Titulo).IsRequired().HasColumnType("varchar(100)");
                f.Property(fat => fat.Descricao).HasColumnType("varchar(500)").HasMaxLength(500);
                f.Property(fat => fat.Valor).IsRequired().HasColumnType("decimal(18,2)").HasDefaultValue(0);
                f.Property(fat => fat.DataDeFaturamento).HasColumnType("datetime2").HasDefaultValueSql("SYSUTCDATETIME()");
            }
        );
        modelBuilder.Entity<Gastos>
        (
            g =>
            {
                g.HasKey(gast => gast.Id);
                g.Property(gast => gast.Titulo).IsRequired().HasColumnType("varchar(100)");
                g.Property(gast => gast.Descricao).HasColumnType("varchar(500)").HasMaxLength(500);
                g.Property(gast => gast.Valor).IsRequired().HasColumnType("decimal(18,2)").HasDefaultValue(0);
                g.Property(gast => gast.DataDeGastos).HasColumnType("datetime2").HasDefaultValueSql("SYSUTCDATETIME()");
            }
        );
    }
}