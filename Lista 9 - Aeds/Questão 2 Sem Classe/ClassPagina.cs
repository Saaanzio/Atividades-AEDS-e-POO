using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão2SemClasse
{
    class Pagina
    {
        private int numero;
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private string arquivo;
        public string Arquivo
        {
            get { return arquivo; }
            set { arquivo = value; }
        }
        public Pagina(int numero, string arquivo)
        {
            this.arquivo = arquivo;
            this.numero = numero;
        }
    }
}