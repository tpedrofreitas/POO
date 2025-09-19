using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Aluno
{
    internal class Aluno
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a idade do aluno: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());
                        
            Aluno aluno = new Aluno(nome, idade, nota1, nota2);
                       
            Console.WriteLine("\n--- Dados do Aluno ---");
            Console.WriteLine($"Nome: {aluno.Nome}");
            Console.WriteLine($"Idade: {aluno.Idade}");
            Console.WriteLine($"Nota 1: {aluno.Nota1}");
            Console.WriteLine($"Nota 2: {aluno.Nota2}");
            Console.WriteLine($"Média: {aluno.Media}");
            Console.WriteLine($"Situação: {aluno.Situacao}");
        }

        private string nome;
        private int idade;
        private double nota1;
        private double nota2;

        public Aluno(string nome, int idade,double nota1, double nota2)
        {
            this.nome = nome;
            Idade= idade;
            Nota1 = nota1;
            Nota2 = nota2;
        }
        public string Nome
        {
            get { return nome; }
        }
        
        public int Idade
        {
            get { return idade; }
            set
            {
                if (value >= 0)
                    idade = value;

                else
                
                    Console.WriteLine("Idade Inválida");
                    
                
            }

        }
        public double Nota1
        {
            get { return nota1; }
            private set { nota1 = value; }
        }
        public double Nota2
        {
            get { return nota2; }
            private set { nota2 = value; }
        }
        public double Media
        {
            get { return (nota1 + nota2) / 2; }
        }
        public string Situacao
        {
            get { return (Media >= 6) ? "Aprovado" : "Reprovado"; }
        }

        
    }
}
