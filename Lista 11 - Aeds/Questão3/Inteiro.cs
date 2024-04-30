using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão3Lista11
{
    internal class Inteiro
    {
        private string item;

        public string Item
        {
            get { return item; }
            set { item = value; }
        }
        public Inteiro()
        {
            item = null;
        }
        public Inteiro(string item)
        {
            this.item = item;
        }
        public void Imprimir()
        {
            Console.WriteLine("Item: {0}", item);
        }
    }
}

