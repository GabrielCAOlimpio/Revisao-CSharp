using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoFinacaMinimalAPI.DTOs.Gastos;


public class GastosResponseDTO
{
    public Guid Id {get;set;}
    public string Titulo {get;set;} = string.Empty;
    public decimal Valor {get;set;} 
    public string Descricao {get;set;} = string.Empty;
    public string DataDeGastos {get;set;} = string.Empty;
}