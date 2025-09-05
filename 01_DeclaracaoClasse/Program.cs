using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _01_DeclaracaoClasse
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Quadrado Obj1 = new Quadrado();
            //Obj1.Lado = 5;
            //Obj1.ImprimeArea();

            //Obj1.Lado = 15;
            //Obj1.ImprimeArea();

            //Quadrado Obj2 = new Quadrado();
            //Obj2.Lado = 25;
            //Obj2.ImprimeArea();

            //Retangulo Obj3 = new Retangulo();
            //Obj3.Largura = 10;
            //Obj3.Altura = 5;
            //Obj3.ImprimeArea();

            //Circulo Obj4 = new Circulo();
            //Obj4.Raio = 10;
            //Obj4.ImprimeArea();

            
            //Obj4.Raio = 50;
            //Obj4.ImprimeArea();

            //Triangulo Obj5 = new Triangulo();
            //Obj5.Base = 10;
            //Obj5.Altura = 5;
            //Obj5.ImprimeArea();

            //Instanciar
          Conta conta2 = new Conta();
           conta2.Banco = 1;
           conta2.Agencia = "1234-5";
           conta2.Numero = "98765-4";
           conta2.Saldo = 500.00;
           conta2.Limite = 1000.00;


            conta2.Depositar(1000.00);
           Console.WriteLine($"Saldo Atual: { conta2.ConsultaSaldo()}");

           conta2.Sacar(600.00);
           Console.WriteLine($"Saldo Atual: {conta2.ConsultaSaldo()}");

            Aluno aluno1 = new Aluno();
            aluno1.Nome = "Thiago";
            aluno1.Codigo = 1;
            aluno1.LancarNota(1, 8.6);
            aluno1.LancarNota(2, 9.0);
            aluno1.LancarNota(3, 9.5);
            aluno1.LancarNota(4, 10.0);

            Console.WriteLine($"Aluno {aluno1.Nome} {aluno1.Mencao()} com média de {aluno1.CalcularMedia():N2}");
        }
    }

    public class Quadrado
    {
        public int Lado;

        public int CalculaArea()
        {
            int area = Lado * Lado;
            return area;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Quadrado com lado  de {Lado} possui uma área de {CalculaArea()}");

        }
    }

    public class Retangulo
    {
        public int Largura;
        public int Altura;

        public int CalculaArea()
        {
            int area = Largura * Altura;
            return area;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Retângulo com largura de {Largura} e altura de {Altura} possui uma área de {CalculaArea()}");
        }
    }
    public class Circulo
    {
        public double Raio;
       

        public double CalculaArea()
        {   //Math.POW(raio,2) * Mach.PI
            double area = (Raio * Raio)* Math.PI;
            return area;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Circulo com raio de {Raio} e possui uma área de {CalculaArea():N2}");
        }
    }
    public class Triangulo
    {
        public int Base;
        public int Altura;


        public double CalculaArea()
        {   //Math.POW(raio,2) * Mach.PI
            double area = (Base * Altura) /2.0;
            return area;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"TRinagulo com base de {Base} e altura com {Altura} e possui uma área de {CalculaArea()}");
        }

    }


    public class Conta
    {
        public int Banco;
        public string Agencia;
        public string Numero;
        public double Saldo;
        public double Limite;

        public void Depositar(Double valor)
        {
            Saldo += valor;
        }
        public void Sacar(Double valor)
        { 
            Saldo -= valor;
        }
        public double ConsultaSaldo()
        {
           return Saldo;
        }
    }

    public class Aluno
    {
        public int Codigo;
        public string Nome;
        public double[] Notas = new double[4];

        public void LancarNota(int trimestre, double nota)
        {
            Notas[trimestre - 1] = nota;
        }
        public double CalcularMedia()
        {
            double media = 0;
            foreach (double nota in Notas)
            {
                media += nota;
            }
            return media / 4;


        }
        public string Mencao()
        {
            // if (CalcularMedia() >= 5.0)
            //     return "Aprovado";
            //  else
            //     return "Reprovado";

            return (CalcularMedia() >= 5.0) ? "Aprovado" : "Reprovado";
        }
    }

}
