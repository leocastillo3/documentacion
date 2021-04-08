namespace BackendAcademico.Infrastructure.Validators.PreInscripcion
{
    using BackendAcademico.Core.QueryFilters.PreInscripcion;
    using FluentValidation;

    public class PreHermanosValidator : AbstractValidator<PreHermanosQueryFilter>
    {
        public PreHermanosValidator()
        {
            RuleFor(hermanos => hermanos.Nombre)
                .NotEmpty()
                .WithMessage("El nombre del hermano es requerido.")
                .DependentRules(() =>
                {
                    RuleFor(hermanos => hermanos.Nombre)
                        .MaximumLength(150)
                        .WithMessage("El nombre no  debe superar los 150 caracteres.");
                }); 
            
            RuleFor(hermanos => hermanos.NumeroDocumento)
               .NotEmpty()
               .WithMessage("El número de documento de identidad del hermano es requerido.")
               .DependentRules(() =>
               {
                   RuleFor(hermanos => hermanos.NumeroDocumento)
                       .MaximumLength(10)
                       .WithMessage("El número de documento de identidad del hermano no debe superar los 10 caracteres.");
               });

        }
    }
}
