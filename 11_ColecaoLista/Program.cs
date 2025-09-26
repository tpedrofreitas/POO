using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ColecaoLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            Console.WriteLine("Digite 5 nomes (mínimo 3 caracteres cada):");

            while (nomes.Count < 5)
            {
                Console.Write($"Nome {nomes.Count + 1}: ");
                string nome = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nome) || nome.Length < 3)
                {
                    Console.WriteLine(" Nome inválido! Digite pelo menos 3 caracteres.");
                }
                else
                {
                    nomes.Add(nome);
                }
            }

            Console.WriteLine("\n Lista de nomes cadastrados:");
            foreach (string n in nomes)
            {
                Console.WriteLine(n);
            }

        }
    }
}
