
using FluentValidation;
using AdestramentoMagali.Domain.Entities;

namespace AdestramentoMagali.Service.Validators
{
    public class EquipamentoValidator : AbstractValidator<Equipamento>
    {
        public EquipamentoValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");
        }
    }
}
