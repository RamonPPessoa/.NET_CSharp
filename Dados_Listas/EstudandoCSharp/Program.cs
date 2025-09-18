using System.Globalization;
using EstudandoCSharp.Models;


using System.Globalization;
using EstudandoCSharp.Models;
using System.IO;


new ExemploExcecao().Metodo1();




// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/LeituraArquivos.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Diretório não encontrado. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }

// finally
// {
//     System.Console.WriteLine("Chegou aqui !!");
// }




// string dataString = "2025-14-20  20:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm",
//                         CultureInfo.InvariantCulture,
//                          DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     System.Console.WriteLine($"Conversão com sucesso Data: {data}");
// }

// else
// {
//     System.Console.WriteLine($"{dataString} não é uma data válida");
// }





/*DateTime data = DateTime.Now;

System.Console.WriteLine(data.ToString("dd/MM/yyyy"));

*/




















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");


// decimal valorMoneatrio = 1582.40M;
// System.Console.WriteLine(valorMoneatrio.ToString("N2"));


// double procentagem =  .3422;
// System.Console.WriteLine(  procentagem.ToString("P"));

// int numero = 123456;
// System.Console.WriteLine(numero.ToString("## - ## - ##"));





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

