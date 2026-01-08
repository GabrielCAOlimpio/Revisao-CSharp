using System;

namespace Program;

public class Program
{
    public static void Main(string[] args)
    {
        List<Aluno> alunos = new List<Aluno>()
        {
            new Aluno("Ana", 20, "Engenharia"),
            new Aluno("Bruno", 22, "Medicina"),
            new Aluno("Carlos", 21, "Direito"),
            new Aluno("Diana", 20, "Psicologia"),
            new Aluno("Eduardo", 23, "Administração"),
            new Aluno("Fernanda", 21, "Enfermagem"),
            new Aluno("Gabriel", 22, "Arquitetura"),
            new Aluno("Helena", 20, "Biologia"),
            new Aluno("Igor", 24, "Física"),
            new Aluno("Julia", 21, "Química"),
            new Aluno("Kevin", 22, "Matemática")
        };

        foreach (var aluno in alunos)
        {
            aluno.ApresentarAluno();
            Console.WriteLine();
        }
    }
}
