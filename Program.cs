using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            double num1, num2, res = 0;
            char op;

            Console.WriteLine("=====================================");
            Console.Write("Numero 1: ");
            num1 = double.Parse(Console.ReadLine());
            Operacao:
            Console.Write("Operação(+ - * /): ");
            op = char.Parse(Console.ReadLine());
            Console.Write("Numero 2: ");
            num2 = double.Parse(Console.ReadLine());

            switch(op)
            {
                default:
                    Console.WriteLine("Coloca o bagulho certo filho da puta");
                    goto Inicio;
                case '+':
                    res = num1 + num2;
                    break;
                case '-':
                    res = num1 - num2;
                    break;
                case '*':
                    res = num1 * num2;
                    break;
                case '/':
                    res = num1 / num2;
                    break;
            }

            Console.WriteLine("=====================================");
            Console.WriteLine(num1 + " " + op + " " + num2 + " = " + res);

            num1 = res;
            Console.WriteLine("=====================================");
            goto Operacao;

        }
    }
}
