decimal salario = 1620;
decimal fgts = salario * 0.08m;

Console.WriteLine($"Salario Bruto : {salario:C2}");
Console.WriteLine($"FGTS (8%) : {fgts:C2}");
Console.WriteLine($"Salario Liquido: {salario - fgts:C2}");