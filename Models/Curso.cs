using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExplorandoC.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos  { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeDeAlunosMatriculados()//seguindo as boas praticas, deixando nítido 
        {
            int quantidade = Alunos.Count;
            return quantidade;//o valor que ele vai te retornar precisa ser igual o valor do seu método, nesse caso(inteiro)
        }
        public bool RemoverAluno(Pessoa aluno)
        {
           return Alunos.Remove(aluno);
         }
         public void ListarAlunos()
         {
            Console.WriteLine($"Alunos do curso de:{Nome}");
            foreach (Pessoa aluno in Alunos){
                Console.WriteLine(aluno.NomeCompleto);
            }
         }
    }
}