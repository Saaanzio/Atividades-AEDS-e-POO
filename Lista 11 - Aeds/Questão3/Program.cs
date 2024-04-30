using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão3Lista11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            Inteiro musica;
            string removido, nome;
            int escolha, pos;
            do
            {
                Console.WriteLine("1. Inserir uma música no final da lista\r\n2. Inserir uma música no início da lista\r\n3. Inserir uma música numa posição específica da lista\r\n4. Remover a música do início da lista\r\n5. Remover a música do final da lista\r\n6. Remover uma música de uma posição específica da lista\r\n7. Listar todas as músicas da lista\r\n8. Listar todas as músicas da lista na ordem inversa (O programa deve imprimir da última música na lista até\r\na primeira)\r\n9. Pesquisar uma música na lista (O usuário deve informar uma música. O programa deve imprimir a\r\nposição da música informada).\r\n10. Pesquisar música anterior (O usuário deve informar uma música. O programa deve imprimir a música\r\nanterior a música informada)\r\n11. Pesquisar música posterior (O usuário deve informar uma música. O programa deve imprimir a música\r\nposterior a música informada)\r\n12. Encerrar o programa");
                escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Insira o nome da música");
                        nome = Console.ReadLine();
                        musica = new Inteiro(nome);
                        lista.InserirFinal(musica);
                        break;
                    case 2:
                        Console.WriteLine("Insira o nome da música");
                        nome = Console.ReadLine();
                        musica = new Inteiro(nome);
                        lista.Inserir(0, musica);
                        break;
                    case 3:
                        Console.WriteLine("Insira o nome da música e a posição desejada");
                        nome = Console.ReadLine();
                        musica = new Inteiro(nome);
                        pos = int.Parse(Console.ReadLine());
                        lista.Inserir(pos, musica);
                        break;
                    case 4:
                        removido = lista.Remover(0).Item;
                        Console.WriteLine("{0} removida com sucesso", removido);
                        break;
                    case 5:
                        removido = lista.RemoverFinal().Item;
                        Console.WriteLine("{0} removida com sucesso", removido);
                        break;
                    case 6:
                        Console.WriteLine("Insira a posição desejada");
                        pos = int.Parse(Console.ReadLine());
                        removido = lista.Remover(pos).Item;
                        Console.WriteLine("{0} removida com sucesso", removido);
                        break;
                    case 7:
                        lista.Imprimir();
                        break;
                    case 8:
                        lista.ImprimirInverso();
                        break;
                    case 9:
                        Console.WriteLine("Insira a música desejada");
                        nome = Console.ReadLine();
                        musica = new Inteiro(nome);
                        Console.WriteLine("Posição: "+lista.Position(musica));
                        break;
                    case 10:
                        Console.WriteLine("Insira a música desejada");
                        nome = Console.ReadLine();
                        musica = new Inteiro(nome);
                        Console.WriteLine("Anterior: " + lista.Anterior(musica).Item);
                        break;
                    case 11:
                        Console.WriteLine("Insira a música desejada");
                        nome = Console.ReadLine();
                        musica = new Inteiro(nome);
                        Console.WriteLine("Posterior: " + lista.Posterior(musica).Item);
                        break;
                    default:
                        break;
                }
            } while (escolha != 12);
        }
    }
}
