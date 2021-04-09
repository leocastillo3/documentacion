namespace BackendAcademico.Api.Controllers
{
    using BackendAcademico.Core.CustomEntities;
    using BackendAcademico.Core.CustomEntities.Response;
    using BackendAcademico.Core.Enums;
    using BackendAcademico.Core.Interfaces.PreInscripcion;
    using BackendAcademico.Core.QueryFilters.PreInscripcion;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Threading.Tasks;

    [Route("api/Academico/Preinscripcion")]
    [ApiController]
    public class PreInscripcionController : ControllerBase
    {
        #region Atributos
        private readonly IPreInscripcionService _preInscripcionService;
        private readonly ILogger<PreInscripcionController> _logger;
        #endregion

        #region Constructores
        public PreInscripcionController(IPreInscripcionService preInscripcionService, ILogger<PreInscripcionController> logger)
        {
            _preInscripcionService = preInscripcionService;
            _logger = logger;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// CONSIDERACIONES: Devuele la lista de los periódos académicos habilitados para la pre-inscripción.
        /// <para>
        /// TIPO: GET
        /// </para>
        /// <para>
        /// PARÁMETROS: No requiere parámetros.
        /// </para>
        /// <para>
        /// <see href="http://localhost:8080/articles/intro.html">URL BASE</see> +api/Academico/Preinscripcion/ObtenerPeriodosAcademicos 
        /// </para>
        /// <para>
        /// RESULTADO:
        /// </para>
        /// <code language="cs">
        /// {
        ///     "data": [
        ///         {
        ///             "id": "gh8GevFlCVbXqMH9ij444a==",
        ///             "codigo": "V-2020"
        ///         },
        ///         {
        ///             "id": "mWfzCjdGHwl9dsHxo5LjiQ==",
        ///             "codigo": "1-2021"
        ///         }
        ///     ]
        /// }
        /// </code>
        /// </summary> 
        [HttpGet]
        [Route("ObtenerPeriodosAcademicos")]
        public async Task<IActionResult> GetPeriodosAcademicos()
        {
            try
            {
                _logger.LogInformation("Iniciando Proceso para recuperar datos Periodos Academicos de la BD");
                var periodosAcademicos = await _preInscripcionService.GetPeridosAcademicos();
                if (periodosAcademicos == null)
                    _logger.LogWarning("No se encontraron datos.");
                return Ok(periodosAcademicos);
            }
            catch (Exception err)
            {
                _logger.LogError(err, "Error inesperado");
                var response = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.error.ToString(), Description = err.Message } },
                };
                return StatusCode(500, response);
            }
        }
        /// <summary>
        /// CONSIDERACIONES: Devuele la lista de las carreras habilitadas.
        /// <para>
        /// TIPO: GET
        /// </para>
        /// <para>
        /// PARÁMETROS: No requiere parámetros.
        /// </para>
        /// <para>
        /// <see href="http://localhost:8080/articles/intro.html">URL BASE</see> api/Academico/Preinscripcion/ObtenerCarreras 
        /// </para>
        /// <para>
        /// RESULTADO:
        /// </para>
        /// <code language="cs">
        /// {
        ///     "data": [
        ///         {
        ///             "id": "fGZrfeQ6LvXdvVIGdsgHVw==",
        ///             "nombre": "EDUCACION (PSC)"
        ///         },
        ///         {
        ///             "id": "zkzh3GevYyPDLn0YqFWZCA==",
        ///             "nombre": "LICENCIATURA EN EDUCACION SECUNDARIA"
        ///         }
        ///     ]
        /// }
        /// </code>
        /// </summary>
        [HttpGet]
        [Route("ObtenerCarreras")]
        public async Task<IActionResult> GetCarreras()
        {
            try
            {
                _logger.LogInformation("Iniciando Proceso para recuperar datos Carreras de la BD");
                var carreras = await _preInscripcionService.GetCarreras();
                if (carreras == null)
                    _logger.LogWarning("No se encontraron datos.");
                return Ok(carreras);
            }
            catch (Exception err)
            {
                _logger.LogError(err, "Error inesperado");
                var response = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.error.ToString(), Description = err.Message } },
                };
                return StatusCode(500, response);
            }
        }
        /// <summary>
        /// CONSIDERACIONES: Devuele la lista de países para la nacionalidad.
        /// <para>
        /// TIPO: GET
        /// </para>
        /// <para>
        /// PARÁMETROS: No requiere parámetros.
        /// </para>
        /// <para>
        /// <see href="http://localhost:8080/articles/intro.html">URL BASE</see> api/Academico/Preinscripcion/ObtenerNacionalidades
        /// </para>
        /// <para>
        /// RESULTADO:
        /// </para>
        /// <code language="cs">
        /// {
        ///     "data": [
        ///         {
        ///             "id": "ooo40MW8KdnMovKywZ6qzQ==",
        ///             "nacionalidad": "BOLIVIANA"
        ///         },
        ///         {
        ///             "id": "4luIxuI/y0rmAbpjz84MwQ==",
        ///             "nacionalidad": "ALEMANA"
        ///         }
        ///     ]
        /// }
        /// </code>
        /// </summary>
        [HttpGet]
        [Route("ObtenerNacionalidades")]
        public async Task<IActionResult> GetNacionalidades()
        {
            try
            {
                _logger.LogInformation("Iniciando Proceso para recuperar datos Nacionalidades de la BD");
                var nacionalidades = await _preInscripcionService.GetNacionalidades();
                if (nacionalidades == null)
                    _logger.LogWarning("No se encontraron datos.");
                return Ok(nacionalidades);
            }
            catch (Exception err)
            {
                _logger.LogError(err, "Error inesperado");
                var response = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.error.ToString(), Description = err.Message } },
                };
                return StatusCode(500, response);
            }
        }
        /// <summary>
        /// CONSIDERACIONES: Devuelve la lista de sexos 
        /// <para>
        /// TIPO: GET
        /// </para>
        /// <para>
        /// PARÁMETROS: No requiere parámetros.
        /// </para>
        /// <para>
        /// <see href="http://localhost:8080/articles/intro.html">URL BASE</see> api/Academico/Preinscripcion/ObtenerSexos
        /// </para>
        /// <para>
        /// RESULTADO:
        /// </para>
        /// <code language="cs">
        /// {
        ///     "data": [
        ///         {
        ///             "valor": "ooo40MW8KdnMovKywZ6qzQ==",
        ///             "descripcion": "MASCULINO"
        ///         },
        ///         {
        ///             "valor": "4mo9gjV/hDzYrnuqH0/IHA==",
        ///             "descripcion": "FEMENINO"
        ///         }
        ///     ]
        /// }
        /// </code>
        /// </summary>
        [HttpGet]
        [Route("ObtenerSexos")]
        public async Task<IActionResult> GetSexos()
        {
            try
            {
                _logger.LogInformation("Iniciando Proceso para recuperar Sexos la BD.");
                var valores = await _preInscripcionService.GetValoresPorDominio(TiposDominio.TIPO_GENERO.ToString());
                if (valores == null)
                    _logger.LogWarning("No se encontraron datos.");
                return Ok(valores);
            }
            catch (Exception err)
            {
                _logger.LogError(err, "Error inesperado");
                var response = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.error.ToString(), Description = err.Message } },
                };
                return StatusCode(500, response);
            }
        }
        /// <summary>
        /// CONSIDERACIONES: Devuele la lista de estado civil.
        /// <para>
        /// TIPO: GET
        /// </para>
        /// <para>
        /// PARÁMETROS: No requiere parámetros.
        /// </para>
        /// <para>
        /// <see href="http://localhost:8080/articles/intro.html">URL BASE</see> api/Academico/Preinscripcion/ObtenerEstadosCiviles
        /// </para>
        /// <para>
        /// RESULTADO:
        /// </para>
        /// <code language="cs">
        /// {
        ///     "data": [
        ///         {
        ///             "valor": "slJUX1cOyzL3cdRvTXg3Wg==",
        ///             "descripcion": "DIVORCIADO"
        ///         },
        ///         {
        ///             "valor": "9d5PCKdDxBLt4g%252bYtsTgyA==",
        ///             "descripcion": "VIUDO"
        ///         }
        ///     ]
        /// }
        /// </code>
        /// </summary>
        [HttpGet]
        [Route("ObtenerEstadosCiviles")]
        public async Task<IActionResult> GetEstadosCiviles()
        {
            try
            {
                _logger.LogInformation("Iniciando Proceso para recuperar valores de Estado Civil de la BD.");
                var valores = await _preInscripcionService.GetValoresPorDominio(TiposDominio.ESTADO_CIVIL.ToString());
                if (valores == null)
                    _logger.LogWarning("No se encontraron datos.");
                return Ok(valores);
            }
            catch (Exception err)
            {
                _logger.LogError(err, "Error inesperado");
                var response = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.error.ToString(), Description = err.Message } },
                };
                return StatusCode(500, response);
            }
        }
        /// <summary>
        /// CONSIDERACIONES: Devuele la lista de los tipos de documentos de identidad.
        /// <para>
        /// TIPO: GET
        /// </para>
        /// <para>
        /// PARÁMETROS: No requiere parámetros.
        /// </para>
        /// <para>
        /// <see href="http://localhost:8080/articles/intro.html">URL BASE</see> api/Academico/Preinscripcion/ObtenerTiposDocumento
        /// </para>
        /// <para>
        /// RESULTADO:
        /// </para>
        /// <code language="cs">
        /// {
        ///     "data": [
        ///         {
        ///             "valor": "slJUX1cOyzL3cdRvTXg3Wg==",
        ///             "descripcion": "CERTIFICADO DE NACIMIENTO"
        ///         },
        ///         {
        ///             "valor": "MhLc0N%252bjvAfuHLRo3NZY6g==",
        ///             "descripcion": "PASAPORTE"
        ///         }
        ///     ]
        /// }
        /// </code>
        /// </summary>
        [HttpGet]
        [Route("ObtenerTiposDocumento")]
        public async Task<IActionResult> GetTiposDocumento()
        {
            try
            {
                _logger.LogInformation("Iniciando Proceso para recuperar Tipos de Documento de la BD.");
                var valores = await _preInscripcionService.GetValoresPorDominio(TiposDominio.TIPO_DOC.ToString());
                if (valores == null)
                    _logger.LogWarning("No se encontraron datos.");
                return Ok(valores);
            }
            catch (Exception err)
            {
                _logger.LogError(err, "Error inesperado");
                var response = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.error.ToString(), Description = err.Message } },
                };
                return StatusCode(500, response);
            }
        }
        /// <summary>
        /// CONSIDERACIONES: Devuele la lista de los turnos de Colegio.
        /// <para>
        /// TIPO: GET
        /// </para>
        /// <para>
        /// PARÁMETROS: No requiere parámetros.
        /// </para>
        /// <para>
        /// <see href="http://localhost:8080/articles/intro.html">URL BASE</see> api/Academico/Preinscripcion/ObtenerTurnosColegio
        /// </para>
        /// <para>
        /// RESULTADO:
        /// </para>
        /// <code language="cs">
        /// {
        ///     "data": [
        ///         {
        ///             "valor": "ooo40MW8KdnMovKywZ6qzQ==",
        ///             "descripcion": "MAÑANA"
        ///         },
        ///         {
        ///             "valor": "4mo9gjV/hDzYrnuqH0/IHA==",
        ///             "descripcion": "TARDE"
        ///         }
        ///     ]
        /// }
        /// </code>
        /// </summary>
        [HttpGet]
        [Route("ObtenerTurnosColegio")]
        public async Task<IActionResult> GetTurnosColegio()
        {
            try
            {
                _logger.LogInformation("Iniciando Proceso para recuperar Turnos Colegio de la BD.");
                var valores = await _preInscripcionService.GetValoresPorDominio(TiposDominio.TURNO_COLEGIO_PRE.ToString());
                if (valores == null)
                    _logger.LogWarning("No se encontraron datos.");
                return Ok(valores);
            }
            catch (Exception err)
            {
                _logger.LogError(err, "Error inesperado");
                var response = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.error.ToString(), Description = err.Message } },
                };
                return StatusCode(500, response);
            }
        }
        /// <summary>
        /// CONSIDERACIONES: Devuele la lista de los tipos de colegio.
        /// <para>
        /// TIPO: GET
        /// </para>
        /// <para>
        /// PARÁMETROS: No requiere parámetros.
        /// </para>
        /// <para>
        /// <see href="http://localhost:8080/articles/intro.html">URL BASE</see> api/Academico/Preinscripcion/ObtenerTiposColegio
        /// </para>
        /// <para>
        /// RESULTADO:
        /// </para>
        /// <code language="cs">
        /// {
        ///     "data": [
        ///         {
        ///             "valor": "ooo40MW8KdnMovKywZ6qzQ==",
        ///             "descripcion": "PRIVADO"
        ///         },
        ///         {
        ///             "valor": "4mo9gjV/hDzYrnuqH0/IHA==",
        ///             "descripcion": "ESTATAL"
        ///         }
        ///     ]
        /// }
        /// </code>
        /// </summary>
        [HttpGet]
        [Route("ObtenerTiposColegio")]
        public async Task<IActionResult> GetTipoColegio()
        {
            try
            {
                _logger.LogInformation("Iniciando Proceso para recuperar Tipos Colegio de la BD.");
                var valores = await _preInscripcionService.GetValoresPorDominio(TiposDominio.TIPO_COLEGIO.ToString());
                if (valores == null)
                    _logger.LogWarning("No se encontraron datos.");
                return Ok(valores);
            }
            catch (Exception err)
            {
                _logger.LogError(err, "Error inesperado");
                var response = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.error.ToString(), Description = err.Message } },
                };
                return StatusCode(500, response);
            }
        }
        /// <summary>
        /// CONSIDERACIONES: Devuele la lista de de los valores de Vive Con.
        /// <para>
        /// TIPO: GET
        /// </para>
        /// <para>
        /// PARÁMETROS: No requiere parámetros.
        /// </para>
        /// <para>
        /// <see href="http://localhost:8080/articles/intro.html">URL BASE</see> api/Academico/Preinscripcion/ObtenerValoresViveCon
        /// </para>
        /// <para>
        /// RESULTADO:
        /// </para>
        /// <code language="cs">
        /// {
        ///     "data": [
        ///         {
        ///             "valor": "ooo40MW8KdnMovKywZ6qzQ==",
        ///             "descripcion": "PADRE"
        ///         },
        ///         {
        ///             "valor": "4mo9gjV/hDzYrnuqH0/IHA==",
        ///             "descripcion": "MADRE"
        ///         }
        ///     ]
        /// }
        /// </code>
        /// </summary>
        [HttpGet]
        [Route("ObtenerValoresViveCon")]
        public async Task<IActionResult> GetValoresViveCon()
        {
            try
            {
                _logger.LogInformation("Iniciando Proceso para recuperar valores de Vive Con de la BD.");
                var valores = await _preInscripcionService.GetValoresPorDominio(TiposDominio.VIVE_CON.ToString());
                if (valores == null)
                    _logger.LogWarning("No se encontraron datos.");
                return Ok(valores);
            }
            catch (Exception err)
            {
                _logger.LogError(err, "Error inesperado");
                var response = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.error.ToString(), Description = err.Message } },
                };
                return StatusCode(500, response);
            }
        }
        /// <summary>
        /// CONSIDERACIONES: Devuele la lista de los tipos de sangre.
        /// <para>
        /// TIPO: GET
        /// </para>
        /// <para>
        /// PARÁMETROS: No requiere parámetros.
        /// </para>
        /// <para>
        /// <see href="http://localhost:8080/articles/intro.html">URL BASE</see> api/Academico/Preinscripcion/ObtenerEstadosCiviles
        /// </para>
        /// <para>
        /// RESULTADO:
        /// </para>
        /// <code language="cs">
        /// {
        ///     "data": [
        ///         {
        ///             "valor": "ooo40MW8KdnMovKywZ6qzQ==",
        ///             "descripcion": "O RH+"
        ///         },
        ///         {
        ///             "valor": "4mo9gjV/hDzYrnuqH0/IHA==",
        ///             "descripcion": "O RH-"
        ///         }
        ///     ]
        /// }
        /// </code>
        /// </summary>
        [HttpGet]
        [Route("ObtenerTiposSangre")]
        public async Task<IActionResult> GetTiposSangre()
        {
            try
            {
                _logger.LogInformation("Iniciando Proceso para recuperar Tipos de sangre la BD.");
                var valores = await _preInscripcionService.GetValoresPorDominio(TiposDominio.TIPO_SANGRE.ToString());
                if (valores == null)
                    _logger.LogWarning("No se encontraron datos.");
                return Ok(valores);
            }
            catch (Exception err)
            {
                _logger.LogError(err, "Error inesperado");
                var response = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.error.ToString(), Description = err.Message } },
                };
                return StatusCode(500, response);
            }
        }
        /// <summary>
        /// CONSIDERACIONES: Devuele los departamentos según el ID del país seleccionado. 
        /// <para>
        /// TIPO: GET
        /// </para>
        /// <para>
        /// PARÁMETROS: idPais (string)
        /// </para>
        /// <see href="http://localhost:8080/articles/intro.html">URL BASE</see> api/Academico/Preinscripcion/ObtenerEstadosCiviles
        /// <para>
        /// RESULTADO:
        /// </para>
        /// <code language="cs">
        /// {
        ///     "data": [
        ///         {
        ///             "id": "znutLqucX0W/WixhwziIzg==",
        ///             "nombre": "LA PAZ"
        ///         },
        ///         {
        ///             "id": "gPbRzH3wMyqs5Lq7T0jvJw==",
        ///             "nombre": "BENI"
        ///         }
        ///     ]
        /// }
        /// </code>
        /// </summary>
        [HttpGet]
        [Route("ObtenerDepartamentosPorPais")]
        public async Task<IActionResult> GetDepartamentosPorPais([FromQuery] int idPais)
        {
            try
            {
                _logger.LogInformation("Iniciando Proceso para recuperar Departamentos de un pais de la BD.");
                var departamentos = await _preInscripcionService.GetDepartamentosPorPais(idPais);
                if (departamentos == null)
                    _logger.LogWarning("No se encontraron datos.");
                return Ok(departamentos);
            }
            catch (Exception err)
            {
                _logger.LogError(err, "Error inesperado");
                var response = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.error.ToString(), Description = err.Message } },
                };
                return StatusCode(500, response);
            }
        }
        /// <summary>
        /// CONSIDERACIONES: Devuelve la lista de los departamentos de Bolivia.
        /// <para>
        /// TIPO: GET
        /// <para>
        /// PARÁMETROS: No requiere parámetros.
        /// </para>
        /// <see href="http://localhost:8080/articles/intro.html">URL BASE</see> api/Academico/Preinscripcion/ObtenerEstadosCiviles
        /// </para>
        /// <para>
        /// RESULTADO:
        /// </para>
        /// <code language="cs">
        /// {
        ///     "data": [
        ///         {
        ///             "id": "c1YR0S9h845CZHS39vt8pA==",
        ///             "nombre": "SANTA CRUZ"
        ///         },
        ///         {
        ///             "id": "8eteVicoi61wB1k4cAcJOg==",
        ///             "nombre": "TARIJA"
        ///         }
        ///     ]
        /// }
        /// </code>
        /// </summary>
        [HttpGet]
        [Route("ObtenerDepartamentosBolivia")]
        public async Task<IActionResult> GetDepartamentosBolivia()
        {
            try
            {
                _logger.LogInformation("Iniciando Proceso para recuperar Departamentos de Bolivia de la BD.");
                var departamentos = await _preInscripcionService.GetDepartamentosBolivia();
                if (departamentos == null)
                    _logger.LogWarning("No se encontraron datos.");
                return Ok(departamentos);
            }
            catch (Exception err)
            {
                _logger.LogError(err, "Error inesperado");
                var response = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.error.ToString(), Description = err.Message } },
                };
                return StatusCode(500, response);
            }
        }
        /// <summary>
        /// CONSIDERACIONES: Devuele la lista de provincias según el departamento seleccionado.
        /// <para>
        /// TIPO: GET
        /// </para>
        /// <para>
        /// PARÁMETROS: idDepartamento (String)
        /// </para>
        /// <para>
        /// <see href="http://localhost:8080/articles/intro.html">URL BASE</see> api/Academico/Preinscripcion/ObtenerEstadosCiviles
        /// </para>
        /// <para>
        /// RESULTADO:
        /// </para>
        /// <code language="cs">
        /// {
        ///     "data": [
        ///         {
        ///             "id": "c1YR0S9h845CZHS39vt8pA==",
        ///             "nombre": "CERCADO"
        ///         },
        ///         {
        ///             "id": "8eteVicoi61wB1k4cAcJOg==",
        ///             "nombre": "CARRASCO"
        ///         }
        ///     ]
        /// }
        /// </code>
        /// </summary>
        [HttpGet]
        [Route("ObtenerProvinciasPorDepartamento")]
        public async Task<IActionResult> GetProvinciasPorDepartamento([FromQuery] int idDepartamento)
        {
            try
            {
                _logger.LogInformation("Iniciando Proceso para recuperar Provincias de la BD.");
                var provincias = await _preInscripcionService.GetProvinciasPorDepartamento(idDepartamento);
                if (provincias == null)
                    _logger.LogWarning("No se encontraron datos.");
                return Ok(provincias);
            }
            catch (Exception err)
            {
                _logger.LogError(err, "Error inesperado");
                var response = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.error.ToString(), Description = err.Message } },
                };
                return StatusCode(500, response);
            }
        }
        /// <summary>
        /// CONSIDERACIONES: Devuele la lista de los Municipios según la Provincia seleccionada.
        /// <para>
        /// TIPO: GET
        /// </para>
        /// <para>
        /// PARÁMETROS: idProvincia(String)
        /// </para>
        /// <para>
        /// <see href="http://localhost:8080/articles/intro.html">URL BASE</see> api/Academico/Preinscripcion/ObtenerEstadosCiviles
        /// </para>
        /// <para>
        /// RESULTADO:
        /// </para>
        /// <code language="cs">
        /// {
        ///     "data": [
        ///         {
        ///             "id": "c1YR0S9h845CZHS39vt8pA==",
        ///             "nombre": "LA PAZ"
        ///         },
        ///         {
        ///             "id": "8eteVicoi61wB1k4cAcJOg==",
        ///             "nombre": "EL ALTO"
        ///         }
        ///     ]
        /// } 
        /// </code>
        /// </summary>
        [HttpGet]
        [Route("ObtenerMunicipiosPorProvincia")]
        public async Task<IActionResult> GetMunicipiosPorProvincia([FromQuery] int idProvincia)
        {
            try
            {
                _logger.LogInformation("Iniciando Proceso para recuperar Municipios de la BD.");
                var municipios = await _preInscripcionService.GetMunicipiosPorProvincia(idProvincia);
                if (municipios == null)
                    _logger.LogWarning("No se encontraron datos.");
                return Ok(municipios);
            }
            catch (Exception err)
            {
                _logger.LogError(err, "Error inesperado");
                var response = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.error.ToString(), Description = err.Message } },
                };
                return StatusCode(500, response);
            }
        }
        /// <summary>
        /// CONSIDERACIONES: Devuele la lista de las Zonas según el Municipo seleccionado.
        /// <para>
        /// TIPO: GET
        /// </para>
        /// <para>
        /// PARÁMETROS: idMunicipio(String)
        /// </para>
        /// <para>
        /// <see href="http://localhost:8080/articles/intro.html">URL BASE</see> api/Academico/Preinscripcion/ObtenerEstadosCiviles 
        /// </para>
        /// <para>
        /// RESULTADO:
        /// </para>
        /// <code language="cs">
        /// {
        ///     "data": [
        ///         {
        ///             "id": "c1YR0S9h845CZHS39vt8pA==",
        ///             "nombre": "CALA CALA"
        ///         },
        ///         {
        ///             "id": "8eteVicoi61wB1k4cAcJOg==",
        ///             "nombre": "SACOBAMBA"
        ///         }
        ///     ]
        /// } 
        /// </code>
        /// </summary>
        [HttpGet]
        [Route("ObtenerZonasPorMunicipio")]
        public async Task<IActionResult> GetZonasPorMunicipio([FromQuery] int idMunicipio)
        {
            try
            {
                _logger.LogInformation("Iniciando Proceso para recuperar Zonas de la BD.");
                var zonas = await _preInscripcionService.GetZonasPorMunicipio(idMunicipio);
                if (zonas == null)
                    _logger.LogWarning("No se encontraron datos.");
                return Ok(zonas);
            }
            catch (Exception err)
            {
                _logger.LogError(err, "Error inesperado");
                var response = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.error.ToString(), Description = err.Message } },
                };
                return StatusCode(500, response);
            }
        }
        /// <summary>
        /// CONSIDERACIONES: Devuele la lista de colegios a partir de un ID provincia.
        /// <para>
        /// TIPO: GET
        /// </para>
        /// <para>
        /// PARÁMETROS: idProvincia (String)
        /// </para>
        /// <para>
        /// <see href="http://localhost:8080/articles/intro.html">URL BASE</see> api/Academico/Preinscripcion/ObtenerEstadosCiviles
        /// </para>
        /// <para>
        /// RESULTADO:
        /// </para>
        /// <code language="cs">
        /// {
        ///     "data": [
        ///         {
        ///             "id": "c1YR0S9h845CZHS39vt8pA==",
        ///             "nombre": "SAN CALIXTO"
        ///         },
        ///         {
        ///             "id": "8eteVicoi61wB1k4cAcJOg==",
        ///             "nombre": "SAN IGNACIO"
        ///         }
        ///     ]
        /// } 
        /// </code>
        /// </summary>
        [HttpGet]
        [Route("ObtenerColegiosPorProvincia")]
        public async Task<IActionResult> GetColegiosPorProvincia([FromQuery] int idProvincia)
        {
            try
            {
                _logger.LogInformation("Iniciando Proceso para recuperar Colegios de una provincia de la BD.");
                var colegios = await _preInscripcionService.GetColegiosPorProvincia(idProvincia);
                if (colegios == null)
                    _logger.LogWarning("No se encontraron datos.");
                return Ok(colegios);
            }
            catch (Exception err)
            {
                _logger.LogError(err, "Error inesperado");
                var response = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.error.ToString(), Description = err.Message } },
                };
                return StatusCode(500, response);
            }
        }
        /// <summary>
        /// CONSIDERACIONES: Devuele la lista de profesiones de la lista de la Base de Datos.
        /// <para>
        /// TIPO: GET
        /// </para>
        /// <para>
        /// PARÁMETROS: No requiere parámetros.
        /// </para>
        /// <para>
        /// <see href="http://localhost:8080/articles/intro.html">URL BASE</see> api/Academico/Preinscripcion/ObtenerEstadosCiviles
        /// </para>
        /// <para>
        /// RESULTADO:
        /// </para>
        /// <code language="cs">
        /// {
        ///     "data": [
        ///         {
        ///             "id": "Psoyk2MVU7IYwxyzBWsNSg==",
        ///             "nombre": "TECNOLOGIA DE ALIMENTOS"
        ///         },
        ///         {
        ///             "id": "xKoQU/IoXiU4PbWmJoKWZA==",
        ///             "nombre": "DESARROLLO Y PLANIFICACION DE LA EDUCACION SUPERIOR"
        ///         }
        ///     ]   
        /// }
        /// </code>
        /// </summary>
        [HttpGet]
        [Route("ObtenerProfesiones")]
        public async Task<IActionResult> GetProfesiones()
        {
            try
            {
                _logger.LogInformation("Iniciando Proceso para recuperar Zonas de una provincia de la BD.");
                var profesiones = await _preInscripcionService.GetProfesiones();
                if (profesiones == null)
                    _logger.LogWarning("No se encontraron datos.");
                return Ok(profesiones);
            }
            catch (Exception err)
            {
                _logger.LogError(err, "Error inesperado");
                var response = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.error.ToString(), Description = err.Message } },
                };
                return StatusCode(500, response);
            }
        }
        /// <summary>
        /// CONSIDERACIONES: Guarda una nueva Pre-Inscripción.
        /// <para>
        /// <b> PROCESO:</b>  pre-inscripción.
        /// </para>
        /// <returns>
        /// <img src="https://cdn.marketing123.123formbuilder.com/wp-content/uploads/2020/12/Formulario-de-Inscripcion-1095873.jpg"/>     
        /// </returns>
        /// <para>
        /// TIPO: POST
        /// </para>
        /// <para>
        /// Formato del PayLoad de Pre-Inscripción:
        /// </para>
        /// <code language="cs">
        ///{
        ///  "informacionGeneral": {
        ///   "idCarrera": "B65EJjJsnGXhytmZHqfQ==",
        ///   "idPeriodoAcademico": "gh8GelCVbXqMH9ij444w==",
        ///   "fechaInscripcion": "2019-08-28",
        ///   "observacion": "Sin observaciones"
        /// },
        ///   "datosPersonales": {
        ///   "documentoIdentidad": "8895578",
        ///   "valorTipoDocumento": "ooo4W8KdnMovKywZ6qzQ==",
        ///   "idDepartamentoExpedido": "ooo408KdnMovKywZ6qzQ==",
        ///   "primerApellido": "Rojas",
        ///   "segundoApellido": "Garcia",
        ///   "tercerApellido": "Guzman",
        ///   "nombres": "Carla",
        ///   "fechaNacimiento": "07/01/1999",
        ///   "idPaisNacionalidad": "ooo40MW8KdovKywZ6qzQ==",
        ///   "idDepartamentoNacimiento": "oooMW8KdnMovKywZ6qzQ==",
        ///   "valorSexo": "4mo9gjV/hDzYrnu/IHA==",
        ///   "valorEstadoCivil": "ooo40MKdnMovKywZ6qzQ==",
        ///   "valorTipoSangre":  "ooo40MKdnMovKywZ6qzQ==",
        ///   "direccion": "Av. America",
        ///   "idZona": "ngWP2wRvZTfy2aeq4xcw==",
        ///   "telefonos": "4245896",
        ///   "celulares": "70589630",
        ///   "correoElectronico": "carla@gmail.com",
        ///   "trabaja": false,
        ///   "lugarDeTrabajo": "UMSS"
        /// },
        ///   "datosColegio": {
        ///   "idColegio": "6RGxgBKQ/HgJoq40MiHfw==",
        ///   "idDepartamento":"ooo408KdnMovKywZ6qzQ==",
        ///   "idProvincia": "ooo40MWdnMovKywZ6qzQ==",
        ///   "valorTurno": "ooo40MKdnMovKywZ6qzQ==",
        ///   "valorTipoColegio": "ooo40MW8KdnvKywZ6qzQ==",
        ///   "anioEgreso": 2020
        /// },
        ///   "datosPadre": {
        ///   "primerApellido": "Rojas",
        ///   "segundoApellido": "Garcia",
        ///   "nombres": "Ignacio",
        ///   "direccion": "Av. America",
        ///   "idDepartamento": "oooMW8KdnMovKywZ6qzQ==",
        ///   "telefonos": "78958963",
        ///   "idProfesion": "Psoyk2MVUIYwxyzBWsNSg==",
        ///   "lugarDeTrabajo": "UMSS"
        /// },
        ///   "datosMadre": {
        ///   "primerApellido": "Rojas",
        ///   "segundoApellido": "Garcia",
        ///   "nombres": "Luz",
        ///   "direccion": "Av. America",
        ///   "idDepartamento": "ooo40MW8KMovKywZ6qzQ==",
        ///   "telefonos": "78969637",
        ///   "idProfesion": "Psoyk2MVU7IYwxyzBNSg==",
        ///   "lugarTrabajo": "UMSS"
        /// },
        ///   "autorizaciones": [
        ///  {
        ///   "nombre": "Luz Garcia",
        ///      "correoElectronico": "luzg@gmail.com"
        ///    }
        ///  ],
        ///  "hermanos": [
        ///  {
        ///   "nombre": "Diego Garcia",
        ///   "numeroDocumento": "55286934"
        ///  }
        ///  ],
        ///  "viveCon": {
        ///    "valorViveCon": "ooo40MW8nMovKywZ6qzQ==",
        ///    "nombreTutor": "Luz Garcia",
        ///    "telefonos": "4795896",
        ///    "celulares": "78986535"
        ///   }
        /// }
        /// </code>
        /// <para>
        /// RESULTADO:
        /// </para>
        /// <code language="cs">
        /// {
        ///     "response": {
        ///         "process": "Pre Inscripcion",
        ///         "affectedRows": 1
        ///     }
        /// }
        /// </code> 
        /// </summary>
        /// <param name="GuardarPreInscripcion">Es la inscripcion que se realizara</param>
        [HttpPost]
        [Route("GuardarPreInscripcion")]
        public async Task<IActionResult> AddPreInscripcion([FromBody] PreInscripcionQueryFilter preInscripcionQueryFilter)
        {
            try
            {
                var preInscripcion = await _preInscripcionService.InsPreInscripcion(preInscripcionQueryFilter);
                return StatusCode((int)preInscripcion.StatusCode, preInscripcion);
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