using GestaoFinacaMinimalAPI.Interfaces.Repositories;
using GestaoFinacaMinimalAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace GestaoFinacaMinimalAPI.Repositories;


public class FaturamentoRepository : IFaturamentoRepository
{
    private readonly AppDbContext _dbContext;

    public FaturamentoRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Faturamento>> GetFaturamentosAsync()
    {
        return await _dbContext.Faturamentos
        .AsNoTracking()
        .ToListAsync();
    }
    public async Task CriarFaturamentoAsync(Faturamento newFaturamento)
    {
        _dbContext.Add(newFaturamento);
        await _dbContext.SaveChangesAsync();
       
    }
    public async Task EditarFaturamentoAsync(Guid guid, Faturamento updatedFaturamento)
    {
        var existingFaturamento = await _dbContext.Faturamentos.FindAsync(guid);

        if (existingFaturamento == null)
        {
            throw new KeyNotFoundException("Faturamento não encontrado.");
        }
        existingFaturamento.Alterar(updatedFaturamento.Titulo, updatedFaturamento.Valor, updatedFaturamento.Descricao, updatedFaturamento.DataDeFaturamento);

        await _dbContext.SaveChangesAsync();
    }
    public async Task ExcluirFaturamentoAsync(Guid guid)
    {
        var existingFaturamento = await _dbContext.Faturamentos.FindAsync(guid);

        if (existingFaturamento == null)
        {
            throw new KeyNotFoundException("Faturamento não encontrado.");
        }

        _dbContext.Faturamentos.Remove(existingFaturamento);
        await _dbContext.SaveChangesAsync();
    }
}