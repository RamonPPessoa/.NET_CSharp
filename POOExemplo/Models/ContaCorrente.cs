using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace POOExemplo.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta,decimal saldoInicial)
        {
            NumeroConta =  numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }

        public decimal saldo { get; set; }

        public void Sacar (decimal valor)
        {

            if (saldo >= valor)
            {
                saldo -=valor;
                System.Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                System.Console.WriteLine("Saldo insuficiente !!");
            }
        }

        public void Exibirsaldo()
        {
            System.Console.WriteLine("Seu saldo disponivel é: "+ saldo);
        }
    }
}