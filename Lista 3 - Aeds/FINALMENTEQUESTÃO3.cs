using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Questão_3
{
    class Jogador
    {
        private int numero;
        private string nome;
        private string posicao;
        public Jogador(int numero, string nome, string posicao)
        {
            this.numero = numero;
            this.nome = nome;
            this.posicao = posicao;
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Posicao
        {
            get { return posicao; }
            set { posicao = value; }
        }
    }
    class Time
    {
        private string nome;
        private Jogador[] titulares;
        private Jogador[] reservas;
        private int quantTitulares, quantReservas;
        public Time(string nome)
        {
            this.nome = nome;
            titulares = new Jogador[11];
            reservas = new Jogador[12];
            quantTitulares = 0;
            quantReservas = 0;
        }
        public bool AdicionarTitular(Jogador jogador)
        {
            if (quantTitulares < 11)
            {
                titulares[quantTitulares] = jogador;
                quantTitulares++;
                return true;
            }
            return false;
        }
        public bool AdicionarReserva(Jogador jogador)
        {
            if (quantReservas < 12)
            {
                reservas[quantReservas] = jogador;
                quantReservas++;
                return true;
            }
            return false;
        }
        public bool SubstituirTitular(string jogador, Jogador novoJogador)
        {
            for (int i = 0; i < quantTitulares; i++)
            {
                if (titulares[i].Nome == jogador)
                {
                    titulares[i] = novoJogador;
                    return true;
                }
            }
            return false;
        }
        public bool SubstituirReserva(string jogador, Jogador novoJogador)
        {
            for (int i = 0; i < quantReservas; i++)
            {
                if (reservas[i].Nome == jogador)
                {
                    reservas[i] = novoJogador;
                    return true;
                }
            }
            return false;
        }
        public bool ConsultarTitular(string jogador)
        {
            for (int i = 0; i < quantTitulares; i++)
            {
                if (titulares[i].Nome == jogador)
                {
                    return true;
                }
            }
            return false;
        }
        public bool ConsultarReserva(String jogador)
        {
            for (int i = 0; i < quantReservas; i++)
            {
                if (reservas[i].Nome == jogador)
                {
                    return true;
                }
            }
            return false;
        }
        public void ExcluirTitular(string jogador)
        {
            Jogador[] temp = new Jogador[11];
            for (int i = 0; i < quantTitulares; i++)
            {
                if (titulares[i].Nome == jogador)
                {
                    titulares[i] = null;
                }
            }
            for (int i = 0, j = 0; i < quantTitulares; i++)
            {
                if (titulares[i] != null)
                {
                    temp[j] = titulares[i];
                    j++;
                }
            }
            for (int i = 0; i < quantTitulares; i++)
            {
                titulares[i] = temp[i];
            }
        }
        public void ExcluirReserva(string jogador)
        {
            Jogador[] tempR = new Jogador[12];
            for (int i = 0; i < quantReservas; i++)
            {
                if (reservas[i].Nome == jogador)
                {
                    reservas[i] = null;
                }
            }
            for (int i = 0, j = 0; i < quantReservas; i++)
            {
                if (reservas[i] != null)
                {
                    tempR[j] = reservas[i];
                    j++;
                }
            }
            for (int i = 0; i < quantReservas; i++)
            {
                reservas[i] = tempR[i];
            }
        }
        public void GerarArqTime(StreamWriter MeuTime)
        {
            MeuTime = new StreamWriter("MeuTime.txt");
            for (int i = 0; i < titulares.Length; i++)
            {
                if (titulares[i] != null)
                {
                    MeuTime.WriteLine(titulares[i].Nome + " " + titulares[i].Numero + " " + titulares[i].Posicao);
                }
            }
            MeuTime.Close();

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time("SNP");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("Insira nome, número e posição do jogador: ");
                string nome = Console.ReadLine();
                int numero = int.Parse(Console.ReadLine());
                string posicao = Console.ReadLine();
                Jogador jogador = new Jogador(numero, nome, posicao);
                time.AdicionarTitular(jogador);
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
            }
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Insira nome, número e posição do reserva: ");
                string nome1 = Console.ReadLine();
                int numero1 = int.Parse(Console.ReadLine());
                string posicao1 = Console.ReadLine();
                Jogador reserva = new Jogador(numero1, nome1, posicao1);
                time.AdicionarReserva(reserva);
            }
            Console.WriteLine("Insira os dados do substituto, nome, número, posição");
            string nome2 = Console.ReadLine();
            int numero2 = int.Parse(Console.ReadLine());
            string posicao2 = Console.ReadLine();
            Jogador subT = new Jogador(numero2, nome2, posicao2);
            Console.WriteLine("Insira o nome do jogador que deseja substituir: ");
            string nome3 = Console.ReadLine();
            time.SubstituirTitular(nome3, subT);
            //----------------------------------------------------------------------------
            Console.WriteLine("Insira os dados do substituto reserva, nome, número, posição");
            string nome5 = Console.ReadLine();
            int numero3 = int.Parse(Console.ReadLine());
            string posicao3 = Console.ReadLine();
            Jogador subR = new Jogador(numero3, nome5, posicao3);
            Console.WriteLine("Insira o nome do jogador que deseja substituir: ");
            string nome6 = Console.ReadLine();
            time.SubstituirReserva(nome6, subR);

            Console.WriteLine("Insira o nome do jogador que deseja consultar");
            string consult = Console.ReadLine();
            Console.WriteLine(time.ConsultarTitular(consult));
            Console.WriteLine("Insira o nome do reserva que deseja consultar");
            string consult1 = Console.ReadLine();
            Console.WriteLine(time.ConsultarReserva(consult1));

            Console.WriteLine("Insira o nome do jogador que deseja excluir");
            string excl = Console.ReadLine();
            time.ExcluirTitular(excl);
            Console.WriteLine("Insira o nome do resereva que deseja excluir");
            string excl1 = Console.ReadLine();
            time.ExcluirReserva(excl1);
            StreamWriter MeuTime = new StreamWriter("MeuTime.txt");
            MeuTime.Close();
            time.GerarArqTime(MeuTime);
            Console.ReadLine();

        }
    }
}
