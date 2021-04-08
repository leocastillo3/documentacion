namespace BackendAcademico.Infrastructure.Data
{
    using BackendAcademico.Core.Interfaces.Data;
    using Dapper;
    using Microsoft.Extensions.Configuration;
    using Oracle.ManagedDataAccess.Client;
    using Oracle.ManagedDataAccess.Types;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Threading.Tasks;

    public class Coneccion : IConeccion
    {
        #region Atributos
        private readonly IConfiguration _configuration;
        #endregion

        #region Constructores
        public Coneccion(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion

        #region Métodos
        public IDbConnection GetConnection()
        {
            var connectionString = _configuration.GetConnectionString("OracleDBConnection");
            var conn = new OracleConnection(connectionString);
            return conn;
        }

        public async Task<IEnumerable<dynamic>> GetData(object parametros, string query)
        {
            parametros = (OracleDynamicParameters)parametros;

            using (IDbConnection conn = GetConnection())
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                if (conn.State == ConnectionState.Open)
                {
                    return await SqlMapper.QueryAsync(conn, query, param: parametros, commandType: CommandType.StoredProcedure);
                }
            }

            return null;
        }

        public async Task<IEnumerable<dynamic>> GetData2(object parametros, string query)
        {
            parametros = (OracleDynamicParameters)parametros;

            using (IDbConnection conn = GetConnection())
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                if (conn.State == ConnectionState.Open)
                {
                    return await SqlMapper.QueryAsync(conn, query, param: parametros, commandType: CommandType.StoredProcedure);
                }
            }

            return null;
        }

        public async Task<object> GetDataEscalar(object parametros, string query)
        {
            parametros = (OracleDynamicParameters)parametros;

            using (IDbConnection conn = GetConnection())
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                if (conn.State == ConnectionState.Open)
                {
                    return await SqlMapper.ExecuteScalarAsync<int>(conn, query, param: parametros, commandType: CommandType.Text);
                }
            }

            return null;
        }
        public async Task<IEnumerable<T>> GetData<T>(object parametros, string query) //where T: IEnumerable<T>
        {
            parametros = (OracleDynamicParameters)parametros;

            using (IDbConnection conn = GetConnection())
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                if (conn.State == ConnectionState.Open)
                {
                    return await SqlMapper.QueryAsync<T>(conn, query, param: parametros, commandType: CommandType.StoredProcedure);
                }
            }

            return null;
        }
        public async Task InsData(object parametros, string query)
        {
            try
            {
                parametros = (OracleDynamicParameters)parametros;

                using (IDbConnection conn = GetConnection())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    if (conn.State == ConnectionState.Open)
                    {
                        await SqlMapper.ExecuteAsync(conn, query, param: parametros, commandType: CommandType.StoredProcedure);
                    }
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
        public async Task<int> InsData(object parametros, string query, Dictionary<string, object> paramBlob)
        {
            try
            {
                var customParametros = (OracleDynamicParameters)parametros;
                var rowsAffected = 0;

                using (IDbConnection conn = GetConnection())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();

                        #region Blob
                        if (paramBlob != null && paramBlob.Count > 0)
                        {
                            //byte[] newvalue = System.Text.Encoding.Unicode.GetBytes("1");
                            //var blob = new OracleBlob((OracleConnection)conn);
                            //blob.Write(newvalue, 0, newvalue.Length);
                            //((OracleDynamicParameters)parametros).Add("adjunto", OracleDbType.Blob, ParameterDirection.Input, blob);

                            byte[] newvalue = (byte[])paramBlob["adjunto"];
                            var blob = new OracleBlob((OracleConnection)conn);
                            blob.Write(newvalue, 0, newvalue.Length);
                            customParametros.Add("adjunto", OracleDbType.Blob, ParameterDirection.Input, blob);
                        }
                        #endregion
                    }
                    if (conn.State == ConnectionState.Open)
                    {
                        rowsAffected = await SqlMapper.ExecuteAsync(conn, query, param: customParametros, commandType: CommandType.StoredProcedure);
                    }
                    return rowsAffected;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        } 
        #endregion
    }
}
