using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOExemplo.Models
{
    public class Diretor : Professor // Classe selada nao pode ser herdada
    {
          public override void Apresentar()
        {
            Console.WriteLine("Diretor");
        }
    }
}