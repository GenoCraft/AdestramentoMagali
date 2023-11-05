using AdestramentoMagali.Domain.Entities;

public class CachorroModel
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public int? Idade { get; set; }
    public string? Raca { get; set; }
    public string? Sexo { get; set; }
    public string? Porte { get; set; }
    public float? Peso { get; set; }
    public string? Temperamento { get; set; }
    public string? TipoAdestramento { get; set; }
    public string? Plano { get; set; }
    public Adestrador? Adestrador { get; set; }
    public Cliente? Cliente { get; set; }
    public List<Equipamento> Equipamentos { get; set; }
}