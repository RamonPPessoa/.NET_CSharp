using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Aluno
    {
        public string? Nome;
        public int Idade;
        public int Serie;

public string Retorno()
{
return string.Format($"O aluno {Nome} tem {Idade} anos e pertence ao {Serie} ano");
}
public void RetornoConsole()
{
Console.WriteLine(Retorno());
    
    
}


    }
}
