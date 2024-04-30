using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista11Questão1Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            Lista lista = new Lista(20);
            Inteiro horasInteiro;
            int horas, pos, removido;
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
                        horasInteiro = new Inteiro(horas);
                        lista.Inserir(0, horasInteiro);
                        break;
                    case 2:
                        Console.WriteLine("Insira as horas:");
                        horas = int.Parse(Console.ReadLine());
                        horasInteiro = new Inteiro(horas);
                        lista.Inserir(lista.Count(),horasInteiro);
                        break;
                    case 3:
                        Console.WriteLine("Insira as horas que deseja inserir e em qual posição");
                        horas = int.Parse(Console.ReadLine());
                        horasInteiro = new Inteiro(horas);
                        pos = int.Parse(Console.ReadLine());
                        lista.Inserir(pos, horasInteiro);
                        break;
                    case 4:
                        removido = lista.Remover(0).Item;
                        Console.WriteLine("{0} removido com sucesso.", removido);
                        break;
                    case 5:
                        removido = lista.Remover(lista.Count()).Item;
                        Console.WriteLine("{0} removido com sucesso.", removido);
                         
                        break;
                    case 6:
                        Console.WriteLine("Qual posição deseja remover: ");
                        pos = int.Parse(Console.ReadLine());
                        removido = lista.Remover(pos).Item;
                        Console.WriteLine("{0} removido com sucesso.", removido);
                        
                        break;
                    case 7:
                        Console.WriteLine("Insira o tempo que deseja remover: ");
                        horas = int.Parse(Console.ReadLine());
                        horasInteiro = new Inteiro(horas);
                        lista.RemoverHoras(horasInteiro);
                        break;
                    case 8:
                        Console.WriteLine("Insira o tempo que deseja remover: ");
                        horas = int.Parse(Console.ReadLine());
                        horasInteiro = new Inteiro(horas);
                        int repet = lista.Repetir(horasInteiro);
                        Console.WriteLine("O elemento se repete {0} vezes", repet);
                        break;
                    case 9:
                        lista.Imprimir();
                        break;
                    default:
                        break;
                }
            } while (escolha != 10);
            Console.ReadLine();
        }
    }
}
