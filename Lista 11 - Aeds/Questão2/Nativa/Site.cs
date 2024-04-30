using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista11Questão2
{
    internal class Site
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string link;

        public string Link
        {
            get { return link; }
            set { link = value; }
        }

        public Site()
        {
            nome = null;
            link = null;
        }
        public Site(string nome, string link)
        {
            this.nome = nome;
            this.link = link;
        }
        public void Imprimir()
        {
            Console.WriteLine("Site: {0}:{1}", nome, link);
        }
    }
}
