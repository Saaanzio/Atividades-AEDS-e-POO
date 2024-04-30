using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lista9FilaNormal
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();
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
                        Console.WriteLine("O avião {0} decolou", fila.Dequeue());
                        break;
                    case 3:
                        Console.WriteLine("Insira o modelo do avião que deseja inserir: ");
                        string aviao = Console.ReadLine();
                        fila.Enqueue(aviao);
                        break;
                    case 4:
                        string[] vet = fila.ToArray();
                        for (int i = 0; i < vet.Length; i++)
                        {
                            Console.WriteLine("O avião de número {0} é {1}", i, vet[i]);
                        }
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
