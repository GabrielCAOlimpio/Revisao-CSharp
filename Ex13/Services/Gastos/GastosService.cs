using GestaoFinacaMinimalAPI.DTOs.Gastos;
using GestaoFinacaMinimalAPI.Interfaces.Repositories;
using GestaoFinacaMinimalAPI.Interfaces.Services;
using GestaoFinacaMinimalAPI.Models;
using System.Globalization;

namespace GestaoFinacaMinimalAPI.Services;

public class GastosService : IGastosService
{
    private readonly IGastosRepository _gastosRepository;

    public GastosService(IGastosRepository gastosRepository)
    {
        _gastosRepository = gastosRepository;
    }

    public async Task<List<GastosResponseDTO>> GetGastosAsync()
    {
        var gastos = await  _gastosRepository.GetGastosAsync();
        return gastos.Select(g => new GastosResponseDTO
        {
            Id = g.Id,
            Titulo = g.Titulo,
            Descricao = g.Descricao,
            DataDeGastos = g.DataDeGastos.ToString("yyyy-MM-dd"),
            Valor = g.Valor
        }).ToList();
    }

    public async Task AddGastosAsync(GastosRequestDTO newGastoDTO)
    {
    

        if (string.IsNullOrWhiteSpace(newGastoDTO.Titulo))
        {
            throw new ArgumentException("O título do gasto é obrigatório.");
        }
        if (string.IsNullOrWhiteSpace(newGastoDTO.Valor))
        {
            throw new ArgumentException("O valor do gasto é obrigatório.");
        }
        if (!decimal.TryParse(newGastoDTO.Valor, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal valorDecimal))
        {
            throw new ArgumentException("O valor do gasto é inválido. Certifique-se de fornecer um número válido.");
        }
        if (valorDecimal <= 0)
        {
            throw new ArgumentException("O valor do gasto deve ser positivo.");
        }
        if (newGastoDTO.Descricao != null && newGastoDTO.Descricao.Length > 500)
        {
            throw new ArgumentException("A descrição do gasto não pode exceder 500 caracteres.");
        }
        if (string.IsNullOrWhiteSpace(newGastoDTO.DataDeGastos))
        {
            newGastoDTO.DataDeGastos = DateTime.UtcNow.ToString("yyyy-MM-dd");
        }
        if (!DateTime.TryParse(newGastoDTO.DataDeGastos, out DateTime dateDeGastos))
        {
            throw new ArgumentException("A data do gasto é inválida. Use um formato de data válido.");
        }
        if (dateDeGastos > DateTime.UtcNow)
        {
            throw new ArgumentException("A data do gasto não pode ser futura.");
        }
        var newGasto = new Gastos
        (
            newGastoDTO.Titulo,
            valorDecimal,
            newGastoDTO.Descricao ?? string.Empty,
            dateDeGastos
        );

        await _gastosRepository.AddGastosAsync(newGasto);
    }
    public async Task EditarGastosAsync(string guidString, GastosRequestDTO updatedGastoDTO)
    {
        if (!Guid.TryParse(guidString, out Guid guid))
        {
            throw new ArgumentException("ID do gasto é inválido. Certifique-se de fornecer um GUID válido.");
        }
        if (guid == Guid.Empty)
        {
            throw new ArgumentException("ID do gasto é inválido.");
        }
        if (string.IsNullOrWhiteSpace(updatedGastoDTO.Titulo))
        {
            throw new ArgumentException("O título do gasto é obrigatório.");
        }
        if (string.IsNullOrWhiteSpace(updatedGastoDTO.Valor))
        {
            throw new ArgumentException("O valor do gasto é obrigatório.");
        }
        if (!decimal.TryParse(updatedGastoDTO.Valor, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal valorDecimal))
        {
            throw new ArgumentException("O valor do gasto é inválido. Certifique-se de fornecer um número válido.");
        }
        if (valorDecimal <= 0)
        {
            throw new ArgumentException("O valor do gasto deve ser positivo.");
        }

        if (updatedGastoDTO.Descricao != null && updatedGastoDTO.Descricao.Length > 500)
        {
            throw new ArgumentException("A descrição do gasto não pode exceder 500 caracteres.");
        }

        if (!DateTime.TryParse(updatedGastoDTO.DataDeGastos, out DateTime dateDeGastos))
        {
            throw new ArgumentException("A data do gasto é inválida. Use um formato de data válido.");
        }
        if (dateDeGastos > DateTime.UtcNow)
        {
            throw new ArgumentException("A data do gasto não pode ser futura.");
        }

        var newGasto = new Gastos
        (
            updatedGastoDTO.Titulo,
            valorDecimal,
            updatedGastoDTO.Descricao ?? string.Empty,
            dateDeGastos
        );

        

        await _gastosRepository.EditarGastosAsync(guid, newGasto);
    }
    public async Task ExcluirGastosAsync(string guidString)
    {
        if (!Guid.TryParse(guidString, out Guid guid))
        {
            throw new ArgumentException("ID do gasto é inválido. Certifique-se de fornecer um GUID válido.");
        }
        if (guid == Guid.Empty)
        {
            throw new ArgumentException("ID do gasto é inválido.");
        }

        await _gastosRepository.ExcluirGastosAsync(guid);
    }
}