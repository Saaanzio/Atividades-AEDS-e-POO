
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão2SemClasse
{

    class Program
    {
        static void Main(string[] args)
        {
            Queue<Pagina> fila = new Queue<Pagina>();
            int escolha;
            do
            {
                Console.WriteLine("1. Inserir arquivo na fila de impressão");
                Console.WriteLine("2. Executar impressão");
                Console.WriteLine("3. Exibir fila de impressão");
                Console.WriteLine("4. Sair");
                escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Insira o arquivo e a quantidade de arquivos a ser imprimido");
                        string arquivo = Console.ReadLine();
                        int qnt = int.Parse(Console.ReadLine());
                        Pagina pagina = new Pagina(qnt, arquivo);
                        break;
                    case 2:
                        Pagina imprimir = fila.Dequeue();
                        Console.WriteLine("O arquivo: {0}, impressões: {1} foi retirado", imprimir.Arquivo, imprimir.Numero);
                        break;
                    case 3:
                        Pagina[] vet = fila.ToArray();
                        for (int i = 0; i < vet.Length; i++)
                        {
                            Console.WriteLine("Elemento de número {0}: {1} : Páginas{2}", i, vet[i].Arquivo, vet[i].Numero);
                        }
                        break;
                    default:
                        break;
                }
            } while (escolha != 4);
        }
    }
}