using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão1FilaVetor
{
    class Valor
    {
        private string num;

        public string Num
        {
            get { return num; }
            set { num = value; }
        }
        public Valor(string valor)
        {
            num = valor;
        }
        public Valor()
        {
            num = null;
        }
        public void imprimir()
        {
            Console.WriteLine(num);
        }

    }
    class Fila
    {
        private Valor[] fila;
        private int frente;
        private int tras;
        private int tamanho;
        public Fila(int tamanho)
        {
            fila = new Valor[tamanho];
            frente = 0;
            tras = 0;
            this.tamanho = tamanho;
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
        public bool Cheia()
        {
            if (((tras + 1) % tamanho) == (frente % tamanho))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Push(Valor valor)
        {
            int cont;
            if (!Cheia())
            {
                cont = tras % tamanho;
                fila[cont] = valor;
                tras++;
            }
            else
            {
                throw new Exception("Fila cheia!");
            }
        }
        public Valor Pop()
        {
            Valor pop;
            int cont;
            if (!Vazia())
            {
                cont = frente % tamanho;
                pop = fila[cont];
                frente++;
                return pop;
            }
            else
            {
                throw new Exception("Fila Vazia!");
            }
        }
        public void Print()
        {
            int cont;
            if (!Vazia())
            {
                for (int i = frente; i < tras; i++)
                {
                    cont = i % tamanho;
                    fila[cont].imprimir();
                }
            }
            else
            {
                throw new Exception("Fila vazia");
            }

        }
        public int Count()
        {
            int cont = 0;
            for (int i = 0; i < tamanho; i++)
            {
                if (fila[i] != null)
                {
                    cont++;
                }
            }
            return cont;
        }
        public string Peek()
        {
            return fila[frente].Num;
        }
    }
}
