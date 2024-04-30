using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista11Questão1Vetor
{
    internal class Inteiro
    {
        private int item;

        public int Item
        {
            get { return item; }
            set { item = value; }
        }
        public Inteiro()
        {
            item = 0;
        }
        public Inteiro(int item)
        {
            this.item = item;
        }
        public void Imprimir()
        {
            Console.WriteLine("Item: {0}", item);
        }
    }
}
