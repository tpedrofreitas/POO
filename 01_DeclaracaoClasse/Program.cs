using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DeclaracaoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado Obj1 = new Quadrado();
            Obj1.Lado = 5;
            Obj1.ImprimeArea();

            Obj1.Lado = 15;
            Obj1.ImprimeArea();

            Quadrado Obj2 = new Quadrado();
            Obj2.Lado = 25;
            Obj2.ImprimeArea();

            Retangulo Obj3 = new Retangulo();
            Obj3.Largura = 10;
            Obj3.Altura = 5;
            Obj3.ImprimeArea();

            Circulo Obj4 = new Circulo();
            Obj4.Raio = 10;
            Obj4.ImprimeArea();

            
            Obj4.Raio = 50;
            Obj4.ImprimeArea();

            Triangulo Obj5 = new Triangulo();
            Obj5.Base = 10;
            Obj5.Altura = 5;
            Obj5.ImprimeArea();


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
}
