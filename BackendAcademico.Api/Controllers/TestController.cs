namespace BackendAcademico.Api.Controllers
{
    using BackendAcademico.Api.Responses;
    using BackendAcademico.Core.CustomEntities;
    using BackendAcademico.Core.CustomEntities.Response;
    using BackendAcademico.Core.Enums;
    using BackendAcademico.Core.Exceptions;
    using BackendAcademico.Core.Interfaces.Test;
    using BackendAcademico.Core.QueryFilters.Test;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [Route("api/Test")]
    [Produces("application/json")]
    [ApiController]
    public class TestController : ControllerBase
    {
        #region Atributos
        private readonly ITestService _testService;
        private readonly ILogger<TestController> _logger;
        #endregion

        #region Constructores
        public TestController(ITestService testService, ILogger<TestController> logger)
        {
            _testService = testService;
            _logger = logger;
        }
        #endregion

        #region Métodos
        [HttpGet]
        [Route("GetDataBD")]
        public async Task<IActionResult> GetDataBDTestAsync()
        {
            try
            {
                _logger.LogInformation("Iniciando Proceso para recuperar datos Test de la BD");
                var test = await _testService.GetDataBDTestAsync();
                
                if (test == null)
                    _logger.LogWarning("No se encontraron datos.");

                //throw new Exception("Error controlado");

                return Ok(test);
            }
            catch (Exception err)
            {
                _logger.LogError(err, "Error inesperado");
                var responsePost = new ResponsePost()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.error.ToString(), Description = err.Message } },
                };
                return StatusCode(500, responsePost);
                //throw new BussinesException(err.Message);
            }
        }

        [HttpGet]
        [Route("GetDataBDPagination")]
        public async Task<IActionResult> GetDataBDPaginationTestAsync([FromQuery] TestGetQueryFilter testQueryFilter)
        {
            try
            {
                _logger.LogInformation("Iniciando Proceso para recuperar datos Test de la BD");
                var test = await _testService.GetDataBDTestPaginationAsync(testQueryFilter);

                if (test == null)
                    _logger.LogWarning("No se encontraron datos.");

                var pagination = new Pagination
                {
                    TotalRegistros = test.Paginations.TotalRegistros,
                    TamanoDePagina = test.Paginations.TamanoDePagina,
                    PaginaActual = test.Paginations.PaginaActual,
                    TotalPaginas = test.Paginations.TotalPaginas,
                    TienePaginaAnterior = test.Paginations.TienePaginaAnterior,
                    TienePaginaSiguiente = test.Paginations.TienePaginaSiguiente
                };

                var response = new ApiResponse<IEnumerable<object>>(test.Paginations)
                {
                    Pagination = pagination,
                    Messages = test.Messages
                };
                
                return StatusCode((int)test.StatusCode, response);
            }
            catch (Exception err)
            {
                _logger.LogError(err, "Error inesperado");
                var responsePost = new ResponsePost()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.error.ToString(), Description = err.Message } },
                };
                return StatusCode(500, responsePost);
                //throw new BussinesException(err.Message);
            }
        }

        [HttpGet]
        [Route("GetConectivityApi")]
        public IActionResult GetConectivityApi()
        {
            try
            {
                _logger.LogInformation("Iniciando Proceso Test de Conectividad");

                Dictionary<string, string> dicRes = new Dictionary<string, string>();
                dicRes.Add("Coneccion", "ok");
                return Ok(dicRes);
            }
            catch (Exception err)
            {
                _logger.LogError(err, "Error inesperado");
                throw new BussinesException(err.Message);
            }
        }

        [HttpPost]
        [Route("AddTest")]
        public async Task<IActionResult> PostPersona(TestInsQueryFilter testInsQueryFilter)
        {
            try
            {
                var per = await _testService.InsTestAsync(testInsQueryFilter);
                return StatusCode((int)per.StatusCode, per);
            }
            catch (Exception err)
            {
                _logger.LogError(err, "Error inesperado");

                var responsePost = new ResponsePost()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.error.ToString(), Description = err.Message } },
                };
                return StatusCode(500, responsePost);
            }
        }
        #endregion
    }
}
