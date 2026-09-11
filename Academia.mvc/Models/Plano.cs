namespace Academia;

public class Plano
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal ValorMensal { get; set; }
    public int DuracaoMeses { get; set; }
    public List<Matricula>? Matriculas { get; set;}
    
}