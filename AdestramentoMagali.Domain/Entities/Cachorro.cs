using System.Text.Json.Serialization;
using AdestramentoMagali.Domain.Base;

namespace AdestramentoMagali.Domain.Entities
{
    public class Cachorro : BaseEntity<int>
    {
        public Cachorro()
        {
            Items = new List<CachorroItem>();
        }
        
        public Cachorro(int id, DateTime data, float valorTotal, Adestrador? adestrador, Cliente? cliente, List<CachorroItem> items) : base(id)
        {
            Data = data;
            ValorTotal = valorTotal;
            Adestrador = adestrador;
            Cliente = cliente;
            Items = items;
        }

        public DateTime Data { get; set; }
        public float ValorTotal { get; set; }
        public Adestrador? Adestrador { get; set; }
        public Cliente? Cliente { get; set; }
        public List<CachorroItem> Items { get; set; }
    }

    public class CachorroItem : BaseEntity<int>
    {
        public CachorroItem()
        {
            
        }

        public CachorroItem(int id, Equipamento? equipamento, int quantidade, float valorUnitario, float valorTotal, Cachorro? cachorro) : base(id)
        {
            Equipamento = equipamento;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
            ValorTotal = valorTotal;
            Cachorro = cachorro;
        }

        public Equipamento? Equipamento { get; set; }
        public int Quantidade { get; set; }
        public float ValorUnitario { get; set; }    
        public float ValorTotal { get; set; }
        [JsonIgnore]
        public Cachorro? Cachorro { get; set; }
    }
}
