namespace AdestramentoMagali.App.Models
{
    public class AdestradorModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public string? Email { get; set; }
        public long? Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public string? Especialidade { get; set; }
        public bool Ativo { get; set; }
    }
}
