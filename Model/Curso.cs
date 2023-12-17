using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades__Métodos_e_Construtores.Model
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos {get;set;}

        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados(){
            int quantidade = Alunos.Count;
            return quantidade;

        }
    }
}