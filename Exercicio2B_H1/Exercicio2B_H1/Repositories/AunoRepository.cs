using Exercicio2B_H1.Models;

namespace Exercicio2B_H1.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private static List<Aluno> dadosAlunosList = new List<Aluno>();

        public AlunoRepository() { }
        public void Inserir(Aluno novoAluno)
        {
            dadosAlunosList.Add(new Aluno(

                novoAluno.Nome,
                novoAluno.Email,
                novoAluno.Telefone,
                novoAluno.CPF,
                novoAluno.RA
            ));
        }
        public Aluno obterAlunoPorRa(string ra)
        {
            return dadosAlunosList.Where(a => a.RA == ra).FirstOrDefault();
        }


        public Aluno obterAlunosPorCpf(string cpf)
        {
            return dadosAlunosList.Where(a => a.CPF == cpf).FirstOrDefault();
        }

        public List<Aluno> obterTodosAlunos()
        {
            return dadosAlunosList;
        }
    }
}