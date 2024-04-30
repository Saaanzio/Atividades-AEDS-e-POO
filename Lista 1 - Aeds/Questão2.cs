using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1___Questão_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, seq = 1, maior = 0;
            Console.WriteLine("Insira um número");
            num2 = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Insira um número");
                num1 = int.Parse(Console.ReadLine());
                if(num1 > num2)
                {
                    seq++;
                    if (maior < seq)
                    {
                        maior = seq;
                    }
                }
                else
                {
                    seq = 1;
                }
                num2 = num1;
            } while (num1 != -1);
            Console.WriteLine("A maior sequência foi de: " + maior);
            Console.ReadKey();
        }
    }
}
