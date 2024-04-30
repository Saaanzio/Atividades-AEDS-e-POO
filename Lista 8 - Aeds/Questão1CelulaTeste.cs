using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Questão1Flex
{
    class Teste
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();
            String not = "3572-*4/+";
            for (int i = 0; i < not.Length; i++)
            {
                if (not[i] == '+' || not[i] == '-' || not[i] == '*' || not[i] == '/')
                {
                    switch (not[i])
                    {
                        case '+':
                            double num = pilha.Desempilhar().DobroV;
                            double num2 = pilha.Desempilhar().DobroV;
                            Dobro num3 = new Dobro();
                            num3.DobroV = num + num2;
                            pilha.Empilhar(num3);
                            break;
                        case '-':
                            num = pilha.Desempilhar().DobroV;
                            num2 = pilha.Desempilhar().DobroV;
                            num3 = new Dobro();
                            num3.DobroV = num2 - num;
                            pilha.Empilhar(num3);
                            break;
                        case '*':
                            num = pilha.Desempilhar().DobroV;
                            num2 = pilha.Desempilhar().DobroV;
                            num3 = new Dobro();
                            num3.DobroV = num * num2;
                            pilha.Empilhar(num3);
                            break;
                        case '/':
                            num = pilha.Desempilhar().DobroV;
                            num2 = pilha.Desempilhar().DobroV;
                            num3 = new Dobro();
                            num3.DobroV = num2 / num;
                            pilha.Empilhar(num3);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Dobro numero = new Dobro();
                    numero.DobroV = Char.GetNumericValue(not[i]);
                    pilha.Empilhar(numero);
                }
            }
            Console.WriteLine(pilha.Pico().DobroV);
            Console.ReadLine();
        }
    }
}