using AdestramentoMagali.Domain.Base;

namespace AdestramentoMagali.Domain.Entities
{
    public class Equipamento : BaseEntity<int>
    {
        public Equipamento()
        {
            
        }

        public Equipamento(int id, string? nome, float preco, int quantidade, DateTime dataCompra, string? unidadeCachorro) : base(id)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            DataCompra = dataCompra;
            UnidadeCachorro = unidadeCachorro;
        }

        public string? Nome { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCompra { get; set; }
        public string? UnidadeCachorro { get; set; }

    }
}
