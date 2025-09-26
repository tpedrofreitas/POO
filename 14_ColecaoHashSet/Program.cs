using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ColecaoHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numeros = new HashSet<int>();

            numeros.Add(5);
            numeros.Add(10);
            numeros.Add(15);
            numeros.Add(20);
            numeros.Add(25);
            numeros.Add(30);
            numeros.Add(5);
            numeros.Add(10);
            numeros.Add(15);
            numeros.Add(25);
            numeros.Add(30);

            Console.WriteLine("Lista final sem duplicatas:");

            foreach (int n in numeros)
            {
                Console.WriteLine(n);
            }
        }
    }
}
