namespace GestaoFinacaMinimalAPI.Models;

public class Gastos
{
    public Guid Id {get; private set;} = Guid.NewGuid();
    public string Titulo {get;private set;} = string.Empty;
    public decimal Valor {get;private set;} = 0;
    public string Descricao {get;private set;} = string.Empty;
    public DateTime DataDeGastos {get;private set;}

    protected Gastos(){}

    public Gastos(string _titulo, decimal _valor, string _descricao, DateTime _dataDeGasto)
    {
        if (string.IsNullOrEmpty(_titulo))
            throw new ArgumentNullException("Erro! Titulo de Gastos é obrigatório!");
        
        if (_valor <= 0)    
            throw new ArgumentException("Erro! Valor deve ser um numero positivo!");
        
        if (_dataDeGasto > DateTime.UtcNow)
            throw new ArgumentException("Data de gastos não pode ser superior à data atual");


        Titulo = _titulo;
        Descricao = _descricao;
        Valor = _valor;
        DataDeGastos = _dataDeGasto;
    }

    public void Alterar(string novoTitulo, decimal novoValor, string novaDescricao, DateTime dataDeGasto)
    {
        if (string.IsNullOrWhiteSpace(novoTitulo))
            throw new ArgumentException("Título inválido para alteração.");
        
        if (novoValor <= 0)
            throw new ArgumentException("O novo valor deve ser positivo.");
        
        if (dataDeGasto > DateTime.UtcNow)
            throw new ArgumentException("Data de gastos não pode ser superior à data atual");

        Titulo = novoTitulo;
        Valor = novoValor;
        Descricao = novaDescricao;
        DataDeGastos = dataDeGasto;
    }
}