using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculo
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            while (true) { 
            Console.WriteLine("Digite a forma geométrica(quadrado,retangulo,trapezio,losango):");
            string op = Console.ReadLine();

            double l1, l2,h,a;

            switch (op)
            {
                case "quadrado":
                    Console.WriteLine("Insira o tamanho dos lados:");
                    l1 = double.Parse(Console.ReadLine());
                    a = l1 * l1;
                    Console.WriteLine("A área do quadrado é: " + a);
                    break;
                case "retangulo":
                    Console.WriteLine("Insira o tamanho do lado 1:");
                    l1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o tamanho do lado 2:");
                    l2 = double.Parse(Console.ReadLine());
                    a = l1*l2;
                    Console.WriteLine("A área do retângulo é: " + a);
                    break;
                case "trapezio":
                    Console.WriteLine("Insira o tamanho da base 1:");
                    l1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o tamanho da base 2:");
                    l2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira a altura");
                    h = double.Parse(Console.ReadLine());
                    a = ((l1 + l2) * h) / 2;
                    Console.WriteLine("A área do trapezio é: " + a);
                    break;
                case "losango":
                    Console.WriteLine("Insira o tamanho da diagonal 1:");
                    l1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o tamanho da diagonal 2:");
                    l2 = double.Parse(Console.ReadLine());
                    a = (l1 * l2) / 2;
                    Console.WriteLine("A área do losango é: " + a);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                        break;
            }
            Console.ReadKey();
            Console.Clear();
            }
        }
    }
}
