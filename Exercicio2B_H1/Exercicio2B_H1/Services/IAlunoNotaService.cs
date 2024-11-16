using Exercicio2B_H1.Models;

namespace Exercicio2B_H1.Services
{
    public interface IAlunoNotaService
    {
        public List<AlunoNota> ListarAlunosAprovados();
        public List<AlunoNota> ListarAlunosReprovados();
        AlunoNota obterNotaPorAlunoEDisciplina(string raAluno, string idDisciplina);
        public bool InserirNota(AlunoNota alunoNota);
    }
}
