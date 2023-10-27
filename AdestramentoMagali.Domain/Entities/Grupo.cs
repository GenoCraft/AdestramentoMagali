using AdestramentoMagali.Domain.Base;

namespace AdestramentoMagali.Domain.Entities
{
    public class Grupo : BaseEntity<int>
    {
        public Grupo()
        {
            
        }

        public Grupo(int id, string? nome) : base(id)
        {
            Nome = nome;
        }

        public string? Nome { get; set; } 
    }
}
