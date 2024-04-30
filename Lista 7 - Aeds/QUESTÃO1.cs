using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<double> pilha = new Stack<double>();
            String not = "3572-*4/+";
            for(int i = 0; i < not.Length; i++)
            {
                if(not[i] == '+' || not[i] == '-' || not[i] == '*' || not[i] == '/')
                {
                    switch (not[i])
                    {
                        case '+':
                            pilha.Push(pilha.Pop() + pilha.Pop());
                            break;
                        case '-':
                            double num = pilha.Pop();
                            double num2 = pilha.Pop();
                            pilha.Push(num2 - num);
                            break;
                        case '*':
                            pilha.Push(pilha.Pop() * pilha.Pop());
                            break;
                        case '/':
                            double num3 = pilha.Pop();
                            double num4 = pilha.Pop();
                            pilha.Push(num4 / num3);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine(not[i]);
                    pilha.Push(Double.Parse(not[i].ToString()));
                }
            }
            Console.WriteLine(pilha.Peek());

            Console.ReadLine();
        }
    }
}
