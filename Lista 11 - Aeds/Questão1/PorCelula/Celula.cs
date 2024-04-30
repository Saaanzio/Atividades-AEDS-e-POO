using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista11CelulaQUestão1
{
    internal class Celula
    {
            private Inteiro valor;

            public Inteiro Valor
            {
                get { return valor; }
                set { valor = value; }
            }
            private Celula proximo;

            public Celula Proximo
            {
                get { return proximo; }
                set { proximo = value; }
            }
            public Celula()
            {
                valor = new Inteiro();
                proximo = null;
            }
            public Celula(Inteiro valor)
            {
                this.valor = valor;
            }
        }
    }

