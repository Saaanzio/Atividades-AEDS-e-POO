using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nativa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            List<int> lista = new List<int>();
            int horas, pos;
            do
            {
                Console.WriteLine("\n1) Inserir um tempo no início da lista " +
                    "\n2) Inserir um tempo no final da lista" +
                    "\n3) Inserir um tempo numa posição específica da lista(O usuário deve informar a posição e o tempo a ser inserido)" +
                    "\n4) Remover o primeiro tempo da lista(Imprimir o tempo removido)" +
                    "\n5) Remover o último tempo da lista(Imprimir o tempo removido)" +
                    "\n6) Remover um tempo de uma posição específica na lista(O usuário deve informar a posição do tempo a ser removido. Imprimir o tempo removido)" +
                    "\n7) Remover um tempo específico da lista(O usuário deve informar o tempo a ser removido)." +
                    "\n8) Pesquisar quantas vezes um determinado tempo consta na lista(O usuário deve informar o tempo a ser pesquisado)." +
                    "\n9) Mostrar todos os tempos da lista" +
                    "\n10) Encerrar o programa");
                escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Insira as horas: ");
                        horas = int.Parse(Console.ReadLine());
                        lista.Insert(0, horas);
                        break;
                    case 2:
                        Console.WriteLine("Insira as horas:");
                        horas = int.Parse(Console.ReadLine());
                        lista.Add(horas);
                        break;
                    case 3:
                        Console.WriteLine("Insira as horas que deseja inserir e em qual posição");
                        horas = int.Parse(Console.ReadLine());
                        pos = int.Parse(Console.ReadLine());
                        lista.Insert(pos, horas);
                        break;
                    case 4:
                        Console.WriteLine("{0} removido com sucesso.", lista[0]);
                        lista.RemoveAt(0);
                        break;
                    case 5:
                        Console.WriteLine("{0} removido com sucesso.", lista[lista.Count - 1]);
                        lista.RemoveAt(lista.Count - 1);
                        break;
                    case 6:
                        Console.WriteLine("Qual posição deseja remover: ");
                        pos = int.Parse(Console.ReadLine());
                        Console.WriteLine("{0} removido com sucesso.", lista[pos]);
                        lista.RemoveAt(pos);
                        break;
                    case 7:
                        Console.WriteLine("Insira o tempo que deseja remover: ");
                        horas = int.Parse(Console.ReadLine());
                        lista.Remove(horas);
                        break;
                    case 8:
                        Console.WriteLine("Insira o número que deseja verificar repetições: ");
                        horas = int.Parse(Console.ReadLine());
                        int[] lista2 = lista.ToArray();
                        int repet = 0;
                        for (int i = 0; i < lista.Count - 1; i++)
                        {
                            if (lista2[i] == horas)
                            {
                                repet++;
                            }
                        }
                        Console.WriteLine("O elemento se repete {0} vezes", repet);
                        break;
                    case 9:
                        for (int i = 0; i < lista.Count - 1; i++)
                        {
                            Console.Write(lista[i] + " / ");
                        }
                        break;
                    default:
                        break;
                }
            } while (escolha != 10);
            Console.ReadLine();
        }
    }
}
