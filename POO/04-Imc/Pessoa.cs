using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_Imc
{
    public class Pessoa
    {
        public double peso,altura;


        public double Calculo()
        {
            return peso /(altura *altura);
        }

        public string  Situação(double imc)
        {
            string retorno;

            if(imc < 18.5)
            {
                retorno = "Abaixo do peso";
            }
            else if(imc <25)
            {
                retorno = "Peso normal";
            }
             else if(imc <30)
            {
                 retorno = "acima do peso normal";
            }
             else if(imc <35)
            {
                 retorno = "Obesidade nível 1";
            }
             else if(imc < 40)
            {
                 retorno = "Obesidade nível 2";
            }
             else 
            {
                 retorno = "Obesidade nível 3";
            }
            return retorno;
        }

        public void Mensagem()
        {
            double obterCalculo = Calculo();

            string obterSituacao = Situação(obterCalculo);

            System.Console.WriteLine("IMC: " + obterCalculo);
            System.Console.WriteLine("Situação: " + obterSituacao);
        }
    }
}