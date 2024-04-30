using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(3119, "12345678909", 200, 100);
            /*conta.Depositar(300);
            conta.Sacar(600);
            conta.getSaldo();
            conta.ImprimirExtrato();
            //Teste com menos de 10 números
            */
            conta.Depositar(201);
            conta.Depositar(202);
            conta.Depositar(203);
            conta.Depositar(204);
            conta.Sacar(205);
            conta.Depositar(206);
            conta.Depositar(207);
            conta.Depositar(208);
            conta.Depositar(209);
            conta.Sacar(210);
            conta.Depositar(211);
            Console.WriteLine(conta.exibirSaldo());
            conta.Sacar(1736);
            Console.WriteLine(conta.exibirSaldo());
            conta.Depositar(200);
            Console.WriteLine(conta.exibirSaldo());
            conta.ImprimirExtrato();
            //Teste com mais de 10 números
            Console.ReadLine();
        }
    }
}
