using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão1ComCelula
{
    class Valor
    {
        public Valor(String valor)
        {
            obj = valor;
        }
        private string obj;



        public string Obj
        {
            get { return obj; }
            set { obj = value; }
        }
        public void Imprimir()
        {
            Console.WriteLine("Valor: {0}", obj);
        }
    }
    class Celula
    {
        private Valor valor;
        private Celula proximo;
        public Celula()
        {
            valor = null;
            proximo = null;
        }
        public Celula(Valor valor)
        {
            this.valor = valor;
            proximo = null;
        }
        public Celula Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }
        public Valor Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
    class Fila
    {
        private Celula frente;
        private Celula tras;
        public Fila()
        {
            Celula sentinela = new Celula();
            frente = sentinela;
            tras = sentinela;
        }
        public bool Vazia()
        {
            if (frente == tras)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Enqueue(Valor obj)
        {
            Celula aux = new Celula(obj);
            tras.Proximo = aux;
            tras = aux;
        }
        public Valor Dequeue()
        {
            Celula removida;
            Celula nextCelula;
            if (!Vazia())
            {
                removida = frente.Proximo;
                nextCelula = removida.Proximo;
                if (removida == tras)
                {
                    tras = frente;
                }
                return removida.Valor;
            }
            else
            {
                throw new Exception("Fila Vazia!");
            }
        }
        public void Imprimir()
        {
            Celula aux;
            if (!Vazia())
            {
                aux = frente.Proximo;
                while (aux != null)
                {
                    aux.Valor.Imprimir();
                    aux = aux.Proximo;
                }
            }
            else
            {
                throw new Exception("Fila Vazia!");
            }
        }
        public int Count()
        {
            Celula aux;
            int cont = 0;
            if (!Vazia())
            {
                aux = frente.Proximo;
                while (aux != null)
                {
                    cont++;
                    aux = aux.Proximo;
                }
            }
            else
            {
                throw new Exception("Fila Vazia!");
            }
            return cont;
        }
        public Valor Peek()
        {
            return frente.Valor;
        }
    }
}
