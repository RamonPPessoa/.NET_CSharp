using System.Globalization;
using EstudandoCSharp.Models;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");


decimal valorMoneatrio = 1582.40M;
System.Console.WriteLine(valorMoneatrio.ToString("N2"));


double procentagem =  .3422;
System.Console.WriteLine(  procentagem.ToString("P"));

int numero = 123456;
System.Console.WriteLine(numero.ToString("## - ## - ##"));


// Pessoa pessoa1 = new Pessoa("Joana", "Teixeira");


// Pessoa pessoa2 = new Pessoa("Paula","Santos");


// Curso cursoDeIngles = new Curso();

// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();
// cursoDeIngles.AdicionarAluno(pessoa1);
// cursoDeIngles.AdicionarAluno(pessoa2);
// cursoDeIngles.ListarAluno();







// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Paula";
// pessoa1.Sobrenome = "Teixeira";
// pessoa1.Idade = 35;
// pessoa1.Apresentar();

