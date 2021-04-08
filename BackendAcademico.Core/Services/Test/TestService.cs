namespace BackendAcademico.Core.Services.Test
{
    using BackendAcademico.Core.CustomEntities;
    using BackendAcademico.Core.CustomEntities.Response;
    using BackendAcademico.Core.Enums;
    using BackendAcademico.Core.Interfaces.Test;
    using BackendAcademico.Core.Interfaces.Validators.Test;
    using BackendAcademico.Core.QueryFilters.Test;
    using Microsoft.Extensions.Options;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;

    public class TestService : ITestService
    {
        #region Atributos
        private readonly PaginationOptions _paginationOptions;
        private readonly ITestRepository _testRepository;
        private readonly ITestRepositoryVal _testRepositoryVal;
        ResponseGet responseGet;
        #endregion

        #region Constructores
        public TestService(IOptions<PaginationOptions> options, ITestRepository testRepository, 
            ITestRepositoryVal testRepositoryVal)
        {
            _paginationOptions = options.Value;
            _testRepository = testRepository;
            _testRepositoryVal = testRepositoryVal;
        }
        #endregion

        #region Métodos
        public async Task<ResponseGet> GetDataBDTestAsync()
        {
            var test = await _testRepository.GetDataBDTestAsync();
            if (test.Count() > 0)
            {
                responseGet = new ResponseGet()
                {
                    Data = test,
                    StatusCode = HttpStatusCode.OK
                };
            }
            else
            {
                responseGet = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.information.ToString(), Description = "No se encontraron datos en Test" } },
                    StatusCode = HttpStatusCode.NotFound
                };
            }

            return responseGet;
        }

        public async Task<ResponseGetPagination> GetDataBDTestPaginationAsync(TestGetQueryFilter testQueryFilter)
        {
            testQueryFilter.NumeroDePagina = testQueryFilter.NumeroDePagina == 0 ? _paginationOptions.InicialNumeroDePagina : testQueryFilter.NumeroDePagina;
            testQueryFilter.TamanoDePagina = testQueryFilter.TamanoDePagina == 0 ? _paginationOptions.InicialTamanoDePagina : testQueryFilter.TamanoDePagina;

            var test = await _testRepository.GetDataBDTestAsync();
            if (test.Count() > 0)
            {
                var paginacion = ListaPaginada<object>.Crear(test, testQueryFilter.NumeroDePagina, testQueryFilter.TamanoDePagina);

                return  new ResponseGetPagination()
                    {
                        Paginations = paginacion,
                        StatusCode = HttpStatusCode.OK
                    };
            }
            else
            {
                return new ResponseGetPagination()
                    {
                        Messages = new Message[] { new Message() { Type = TypeMessage.information.ToString(), Description = "No se encontraron datos en Test" } },
                        StatusCode = HttpStatusCode.NotFound
                    };
            }
        }

        public async Task<ResponsePost> InsTestAsync(TestInsQueryFilter testInsQueryFilter)
        {
            #region Test Validator
            var responseModel = _testRepositoryVal.ValidateTestInsData(testInsQueryFilter);
            if (!responseModel.IsValid)
            {
                return new ResponsePost()
                {
                    Messages = responseModel.ValidationMessages.ToArray(),
                    StatusCode = HttpStatusCode.BadRequest
                };
            }
            #endregion

            #region Reglas de Negocio
            //Si existe un registro con VALOR igual en la tabla Test2 no permitir el insert en Test
            var test2 = await _testRepository.GetDataBDTest2Async(testInsQueryFilter);
            if (test2.Count() > 0)
            {
                return new ResponsePost()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.warning.ToString(), Description = "El valor que se intenta registrar en Test1 ya existe en Test2" } },
                    StatusCode = HttpStatusCode.BadRequest
                };
            }
            #endregion

            var testIns = await _testRepository.InsTestAsync(testInsQueryFilter);
            if (testIns.AffectedRows > 0)
            {
                return new ResponsePost()
                {
                    Response = testIns,
                    StatusCode = HttpStatusCode.OK
                };
            }
            else
            {
                return new ResponsePost()
                {
                    Response = testIns,
                    StatusCode = HttpStatusCode.NoContent
                };
            }
        }
        #endregion
    }
}