using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão2ComCelula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila();
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
                        Valor valor = new Valor(pagina);
                        fila.Enqueue(valor);
                        break;
                    case 2:
                        Valor imprimir = fila.Dequeue();
                        Console.WriteLine("O arquivo: {0}, impressões: {1} foi retirado", imprimir.Obj.Arquivo, imprimir.Obj.Numero);
                        break;
                    case 3:
                        fila.Imprimir();
                        break;
                    default:
                        break;
                }
            } while (escolha != 4);
            Console.ReadLine();
        }
    }
}
