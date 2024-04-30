using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace sequencia
{
    internal class Program
    {
        public static bool Seq(string seq)
        {
            Stack<char> pilha = new Stack<char>();
            for(int i = 0 ; i < seq.Length; i++)
            {
                if (seq[i] == '(' || seq[i] == '[')
                {
                    pilha.Push(seq[i]);
                }
                else if (seq[i] == ')')
                {
                    if(pilha.Peek() == '(')
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
            Console.WriteLine("Insira uma sequencia: ");
            string seq = Console.ReadLine();
            Console.WriteLine(Seq(seq));
            Console.ReadLine();
        }
    }
}
