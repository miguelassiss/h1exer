using Exercicio2B_H1.Models;

namespace Exercicio2B_H1.Repositories
{
    public interface IDisciplinaRepository
    {
        public List<Disciplina> BuscarTodasDisciplinas();
        public void Criar(Disciplina novaDisciplina);
        public Disciplina obterDisciplinaPorNome(string nome);
        public Disciplina obterDisciplinaPorId(string id);
    }
}
