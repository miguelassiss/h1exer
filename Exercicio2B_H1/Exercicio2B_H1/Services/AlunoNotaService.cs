using Exercicio2B_H1.Models;
using Exercicio2B_H1.Repositories;

namespace Exercicio2B_H1.Services
{
    public class AlunoNotaService : IAlunoNotaService
    {
        private readonly IAlunoNotaRepository _alunoNotaRepository;
        private readonly IAlunoRepository _alunoRepository;
        private readonly IDisciplinaRepository _disciplinaRepository;
        public AlunoNotaService(IAlunoNotaRepository alunoNotaRepository, IAlunoRepository alunoRepository, IDisciplinaRepository disciplinaRepository)
        {
            _alunoNotaRepository = alunoNotaRepository;
            _alunoRepository = alunoRepository;
            _disciplinaRepository = disciplinaRepository;
        }
        public bool InserirNota(AlunoNota alunoNota)
        {
            Aluno alunoExistente = _alunoRepository.obterAlunoPorRa(alunoNota.RaAluno);
            if (alunoExistente == null)
            {
                return false;
            }

            Disciplina disciplinaExistente = _disciplinaRepository.obterDisciplinaPorId(alunoNota.IdDisciplina);
            if (disciplinaExistente == null)
            {
                return false;
            }

            AlunoNota notaExistente = _alunoNotaRepository.obterNotaPorAlunoEDisciplina(alunoNota.RaAluno, alunoNota.IdDisciplina);
            if (notaExistente != null)
            {
                return false;
            }

            _alunoNotaRepository.InserirNota(alunoNota);
            return true;
        }
        public AlunoNota obterNotaPorAlunoEDisciplina(string raAluno, string idDisciplina)
        {
            return _alunoNotaRepository.obterNotaPorAlunoEDisciplina(raAluno, idDisciplina);
        }
        public List<AlunoNota> ListarAlunosAprovados()
        {
            return _alunoNotaRepository.ListarAlunosAprovados();
        }
        public List<AlunoNota> ListarAlunosReprovados()
        {
            return _alunoNotaRepository.ListarAlunosReprovados();
        }

    }

}