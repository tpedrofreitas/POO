using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ValidaCPFComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o CPF: ");
            //string cpf =  Console.ReadLine();
            //CPF objCPF = new CPF( cpf );
            IDocumento documento;

            while (true)
            {
                 
                Console.Write("Digite seu CPF: ");
                try
                {
                    documento = new CPF(Console.ReadLine());
                    break;
                }
                catch (CPFQtdeDigitosException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(CPFMesmoNumeroException ex) 
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"CPF inválido: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
            

            if (documento.Validar())
                Console.WriteLine("Documento válido!");
            else
                Console.WriteLine("Documento inválido!");

            Console.Write("Digite o CNPJ: ");
            documento = new CNPJ(Console.ReadLine());

            if (documento.Validar())
                Console.WriteLine("Documento válido!");
            else
                Console.WriteLine("Documento inválido!");
        }
    }
}
