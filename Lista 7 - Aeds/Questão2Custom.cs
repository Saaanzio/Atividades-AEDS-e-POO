using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão2Custom
{
    class Pilha
    {
        private char[] vetor;
        private int topo;
        public Pilha(int tamanho)
        {
            vetor = new char[tamanho];
            topo = 0;
        }
        public char Peek()
        {
            return vetor[topo - 1];
        }
        public void Push(char num)
        {
            if (topo >= vetor.Length)
            {
                Console.WriteLine("Tamanho máximo.");
            }
            else
            {
                vetor[topo] = num;
                topo++;
            }
        }
        public char Pop()
        {
            char num = vetor[topo - 1];
            vetor[topo - 1] = ' ';
            topo--;
            return num;
        }
        public void Clear()
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = ' ';
            }
        }

    }
    internal class Program
    {
        public static bool Seq(string seq, int tamanho)
        {
            Pilha pilha = new Pilha(tamanho);
            for (int i = 0; i < seq.Length; i++)
            {
                if (seq[i] == '(' || seq[i] == '[')
                {
                    pilha.Push(seq[i]);
                }
                else if (seq[i] == ')')
                {
                    if (pilha.Peek() == '(')
                    {
                        pilha.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (seq[i] == ']')
                {
                    if (pilha.Peek() == '[')
                    {
                        pilha.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insira uma sequencia e um tamanho: ");
            string seq = Console.ReadLine();
            int tamanho = int.Parse(Console.ReadLine());
            Console.WriteLine(Seq(seq, tamanho));
            Console.ReadLine();
        }
    }
}
