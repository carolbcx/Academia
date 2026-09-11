namespace Academia;

public class Aula
{
    public  int Id {get; set;}
    public String Nome {get; set;} = string.Empty;
    public DayOfWeek DiaDaSemana {get; set;}
    public TimeSpan Horario {get; set;}
    public int VagasTotais {get; set;}
    public int ProfissionalId {get; set;}
    public Profissional? Profissional {get; set;}
    public List<Inscricao>? Incricoes {get; set;}

}