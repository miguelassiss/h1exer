using Exercicio2B_H1.Models;
using Exercicio2B_H1.Services;
using Microsoft.AspNetCore.Mvc;

namespace Exercicio2B_H1.Controllers
{
    [ApiController]
    [Route("api/NotaAluno")]
    public class NotaAlunoController : ControllerBase
    {
        private readonly IAlunoNotaService _alunoNotaService;

        public NotaAlunoController(IAlunoNotaService alunoNotaService)
        {
            _alunoNotaService = alunoNotaService;
        }

        [HttpPost]
        [Route("InserirNota")]
        public IActionResult InserirNota(AlunoNota alunoNota)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool flInseriu = _alunoNotaService.InserirNota(alunoNota);

            if (flInseriu)
                return Ok("Nota inserida com sucesso.");

            return BadRequest("Nota não inserida");
        }
        [HttpGet]
        [Route("ListaAlunosAprovados")]
        public IActionResult ListarAlunosAprovados()
        {
            return Ok(_alunoNotaService.ListarAlunosAprovados());
        }
        [HttpGet]
        [Route("ListaAlunosReprovados")]
        public IActionResult ListarAlunosReprovados()
        {
            return Ok(_alunoNotaService.ListarAlunosReprovados());
        }
    }
}
