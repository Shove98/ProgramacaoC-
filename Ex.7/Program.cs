using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores inteiros separados por vírgula (dividendo,divisor):");
            string input = Console.ReadLine();

            string[] valores = input.Split(',');

            int dividendo = Convert.ToInt32(valores[0]);
            int divisor = Convert.ToInt32(valores[1]);

            int resultado = (int)Math.Round((double)dividendo / divisor);

            Console.WriteLine($"Resultado da divisão arredondado: {resultado}");
        }
    }
}
