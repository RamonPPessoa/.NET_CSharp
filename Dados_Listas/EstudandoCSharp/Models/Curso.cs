using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudandoCSharp.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }


        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int QuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAluno()
        {
            foreach (Pessoa aluno in Alunos)
            {
                System.Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}