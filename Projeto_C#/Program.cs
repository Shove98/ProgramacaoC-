using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double comprimento, altura, area;

            Console.Write("Insira o comprimento do retângulo: ");
            comprimento = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira a altura do retângulo: ");
            altura = Convert.ToDouble(Console.ReadLine());

            area = comprimento * altura;

            Console.WriteLine("A área do retângulo é: " + area);
        }
    }
}
