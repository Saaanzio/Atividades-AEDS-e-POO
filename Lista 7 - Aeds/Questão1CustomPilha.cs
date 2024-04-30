using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    class Pilha
    {
        private double[] vetor;
        private int topo;
        public Pilha(int tamanho)
        {
            vetor = new double[tamanho];
            topo = 0;
        }
        public double Peek()
        {
            return vetor[topo - 1];
        }
        public void Push(double num)
        {
            if(topo >= vetor.Length)
            {
                Console.WriteLine("Tamanho máximo.");
            }
            else
            {
                vetor[topo] = num;
                topo++;
            }
        }
        public double Pop()
        {
            double num = vetor[topo - 1];
            vetor[topo - 1] = 0;
            topo--;
            return num;
        }
        public void Clear()
        {
            for(int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = 0;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha(5);
            String not = "3572-*4/+";
            for (int i = 0; i < not.Length; i++)
            {
                if (not[i] == '+' || not[i] == '-' || not[i] == '*' || not[i] == '/')
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
