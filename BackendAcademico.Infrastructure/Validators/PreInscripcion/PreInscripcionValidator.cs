namespace BackendAcademico.Infrastructure.Validators.PreInscripcion
{
    using BackendAcademico.Core.QueryFilters.PreInscripcion;
    using FluentValidation;

    public class PreInscripcionValidator : AbstractValidator<PreInscripcionQueryFilter>
    {
        public PreInscripcionValidator()
        {
            RuleFor(preInscripcion => preInscripcion.InformacionGeneral) 
                .NotEmpty() 
                .WithMessage("La información general es requerida.")
                .DependentRules(() =>
                {
                    RuleFor(preInscripcion => preInscripcion.InformacionGeneral)
                        .SetValidator(new PreInformacionGeneralValidator());
                });

            RuleFor(preInscripcion => preInscripcion.DatosPersonales)
                .NotEmpty()
                .WithMessage("Los datos personales son requeridos.")
                .DependentRules(() =>
                {
                    RuleFor(preInscripcion => preInscripcion.DatosPersonales)
                        .SetValidator(new PreDatosPersonalesValidator());
                });

            RuleFor(preInscripcion => preInscripcion.DatosColegio)
                .NotEmpty()
                .WithMessage("Los datos del colegio son requeridos.")
                .DependentRules(() =>
                {
                    RuleFor(preInscripcion => preInscripcion.DatosColegio)
                        .SetValidator(new PreColegioValidator());
                });

            RuleFor(preInscripcion => preInscripcion.DatosMadre)
                .SetValidator(new PreDatosPadres());

            RuleFor(preInscripcion => preInscripcion.DatosPadre)
                .SetValidator(new PreDatosPadres());

            RuleFor(preInscripcion => preInscripcion.ViveCon)
                .NotEmpty()
                .WithMessage("Los datos de vive con son requeridos.")
                .DependentRules(() =>
                {
                    RuleFor(preInscripcion => preInscripcion.ViveCon)
                        .SetValidator(new PreViveConValidator());
                });

            RuleForEach(preInscripcion => preInscripcion.Autorizaciones)
                .SetValidator(new PreAutorizacionValidator());

            RuleForEach(preInscripcion => preInscripcion.Hermanos)
                .SetValidator(new PreHermanosValidator());

            RuleFor(preInscripcion => preInscripcion.Discapacidades)
                .NotEmpty()
                .WithMessage("Los datos de discapacidad son requeridos.")
                .DependentRules(() =>
                {
                    RuleFor(preInscripcion => preInscripcion.Discapacidades)
                        .SetValidator(new PreDiscapacidadesValidator());
                });

        }
    }
}
