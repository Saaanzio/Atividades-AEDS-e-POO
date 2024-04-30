using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_3___Questão_1
{
    class Estacionamento
    {
        private String nome;
        private int numTotalVagas;
        private int numVagasLivres;
        private String[] vaga;
        public Estacionamento(String nome, int numTotalVagas)
        {
            this.nome = nome;
            this.numTotalVagas = numTotalVagas;
            this.numVagasLivres = numTotalVagas;
            vaga = new String[numTotalVagas];
            for(int i = 0; i < vaga.Length; i++)
            {
                vaga[i] = null;
            }

        }
        public int Estacionar(String placa)
        {
            for(int i = 0; i < vaga.Length; i++)
            {
                if(vaga[i] == null)
                {
                    vaga[i] = placa;
                    return i;
                }
                
            }
            return -1;
        }
        public int ObterVagaOcupada(String placa)
        {
            for (int i = 0; i < vaga.Length; i++)
            {
                if (vaga[i] == placa)
                {
                    return i;
                }
            }
            return -1;
        }
        public void RetirarVeiculo(String placa)
        {
            for (int i = 0; i < vaga.Length; i++)
            {
                if (vaga[i] == placa)
                {
                    vaga[i] = null;
                }
            }
        }
        public int ObterNumVagasLivres()
        {
            numVagasLivres = 0;
            for (int i = 0; i < vaga.Length; i++)
            {
                if (vaga[i] == null)
                {
                    numVagasLivres++;
                }       
            }
            return numVagasLivres;
        }
        public void ExibirOcupacaoEstacionamento()
        {
            for (int i = 0; i < vaga.Length; i++)
            {
                Console.WriteLine("Vaga: "+ i + "/ Ocupação: "+vaga[i]);
            }
        }

    }

}
