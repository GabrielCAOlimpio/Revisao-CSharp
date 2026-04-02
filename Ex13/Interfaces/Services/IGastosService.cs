using GestaoFinacaMinimalAPI.DTOs.Faturamento;
using GestaoFinacaMinimalAPI.DTOs.Gastos;
using GestaoFinacaMinimalAPI.Models;

namespace GestaoFinacaMinimalAPI.Interfaces.Services;


public interface IGastosService
{
    public Task<List<GastosResponseDTO>> GetGastosAsync();
    public Task AddGastosAsync(GastosRequestDTO newGastos);
    public Task EditarGastosAsync(string guid, GastosRequestDTO updatedGastos);
    public Task ExcluirGastosAsync(string guid);
    
}