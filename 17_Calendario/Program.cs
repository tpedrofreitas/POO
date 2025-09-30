using System;

namespace _17_Calendario

{
    internal class Program
    {
        static void Main(string[] args)

        {
           // Console.Write("Digite o Mês(1 a 12):");
           // int mes = int.Parse(Console.ReadLine());

            
            Console.Write("digite o ano :");
            int ano = int.Parse(Console.ReadLine());

            Calendario calendario;
            for (int mes = 1; mes <= 12; mes++)

            {
                calendario = new Calendario(ano, mes);
                calendario.imprimirCalendario();

                Console.WriteLine("\n\n");
                               
            }
            //esperar o usuário tecla qualquer tecla
            Console.ReadKey();
        }
            
       
             
            
             
    }
}