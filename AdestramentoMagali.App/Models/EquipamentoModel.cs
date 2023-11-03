namespace AdestramentoMagali.App.Models
{
    public class EquipamentoModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCompra { get; set; }
        public string? UnidadeCachorro { get; set; }
    }
}
