using Exercicio2B_H1.Models;

namespace Exercicio2B_H1.Services
{
    public interface IAlunoService
    {
        public List<Aluno> obterTodosAlunos();
        public Aluno obterAlunosPorCpf(string cpf);
        public bool Inserir(Aluno novoAluno);
        public Aluno obterAlunoPorRa(string ra);

    }
}
