namespace BackendAcademico.Infrastructure.Validators.Repositories
{
    using BackendAcademico.Core.CustomEntities.Response;
    using BackendAcademico.Core.Interfaces.Validators.Test;
    using BackendAcademico.Core.QueryFilters.Test;
    using BackendAcademico.Infrastructure.Validators.Test;
    using System;

    public class TestRepositoryVal : ITestRepositoryVal
    {
        #region Contructor
        public TestRepositoryVal()
        {

        }
        #endregion

        #region Métodos
        public ResponseModel ValidateTestInsData(TestInsQueryFilter testInsQueryFilter)
        {
            try
            {
                TestValidator validator = new TestValidator();
                var validationResult = validator.Validate(testInsQueryFilter);
                return MainValidator.IterationValidationResult(validationResult);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
        #endregion
    }
}
