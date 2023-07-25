using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_Exercicio
{
    public class Aluno
    {
        public string nome ;
        public double nota1, nota2;


        public double Media()
        {
            return (nota1+nota2)/2;
        }

        public string Situacao(double media)
        {
            return media >=7 ? "Aprovado": "Reprovado";
        }

        public void Mensagem()
        {
            double obterMedia = Media();


            string obterSituacao = Situacao(obterMedia);


            System.Console.WriteLine(nome+ "Voce está"+obterSituacao+ " e sua média é "+ obterMedia);
        }


    }
}