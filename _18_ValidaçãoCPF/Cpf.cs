using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _18_ValidaçãoCPF
{
    internal class CPF : IDocumento
    {
        private string numero; 

        public CPF(string numero)
        {
            
            this.numero = Regex.Replace(numero, "[^0-9]", "");
        }

     
        public string ObterNumero()
        {
            return numero;
        }

        public bool Validar()
        {
            if (numero.Length != 11) return false;

            if (new string(numero[0], 11) == numero) return false;

            return numero[9] == CalculaDV(numero, 9, 10) &&
                   numero[10] == CalculaDV(numero, 10, 11);
        }

        private char CalculaDV(string cpf, int qtdeNumeros, int peso)
        {
            int soma = 0;
            for (int i = 0; i < qtdeNumeros; i++)
                soma += (cpf[i] - '0') * (peso - i);

            int resto = soma % 11;
            int digito = (resto >= 2) ? 11 - resto : 0;

            return (char)(digito + '0');
        }
    }
}


