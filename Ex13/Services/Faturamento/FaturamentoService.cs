using GestaoFinacaMinimalAPI.DTOs.Faturamento;
using GestaoFinacaMinimalAPI.Interfaces.Repositories;
using GestaoFinacaMinimalAPI.Interfaces.Services;
using GestaoFinacaMinimalAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace GestaoFinacaMinimalAPI.Services;


public class FaturamentoService : IFaturamentoService
{
    private readonly IFaturamentoRepository _faturamentoRepository;

    public FaturamentoService(IFaturamentoRepository faturamentoRepository)
    {
        _faturamentoRepository = faturamentoRepository;
    }

    public async Task<List<FaturamentoResponseDTO>> GetFaturamentosAsync()
    {
        var faturamento = await _faturamentoRepository.GetFaturamentosAsync();

        return faturamento.Select ( fat =>  new FaturamentoResponseDTO 
        {
            Id = fat.Id,
            Titulo = fat.Titulo,
            Descricao = fat.Descricao,
            Valor = fat.Valor,
            DataDeFaturamento = fat.DataDeFaturamento.ToString("yyyy-MM-dd")
        }).ToList();

        
        

    }
    public async Task CriarFaturamentoAsync(FaturamentoRequestDTO newFaturamentoDTO)
    {
        if (string.IsNullOrWhiteSpace(newFaturamentoDTO.Titulo))
        {
            throw new ArgumentException("O título do faturamento é obrigatório.");
        }
        if (string.IsNullOrWhiteSpace(newFaturamentoDTO.Valor))
        {
            throw new ArgumentException("O valor do faturamento é obrigatório.");
        }
        if (!decimal.TryParse(newFaturamentoDTO.Valor, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal valorDecimal))
        {
            throw new ArgumentException("O valor do faturamento é inválido. Certifique-se de fornecer um número válido.");
        }
        if (valorDecimal <= 0)
        {
            throw new ArgumentException("O valor do faturamento deve ser positivo.");
        }
        if (newFaturamentoDTO.Descricao != null && newFaturamentoDTO.Descricao.Length > 500)
        {
            throw new ArgumentException("A descrição do faturamento não pode exceder 500 caracteres.");
        }
        if (string.IsNullOrWhiteSpace(newFaturamentoDTO.DataDeFaturamento))
        {
            newFaturamentoDTO.DataDeFaturamento = DateTime.UtcNow.ToString("yyyy-MM-dd");
        }
        if (!DateTime.TryParse(newFaturamentoDTO.DataDeFaturamento, out DateTime dataDeFaturamento))
        {
            throw new ArgumentException("A data do faturamento é inválida. Use um formato de data válido.");
        }
        if (dataDeFaturamento > DateTime.UtcNow)
        {
            throw new ArgumentException("A data do faturamento não pode ser futura.");
        }
        var newFaturamento = new Faturamento
        (
            newFaturamentoDTO.Titulo,
            valorDecimal,
            newFaturamentoDTO.Descricao ?? string.Empty,
            dataDeFaturamento
        );
    
        await _faturamentoRepository.CriarFaturamentoAsync(newFaturamento);
    }

    public async Task EditarFaturamentoAsync(string guidString, FaturamentoRequestDTO updatedFaturamentoDTO)
    {
        if (!Guid.TryParse(guidString, out Guid guid))
        {
            throw new ArgumentException("ID do faturamento é inválido. Certifique-se de fornecer um GUID válido.");
        }
        if (guid == Guid.Empty)
        {
            throw new ArgumentException("ID do faturamento é inválido.");
        }
        if (string.IsNullOrWhiteSpace(updatedFaturamentoDTO.Titulo))
        {
            throw new ArgumentException("O título do faturamento é obrigatório.");
        }
        if (string.IsNullOrWhiteSpace(updatedFaturamentoDTO.Valor))
        {
            throw new ArgumentException("O valor do faturamento é obrigatório.");
        }
        if (!decimal.TryParse(updatedFaturamentoDTO.Valor, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal valorDecimal))
        {
            throw new ArgumentException("O valor do faturamento é inválido. Certifique-se de fornecer um número válido.");
        }
        if (valorDecimal <= 0)
        {
            throw new ArgumentException("O valor do faturamento deve ser positivo.");
        }
        if (updatedFaturamentoDTO.Descricao != null && updatedFaturamentoDTO.Descricao.Length > 500)
        {
            throw new ArgumentException("A descrição do faturamento não pode exceder 500 caracteres.");
        }
        if (!DateTime.TryParse(updatedFaturamentoDTO.DataDeFaturamento, out DateTime dataDeFaturamento))
        {
            throw new ArgumentException("A data do faturamento é inválida. Use um formato de data válido.");
        }
        if (dataDeFaturamento > DateTime.UtcNow)
        {
            throw new ArgumentException("A data do faturamento não pode ser futura.");
        }
        var updatedFaturamento = new Faturamento
        (
            updatedFaturamentoDTO.Titulo,
            valorDecimal,
            updatedFaturamentoDTO.Descricao ?? string.Empty,
            dataDeFaturamento
        );

        await _faturamentoRepository.EditarFaturamentoAsync(guid, updatedFaturamento);
    }
    public async Task ExcluirFaturamentoAsync(string guidString)
     {
        if (!Guid.TryParse(guidString, out Guid guid))
        {
            throw new ArgumentException("ID do faturamento é inválido. Certifique-se de fornecer um GUID válido.");
        }
        if (guid == Guid.Empty)
        {
            throw new ArgumentException("ID do faturamento é inválido.");
        }

        await _faturamentoRepository.ExcluirFaturamentoAsync(guid);
    }


}
