using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número");
            int num1 = int.Parse(Console.ReadLine());
            double resultado = 0;
            double menosmais = 1;
            for (double divisor = 1; divisor < num1; divisor += 2)
            {
                resultado += 4 / divisor * menosmais;
                menosmais *= -1;
            }
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
