namespace academia;

public class Aluno
{
    public int Id {get; set;}
    public string Nome {get; set;} = String.Empty;
    public DateTime DataNascimento {get; set;}
    public string? UserId {get; set;}
    public List<Matricula>? Matriculas {get; set;}
    public List<AvaliacaoFisica>? Avaliacoes {get; set;}
    public List<Inscricao>? Inscricoes {get; set;}
}
