using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão3Lista11
{
    internal class CelulaDupla
    {
        private Inteiro valor;

        public Inteiro Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        private CelulaDupla proximo;

        public CelulaDupla Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }
        private CelulaDupla anterior;

        public CelulaDupla Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
        public CelulaDupla()
        {
            valor = new Inteiro();
            proximo = null;
            anterior = null;
        }
        public CelulaDupla(Inteiro valor)
        {
            this.valor = valor;
            proximo = null;
            anterior = null;
        }
    }
}
