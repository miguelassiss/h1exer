using Exercicio2B_H1.Models;
using System.Runtime.InteropServices;

namespace Exercicio2B_H1.Services
{
    public interface IDisciplinaService
    {
        public List<Disciplina> BuscarTodasDisciplinas();
        public bool Criar(Disciplina novaDisciplina);
        public Disciplina obterDisciplinaPorNome(string nome);
        public Disciplina obterDisciplinaPorId(string id);
    }
}
