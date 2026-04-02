using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoFinacaMinimalAPI.DTOs.Gastos;

public class GastosRequestDTO
{
    [Required]
    [MaxLength(100,ErrorMessage = "Erro! Titulo não pode superar 100 caracteres")]
    public string Titulo {get;set;} = string.Empty;

    [Required]
    public string Valor {get;set;} = string.Empty;

    [MaxLength(500, ErrorMessage = "Erro! Descrição não pode ser maior que 500 caracteres!")]
    public string Descricao {get;set;} = string.Empty;

    public string DataDeGastos {get;set;} = string.Empty;

}