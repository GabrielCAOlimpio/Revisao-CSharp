using GestaoFinacaMinimalAPI.DTOs.Faturamento;
using GestaoFinacaMinimalAPI.Models;

namespace GestaoFinacaMinimalAPI.Interfaces.Services;


public interface IFaturamentoService
{
    public Task<List<FaturamentoResponseDTO>> GetFaturamentosAsync();
    public Task CriarFaturamentoAsync(FaturamentoRequestDTO newFaturamento);
    public Task EditarFaturamentoAsync(string guid, FaturamentoRequestDTO updatedFaturamento);
    public Task ExcluirFaturamentoAsync(string guid);
    
}