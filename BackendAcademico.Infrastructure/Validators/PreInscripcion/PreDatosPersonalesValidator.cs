namespace BackendAcademico.Infrastructure.Validators.PreInscripcion
{
    using BackendAcademico.Core.QueryFilters.PreInscripcion;
    using FluentValidation;
    using System;

    public class PreDatosPersonalesValidator : AbstractValidator<PreDatosPersonalesQueryFilter>
    {
        public PreDatosPersonalesValidator()
        {
            RuleFor(datosPersonales => datosPersonales.DocumentoIdentidad)
                 .NotEmpty()
                 .WithMessage("El documento de identidad es requerido.")
                 .DependentRules(() =>
                 {
                     RuleFor(datosPersonales => datosPersonales.DocumentoIdentidad)
                         .MaximumLength(10)
                         .WithMessage("El documento de identidad no debe superar los 10 caracteres.");
                 });

           
            RuleFor(datosPersonales => datosPersonales.NumeroRegistro)
                .MaximumLength(10)
                .WithMessage("El número de registro no debe superar los 10 caracteres.");

            RuleFor(datosPersonales => datosPersonales.ValorTipoDocumento)
                .NotEmpty()
                .WithMessage("El tipo de documento es requerido.")
                .DependentRules(() =>
                {
                    RuleFor(datosPersonales => datosPersonales.ValorTipoDocumento)
                        .InclusiveBetween(1,9)
                        .WithMessage("El tipo de documento es inválido.");
                });

            RuleFor(datosPersonales => datosPersonales.IdDepartamentoExpedido)
                .InclusiveBetween(1, 999999999)
                .WithMessage("El departamento expedido es inválido.");

            RuleFor(datosPersonales => datosPersonales.Nombres)
                .NotEmpty()
                .WithMessage("El nombre no debe ser nulo.")
                .DependentRules(() =>
                {
                    RuleFor(datosPersonales => datosPersonales.Nombres)
                        .MaximumLength(70)
                        .WithMessage("El nombre no debe superar los 70 caracteres.");
                });

            RuleFor(datosPersonales => datosPersonales.PrimerApellido)
                .MaximumLength(40)
                .WithMessage("El primer apellido no debe superar los 40 caracteres.");

            RuleFor(datosPersonales => datosPersonales.SegundoApellido)
                .MaximumLength(40)
                .WithMessage("El segundo apellido no debe superar los 40 caracteres.");

            RuleFor(datosPersonales => datosPersonales.TercerApellido)
                .MaximumLength(40)
                .WithMessage("El tercer apellido no debe superar los 40 caracteres.");

            RuleFor(datosPersonales => datosPersonales.FechaNacimiento)
                .NotEmpty()
                .WithMessage("La fecha de nacimiento no debe ser nula.")
                .DependentRules(() =>
                {
                    RuleFor(datosPersonales => datosPersonales.FechaNacimiento)
                        .LessThan(DateTime.Now)                    
                        .WithMessage("La fecha de nacimietno es inválida");
               });

            RuleFor(datosPersonales => datosPersonales.IdPaisNacionalidad)
                .NotEmpty()
                .WithMessage("La nacionalidad es requerida.")
                .DependentRules(() =>
                {
                    RuleFor(datosPersonales => datosPersonales.IdPaisNacionalidad)
                        .InclusiveBetween(1, 999999999)
                        .WithMessage("La nacionalidad es inválida.");
                }); 

            RuleFor(datosPersonales => datosPersonales.IdDepartamentoNacimiento)
                .NotEmpty()
                .WithMessage("El departamento de nacimiento es requerido.")
                .DependentRules(() =>
                {
                    RuleFor(datosPersonales => datosPersonales.IdDepartamentoNacimiento)
                        .InclusiveBetween(1, 999999999)
                        .WithMessage("El departamento de nacimiento es inválido.");
                });

            RuleFor(datosPersonales => datosPersonales.CorreoElectronico)
                .EmailAddress()
                .WithMessage("El correo electrónico no tiene el formato correcto.")
                .MaximumLength(50)
                .WithMessage("El correo electrónico no  debe superar los 50 caracteres.");

            RuleFor(datosPersonales => datosPersonales.ValorSexo)
                .NotEmpty()
                .WithMessage("El sexo no debe ser nulo.")
                .DependentRules(() =>
                {
                    RuleFor(datosPersonales => datosPersonales.ValorSexo)
                        .InclusiveBetween(1, 9)
                        .WithMessage("El sexo es inválido.");
                });

            RuleFor(datosPersonales => datosPersonales.ValorEstadoCivil)
                .NotEmpty()
                .WithMessage("El estado civil es requerido.")
                .DependentRules(() =>
                {
                    RuleFor(datosPersonales => datosPersonales.ValorEstadoCivil)
                        .InclusiveBetween(1, 9)
                        .WithMessage("El estado civil es inválido.");
                });

            RuleFor(datosPersonales => datosPersonales.ValorTipoSangre)
                .NotEmpty()
                .WithMessage("El tipo de sangre es requerido.")
                .DependentRules(() =>
                {
                    RuleFor(datosPersonales => datosPersonales.ValorTipoSangre)
                        .InclusiveBetween(1, 9)
                        .WithMessage("El tipo de sangre es inválido.");
                });
            
            RuleFor(datosPersonales => datosPersonales.Direccion)
                .NotEmpty()
                .WithMessage("La dirección es requerida.")
                .DependentRules(() =>
                {
                    RuleFor(datosPersonales => datosPersonales.Direccion)
                        .MaximumLength(100)
                        .WithMessage("La dirección no debe superar los 100 caracteres.");
                });

            RuleFor(datosPersonales => datosPersonales.IdZona)
                .NotEmpty()
                .WithMessage("La zona es requerida.")
                .DependentRules(() =>
                {
                    RuleFor(datosPersonales => datosPersonales.IdZona)
                        .InclusiveBetween(1, 999999999)
                        .WithMessage("La zona es inválido.");
                });
           
            RuleFor(datosPersonales => datosPersonales.Telefonos)  
                .MaximumLength(25)        
                .WithMessage("El teléfono no  debe superar los 25 caracteres.");

            RuleFor(datosPersonales => datosPersonales.Celulares)
                 .MaximumLength(25)
                 .WithMessage("El celular no  debe superar los 25 caracteres.");

            RuleFor(datosPersonales => datosPersonales.Trabaja)
                .NotNull()
                .WithMessage("El valor de trabaja es requerido.");
              
            RuleFor(datosPersonales => datosPersonales.LugarDeTrabajo)
                .MaximumLength(100) 
                .WithMessage("El lugar de trabajo no  debe superar los 100 caracteres.");
        }
    }
}
