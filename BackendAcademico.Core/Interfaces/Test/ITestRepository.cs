namespace BackendAcademico.Core.Interfaces.Test
{
    using BackendAcademico.Core.CustomEntities.Response;
    using BackendAcademico.Core.Entities;
    using BackendAcademico.Core.QueryFilters.Test;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ITestRepository
    {
        Task<IEnumerable<Test>> GetDataBDTestAsync();
        Task<IEnumerable<Test>> GetDataBDTest2Async(TestInsQueryFilter testInsQueryFilter);
        Task<ResponsePostDetail> InsTestAsync(TestInsQueryFilter testInsQueryFilter);
    }
}
