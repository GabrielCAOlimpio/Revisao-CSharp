using GestaoFinacaMinimalAPI.Models;

namespace GestaoFinacaMinimalAPI.Interfaces.Repositories;


public interface IFaturamentoRepository
{
    Task<List<Faturamento>> GetFaturamentosAsync();
    Task CriarFaturamentoAsync(Faturamento newFaturamento);
    Task EditarFaturamentoAsync(Guid guid, Faturamento updatedFaturamento);

    Task ExcluirFaturamentoAsync(Guid guid);

}