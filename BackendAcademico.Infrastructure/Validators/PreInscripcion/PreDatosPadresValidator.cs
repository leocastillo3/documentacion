namespace BackendAcademico.Infrastructure.Validators.PreInscripcion
{
    using BackendAcademico.Core.QueryFilters.PreInscripcion;
    using FluentValidation;

    public class PreDatosPadres : AbstractValidator<PreDatosPadresQueryFilter>
    {
        public PreDatosPadres()
        {           
            RuleFor(datosPadre => datosPadre.Nombres)
                .NotEmpty()
                .WithMessage("El nombre del padre es requerido.")
                .DependentRules(() =>
                {
                    RuleFor(datosPadre => datosPadre.Nombres)
                        .MaximumLength(70)
                        .WithMessage("El nombre del padre no  debe superar los 70 caracteres.");
                });

            RuleFor(datosPadre => datosPadre.SegundoApellido)
                .MaximumLength(40)
                .WithMessage("El primer apellido no  debe superar los 40 caracteres.");

            RuleFor(datosPadre => datosPadre.PrimerApellido)
                .MaximumLength(40)
                .WithMessage("El segundo apellido no  debe superar los 40 caracteres.");

            RuleFor(datosPadre => datosPadre.Direccion)
                .MaximumLength(100)
                .WithMessage("La dirección no  debe superar los 100 caracteres.");

            RuleFor(datosPadre => datosPadre.IdDepartamento)
                .NotEmpty()
                .WithMessage("El departamento de los padres es requerido.")
                .DependentRules(() =>
                {
                    RuleFor(datosPadre => datosPadre.IdDepartamento)
                        .InclusiveBetween(1, 999999999)
                        .WithMessage("El id del departamento es inválido.");
                });

            RuleFor(datosPadre => datosPadre.Telefonos)
                .MaximumLength(25)
                .WithMessage("El teléfono no  debe superar los 25 caracteres.");

            RuleFor(datosPadre => datosPadre.IdProfesion)
                .NotEmpty()
                .WithMessage("La profesión es requerida.")
                .DependentRules(() =>
                {
                    RuleFor(datosPadre => datosPadre.IdProfesion)
                        .InclusiveBetween(1, 999999999)
                        .WithMessage("La profesión es inválida.");
                });

            RuleFor(datosPadre => datosPadre.LugarDeTrabajo)
                .MaximumLength(50)
                .WithMessage("El lugar de trabajo no  debe superar los 50 caracteres.");
        }
    }
}
