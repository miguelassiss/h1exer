using Exercicio2B_H1.Models;
using Exercicio2B_H1.Repositories;

namespace Exercicio2B_H1.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }
        public Aluno obterAlunoPorRa(string ra)
        {
            return _alunoRepository.obterAlunoPorRa(ra);
        }
        public bool Inserir(Aluno novoAluno)
        {
            Aluno alunoExistente = _alunoRepository.obterAlunoPorRa(novoAluno.RA);

            if (alunoExistente != null)
            {
                return false;
            }

            _alunoRepository.Inserir(novoAluno);
            return true;
        }
        public Aluno obterAlunosPorCpf(string cpf)
        {
            return _alunoRepository.obterAlunosPorCpf(cpf);
        }
        public List<Aluno> obterTodosAlunos()
        {
            return _alunoRepository.obterTodosAlunos();
        }


    }
}
