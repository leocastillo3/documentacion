namespace BackendAcademico.Infrastructure.Validators.PreInscripcion
{
    using BackendAcademico.Core.QueryFilters.PreInscripcion;
    using FluentValidation;
    using System;

    public class PreColegioValidator : AbstractValidator<PreColegioQueryFilter>
    {
        public PreColegioValidator()
        {
            RuleFor(datosColegio => datosColegio.IdColegio)
                .NotEmpty()
                .WithMessage("El colegio es requerido.")
                .DependentRules(() =>
                {
                    RuleFor(datosColegio => datosColegio.IdColegio)
                        .InclusiveBetween(1, 999999999)
                        .WithMessage("El colegio es inválido.");
                });

            RuleFor(datosColegio => datosColegio.IdDepartamento)
                .NotEmpty()
                .WithMessage("El departamento del colegio es requerido.")
                .DependentRules(() =>
                {
                    RuleFor(datosColegio => datosColegio.IdDepartamento)
                        .InclusiveBetween(1, 999999999)
                        .WithMessage("El departamento del colegio es inválido.");
                });

            RuleFor(datosColegio => datosColegio.IdProvincia)
                .NotEmpty()
                .WithMessage("La provincia del colegio es requerida.")
                .DependentRules(() =>
                {
                    RuleFor(datosColegio => datosColegio.IdProvincia)
                        .InclusiveBetween(1, 999999999)
                        .WithMessage("La provincia del colegio es inválida.");
                });

            RuleFor(datosColegio => datosColegio.ValorTurno)
                .NotEmpty()
                .WithMessage("El turno del colegio es requerido.")
                .DependentRules(() =>
                {
                    RuleFor(datosColegio => datosColegio.ValorTurno)
                        .InclusiveBetween(1, 9)
                        .WithMessage("El turno del colegio es inválido.");
                });

            RuleFor(datosColegio => datosColegio.ValorTipoColegio)
                .NotEmpty()
                .WithMessage("El tipo de colegio es requerido.")
                .DependentRules(() =>
                {
                    RuleFor(datosColegio => datosColegio.ValorTipoColegio)
                        .InclusiveBetween(1, 9)
                        .WithMessage("El tipo de colegio es inválido.");
                });

            RuleFor(datosColegio => datosColegio.AnioEgreso)
                .NotEmpty()
                .WithMessage("El año de egreso es requerido.");
        }
    }
}
