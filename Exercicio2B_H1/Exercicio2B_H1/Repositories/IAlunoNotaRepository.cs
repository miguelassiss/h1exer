using Exercicio2B_H1.Models;

namespace Exercicio2B_H1.Repositories
{
    public interface IAlunoNotaRepository
    {
        public List<AlunoNota> ListarAlunosAprovados();
        public List<AlunoNota> ListarAlunosReprovados();
        public AlunoNota obterNotaPorAlunoEDisciplina(string raAluno, string idDisciplina);
        public void InserirNota(AlunoNota alunoNota);
    }
}
