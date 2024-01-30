using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua data de nascimento (no formato DD/MM/AAAA):");
            string input = Console.ReadLine();

            DateTime dataNascimento = DateTime.ParseExact(input, "dd/MM/yyyy", null);

            int idade = CalcularIdade(dataNascimento);

            string diaSemanaNascimento = dataNascimento.ToString("dddd");

            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"Dia da semana de nascimento: {diaSemanaNascimento}");
        }

        static int CalcularIdade(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Today;
            int idade = dataAtual.Year - dataNascimento.Year;

            if (dataNascimento.Date > dataAtual.AddYears(-idade))
            {
                idade--;
            }

            return idade;
        }
    }
}
