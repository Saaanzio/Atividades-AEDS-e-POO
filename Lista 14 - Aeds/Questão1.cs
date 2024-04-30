using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão2Lista14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a quantidade de elementos do vetor: ");
            int size = int.Parse(Console.ReadLine());
            int[] vet = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Insira um número do vetor: ");
                int num = int.Parse(Console.ReadLine());
                vet[i] = num;
            }
            Console.WriteLine("Digite o elemento procurado: ");
            int busca = int.Parse(Console.ReadLine());
            Console.WriteLine("Resposta: " + Pesquisa(vet, busca));
            Console.ReadLine();
        }
        public static bool Pesquisa(int[] vet, int busca)
        {
            return Pesquisa(vet, busca, 0, (vet.Length - 1));
        }
        private static bool Pesquisa(int[] vet, int busca, int esq, int dir)
        {
            Boolean resp;
            int meio = (esq + dir) / 2;
            if (esq > dir)
            {
                resp = false;
            }
            else if (busca == vet[meio])
            {
                resp = true;
            }
            else if (busca > vet[meio])
            {
                resp = Pesquisa(vet, busca, meio + 1, dir);
            }
            else
            {
                resp = Pesquisa(vet, busca, esq, meio - 1);
            }
            return resp;
        }
    }
}

  

