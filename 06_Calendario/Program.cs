using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06_Calendario;

namespace _09_Calendario
{
    internal class Program
    {
        static void main(string[] args)

        {

            
            Console.Write("digite o ano :");
            int ano = int.Parse(Console.ReadLine());

            Calendario calendario;
            for (int mes = 1; mes <= 12; mes++)

            {
                calendario = new Calendario(ano, mes);
                calendario.imprimirCalendario();

                Console.WriteLine("\n\n");
                               
            }
            Console.ReadKey();
        }
            
       
             
            
             
    }
}