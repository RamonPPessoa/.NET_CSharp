using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudandoCSharp.Models
{
    public class Pessoa
    {
        private string _nome;
        public string Nome
        {
            get => _nome.ToUpper(); // body expressions
             

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Nome nao pode ser vazio");
                }
                _nome = value;
            }

        }
        public int Idade { get; set; }

        public void Apresentar()
        {
            System.Console.WriteLine( $"Nome:{Nome} de idade:{Idade}");
        }
    }
}