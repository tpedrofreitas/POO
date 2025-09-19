using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Não é possivel instanciar uma classe abstrata
            //Pessoa obj=new Pessoa ();

            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Geraldo";
            pessoaFisica.CPF = "999.999.999-99";
            pessoaFisica.Telefone = "(14) 99999-9999";
            pessoaFisica.Imprimir();

            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Senac Marilia";
            pessoaJuridica.CNPJ = "99.999.999/9999-99";
            pessoaJuridica.Telefone = "(14) 99999-9999";
            pessoaJuridica.Imprimir();


        }
    }
}
