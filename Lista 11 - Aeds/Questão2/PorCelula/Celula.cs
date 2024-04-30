using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão2PorCelula
{
    internal class Celula
    {
        private Site valor;

        public Site Valor
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
            valor = new Site();
            proximo = null;
        }
        public Celula(Site valor)
        {
            this.valor = valor;
        }
    }
}
