using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Encapsulamento
{
    public class Aluno
    {

        private double nota1,nota2;
        private double Media()
        {
            return (nota1+nota2)/2;
        }

        public void Mensagem()
        {
            System.Console.WriteLine("Primeira nota: ");
            nota1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Segunda nota: ");
            nota2 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("A media é: " + Media());
        }
    }
}