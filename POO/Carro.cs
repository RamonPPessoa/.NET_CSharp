using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Carro
    {
        private string? Nome;
        private string? Marca;
        private double Potencia;

        public Carro(string nome,string marca,double potencia)
        {
            Nome = nome;
            Marca = marca;
            Potencia = potencia;
        }
        public Carro()
        {
            
        }
        public string GetMarca()
        {
            return Marca;
        }
        public void SetMarca(string marca)
        {
            Marca = marca;
        }

         public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }

         public double GetPotencia()
        {
            return Potencia;
        }
        public void SetPotencia(double potencia)
        {
            Potencia = potencia;
        }
    }
}