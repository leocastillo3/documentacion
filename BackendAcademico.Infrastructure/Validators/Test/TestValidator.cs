namespace BackendAcademico.Infrastructure.Validators.Test
{
    using BackendAcademico.Core.QueryFilters.Test;
    using FluentValidation;

    public class TestValidator : AbstractValidator<TestInsQueryFilter>
    {
        public TestValidator()
        {
            //RuleFor(test => test.Valor)
            //    .NotNull()
            //    .Length(10, 500)
            //    .WithMessage("El valor no debe ser nulo");

            RuleFor(test => test.Valor)
                .NotNull()
                .WithMessage("El valor no debe ser nulo");
        }
    }
}