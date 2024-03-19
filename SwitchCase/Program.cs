using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Insira o primeiro número:");
                double n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira o segundo número:");
                double n2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Insira a operação(+,-,*,/)");
                string op = Console.ReadLine();
                double res = 0;
                switch (op)
                {
                    case "+":
                        res = n1 + n2;
                        Console.WriteLine("Resultado:" + res);
                        break;
                    case "-":
                        res = n1 - n2;
                        Console.WriteLine("Resultado:" + res);
                        break;
                    case "*":
                        res = n1 * n2;
                        Console.WriteLine("Resultado:" + res);
                        break;
                    case "/":
                        res = n1 / n2;
                        Console.WriteLine("Resultado:" + res);
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }


                Console.ReadKey();
                Console.Clear();
            }
        }


    }
}
