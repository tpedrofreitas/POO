using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_TratamentoExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            while (true)
            {
                Console.Write("Digite um número inteiro: ");
                try
                {
                    numero = int.Parse(Console.ReadLine());
                    break;
                       
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Número inválido, informe apenas valores inteiros!\nPressione qualquer tecla para continuar");
                    Console.ReadKey();  
                }
                finally
                {
                   Console.Clear(); 
                }
            }
            if(numero % 2 == 0)
                Console.WriteLine("O número é par");

            Console.WriteLine("O número é ímpar");
        }
        
    }
}
