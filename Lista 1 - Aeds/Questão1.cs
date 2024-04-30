using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double somaMes = 0, somaTotal = 0;
            double[,] mat1 = new double[12, 4];
            double[] vetSemana = new double[4];
            for(int i = 0; i < 12; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Insira o valor do mês: " + (i + 1) + " na semana: "+(j + 1));
                    mat1[i, j] = double.Parse(Console.ReadLine());
                }
            }
            for(int i = 0; i < 12; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    somaMes += mat1[i, j];
                    vetSemana[j] += mat1[i, j];
                }
                Console.WriteLine("A soma total do mês: " + (i + 1) + " é de:" + somaMes);
                somaTotal += somaMes;
                somaMes = 0;
            }
            double maior = 0;
            int semana = 0;
            for (int i = 0; i < 4; i++)
            {
                if (vetSemana[i] > maior)
                {
                    maior = vetSemana[i];
                    semana = i;
                }
            }
            Console.WriteLine("A semana com mais vendas é a: " + (semana + 1) + " com um total de vendas de: " + maior);
            Console.WriteLine("A soma de todos meses é de:" + somaTotal);
            Console.ReadKey();
        }
    }
}
