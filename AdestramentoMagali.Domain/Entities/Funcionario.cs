using AdestramentoMagali.Domain.Base;

namespace AdestramentoMagali.Domain.Entities
{
    public class Funcionario : BaseEntity<int>
    {
        public Funcionario()
        {
            
        }

        public Funcionario(int id, string? nome, string? senha, string? email, long telefone, DateTime dataCadastro, string especialidade, bool ativo) : base(id)
        {
            Nome = nome;
            Senha = senha;
            Email = email;
            Telefone = telefone;
            DataCadastro = dataCadastro;
            Especialidade = especialidade;
            Ativo = ativo;
        }

        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public string? Email { get; set; }
        public long? Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public string? Especialidade { get; set; }
        public bool Ativo { get; set; }

    }
}
