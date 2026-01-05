//RELEMBRANDO TIPOS DE DADOS DE TEXTO EM C#
//REVIEWING TEXT DATA TYPES IN C#

string Nome = "Gabriel";
char letra = 'G';


Console.WriteLine("This is my text data types review:");
Console.WriteLine($"My first string: {Nome}");
Console.WriteLine($"My first char: {letra}");

Console.Write($"A String to char ");
foreach (char c in Nome)
{
    Console.Write(c + " ");
}
Console.WriteLine("\nConvertendo String para Char Array");
foreach (char item in Nome.ToCharArray())
{
    Console.Write(item + " ");
}