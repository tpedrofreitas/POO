using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_PropriedadesAteNet8
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
           // Conta conta = new Conta()
            Conta conta = new Conta("1111-2222");
            conta.Nome = "Thiago Freitas";

            //Não é possivel atribuir o valpoe em um atributo privado
          // conta.Numero = "1111-2222";


            //conta.Saldo = -2000.00m;
            conta.Depositar(-2000.00m);

            //utilizando o metodo acessador
            conta.Saldo = 2000.00m;
           


            while (true)
            {
                Console.WriteLine("Informe a Operação: [D]-Depositar, [S]-Sacar ou [E]-Sair");
                string operacao = Console.ReadLine();

                if (operacao.ToUpper() == "D")
                {
                    Console.WriteLine("Informe o valor para depósito");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    conta.ImprimirSaldo();
                }
                else if (operacao.ToUpper() == "S")
                {
                    Console.WriteLine("Informe o valor para saque:");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    conta.ImprimirSaldo();

                }
                else if (operacao.ToUpper() == "E")
                {
                    Console.WriteLine($"Conta: {conta.Numero}Nome: {conta.Nome} Saldo: {conta.Saldo:C2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Informe apenas as letras [D] para despositar , [S] para Sacar ou [E] para sair");
                }
            }
        }
    }

    public class Conta
    {
        // public string Numero; 
        private string numero;

        public string Numero { get; }

        public Conta(string numero)
        {
            this.numero = numero;
        }
       // public string getNumero()
       // {
           // return numero;
       // }
        
       // public string Nome;
      private string nome;
        
        public string Nome { get; set; }
       // public string getNome()
      //  {
        //  return nome;
       // }
      // public void setNome(string nome)
     //  {
        //  this.nome = nome;
     //  }


        //Transformar conta saldo com acesso privado
        // public decimal Saldo;
        private decimal saldo;

        //Declaração de propriedade até a versão 8 do . Net
        public decimal Saldo
        {
            get {  return saldo; }
            set
            {
                this.Depositar(value);
            }

        }

        //métodos acessadores
        //public decimal getSaldo()
        // {
        //    return saldo;
        //  }
       // public void setSaldo(decimal saldo)
       // {
           // this.Depositar(saldo); 
       // }

        public void Depositar(decimal valor)
        {
            if(valor > 0)
            saldo += valor;
            else
                Console.WriteLine("Valor de deposito incorreto, de ser maior que zero");
        }

        public void Sacar(decimal valor)
        {
            saldo -= valor;
        }
        public void ImprimirSaldo()
        {
            //Console.Writeline($"Saldo Atual:{getSaldo():c2}");
            Console.WriteLine($"Saldo Atual da conta {saldo:c2}");
        }

    }
}
