using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_Conceitos
{
    public class Pessoa
    {
        public string? nome;
        public int idade;


        public void Mensagem() 
        {
            System.Console.WriteLine($"Ola {nome} voce tem {idade}");
        }
    }
}