using Exercicio2B_H1.Models;

namespace Exercicio2B_H1.Repositories
{
    public class AlunoNotaRepository : IAlunoNotaRepository
    {
        private static List<AlunoNota> listaNotas = new List<AlunoNota>();

        public AlunoNotaRepository() { }
        public void InserirNota(AlunoNota alunoNota)
        {
            listaNotas.Add(new AlunoNota(

                alunoNota.RaAluno,
                alunoNota.IdDisciplina,
                alunoNota.Nota,
                alunoNota.Frequencia
            ));
        }
        public AlunoNota obterNotaPorAlunoEDisciplina(string raAluno, string idDisciplina)
        {
            return listaNotas.FirstOrDefault(n => n.RaAluno == raAluno && n.IdDisciplina == idDisciplina);
        }
        public List<AlunoNota> ListarAlunosReprovados()
        {
            return listaNotas.Where(an => an.Nota < 7 || an.Frequencia < 75).ToList();
        }
        public List<AlunoNota> ListarAlunosAprovados()
        {
            return listaNotas.Where(an => an.Nota >= 7 && an.Frequencia >= 75).ToList();
        }
    } }

