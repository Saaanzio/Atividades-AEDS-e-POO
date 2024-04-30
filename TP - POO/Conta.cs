using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TesteContaBancaria
{
    internal class Conta
    {
        private int contaId;
        private string cpf;
        private double saldo;
        private double limite;
        private Stack<string> extrato;
        public Conta(int contaId, string cpf, double saldo, double limite)
        {
            this.contaId = contaId;
            this.cpf = cpf;
            this.saldo = saldo;
            this.limite = limite;
            extrato = new Stack<string>();
        }
        public void Depositar(double valor)
        {
            valor = cobrarTaxa(valor);
            saldo += valor;
            adicionarExtrato(valor, "Deposito");
            Console.WriteLine("Deposito realizado com sucesso");
        }

        private void adicionarExtrato(double valor, string acao)
        {
            extrato.Push(string.Format("Ação: {0} de valor de: {1}",acao, valor));
        }

        private double cobrarTaxa(double valor)
        {
            if(saldo < 0)
                return valor - ((-1) * (saldo * 0.03));
            return valor;
        }
        public void Sacar(double valor)
        {
            if(valor <= saldo)
            {
                saldo -= valor;
                adicionarExtrato(valor, "Saque");
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else if(valor > saldo && valor <= (saldo + limite))
            { 
                saldo = -1*((saldo + limite) - valor);
                if (saldo == 0) // verificação se o valor é exatamente saldo + limite, para que o saldo negativado não seja 0 e sim o valor de limite negativado
                    saldo = -1 * limite;
                adicionarExtrato(valor, "Saque");
                Console.WriteLine("Saque realizado com sucesso, saldo negativado!");
            }
            else
                Console.WriteLine("Não foi possível sacar seu dinheiro! Saldo e limite insuficiente!");
        }
        public double exibirSaldo()
        {
            return saldo; //método teste feito para verificar funcionanamento. Não incluído no UML
        }
        public void ImprimirExtrato()
        {
            int x = extrato.Count >= 10 ? 10 : extrato.Count; // verifica se tem mais de 10 membros na pilha para que possa imprimir até 10, ou até o limite do extrato
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(extrato.Pop());
            }
        }
    }
}
