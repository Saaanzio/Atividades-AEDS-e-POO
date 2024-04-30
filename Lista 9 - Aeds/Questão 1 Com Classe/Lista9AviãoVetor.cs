using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Questão1FilaVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila(10);
            int escolha;
            do{
                Console.WriteLine("1. Listar a quantidade de aviões que estão aguardando na fila de decolagem");
                Console.WriteLine("2. Autorizar a decolagem do primeiro avião da fila de decolagem (isto é, retirar da fila de colagem)");
                Console.WriteLine("3. Adicionar um avião na fila de colagem");
                Console.WriteLine("4. Listar todos os aviões que estão na fila de colagem");
                Console.WriteLine("5. Exibir o primeiro avião da fila de colagem");
                Console.WriteLine("6. Sair");
                escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine(fila.Count());
                        break;
                    case 2:
                        Console.WriteLine("O avião {0} decolou", fila.Pop());
                        break;
                    case 3:
                        Console.WriteLine("Insira o modelo do avião que deseja inserir: ");
                        string aviao = Console.ReadLine();
                        Valor aviaoV = new Valor(aviao);
                        fila.Push(aviaoV);
                        break;
                    case 4:
                        fila.Print();
                        break;
                    case 5:
                        Console.WriteLine("O avião que está no topo é: {0}", fila.Peek());
                        break;
                    default:
                        break;
                }
            } while (escolha != 0) ;
        }
    }
}
