namespace Exercicio1.Models;
using System;

public class Cliente
{
    public string Nome { get; set; }
    public bool IsVip { get; set; }

    public Cliente(string nome, bool isVip)
    {
        Nome = nome;
        IsVip = isVip;
    }
}