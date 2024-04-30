using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista12
{
    internal class Program
    {
        public static int[] Selection(int[] vet, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int menor = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (vet[menor] > vet[j])
                    {
                        menor = j;
                    }
                }
                int temp = vet[i];
                vet[i] = vet[menor];
                vet[menor] = temp;
            }
            return vet;
        }
        public static int[] SelectionInvertido(int[] vet, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int maior = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (vet[maior] > vet[j])
                    {
                        maior = j;
                    }
                }
                int temp = vet[i];
                vet[i] = vet[maior];
                vet[maior] = temp;
            }
            return vet;
        }
        public static int[] Bubblesort(int[] vet, int n)
        {
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (vet[j] > vet[j + 1])
                    {
                        int temp = vet[j];
                        vet[j] = vet[j + 1];
                        vet[j + 1] = temp;
                    }
                }
            }
            return vet;
        }
        public static int[] BubblesortInvertido(int[] vet, int n)
        {
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (vet[j] < vet[j + 1])
                    {
                        int temp = vet[j];
                        vet[j] = vet[j + 1];
                        vet[j + 1] = temp;
                    }
                }
            }
            return vet;
        }
        public static int[] InsertionSort(int[] vet, int n)
        {
            for (int i = 1; i < n; i++)
            {
                int temp = vet[i];
                int j = i - 1;
                while (j >= 0 && vet[j] > temp)
                {
                    vet[j + 1] = vet[j];
                    j--;
                }
                vet[j + 1] = temp;
            }
            return vet;
        }
        public static int[] InsertionSortInvertido(int[] vet, int n)
        {
            for (int i = 1; i < n; i++)
            {
                int temp = vet[i];
                int j = i - 1;
                while (j >= 0 && vet[j] < temp)
                {
                    vet[j + 1] = vet[j];
                    j--;
                }
                vet[j + 1] = temp;
            }
            return vet;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o tamanho do vetor que deseja criar");
            int tam = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[] vet = new int[tam];
            for(int i = 0; i < vet.Length; i++)
            {
                vet[i] = random.Next(1,101);
            }
            Console.WriteLine("Insira qual operação deseja fazer. 1 - Seleção | 2 - Bubblesort | 3 - Inserção | 4 - Seleção Decrescente | 5 - Bubblesort Decrescente | 6 - Inserção decrescente");
            int escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    vet = Selection(vet, tam);
                    break;
                case 2:
                    vet = Bubblesort(vet, tam);
                    break;
                case 3:
                    vet = InsertionSort(vet, tam);
                    break;
                case 4:
                    vet = SelectionInvertido(vet, tam);
                    break;
                case 4:
                    vet = BubblesortInvertido(vet, tam);
                    break;
                case 5:
                    vet = InsertionSortInvertido(vet, tam);
                    break;
                default:
                    break;
            }
            Console.WriteLine("Resultado: ");
            for(int i = 0;i < vet.Length;i++)
            {
                Console.Write(vet[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
