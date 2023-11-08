using AdestramentoMagali.Domain.Base;

namespace AdestramentoMagali.Domain.Entities
{
    public class Cachorro : BaseEntity<int>
    {
        public Cachorro()
        {
            Equipamentos = new List<Equipamento>();
        }
        
        public Cachorro(int id, string? nome, string sexo, int? idade, string? raca, string? porte, float? peso, string? temperamento, string? tipoAdestramento, string? plano, Adestrador? adestrador, Cliente? cliente, List<Equipamento> equipamentos) : base(id)
        {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
            Raca = raca;
            Porte = porte;
            Peso = peso;
            Temperamento = temperamento;
            TipoAdestramento = tipoAdestramento;
            Plano = plano;
            Adestrador = adestrador;
            Cliente = cliente;
            Equipamentos = equipamentos;
        }

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
}
