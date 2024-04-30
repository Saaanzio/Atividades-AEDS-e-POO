using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista11Questão1Vetor
{
    internal class Lista
    {
        private int primeiro;
        private int ultimo;
        private int tamanho;
        private Inteiro[] lista;
        public Lista(int size)
        {
            primeiro = 0;
            ultimo = 0;
            tamanho = 0;
            lista = new Inteiro[size];
        }
        public int Count()
        {
            return tamanho;
        }
        public bool Cheia()
        {
            if (ultimo == lista.Length)
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
            if (primeiro == ultimo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Inserir(int pos, Inteiro valor)
        {
            if (!Cheia())
            {
                if (pos >= 0 && pos <= tamanho)
                {
                    for (int i = ultimo; i > pos; i--)
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
        public int VerificarPos(Inteiro horas)
        {
            if (!Vazia())
            {
                for(int i = primeiro; i < tamanho, i++)
                {
                    if (lista[i] == horas)
                    {
                        return i;
                    }
                }
                throw new Exception("Elemento Inválido");
            }
            else
            {
                throw new Exception("Lista Vazia!");
            }
        }
        public Inteiro Remover(int pos)
        {
            if (!Vazia())
            {
                if (pos >= 0 && pos < tamanho)
                {
                    Inteiro removido = lista[pos];
                    tamanho--;
                    for (int i = pos; i < tamanho; i++)
                    {
                        lista[i] = lista[i + 1];
                    }
                    ultimo--;
                    return removido;
                }
                else
                {
                    throw new Exception("Inválido");
                }
            }
            else
            {
                throw new Exception("Lista vazia");
            }
        }
        public void RemoverHoras(Inteiro horas)
        {
            if (!Vazia())
            {
                int pos = VerificarPos(horas);
                Inteiro removido = lista[pos];
                tamanho--;
                for (int i = pos; i < tamanho; i++)
                {
                    lista[i] = lista[i + 1];
                }
                ultimo--;
            }
            else
            {
                throw new Exception("Lista vazia");
            }
        }
        public void Imprimir()
        {
            if (!Vazia())
            {
                for(int i = primeiro; i < ultimo; i++)
                {
                    Console.Write(lista[i] + " ");
                }
            }
            else
            {
                throw new Exception("Lista Vazia!");
            }
            
        }
        public int Repetir(Inteiro horas)
        {
            if (!Vazia())
            {
                int cont = 0;
                for(int i = primeiro; i < ultimo; i++)
                {
                    if (lista[i] == horas) {
                        cont++;
                    }
                }
            }
        }
    }
}
