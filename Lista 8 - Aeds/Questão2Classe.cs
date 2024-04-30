using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão2Flex
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;



    namespace Questiones2
    {
        class Linha
        {
            private char stringV;
            public char StringV
            {
                get { return stringV; }
                set { stringV = value; }
            }
        }
        class Celula
        {
            Linha stringV;
            Celula proximo;
            public Celula(Linha stringV)
            {
                this.stringV = stringV;
                this.proximo = null;
            }
            public Celula()
            {
                stringV = null;
                proximo = null;
            }
            public Linha StringV
            {
                get { return stringV; }
                set { stringV = value; }
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
            public void Empilhar(Linha stringV)
            {
                Celula novaCelula = new Celula(stringV);
                novaCelula.Proximo = topo;
                topo = novaCelula;
                novaCelula = null;
            }
            public Linha Desempilhar()
            {
                if (!(topo == fundo))
                {
                    Linha desempilhado = topo.StringV;
                    topo = topo.Proximo;
                    return desempilhado;
                }
                else
                {
                    throw new Exception("A pilha está vazia.");
                }
            }
            public Linha Pico()
            {
                return topo.StringV;
            }



        }
    }
}
