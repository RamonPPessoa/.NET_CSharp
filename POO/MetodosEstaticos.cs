using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class MetodosEstaticos
    {
        public static int somar(int  x,int y)
        {
            return x + y;
        }

        // Sem a determinação static será necessário no metodo multiplicar a criação de uma instancia
         public  int multiplicar(int  x,int y)
        {
            return x * y;
        }
    }
}