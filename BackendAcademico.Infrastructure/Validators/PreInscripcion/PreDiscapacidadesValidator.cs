namespace BackendAcademico.Infrastructure.Validators.PreInscripcion
{
    using BackendAcademico.Core.QueryFilters.PreInscripcion;
    using FluentValidation;

    public class PreDiscapacidadesValidator : AbstractValidator<PreDiscapacidadesQueryFilter>
    {
        public PreDiscapacidadesValidator()
        {
            RuleForEach(discapacidad => discapacidad.DiscapacidadesDetalle)
                .SetValidator(new PreDiscapacidadDetalleValidator());

            RuleForEach(discapacidad => discapacidad.TrastornosDetalle)
                .SetValidator(new PreDiscapacidadDetalleValidator());

            RuleForEach(discapacidad => discapacidad.TrastornosAprendizajeDetalle)
                .SetValidator(new PreDiscapacidadDetalleValidator());
        }
    }
}
