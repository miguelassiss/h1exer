namespace Exercicio2B_H1.Models
{
    public class Aluno
    {
        public Aluno(string nome, string email, string telefone,
            string cpf, string ra)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            CPF = cpf;
            RA = ra;
        }

        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public string CPF { get; private set; }
        public string RA {  get; private set; }
    }
}
