using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha, num;
            Inteiro item;
            ABB arvore = new ABB();
            do
            {
                Console.WriteLine("1- Inserir um número na árvore binária de busca\n" +
                    "2 - Remover um número da árvore binária de busca\n" +
                    "3 - Pesquisar um número na árvore binária de busca\n" +
                    "4 - Mostrar o maior elemento da árvore binária de busca\n" +
                    "5 - Mostrar o menor elemento da árvore de pesquisa de busca\n" +
                    "6 - Mostrar todos os elementos da árvore, usando o caminhamento central\n" +
                    "7 - Mostrar todos os elementos da árvore, usando o caminhamento pós - ordem.\n" +
                    "8 - Mostrar todos os elementos da árvore, usando o caminhamento pré - ordem.\n" +
                    "9 - Sair");
                escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Insira um número");
                        num = int.Parse(Console.ReadLine());
                        item = new Inteiro(num);
                        arvore.inserir(item);
                        break;
                    case 2:
                        Console.WriteLine("Insira um número");
                        num = int.Parse(Console.ReadLine());
                        arvore.remover(num);
                        break;
                    case 3:
                        Console.WriteLine("Insira um número");
                        num = int.Parse(Console.ReadLine());
                        Console.WriteLine(arvore.pesquisar(num).Valor + " encontrado com sucesso.");
                        break;
                    case 4:
                        Console.WriteLine(arvore.pesquisarMaior().Valor + " é o maior valor da árvore");
                        break;
                    case 5:
                        Console.WriteLine(arvore.pesquisarMenor().Valor + " é o menor valor da árvore");
                        break;
                    case 6:
                        arvore.caminhamentoEmOrdem();
                        break;
                    case 7:
                        arvore.caminhamentoPosOrdem();
                        break;
                    case 8:
                        arvore.caminhamentoPreOrdem();
                        break;
                    default:
                        break;
                }
            } while (escolha != 9);
            Console.ReadLine();
        }
    }
}
        
    

