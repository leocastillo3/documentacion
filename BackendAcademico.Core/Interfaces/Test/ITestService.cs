namespace BackendAcademico.Core.Interfaces.Test
{
    using BackendAcademico.Core.CustomEntities.Response;
    using BackendAcademico.Core.QueryFilters.Test;
    using System.Threading.Tasks;

    public interface ITestService
    {
        Task<ResponseGet> GetDataBDTestAsync();
        Task<ResponseGetPagination> GetDataBDTestPaginationAsync(TestGetQueryFilter testQueryFilter);
        Task<ResponsePost> InsTestAsync(TestInsQueryFilter testInsQueryFilter);
    }
}