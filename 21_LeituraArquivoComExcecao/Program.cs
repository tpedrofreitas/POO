using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_LeituraArquivoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string CaminhoDigitado;
            bool CaminhoErrado = false;

            

                Console.WriteLine("Digite o caminho completo do arquivo");
            CaminhoDigitado = Console.ReadLine();
            try
            {
                string Diretorio = System.IO.File.ReadAllText(CaminhoDigitado);


               // Console.WriteLine("Digite o caminho completo do arquivo");
              // CaminhoDigitado =  Console.ReadLine(); ----> Meu primeiro raciocínio era que iciaria o cod dentro do "try" igual aos outros 


            }
            catch(FileNotFoundException)
            {
               
                    Console.WriteLine("Arquivo não encontrado! Verifique o caminho e tente novamente.");
            }
        }
    }
}
