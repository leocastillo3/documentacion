namespace BackendAcademico.Infrastructure.Repositories.Test
{
    using BackendAcademico.Core.CustomEntities;
    using BackendAcademico.Core.CustomEntities.Response;
    using BackendAcademico.Core.Entities;
    using BackendAcademico.Core.Interfaces.Data;
    using BackendAcademico.Core.Interfaces.Test;
    using BackendAcademico.Core.QueryFilters.Test;
    using BackendAcademico.Infrastructure.Data;
    using Microsoft.Extensions.Options;
    using Oracle.ManagedDataAccess.Client;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Threading.Tasks;

    public class TestRepository : ITestRepository
    {
        #region Atributos
        private readonly IConeccion _coneccion;
        private readonly PaginationOptions _paginationOptions;
        private ResponseGet responseGet;
        private ResponseGetPagination responseGetPagination;
        private ResponsePost responsePost;
        #endregion

        #region Constructores
        public TestRepository(IConeccion coneccion, IOptions<PaginationOptions> options)
        {
            _coneccion = coneccion;
            _paginationOptions = options.Value;
            responseGet = new ResponseGet();
            responseGetPagination = new ResponseGetPagination();
            responsePost = new ResponsePost();
        }
        #endregion

        #region Métodos
        public async Task<IEnumerable<Test>> GetDataBDTestAsync()
        {
            try
            {
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("TESTCURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                return await _coneccion.GetData<Test>(dyParam, "TestAcad.SP_GETTEST");
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public async Task<IEnumerable<Test>> GetDataBDTest2Async(TestInsQueryFilter testInsQueryFilter)
        {
            try
            {
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("TESTCURSOR2", OracleDbType.RefCursor, ParameterDirection.Output);
                dyParam.Add("p_valor", OracleDbType.Varchar2, ParameterDirection.Input, testInsQueryFilter.Valor);
                return await _coneccion.GetData<Test>(dyParam, "TestAcad.SP_GETTEST2");
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public async Task<ResponsePostDetail> InsTestAsync(TestInsQueryFilter testInsQueryFilter)
        {
            try
            {
                var affectedRows = 0;
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("valor", OracleDbType.Varchar2, ParameterDirection.Input, testInsQueryFilter.Valor);
                dyParam.Add("affected_rows", OracleDbType.Int32, ParameterDirection.Output, 0);
                await _coneccion.InsData(dyParam, "TestAcad.SP_INSERTTEST");

                affectedRows = dyParam.Get("affected_rows");

                return new ResponsePostDetail() 
                { 
                    Process = "Test", 
                    AffectedRows = affectedRows 
                };
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
        #endregion
    }
}