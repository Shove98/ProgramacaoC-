using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2
{
        class Program
        {
            static void Main(string[] args)
            {
                decimal salarioBruto = 0m;
                decimal descontoSegurancaSocial = 0m;
                decimal descontoIRS = 0m;
                decimal salarioLiquido = 0m;


                Console.Write("Insira o salário bruto: ");
                salarioBruto = Convert.ToDecimal(Console.ReadLine());
                descontoSegurancaSocial = salarioBruto * 0.20m;


                if (salarioBruto <= 500m)
                {
                    descontoIRS = 0m;
                }
                else if (salarioBruto <= 1000m)
                {
                    descontoIRS = salarioBruto * 0.12m;
                }
                else if (salarioBruto <= 1500m)
                {
                    descontoIRS = salarioBruto * 0.15m;
                }
                else
                {
                    descontoIRS = salarioBruto * 0.18m;
                }

               
                salarioLiquido = salarioBruto - descontoSegurancaSocial - descontoIRS;


                Console.WriteLine("Salário líquido: {0}", salarioLiquido);
            }
        }
    }
