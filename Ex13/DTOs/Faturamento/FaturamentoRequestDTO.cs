using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestaoFinacaMinimalAPI.DTOs.Faturamento;




public class FaturamentoRequestDTO
{
    [Required]
    [MaxLength(100, ErrorMessage = "Erro! Titulo não pode superar 100 caracteres")]
    public string Titulo {get;set;} = string.Empty;

    [Required]
    public string Valor {get;set;} = string.Empty;

    [MaxLength(500, ErrorMessage = "Descrição está muito longa, a descrição não pode superar 500 caracteres")]
    public string Descricao {get;set;} = string.Empty;

    public string DataDeFaturamento {get;set;} = string.Empty;

}