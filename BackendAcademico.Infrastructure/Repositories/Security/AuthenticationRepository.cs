namespace BackendAcademico.Infrastructure.Repositories.Security
{
    using BackendAcademico.Core.Entities;
    using BackendAcademico.Core.Interfaces.Data;
    using BackendAcademico.Core.Interfaces.Security;
    using BackendAcademico.Infrastructure.Data;
    using Dapper;
    using Oracle.ManagedDataAccess.Client;
    using System;
    using System.Data;
    using System.Threading.Tasks;

    public class AuthenticationRepository : IAuthenticationRespository
    {
        #region Atributos
        private readonly IConeccion _coneccion;
        #endregion

        #region Constructores
        public AuthenticationRepository(IConeccion coneccion)
        {
            _coneccion = coneccion;
        }
        #endregion

        #region Métodos
        public async Task<object> GetDataBDTestAsync()
        {
            object result = null;
            try
            {
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("TESTCURSOR", OracleDbType.RefCursor, ParameterDirection.Output);

                using (IDbConnection conn = _coneccion.GetConnection())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    if (conn.State == ConnectionState.Open)
                    {
                        var query = "SP_GETTEST";

                        result = await SqlMapper.QueryAsync<Test>(conn, query, param: dyParam, commandType: CommandType.StoredProcedure);
                    }
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            return result;
        }
        #endregion
    }
}
