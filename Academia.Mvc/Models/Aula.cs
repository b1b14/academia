namespace academia;

public class Aula
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public DayOfWeek DiaSemana { get; set; }
    public TimeSpan Horario { get; set; }
    public int VagasTotais { get; set; }
    public int ProfissionalId { get; set; }
    public Profissional? Profissional { get; set; }
    public List<Inscricao>? Inscricoes { get; set; }
}
