// See https://aka.ms/new-console-template for more information
using POO;

Aluno aluno1 = new Aluno(); 
aluno1.Nome = "João"; 
aluno1.Idade = 13; 
aluno1.Serie = 6;

aluno1.RetornoConsole();

System.Console.WriteLine("=============== CLASSE CARRO ================");

Carro carro1 = new Carro();
carro1.Nome = "Fusca";
carro1.Marca = "Wolksvagen";
carro1.Potencia = 1.0;

System.Console.WriteLine($"{carro1.Nome} {carro1.Marca} potencia: {carro1.Potencia.ToString("F1")}");

var carro2 = new Carro("Corsa","Chevrolet",1.0);
System.Console.WriteLine($"{carro2.Nome} {carro2.Marca} potencia: {carro2.Potencia.ToString("F1")}");