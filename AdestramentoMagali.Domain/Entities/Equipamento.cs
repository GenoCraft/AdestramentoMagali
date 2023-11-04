using AdestramentoMagali.Domain.Base;

namespace AdestramentoMagali.Domain.Entities
{
    public class Equipamento : BaseEntity<int>
    {
        public Equipamento()
        {
            
        }

        public Equipamento(int id, string? nome, string indicacao, int quantidade, string? descricao) : base(id)
        {
            Nome = nome;
            Indicacao = indicacao;
            Quantidade = quantidade;
            Descricao = descricao;
        }

        public string? Nome { get; set; }
        public string Indicacao { get; set; }
        public int Quantidade { get; set; }
        public string? Descricao { get; set; }

    }
}
