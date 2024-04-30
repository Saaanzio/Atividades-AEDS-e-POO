using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QUESTÃO2POO
{
    class Nascimento
    {
        private int mes, ano, dia;
        public Nascimento(int mes, int ano, int dia)
        {
            this.mes = mes;
            this.ano = ano;
            this.dia = dia;
        }
        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }
    }
    class Pessoa
    {
        private Nascimento data;
        private double peso, altura;
        public Pessoa(Nascimento data, double peso, double altura)
        {
            this.data = data;
            this.peso = peso;
            this.altura = altura;
        }
        public double IMC()
        {
            return peso / altura * altura;
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public Nascimento Data
        {
            get { return data; }
            set { data = value; }
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira uma opção: 0 - Sair, 1 - Inserir Pessoa, 2 - Ver Pessoas");
            int op = int.Parse(Console.ReadLine());
            while (op != 0)
            {
                if(op == 1)
                {
                    StreamWriter Pessoas = new StreamWriter("ListaPessoas.txt");
                    Console.WriteLine("Insira a data de nascimento: Dia, Mes, Ano");
                    int dia = int.Parse(Console.ReadLine());
                    int mes = int.Parse(Console.ReadLine());
                    int ano = int.Parse(Console.ReadLine());
                    Nascimento data = new Nascimento(mes, ano, dia);
                    Console.WriteLine("Insira o peso e a altura de uma pessoa: ");
                    double peso = double.Parse(Console.ReadLine());
                    double altura = double.Parse(Console.ReadLine());
                    Pessoa pessoa = new Pessoa(data, peso, altura);
                    Pessoas.WriteLine(pessoa.Peso + ":" + pessoa.Altura + ":" + pessoa.Data.Dia + "/" + pessoa.Data.Mes + "/" + pessoa.Data.Ano);
                    Pessoas.Close();
                }
                else if (op == 2)
                {
                    StreamReader PessoasRead = new StreamReader("ListaPessoas.txt");
                    string linha;
                    linha = PessoasRead.ReadLine();
                    while(linha != null)
                    {
                        Console.WriteLine(linha);
                        linha = PessoasRead.ReadLine();
                    }
                    PessoasRead.Close();
                }
                Console.WriteLine("Insira uma opção: 0 - Sair, 1 - Inserir Pessoa, 2 - Ver Pessoas");
                op = int.Parse(Console.ReadLine());
            }
        }
    }
}
