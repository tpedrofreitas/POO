using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ColecaoDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, String> alunoNomes = new Dictionary<int, String>();
            alunoNomes.Add(1, "Thiago");
            alunoNomes.Add(2, "Rafael");
            alunoNomes.Add(3, "Pietro");
            alunoNomes.Add(4, "Isac");

            Console.WriteLine(" Lista de Alunos (RA - Nome):");

            // Maneira simples de imprimir RA e Nome
            foreach (var aluno in alunoNomes)
            {
                Console.WriteLine($"{aluno.Key} - {aluno.Value}");
            }
        }
    }
}
