namespace BackendAcademico.Infrastructure.Validators.PreInscripcion
{
    using BackendAcademico.Core.QueryFilters.PreInscripcion;
    using FluentValidation;

    public class PreInformacionGeneralValidator : AbstractValidator<InformacionGeneralQueryFilter>
    {
        public PreInformacionGeneralValidator()
        {
            RuleFor(informacionGeneral => informacionGeneral.IdCarrera)
                .NotEmpty()
                .WithMessage("La carrera es requerida.")
                .DependentRules(() =>
                {
                    RuleFor(informacionGeneral => informacionGeneral.IdCarrera)
                        .InclusiveBetween(1, 999999999)
                        .WithMessage("El  id de la carrera es inválido.");
                });

            RuleFor(informacionGeneral => informacionGeneral.IdPeriodoAcademico)
                .NotEmpty()
                .WithMessage("El periodo academico es requerido.")
                .DependentRules(() =>
                {
                    RuleFor(informacionGeneral => informacionGeneral.IdPeriodoAcademico)
                        .InclusiveBetween(1, 999999999)
                        .WithMessage("El id del periodo academico es inválido.");
                });

            RuleFor(informacionGeneral => informacionGeneral.FechaInscripcion)
                .NotEmpty()
                .WithMessage("La fecha de inscripcion es requerida.");

            RuleFor(informacionGeneral => informacionGeneral.Observacion)
                .MaximumLength(300)
                .WithMessage("La observacion no debe superar los 300 caracteres.");
        }
    }
}
