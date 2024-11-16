using Microsoft.AspNetCore.Mvc;
using Exercicio2B_H1.Models;
using Exercicio2B_H1.Services;


namespace Exercicio2B_H1.Controllers
{
    [ApiController]
    [Route("api/Aluno")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }
        [HttpPost]
        [Route("InserirAluno")]
        public IActionResult Inserir(Aluno novoAluno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool flInseriu = _alunoService.Inserir(novoAluno);

            if (flInseriu)
                return Ok("Aluno inserido com sucesso.");

            return BadRequest("Aluno não inserido");
        }
        [HttpGet]
        [Route("ObterAlunoPorCpf")]
        public IActionResult obterAlunosPorCpf(string cpf)
        {
            var alunoPesquisado = _alunoService.obterAlunosPorCpf(cpf);

            if (alunoPesquisado is null)
                return NotFound($"Aluno com cpf {cpf} não encontrado.");

            return Ok(alunoPesquisado);
        }
        [HttpGet]
        [Route("ObterAlunoPorRA")]
        public IActionResult obterAlunoPorRa(string ra)
        {
            var alunoPesquisado = _alunoService.obterAlunoPorRa(ra);

            if (alunoPesquisado is null)
                return NotFound($"Aluno com cpf {ra} não encontrado.");

            return Ok(alunoPesquisado);
        }

        [HttpGet]
        [Route("ObterTodosOsAlunos")]
        public IActionResult obterTodosAlunos()
        {
            return Ok(_alunoService.obterTodosAlunos());
        }
    }
}
