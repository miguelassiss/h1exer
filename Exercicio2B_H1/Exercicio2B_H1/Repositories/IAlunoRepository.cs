using Exercicio2B_H1.Models;

namespace Exercicio2B_H1.Repositories
{
    public interface IAlunoRepository
    {
        public List<Aluno> obterTodosAlunos();
        public Aluno obterAlunosPorCpf(string cpf);
        public Aluno obterAlunoPorRa(string ra);
        public void Inserir(Aluno novoAluno);
    }
}
