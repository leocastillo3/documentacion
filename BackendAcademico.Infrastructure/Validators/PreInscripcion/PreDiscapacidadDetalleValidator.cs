namespace BackendAcademico.Infrastructure.Validators.PreInscripcion
{
    using BackendAcademico.Core.QueryFilters.PreInscripcion;
    using FluentValidation;

    public class PreDiscapacidadDetalleValidator : AbstractValidator<PreDiscapacidadDetalleQueryFilter>
    {
        public PreDiscapacidadDetalleValidator()
        {
            RuleFor(discapacidadDetalle => discapacidadDetalle.Descripcion)
                .MaximumLength(100)
                .WithMessage("La descripción no  debe superar los 100 caracteres.");

            RuleFor(discapacidadDetalle => discapacidadDetalle.ValorDiscapacidad)
                .NotEmpty()
                .WithMessage("El valor de la discapacidad es requerida.")
                .DependentRules(() =>
                {
                    RuleFor(discapacidadDetalle => discapacidadDetalle.ValorDiscapacidad)
                        .InclusiveBetween(1,99)
                        .WithMessage("El valor es inválido.");
                });

        }
    }
}
