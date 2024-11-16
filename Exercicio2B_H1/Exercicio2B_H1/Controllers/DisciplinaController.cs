using Microsoft.AspNetCore.Mvc;
using Exercicio2B_H1.Models;
using Exercicio2B_H1.Services;

namespace Exercicio2B_H1.Controllers
{
    [ApiController]
    [Route("api/Disciplina")]
    public class DisciplinaController : ControllerBase
    {
        private readonly IDisciplinaService _disciplinaService;

        public DisciplinaController(IDisciplinaService disciplinaService)
        {
            _disciplinaService = disciplinaService;
        }
        [HttpPost]
        [Route("InserirDisciplina")]
        public IActionResult Criar(Disciplina novaDisciplina)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool flInseriu = _disciplinaService.Criar(novaDisciplina);

            if (flInseriu)
                return Ok("Disciplina inserida com sucesso.");

            return BadRequest("Disciplina não inserida");
        }
        [HttpGet]
        [Route("ObterTodasAsDisciplinas")]
        public IActionResult BuscarTodasDisciplinas()
        {
            return Ok(_disciplinaService.BuscarTodasDisciplinas());
        }
        [HttpGet]
        [Route("ObterDisciplinaPorNome")]
        public IActionResult obterDisciplinaPorNome(string nome)
        {
            var DisciplinaPesquisada = _disciplinaService.obterDisciplinaPorNome(nome);

            if (DisciplinaPesquisada is null)
                return NotFound($"Disciplina {nome} não encontrada.");

            return Ok(DisciplinaPesquisada);
        }

    }
}



