namespace BackendAcademico.Infrastructure.Validators.PreInscripcion
{
    using BackendAcademico.Core.QueryFilters.PreInscripcion;
    using FluentValidation;

    public class PreViveConValidator : AbstractValidator<PreViveConQueryFilter>
    {
        public PreViveConValidator()
        {
            RuleFor(viveCon => viveCon.ValorViveCon)
                .NotEmpty()
                .WithMessage("El valor de vive con es requerido.")
                .DependentRules(() =>
                {
                    RuleFor(viveCon => viveCon.ValorViveCon)
                        .InclusiveBetween(1, 99)
                        .WithMessage("El valor de vive con es inválido.");
                });

            RuleFor(viveCon => viveCon.NombreTutor)
                .MaximumLength(50)
                .WithMessage("El nombre del tutor no  debe superar los 50 caracteres.");

            RuleFor(viveCon => viveCon.Telefonos)
                .MaximumLength(25)
                .WithMessage("El teléfono no  debe superar los 25 caracteres.");

            RuleFor(viveCon => viveCon.Celulares)
                .MaximumLength(25) 
                .WithMessage("El celular no  debe superar los 25 caracteres.");

            RuleFor(viveCon => viveCon.TieneProblemasSalud)
                .NotNull()
                .WithMessage("El valor de tiene problemas de salud es requerido.");

            RuleFor(viveCon => viveCon.ProblemaSaludDetalle)
                .MaximumLength(50)
                .WithMessage("El detalle del problema de salud no  debe superar los 50 caracteres.");



        }
    }
}
