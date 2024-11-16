using Exercicio2B_H1.Models;
namespace Exercicio2B_H1.Repositories
{
    public class DisciplinaRepository : IDisciplinaRepository
    {
        private static List<Disciplina> disciplinasLista = new List<Disciplina>();

        public DisciplinaRepository() { }

        public void Criar(Disciplina novaDisciplina)
        {
            disciplinasLista.Add(new Disciplina(

                novaDisciplina.Nome,
                novaDisciplina.Curso,
                novaDisciplina.Id

            ));
        }
        public Disciplina obterDisciplinaPorNome(string nome)
        {
            return disciplinasLista.Where(a => a.Nome == nome).FirstOrDefault();
        }
        public Disciplina obterDisciplinaPorId(string id)
        {
            return disciplinasLista.Where(a => a.Id == id).FirstOrDefault();
        }
        public List<Disciplina> BuscarTodasDisciplinas()
        {
            return disciplinasLista;
        }
    }
}