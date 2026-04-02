using GestaoFinacaMinimalAPI.Models;

namespace GestaoFinacaMinimalAPI.Interfaces.Repositories;


public interface IGastosRepository
{
    Task<List<Gastos>> GetGastosAsync();
    Task AddGastosAsync(Gastos newGasto);

    Task EditarGastosAsync(Guid guid, Gastos updatedGasto);

    Task ExcluirGastosAsync(Guid guid);

}