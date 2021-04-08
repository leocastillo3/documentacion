namespace BackendAcademico.Core.Interfaces.Validators.PreInscripcion
{
    using BackendAcademico.Core.CustomEntities.Response;
    using BackendAcademico.Core.QueryFilters.PreInscripcion;

    public interface IPreInscripcionRepositoryVal
    {
        ResponseModel ValidateId(int id);
        ResponseModel ValidatePreInscripcion(PreInscripcionQueryFilter preInscripcionQueryFilter);
    }
}
