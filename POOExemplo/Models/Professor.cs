using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOExemplo.Models
{
    public sealed class Professor : Pessoa
    {
        public double Salario{get;set;}

        public override void Apresentar()
        {
            Console.WriteLine($"Meu Nome é {Nome} tenho {Idade} e meu salario é: {Salario}");
        }
    }
}