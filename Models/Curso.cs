using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeAlunosMatriculados()
        {
            int quantidade = Alunos.Count();
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            bool value = Alunos.Remove(aluno);
            if (value == false)
            {
                throw new ArgumentException ("Argumento invalido ao retirar aluno");
            }

            return value;
        }

        public void ListarAlunos()
        {
            foreach(Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}