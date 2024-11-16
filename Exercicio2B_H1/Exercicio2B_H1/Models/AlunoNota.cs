namespace Exercicio2B_H1.Models
{
    public class AlunoNota
    {
        public AlunoNota(string raAluno, string idDisciplina, int nota, double frequencia)
        {
            RaAluno = raAluno;            
            IdDisciplina = idDisciplina;  
            Nota = nota;                  
            Frequencia = frequencia;      
        }

        public string IdDisciplina { get; private set; }
        public int Nota { get; private set; }
        public double Frequencia { get; private set; }
        public string RaAluno { get; private set; }
    }
}
