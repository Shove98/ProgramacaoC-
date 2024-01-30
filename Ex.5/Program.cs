using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreve uma frase:");
            List<string> palavras = new List<string>();

            string frase = Console.ReadLine();

            string[] palavraArray = frase.Split(' ');

            for (int i = 0; i < palavraArray.Length; i++)
            {
                palavras.Add(palavraArray[i]);
            }

            Console.WriteLine("Número de palavras: {0}", palavras.Count);
        }
    }
}
