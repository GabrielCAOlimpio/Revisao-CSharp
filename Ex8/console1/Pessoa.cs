using System;

namespace Program
{
    public class Pessoa
    {
        private string nome = string.Empty;
        private int idade = 0;
        public string Nome
        {
            get 
            {
                if (string.IsNullOrWhiteSpace(nome))
                {
                    throw new InvalidOperationException("O nome não foi definido.");
                }
                return nome;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }
                nome = value;
            }
        }   
        public int Idade
        {
            get => idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("A idade não pode ser negativa.");
                }
                idade = value;
            }
        }
        public Pessoa(string nome)
        {
            this.Nome = nome;
        }
        public Pessoa(string nome, int idade) : this(nome) // Pega o nome do construtor acima, simplificando a class
        {
            this.Idade = idade;
        }
    }
}
