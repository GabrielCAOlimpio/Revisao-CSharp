using GestaoFinacaMinimalAPI.Interfaces.Repositories;
using GestaoFinacaMinimalAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace GestaoFinacaMinimalAPI.Repositories;


public class GastosRepository : IGastosRepository
{
    private readonly AppDbContext _dbContext;

    public GastosRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Gastos>> GetGastosAsync()
    {
        return await _dbContext.Gastos.AsNoTracking().ToListAsync();
    }

    public async Task  AddGastosAsync(Gastos newGasto)
    {
        _dbContext.Add(newGasto);
        await _dbContext.SaveChangesAsync();
    }
    public async Task EditarGastosAsync(Guid guid, Gastos updatedGasto)
    {
        var existingGasto = await _dbContext.Gastos.FindAsync(guid);

        if (existingGasto == null)
        {
            throw new KeyNotFoundException("Gasto não encontrado.");
        }
        existingGasto.Alterar(updatedGasto.Titulo, updatedGasto.Valor, updatedGasto.Descricao, updatedGasto.DataDeGastos);

        await _dbContext.SaveChangesAsync();
    }
    public async Task ExcluirGastosAsync(Guid guid)
    {
        var existingGasto = await _dbContext.Gastos.FindAsync(guid);

        if (existingGasto == null)
        {
            throw new KeyNotFoundException("Gasto não encontrado.");
        }

        _dbContext.Gastos.Remove(existingGasto);
        await _dbContext.SaveChangesAsync();
    }
}