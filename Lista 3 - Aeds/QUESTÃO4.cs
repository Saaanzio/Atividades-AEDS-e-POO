using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTÃO4POOOO
{
    class Livro
    {
        private string titulo, autores, editora;
        public Livro(string titulo, string autores, string editora)
        {
            this.titulo = titulo;
            this.autores = autores;
            this.editora = editora;
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Autores
        {
            get { return autores; }
            set { autores = value; }
        }
        public string Editora
        {
            get { return editora; }
            set { editora = value; }
        }
    }
    class Biblioteca
    {
        public Livro[] livros = new Livro[50];
        private int numLivros = 0;
        private int MAXLIV = 50;
        public void AdicionarLivro(string titulo, string autor, string editora)
        {
            if(numLivros < MAXLIV)
            {
                livros[numLivros] = new Livro(titulo, autor, editora);
                numLivros++;
            }
            else
            {
                Console.WriteLine("Biblioteca cheia");
            }
        }
        public void AdicionarLivro(Livro livro)
        {
            livros[numLivros] = livro;
            numLivros++;
        }
        public Livro ObterLivro(string titulo)
        {
            for(int i = 0; i < numLivros; i++)
            {
                if (livros[i].Titulo == titulo)
                {
                    return livros[i];
                }
            }
            return null;
        }
        public Livro[] ObterLista()
        {
            return livros;
        }
        public int ObterNum()
        {
            return numLivros;
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Insira o titulo, autor e editora do livro: ");
                string titulo1 = Console.ReadLine();
                string autor = Console.ReadLine();
                string editora = Console.ReadLine();
                biblioteca.AdicionarLivro(titulo1, autor, editora);
            }
            Console.WriteLine("Insira o nome do livro que deseja conferir: ");
            string titulo = Console.ReadLine();
            Livro imprimir = biblioteca.ObterLivro(titulo);
            Console.WriteLine(imprimir.Titulo + ", "+ imprimir.Autores + ", "+ imprimir.Editora);
            Livro[] todosLivros = biblioteca.ObterLista();
            for(int i = 0; i < todosLivros.Length; i++)
            {
                if (todosLivros[i] != null)
                {
                    Console.WriteLine(todosLivros[i].Titulo + " "+ todosLivros[i].Autores + " " + todosLivros[i].Editora);
                }
            }
            Console.ReadLine();
        }
    }
}
