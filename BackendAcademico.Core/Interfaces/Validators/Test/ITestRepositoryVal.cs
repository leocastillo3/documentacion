using BackendAcademico.Core.CustomEntities.Response;
using BackendAcademico.Core.QueryFilters.Test;

namespace BackendAcademico.Core.Interfaces.Validators.Test
{
    public interface ITestRepositoryVal
    {
        ResponseModel ValidateTestInsData(TestInsQueryFilter testInsQueryFilter);
    }
}