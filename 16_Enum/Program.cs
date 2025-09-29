using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _16_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sem a Utilização de Enum");
           List<int> diaDaSemanaSemEnum = new List<int> {  1, 2, 3, 4, 5, 6, 7};
          //  List<int> diaDaSemanaSemEnum = new List<int> { 0, 1, 2, 3, 4, 5, 6 };
            foreach ( var item in diaDaSemanaSemEnum)
            {
                //if(item == 0) Console.WriteLine("Domingo");
                //else if (item == 1) Console.WriteLine("Segunda");
                //else if (item == 2) Console.WriteLine("Terça");
                //else if (item == 3) Console.WriteLine("Quarta");
                //else if (item == 4) Console.WriteLine("Quinta");
                //else if (item == 5) Console.WriteLine("Sexta");
                //else if (item == 6) Console.WriteLine("Sabado");

                if (item == 1) Console.WriteLine("Domingo -- Número: 1");
                else if (item == 2) Console.WriteLine("Segunda -- Número: 2");
                else if (item == 3) Console.WriteLine("Terca -- Número: 3");
                else if (item == 4) Console.WriteLine("Quarta -- Número: 4");
                else if (item == 5) Console.WriteLine("Quinta -- Número: 5");
                else if (item == 6) Console.WriteLine("Sexta -- Número: 6");
                else if (item == 7) Console.WriteLine("Sabado -- Número: 7");
            }

            Console.WriteLine("\n\nCom a utilização de Enum");
            List<DiaDaSemana> diaDaSemanaComEnum = new List<DiaDaSemana>()
            {
                DiaDaSemana.Domingo,
                DiaDaSemana.Segunda,
                 DiaDaSemana.Terca,
                 DiaDaSemana.Quarta,
                 DiaDaSemana.Quinta,
                 DiaDaSemana.Sexta,
                 DiaDaSemana.Sabado
            };
            foreach(var item in diaDaSemanaComEnum)
            {
                Console.WriteLine($"{item} Número: {(int)item}");
            }
                          
        }
    }
    public enum DiaDaSemana
    {
        Domingo = 1,
        Segunda,
        Terca,
        Quarta,
        Quinta,
        Sexta,
        Sabado
    }
}
