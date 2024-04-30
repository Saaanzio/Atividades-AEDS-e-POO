using Questão2Flex.Questiones2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão2Flex
{
    internal class teste
    {
        public static bool Seq(string seq)
        {
            Pilha pilha = new Pilha();
            for (int i = 0; i < seq.Length; i++)
            {
                Linha simb = new Linha();
                simb.StringV = seq[i];
                if (seq[i] == '(' || seq[i] == '[')
                {
                    
                    pilha.Empilhar(simb);
                }
                else if (seq[i] == ')')
                {
                    if (pilha.Pico().StringV == '(')
                    {
                        pilha.Desempilhar();
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (seq[i] == ']')
                {
                    if (pilha.Pico().StringV == '[')
                    {
                        pilha.Desempilhar();
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
