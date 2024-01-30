using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3
{
        class Program
        {
            static void Main(string[] args)
            {
                int número;

                Console.Write("Insira um número: ");
                número = int.Parse(Console.ReadLine());

                int fatorial = 1;

                for (int i = número; i >= 1; i--)
                {
                    fatorial *= i;
                }

                Console.WriteLine("O fatorial do número é {0}", fatorial);
            }
        }
}