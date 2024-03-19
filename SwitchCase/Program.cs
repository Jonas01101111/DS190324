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
            Console.WriteLine("Insira o primeiro número:");
                int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número:");
                int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a operação(+,-,*,/)");
                string op = Console.ReadLine();
            int res = 0;
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
                    Console.WriteLine("Resultado:"+res);
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }






            Console.ReadKey();
        }


    }
}
