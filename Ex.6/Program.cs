using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o seu nome completo:");
            string nomeCompleto = Console.ReadLine();

            string[] partesNome = nomeCompleto.Split(' ');

            string primeiroNome = partesNome[0];

            string sobrenome = partesNome[partesNome.Length - 1];

            Console.WriteLine($"Primeiro nome: {primeiroNome}");
            Console.WriteLine($"Sobrenome: {sobrenome}");
        }
    }
}
