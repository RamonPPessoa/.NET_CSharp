using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_Metodos
{
    public class Pessoa
    {
        // 1º Método

    public void Apresentar()
    { 
         
         System.Console.WriteLine(" Hello !!!");
    }

    // 2º Método
    public void Apresentar(string nome)
    { 
         
         System.Console.WriteLine("Hello" + nome);
    }

    // 3º Método
    public void Apresentar(string nome,int idade)
    { 
         
         System.Console.WriteLine("Ola " +nome+" sua idade é :"+idade);
    }
    }
}