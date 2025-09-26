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

           
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Digite o {i}º nome: ");
                string nome = Console.ReadLine();
                nomes.Add(nome); 
            }

            Console.WriteLine("\n--- Nomes digitados ---");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
