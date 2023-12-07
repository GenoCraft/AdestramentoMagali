using AdestramentoMagali.Domain.Base;
using System.Text.Json.Serialization;

namespace AdestramentoMagali.Domain.Entities
{
    public class Cachorro : BaseEntity<int>
    {
        public Cachorro()
        {
            Equipamentos = new List<CachorroEquip>();
        }
        
        public Cachorro(int id, string? nome, string sexo, int? idade, string? raca, string? porte, float? peso, string? temperamento, string? tipoAdestramento, string? plano, Funcionario? funcionario, Cliente? cliente, List<CachorroEquip> equipamentos) : base(id)
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
            Funcionario = funcionario;
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
        public virtual Funcionario? Funcionario { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public virtual List<CachorroEquip> Equipamentos { get; set; }
    }
    public class CachorroEquip : BaseEntity<int>
    {
        public CachorroEquip()
        {

        }

        public CachorroEquip(int id, Equipamento? equipamento, Cachorro? cachorro) : base(id)
        {
            Equipamento = equipamento;
            Cachorro = cachorro;
        }

        public virtual Equipamento? Equipamento { get; set; }
        public virtual Cachorro? Cachorro { get; set; }
    }
}
