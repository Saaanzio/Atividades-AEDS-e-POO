using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão2PorVetor
{
    internal class ListaVetor
    {
        private int primeiro;
        private int ultimo;
        private int tamanho;
        private Site[] lista;
        public ListaVetor(int size)
        {
            primeiro = 0;
            ultimo = 0;
            tamanho = 0;
            lista = new Site[size];
        }
        public int Tamanho
        {
            get { return tamanho; }
        }
        public bool Cheia()
        {
            if(ultimo == lista.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Vazia()
        {
            if(primeiro == ultimo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Inserir(int pos, Site valor)
        {
            if (!Cheia())
            {
                if(pos >= 0 && pos <= tamanho)
                {
                    for(int i = ultimo; i > pos; i--)
                    {
                        lista[i] = lista[i - 1];
                    }
                    lista[pos] = valor;
                    tamanho++;
                    ultimo++;
                }
            }
            else
            {
                throw new Exception("Lista cheia");
            }
        }
        public Site Remover(int pos)
        {
            if (!Vazia())
            {
                if(pos >= 0 && pos < tamanho)
                {
                    Site removido = lista[pos];
                    tamanho--;
                    for(int i = pos; i < tamanho; i++)
                    {
                        lista[i] = lista[i + 1];
                    }
                    ultimo--;
                    return removido;
                }
                else
                {
                    throw new Exception("Fila Vazia!");
                }
            }
            else
            {
                throw new Exception("Fila Vazia!");
            }
        }
        public void Imprimir()
        {
            for(int i = primeiro; i < ultimo; i++)
            {
                Console.WriteLine("{0} / {0}", lista[i].Nome, lista[i].Link);
            }
        }
    }
}
