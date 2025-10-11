using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite a nota do aluno (0 a 10): ");
            double nota = double.Parse(Console.ReadLine());

            if (nota < 0 || nota > 10)
            {
                throw new NotaInvalidaException("Erro: valor de nota inválido! A nota deve estar entre 0 e 10.");
            }

            if (nota >= 6)
            {
                Console.WriteLine("Aluno aprovado!");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }
        }
        catch (NotaInvalidaException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: você deve digitar um número!");
        }
    }
}
