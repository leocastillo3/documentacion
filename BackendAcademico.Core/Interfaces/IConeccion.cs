namespace BackendAcademico.Core.Interfaces.Data
{
    using System.Collections.Generic;
    using System.Data;
    using System.Threading.Tasks;

    public interface IConeccion
    {
        IDbConnection GetConnection();
        Task<IEnumerable<dynamic>> GetData(object parametros, string query);
        Task<IEnumerable<T>> GetData<T>(object parametros, string query);
        Task<IEnumerable<dynamic>> GetData2(object parametros, string query);
        Task<object> GetDataEscalar(object parametros, string query);
        Task InsData(object parametros, string query);
        Task<int> InsData(object parametros, string query, Dictionary<string, object> paramBlob);
    }
}
