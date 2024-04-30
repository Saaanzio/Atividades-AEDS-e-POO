using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista11Questão2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Site> lista = new List<Site>();
            int escolha, pos;
            string nome, link, removido;
            Site site;
            do
            {
                Console.WriteLine("1) Inserir um Site no início da lista\r\n2) Inserir um Site no final da lista\r\n3) Inserir um Site numa posição específica da lista\r\n4) Remover o primeiro Site da lista (Imprimir o nome do site removido)\r\n5) Remover o último Site da lista (Imprimir o nome do site removido)\r\n6) Remover um Site de uma posição específica da lista (Imprimir o nome do site removido)\r\n7) Mostrar o nome e o link de todos os sites da lista\r\n8) Encerrar o programa");
                escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Insira o nome e o link do site");
                        nome = Console.ReadLine();
                        link = Console.ReadLine();
                        site = new Site(nome, link);
                        lista.Insert(0, site);
                        break;
                    case 2:
                        Console.WriteLine("Insira o nome e o link do site");
                        nome = Console.ReadLine();
                        link = Console.ReadLine();
                        site = new Site(nome, link);
                        lista.Add(site);
                        break;
                    case 3:
                        Console.WriteLine("Insira o nome, o link do site e a posição que deseja inserir");
                        nome = Console.ReadLine();
                        link = Console.ReadLine();
                        pos = int.Parse(Console.ReadLine());
                        site = new Site(nome, link);
                        lista.Insert(pos, site);
                        break;
                    case 4:
                        removido = lista[0].Nome;
                        lista.RemoveAt(0);
                        Console.WriteLine("Item {0} removido com sucesso", removido);
                        break;
                    case 5:
                        removido = lista[lista.Count - 1].Nome;
                        lista.RemoveAt(lista.Count - 1);
                        Console.WriteLine("Item {0} removido com sucesso", removido);
                        break;
                    case 6:
                        Console.WriteLine("Insira a posição que deseja remover: ");
                        pos = int.Parse(Console.ReadLine());
                        removido = lista[pos].Nome;
                        lista.RemoveAt(pos);
                        Console.WriteLine("Item {0} removido com sucesso", removido);
                        break;
                    case 7:
                        for(int i = 0; i < lista.Count; i++)
                        {
                            Console.WriteLine("{0} / {1}", lista[i].Nome, lista[i].Link);
                        }
                        break;
                    default:
                        break;
                }
            } while (escolha != 8);
        }
    }
}
