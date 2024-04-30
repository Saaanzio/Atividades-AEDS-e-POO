using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão3Lista11
{
    internal class Lista
    {
        private CelulaDupla primeiro;
        private CelulaDupla ultimo;
        private int tamanho;
        public Lista()
        {
            CelulaDupla sentinela = new CelulaDupla();
            primeiro = sentinela;
            ultimo = sentinela;
            tamanho = 0;
        }
        public void Inserir(int pos, Inteiro valor)
        {
            if (pos >= 0 && pos <= tamanho)
            {
                CelulaDupla anterior = primeiro;
                for (int i = 0; i < pos; i++)
                {
                    anterior = anterior.Proximo;
                }
                CelulaDupla novaCelula = new CelulaDupla(valor);
                CelulaDupla proximaCelula = anterior.Proximo;
                anterior.Proximo = novaCelula;
                novaCelula.Proximo = proximaCelula;
                novaCelula.Anterior = anterior;
                if (pos == tamanho)
                {
                    ultimo = novaCelula;
                }
                tamanho++;
            }
            else
            {
                throw new Exception("Pos inválida");
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
        public Inteiro Remover(int pos)
        {
            CelulaDupla anterior = primeiro;
            if (!Vazia())
            {
                if (pos >= 0 && pos < tamanho)
                {
                    for (int i = 0; i < pos; i++)
                    {
                        anterior = anterior.Proximo;
                    }
                    CelulaDupla removida = anterior.Proximo;
                    CelulaDupla proximaCelula = removida.Proximo;
                    anterior.Proximo = proximaCelula;
                    proximaCelula.Anterior = anterior;
                    removida.Proximo = null;
                    removida.Anterior = null;
                    if (removida == ultimo)
                    {
                        ultimo = anterior;
                    }
                    tamanho--;
                    return removida.Valor;
                }
                else
                {
                    throw new Exception("Pos inválida");
                }
            }
            else
            {
                throw new Exception("Lista Vazia");
            }
        }
        public void InserirFinal(Inteiro valor)
        {
            CelulaDupla novaCelula = new CelulaDupla(valor);
            ultimo.Proximo = novaCelula;
            novaCelula.Anterior = ultimo;
            ultimo = novaCelula;
            tamanho++;
        }
        public Inteiro RemoverFinal()
        {
            if (!Vazia())
            {
                CelulaDupla penultima = ultimo.Anterior;
                CelulaDupla removida = ultimo;
                penultima.Proximo = null;
                removida.Anterior = null;
                ultimo = penultima;
                tamanho--;
                return removida.Valor;
            }
            else
            {
                throw new Exception("Lista Vazia");
            }
        }
        public void Imprimir()
        {
            if (!Vazia())
            {
                CelulaDupla aux = primeiro.Proximo;
                while (aux != null)
                {
                    aux.Valor.Imprimir();
                    aux = aux.Proximo;
                }
            }
            else
            {
                throw new Exception("Lista vazia!");
            }
        }
        public void ImprimirInverso()
        {
            if (!Vazia())
            {
                CelulaDupla aux = ultimo;
                while (aux != null)
                {
                    aux.Valor.Imprimir();
                    aux = aux.Anterior;
                }
            }
            else
            {
                throw new Exception("Lista vazia!");
            }
        }
        public int Position(Inteiro nome)
        {
            if (!Vazia())
            {
                CelulaDupla aux = primeiro.Proximo;
                int cont = 0;
                bool resp = false;
                while (aux != null && resp == false)
                {
                    aux = aux.Proximo;
                    cont++;
                    if (aux.Valor.Item == nome.Item)
                    {
                        resp = true;
                    }
                }
                if(cont == 0) {
                    throw new Exception("Inválido");
                }
                else
                {
                    return cont + 1; // O loop para uma música antes, por isso somei 1
                }
            }
            else
            {
                throw new Exception("Lista vazia!");
            }
        }
        public Inteiro Anterior(Inteiro nome)
        {
            if (!Vazia())
            {
                CelulaDupla aux = primeiro;
                while (aux.Proximo.Valor.Item != nome.Item && aux != null)
                {
                    aux = aux.Proximo;
                }
                return aux.Valor;
            }
            else
            {
                throw new Exception("Lista vazia!");
            }
        }
        public Inteiro Posterior(Inteiro nome)
        {
            if (!Vazia())
            {
                CelulaDupla aux = primeiro;
                while (aux.Proximo.Valor.Item != nome.Item && aux != null)
                {
                    aux = aux.Proximo;
                }
                CelulaDupla desejada = aux.Proximo;
                return desejada.Proximo.Valor;
            }
            else
            {
                throw new Exception("Lista vazia!");
            }
        }
    }
}
