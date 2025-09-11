using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado(5);
            quadrado.ImprimirArea();

            Retangulo retangulo = new Retangulo(10, 10);
            retangulo.ImprimirArea();

            Circulo circulo = new Circulo(10);
            circulo.ImprimirArea();

            Triangulo triangulo = new Triangulo(20, 20);
            triangulo.ImprimirArea();
        }

    }
    public class Quadrado
    {
        //Modificar de acesso Private
        //pode se acessado apenas dentro da Classe
        private int Lado;

        //O Construtor serve para instanciar o objeto e
        //Inicializar os atributos
       
        public Quadrado():this(5)
        {   //this: acessa o membro da classe
            //this.Lado = Lado;
        }
        public Quadrado(int Lado) 
        {
            if (Lado < 0)
                this.Lado = Lado;
        }

        public int CalculaArea()
        {
            return Lado * Lado;
        }
        public void ImprimirArea()
        {
            Console.WriteLine($"Quadrado com Lado de {Lado} possui uma área de {CalculaArea()}");
        }


    }
    public class Retangulo
    {
        private int Largura, Altura;

        public Retangulo(int Largura, int Altura)
        {
            this.Largura = Largura;
            this.Altura = Altura;
        }

        public int CalculaArea()
        {
            return Largura * Altura;
        }
        public void ImprimirArea()
        {
            Console.WriteLine($"Retângulo com largura de {Largura}, altura de {Altura} possui uma área de {CalculaArea()}");
        }
    }


    public class Circulo
    {
        private double raio;

        public Circulo(double raio)
        {
            this.raio = raio;
        }
        public double CalculaArea()
        {
            double area = (raio * raio) * Math.PI;
            return area;
        }
        public void ImprimirArea()
        {
            Console.WriteLine($"círculo com raio de {raio} possui uma area de {CalculaArea():N2}");
        }
    }
    public class Triangulo
    {
        private double Base, Altura;

        public Triangulo(double Base, double Altura)
        {
          this.Base = Base;
          this.Altura = Altura;
        }
        public double CalculaArea()
        {
            double area = (Base * Altura) / 2;
            return area;
        }
        public void ImprimirArea()
        {
            Console.WriteLine($"triângulo com base de {Base},altura de  {Altura} possui uma área{CalculaArea()}");
        }

    }
}



