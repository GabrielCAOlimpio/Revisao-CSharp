using Microsoft.EntityFrameworkCore;

namespace GestaoFinacaMinimalAPI.Models;

public class Faturamento
{
    public Guid Id {get; private set;} = Guid.NewGuid();
    public string Titulo {get;private set;} = string.Empty;
    public decimal Valor {get;private set;} = 0;
    public string Descricao {get;private set;} = string.Empty;
    public DateTime DataDeFaturamento {get;private set;}

    protected Faturamento(){}

    public Faturamento(string _titulo, decimal _valor, string _descricao, DateTime _dataDeFaturamento)
    {
        if (string.IsNullOrEmpty(_titulo))
            throw new ArgumentNullException("Erro! Titulo de Faturamento é obrigatório!");
        
        if (_valor <= 0)    
            throw new ArgumentException("Erro! Valor deve ser um numero positivo!");
        
        if (_dataDeFaturamento > DateTime.UtcNow)
            throw new ArgumentException("Erro! Data não pode ser superior a data atual!");
    

        Titulo = _titulo;
        Descricao = _descricao;
        Valor = _valor;
    }

    public void Alterar(string novoTitulo, decimal novoValor, string novaDescricao, DateTime novaDataDeFaturamento)
    {
        // Reutiliza as mesmas validações do construtor!
        if (string.IsNullOrWhiteSpace(novoTitulo))
            throw new ArgumentException("Título inválido para alteração.");
        
        if (novoValor <= 0)
            throw new ArgumentException("O novo valor deve ser positivo.");

        if (novaDataDeFaturamento > DateTime.UtcNow)
            throw new ArgumentException("Erro! Data não pode ser superior a data atual!");

        Titulo = novoTitulo;
        Valor = novoValor;
        Descricao = novaDescricao;
        DataDeFaturamento = novaDataDeFaturamento;
    }
}