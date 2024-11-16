using Exercicio2B_H1.Models;
using Exercicio2B_H1.Repositories;

namespace Exercicio2B_H1.Services
{
    public class DisciplinaService : IDisciplinaService
    {
        private readonly IDisciplinaRepository _disciplinaRepository;

        public DisciplinaService(IDisciplinaRepository disciplinaRepository)
        {
            _disciplinaRepository = disciplinaRepository;
        }
        public Disciplina obterDisciplinaPorNome(string nome)
        {
            return _disciplinaRepository.obterDisciplinaPorNome(nome);
        }
        public Disciplina obterDisciplinaPorId(string id)
        {
            return _disciplinaRepository.obterDisciplinaPorId(id);
        }
        public bool Criar(Disciplina novaDisciplina)
        {
            Disciplina disciplinaExistente = _disciplinaRepository.obterDisciplinaPorNome(novaDisciplina.Nome);

            if (disciplinaExistente != null)
            {
                return false;
            }

            _disciplinaRepository.Criar(novaDisciplina);
            return true;
        }

        public List<Disciplina> BuscarTodasDisciplinas()
        {
            return _disciplinaRepository.BuscarTodasDisciplinas();
        }
        }
    }

