using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;

namespace Exercicio2B_H1.Models
{
    public class Disciplina
    {
        public Disciplina(string id, string nome, string curso)
        {
            Id = id;
            Nome = nome;
            Curso = curso;
        }

        [Required(ErrorMessage = "ID da disciplina é obrigatório")]
        public string Id { get; private set; }

        [Required(ErrorMessage = "Nome da disciplina é obrigatório")]
        public string Nome { get; private set; }

        [Required(ErrorMessage = "Curso da disciplina é obrigatório")]
        public string Curso { get; private set; }
    }
}
