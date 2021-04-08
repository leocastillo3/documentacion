namespace BackendAcademico.Infrastructure.Validators.Repositories
{
    using BackendAcademico.Core.CustomEntities.Response;
    using BackendAcademico.Core.Interfaces.Validators.PreInscripcion;
    using BackendAcademico.Core.QueryFilters.PreInscripcion;
    using BackendAcademico.Infrastructure.Validators.PreInscripcion;
    using System;

    public class PreInscripcionRepositoryVal : IPreInscripcionRepositoryVal
    {
        #region Contructor
        public PreInscripcionRepositoryVal()
        {

        }
        #endregion

        #region Métodos
        public ResponseModel ValidateId(int id)
        {
            try
            {
                IdValidator validator = new IdValidator();
                var validationResult = validator.Validate(id);
                return MainValidator.IterationValidationResult(validationResult);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public ResponseModel ValidatePreInscripcion(PreInscripcionQueryFilter preInscripcionQueryFilter)
        {
            try
            {
                PreInscripcionValidator validator = new PreInscripcionValidator();
                var validationResult = validator.Validate(preInscripcionQueryFilter);
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
 