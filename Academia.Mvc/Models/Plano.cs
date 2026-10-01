namespace academia;

public class Plano
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public decimal ValorMensalidade { get; set; }
    public int DuracaoMeses { get; set; }
    public List<Matricula>? Matriculas { get; set; }
}
