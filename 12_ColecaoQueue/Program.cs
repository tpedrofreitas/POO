using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ColecaoQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();

            Console.WriteLine("Digite 5 nomes para a fila (mínimo 3 caracteres cada):");

            while (fila.Count < 5)
            {
                Console.Write($"Nome {fila.Count + 1}: ");
                string nome = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nome) || nome.Length < 3)
                {
                    Console.WriteLine(" Nome inválido! Digite pelo menos 3 caracteres.");
                }
                else
                {
                    fila.Enqueue(nome); 
                }
            }

            Console.WriteLine("\n🚀 Atendendo os 3 primeiros da fila:");

            for (int i = 1; i <= 3; i++)
            {
                string atendido = fila.Dequeue(); 
                Console.WriteLine($"{i}º atendido: {atendido}");
            }
            Console.WriteLine("\n Ainda aguardando na fila:");
            int posicao = 4;
            foreach (string nome in fila)
            {
                Console.WriteLine($"{posicao}º da fila: {nome}");
                posicao++;
            }
        }
    }
}
