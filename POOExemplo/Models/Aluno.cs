using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOExemplo.Models
{
    public class Aluno : Pessoa
    {
        public double Nota {get;set;}

         public override void Apresentar()
        {
            Console.WriteLine($"Meu Nome é {Nome} tenho {Idade} e sou aluno nota {Nota}");
        }
    }
}