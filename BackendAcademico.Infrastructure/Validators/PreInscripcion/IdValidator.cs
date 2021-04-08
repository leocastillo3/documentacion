namespace BackendAcademico.Infrastructure.Validators.PreInscripcion
{
    using FluentValidation;

    public class IdValidator : AbstractValidator<int>
    {
        public IdValidator()
        {
            RuleFor(data => data)
                .NotEmpty()
                .WithMessage("El id no debe ser nulo");
        }
    }
}
