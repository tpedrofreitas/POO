using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ColecaoStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pilha = new Stack<int>();

            Console.WriteLine("Digite 5 números inteiros:");

            for(int i = 1;  i <= 5; i++)
            {
                Console.Write($"Número {i}: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                pilha.Push(numero);
            }
            Console.WriteLine($"O último número inserido foi:{pilha.Pop()}");
        }
    }
}
