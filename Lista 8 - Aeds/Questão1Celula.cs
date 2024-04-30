using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Questão1Flex
{
    class Dobro
    {
        private double dobroV;
        public double DobroV
        {
            get { return dobroV; }
            set { dobroV = value; }
        }
    }
    class Celula
    {
        Dobro dobroV;
        Celula proximo;
        public Celula(Dobro dobroV)
        {
            this.dobroV = dobroV;
            this.proximo = null;
        }
        public Celula()
        {
            dobroV = null;
            proximo = null;
        }
        public Dobro DobroV
        {
            get { return dobroV; }
            set { dobroV = value; }
        }
        public Celula Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }



    }
    class Pilha
    {
        public Celula topo;
        public Celula fundo;
        public Pilha()
        {
            Celula sentinela = new Celula();
            topo = sentinela;
            fundo = sentinela;
        }
        public void Empilhar(Dobro dobroV)
        {
            Celula novaCelula = new Celula(dobroV);
            novaCelula.Proximo = topo;
            topo = novaCelula;
            novaCelula = null;
        }
        public Dobro Desempilhar()
        {
            if (!(topo == fundo))
            {
                Dobro desempilhado = topo.DobroV;
                topo = topo.Proximo;
                return desempilhado;
            }
            else
            {
                throw new Exception("A pilha está vazia.");
            }
        }
        public Dobro Pico()
        {
            return topo.DobroV;
        }



    }
}