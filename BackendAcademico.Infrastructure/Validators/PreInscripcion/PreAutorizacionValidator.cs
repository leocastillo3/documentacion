namespace BackendAcademico.Infrastructure.Validators.PreInscripcion
{
    using BackendAcademico.Core.QueryFilters.PreInscripcion;
    using FluentValidation;

    public class PreAutorizacionValidator : AbstractValidator<PreAutorizacionesQueryFilter>
    {
        public PreAutorizacionValidator()
        {
            RuleFor(autorizacion => autorizacion.Nombre)
                .NotEmpty()
                .WithMessage("El nombre de la persona autorizada es requerido.")
                .DependentRules(() =>
                {
                    RuleFor(autorizacion => autorizacion.Nombre)
                        .MaximumLength(150)
                        .WithMessage("El nombre de la persona autorizada no debe superar los 150 caracteres.");
                });

            RuleFor(autorizacion => autorizacion.CorreoElectronico)                                  
                .EmailAddress()
                .WithMessage("El correo electrónico no tiene el formato correcto.")
                .MaximumLength(50) 
                .WithMessage("El correo electrónico no debe superar los 50 caracteres.");
        }
    }
}
