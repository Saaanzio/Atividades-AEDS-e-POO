using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1___Questão_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet1 = new int[5];
            int[] vet2 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Insira o elemento " + i + " dos vetores 1 e 2");
                vet1[i] = int.Parse(Console.ReadLine());
                vet2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("A soma dos elementos na posição " + i + " é de: " + (vet1[i] + vet2[i]));
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("O produto dos elementos na posição " + i + " é de: " + (vet1[i] * vet2[i]));
            }
            for (int i = 0; i < 5; i++)
            {
                bool achei = false;
                for(int j = 0; j < 5; j++)
                {
                    if (vet1[i] == vet2[j])
                    {
                        achei = true;
                        break;
                    }
                }
                if(achei == false)
                {
                    Console.WriteLine("O número " + vet1[i] + "do vetor X, não está presente no vetor Y");
                }
            }
            for (int i = 0; i < 5; i++)
            {
                bool achei = false;
                for (int j = 0; j < 5; j++)
                {
                    if (vet1[i] == vet2[j])
                    {
                        achei = true;
                        break;
                    }
                }
                if (achei == true)
                {
                    Console.WriteLine("O número " + vet1[i] + " está presente em ambos vetores");
                }
            }
            int novoVetor = 0;
            for (int i = 0; i < 5; i++)
            {
                
                for (int j = 0; j < 5; j++)
                {
                    if (vet1[i] == vet2[j])
                    {
                        novoVetor++;
                        break;
                    }
                }
            }
            int[] vet3 = new int[(5 + (vet2.Length - novoVetor))];
            for(int i = 0; i < vet3.Length; i++)
            {
                if(i < 5)
                {
                    vet3[i] = vet1[i];
                }
            }
            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                bool achei2 = false;
                for (int j = 0; j < 5; j++)
                {
                    if (vet1[j] == vet2[i])
                    {
                        achei2 = true;
                        break;
                    }
                }
                if (achei2 == false)
                {
                    vet3[5 + k] = vet2[i];
                    k++;
                }
            }
            Console.Write("Vetor 3:");
            for (int i = 0; i < vet3.Length; i++)
            {
                Console.Write(" "+ vet3[i]);
            }

            Console.ReadKey();
        }
    }
}
