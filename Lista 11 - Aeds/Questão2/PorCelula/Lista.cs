using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão2PorCelula
{
    internal class Lista
    {
        private Celula primeiro, ultimo;
        private int tamanho;
        public int Tamanho
        {
            get { return tamanho; }
        }
        public Lista()
        {
            Celula sentinela = new Celula();
            primeiro = sentinela;
            ultimo = sentinela;
            tamanho = 0;
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
        public void Inserir(int pos, Site valor)
        {
            if (pos >= 0 && pos <= tamanho)
            {
                Celula novaCelula = new Celula(valor);
                Celula anterior = primeiro;
                Celula proximaCelula;
                for (int i = 0; i < pos; i++)
                {
                    anterior = anterior.Proximo;
                }
                proximaCelula = anterior.Proximo;
                anterior.Proximo = novaCelula;
                novaCelula.Proximo = proximaCelula;
                if (pos == tamanho)
                {
                    ultimo = novaCelula;
                }
                tamanho++;
            }
            else
            {
                throw new Exception("Posição inválida");
            }
        }
        public Site Remover(int pos)
        {
            if (!Vazia())
            {
                if (pos >= 0 && pos < tamanho)
                {
                    Celula anterior = primeiro;
                    for (int i = 0; i < pos; i++)
                    {
                        anterior = anterior.Proximo;
                    }
                    Celula celulaRemovida = anterior.Proximo;
                    Celula proximaCelula = celulaRemovida.Proximo;
                    anterior.Proximo = proximaCelula;
                    celulaRemovida.Proximo = null;
                    if (celulaRemovida == ultimo)
                    {
                        ultimo = anterior;
                    }
                    tamanho--;
                    return celulaRemovida.Valor;
                }
                else
                {
                    throw new Exception("Posição inválida");
                }
            }
            else
            {
                throw new Exception("Vazia!");
            }
        }
        public Site RemoverDireto(Site horas)
        {
            if (!Vazia())
            {
                Celula anterior = primeiro;
                for (int i = 0; anterior.Proximo.Valor != horas; i++)
                {
                    anterior = anterior.Proximo;
                }
                Celula removida = anterior.Proximo;
                Celula proxima = removida.Proximo;
                removida.Proximo = null;
                if (ultimo == removida)
                {
                    ultimo = anterior;
                }
                tamanho--;
                return removida.Valor;
            }
            else
            {
                throw new Exception("Fila Vazia!");
            }
        }
        public int Contar(Site horas)
        {
            if (!Vazia())
            {
                Celula aux = primeiro;
                int cont = 0;
                while (aux != null)
                {
                    if (aux.Valor == horas)
                    {
                        cont++;
                    }
                }
                return cont;
            }
            else
            {
                throw new Exception("Lista Vazia!");
            }

        }
        public void Imprimir()
        {
            if (!Vazia())
            {
                Celula aux = primeiro.Proximo;
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
    }
}
