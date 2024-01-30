using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._4
{
    internal class Program
    {
            static void Main(string[] args)
            {
                double catetoA;
                double catetoB;

                Console.Write("Insira o valor do cateto A: ");
                catetoA = Convert.ToDouble(Console.ReadLine());

                Console.Write("Insira o valor do cateto B: ");
                catetoB = Convert.ToDouble(Console.ReadLine());

                double hipotenusa = Math.Sqrt(catetoA * catetoA + catetoB * catetoB);

                Console.WriteLine("A hipotenusa do triângulo é {0}", hipotenusa);
            }
    }
}

