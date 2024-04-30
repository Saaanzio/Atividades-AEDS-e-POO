using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista15Questão3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha, numero;
            Inteiro num;
            ABB arvore = new ABB();
            do
            {
                Console.WriteLine("1- Inserir um número na árvore AVL\r\n2- Remover um número da árvore AVL\r\n3- Pesquisar um número na árvore AVL\r\n4- Mostrar todos os elementos da árvore AVL, usando o caminhamento central\r\n5- Mostrar todos os elementos da árvore AVL, usando o caminhamento pós-ordem.\r\n6- Mostrar todos os elementos da árvore AVL, usando o caminhamento pré-ordem.\r\n7- Sair");
                escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Insira um número: ");
                        numero = int.Parse(Console.ReadLine());
                        num = new Inteiro(numero);
                        arvore.inserir(num);
                        break;
                    case 2:
                        Console.WriteLine("Insira um número: ");
                        numero = int.Parse(Console.ReadLine());
                        arvore.remover(numero);
                        break;
                    case 3:
                        Console.WriteLine("Insira um número: ");
                        numero = int.Parse(Console.ReadLine());
                        arvore.pesquisar(numero);
                        break;
                    case 4:
                        arvore.caminhamentoEmOrdem();
                        break;
                    case 5:
                        arvore.caminhamentoPosOrdem();
                        break;
                    case 6:
                        arvore.caminhamentoPreOrdem();
                        break;
                    default:
                        break;
                }
            } while (escolha != 7);
        }
    }
}
