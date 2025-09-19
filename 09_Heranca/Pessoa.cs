using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Heranca
{
    internal abstract class Pessoa
    {
        public string Nome;
        public string Telefone;

        public abstract string GetDocumento();

        public void Imprimir()
        {
            Console.WriteLine($"LISTA DE PESSOAS\n\n Nome: {this.Nome} Documento: {this.GetDocumento()} Telefone: {this.Telefone}");
        }
    }
}
