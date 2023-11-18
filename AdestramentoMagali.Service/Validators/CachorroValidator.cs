
using FluentValidation;
using AdestramentoMagali.Domain.Entities;

namespace AdestramentoMagali.Service.Validators
{
    public class CachorroValidator : AbstractValidator<Cachorro>
    {
        public CachorroValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");

            RuleFor(c => c.TipoAdestramento)
                .NotEmpty().WithMessage("Por favor informe o tipo de adestramento.")
                .NotNull().WithMessage("Por favor informe o tipo de adestramento.");

            RuleFor(c => c.Plano)
                .NotEmpty().WithMessage("Por favor informe o plano.")
                .NotNull().WithMessage("Por favor informe o plano.");

            RuleFor(c => c.Cliente)
                .NotEmpty().WithMessage("Por favor informe o cliente responsável.")
                .NotNull().WithMessage("Por favor informe o cliente responsável.");
            RuleFor(c => c.Funcionario)
                .NotEmpty().WithMessage("Por favor informe o adestrador responsável.")
                .NotNull().WithMessage("Por favor informe o adestrador responsável.");
        }
    }
}
