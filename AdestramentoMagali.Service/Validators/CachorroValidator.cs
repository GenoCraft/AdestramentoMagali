
using FluentValidation;
using AdestramentoMagali.Domain.Entities;

namespace AdestramentoMagali.Service.Validators
{
    public class CachorroValidator : AbstractValidator<Cachorro>
    {
        public CachorroValidator()
        {
            RuleFor(c => c.Cliente)
                .NotEmpty().WithMessage("Por favor informe o cliente.")
                .NotNull().WithMessage("Por favor informe o cliente.");
            RuleFor(c => c.Adestrador)
                .NotEmpty().WithMessage("Por favor informe o adestrador.")
                .NotNull().WithMessage("Por favor informe o adestrador.");
            RuleFor(c => c.Items)
                .NotEmpty().WithMessage("Por favor informe os equipamentos.")
                .NotNull().WithMessage("Por favor informe os equipamentos.");
        }
    }
}
