using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using _18_ValidaçãoCPF;


namespace _08_ValidaCPF
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            Console.Write("Digite seu CPF: ");
            string cpfDigitado = Console.ReadLine();

            IDocumento documento = new CPF(cpfDigitado);

            if (documento.Validar())
                Console.WriteLine("CPF VÁLIDO: " );
            else
                Console.WriteLine("CPF INVÁLIDO!");

            Console.ReadKey();
        }






    }

}
    

