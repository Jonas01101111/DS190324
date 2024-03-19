using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioSwCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
            Console.WriteLine("Insira a forma de contratação(A:assalariado|C:comissionado|H:horista):");
            string ctrt = Console.ReadLine();
            double v1, v2, sal = 0, sald, d;//valor 1, valor 2, salario, salario com desconto,desconto
            switch (ctrt)//calculo salario
            {
                case "A":
                    Console.WriteLine("Insira o salário bruto:");
                    v1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o desconto:");
                    v2 = double.Parse(Console.ReadLine());
                    sal = v1 - v2;
                    break;
                case "C":
                    Console.WriteLine("Insira a quantidade de peças vendidas:");
                    v1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira a comissão por peça:");
                    v2 = double.Parse(Console.ReadLine());
                    sal = v1 * v2;
                    break;
                case "H":
                    Console.WriteLine("Insira o valor da hora trabalhada:");
                    v1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira quantas horas foram trabalhadas:");
                    v2 = double.Parse(Console.ReadLine());
                    sal = v1 * v2;
                    break;
            }
            //calculo IR
            if (sal <= 2000)//desconto 7.5%
            {
                sald = sal * 0.925;
                d = sal * 0.075;
            }
            else if (sal <= 4000)//desconto 12%
            {
                sald = sal * 0.88;
                d = sal * 0.12;
            }
            else //desconto 15%
            {
                sald = sal * 0.85;
                d = sal * 0.15;
            }

            Console.WriteLine("Salário:" + sal);
            Console.WriteLine("Imposto de renda: " + d);
            Console.WriteLine("Salário com desconto: " + sald);

            Console.ReadKey();
            Console.Clear();
        }
        }
    }
}
