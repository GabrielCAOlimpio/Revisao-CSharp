/*
    public Guid Id {get; private set;} = Guid.NewGuid();
    public string Titulo {get;private set;} = string.Empty;
    public decimal Valor {get;private set;} = 0;
    public string Descricao {get;private set;} = string.Empty;
    public DateTime DataDeFaturamento {get;private set;}
*/

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestaoFinacaMinimalAPI.DTOs.Faturamento;



public class FaturamentoResponseDTO
{
    public Guid Id {get;set;}
    public string Titulo {get;set;} = string.Empty;
    public decimal Valor {get;set;} = 0;
    public string Descricao{get;set;} = string.Empty;
    public string DataDeFaturamento {get;set;} = string.Empty;
}