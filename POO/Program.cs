// See https://aka.ms/new-console-template for more information
using POO;



Aluno aluno1 = new Aluno(); 
aluno1.Nome = "João"; 
aluno1.Idade = 13; 
aluno1.Serie = 6;

aluno1.RetornoConsole();

System.Console.WriteLine("=============== CLASSE CARRO ================");
         Carro carro1 = new Carro();
            carro1.SetNome("Fusca");
            carro1.SetMarca("Wolksvagen");
            carro1.SetPotencia(1.0);

            System.Console.WriteLine($"{carro1.GetNome()} {carro1.GetMarca()} potencia: {carro1.GetPotencia().ToString("F1")}");

            var carro2 = new Carro("Corsa","Chevrolet",2.0);
            System.Console.WriteLine($"{carro2.GetNome()} {carro2.GetMarca()} potencia: {carro2.GetPotencia().ToString("F1")}");

System.Console.WriteLine("============== METODOS ESTÁTICOS ================");

var result = MetodosEstaticos.somar(4,5);
System.Console.WriteLine(" A soma é: {0}", result);
MetodosEstaticos calc = new MetodosEstaticos();
System.Console.WriteLine(calc.multiplicar(2,5));



System.Console.WriteLine("============== Parametros Variaveis ===================");

 static void Despedida(params string [] alunos)
{
    foreach (var aluno in alunos)
    {
        Console.WriteLine("Tchau {0} ate a proxima aula",aluno);
    }


   
}
Despedida("Jhon","Steve","Jane");


        System.Console.WriteLine("============ENUM================");


       int cod = Convert.ToInt32(Video.Genero.Documentario);
       /* ou int cod = (int)Video.Genero.Documentario;*/
            System.Console.WriteLine(cod);
        