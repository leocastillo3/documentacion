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
        /// Consideraciones: Devuele la lista de los periódos académicos habilitados para la pre-inscripción.
        /// <para>
        /// Tipo: GET
        /// </para>
        /// <para>
        /// </para>
        /// <para>
        /// api/Academico/Preinscripcion/ObtenerPeriodosAcademicos 
        /// </para>
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
        /// Consideraciones: Devuele la lista de las carreras habilitadas.
        /// <para>
        /// Tipo: GET
        /// </para>
        /// <para>
        /// Retorna: 
        /// </para>
        /// <para>
        /// api/Academico/Preinscripcion/ObtenerCarreras 
        /// </para>
        /// </summary>
        ///


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
        /// Consideraciones: Devuele la lista de países para la nacionalidad.
        /// <para>
        /// Tipo: GET
        /// </para>
        /// <para>
        /// </para>
        /// <para>
        /// api/Academico/Preinscripcion/ObtenerNacionalidades
        /// </para>
        /// 
        /// </summary>
        ///
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
        /// Consideraciones: Devuelve la lista de sexos.
        /// <para>
        /// Tipo: GET
        /// </para>
        /// <para>
        /// </para>
        /// <para>
        /// api/Academico/Preinscripcion/ObtenerSexos
        /// </para>
        /// 
        /// </summary>
        ///
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
        /// Consideraciones: Devuele la de estados civiles .
        /// <para>
        /// Tipo: GET
        /// </para>
        /// <para>
        /// </para>
        /// <para>
        /// api/Academico/Preinscripcion/ObtenerEstadosCiviles
        /// </para>
        /// 
        /// </summary>
        ///
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
        /// Consideraciones: Devuele la lista de los tipos de documentos
        /// <para>
        /// Tipo: GET
        /// </para>
        /// <para>
        /// </para>
        /// <para>
        /// api/Academico/Preinscripcion/ObtenerTiposDocumento
        /// </para>
        /// 
        /// </summary>
        ///
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
        /// Consideraciones: Devuele la lista de los turnos de Colegio.
        /// <para>
        /// Tipo: GET
        /// </para>
        /// <para>
        /// </para>
        /// <para>
        /// api/Academico/Preinscripcion/ObtenerTurnosColegio
        /// </para>
        /// 
        /// </summary>
        ///
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
        /// Consideraciones: Devuele la lista de los tipos de colegio.
        /// <para>
        /// Tipo: GET
        /// </para>
        /// <para>
        /// </para>
        /// <para>
        /// api/Academico/Preinscripcion/ObtenerTiposColegio
        /// </para>
        /// 
        /// </summary>
        ///
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
        /// Consideraciones: Devuele la lista de las carreras habilitadas.
        /// <para>
        /// Tipo: GET
        /// </para>
        /// <para>
        /// </para>
        /// <para>
        /// api/Academico/Preinscripcion/ObtenerValoresViveCon
        /// </para>
        /// 
        /// </summary>
        ///
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
        /// Consideraciones: Devuele la lista del tipo de sangre.
        /// <para>
        /// Tipo: GET
        /// </para>
        /// <para>

        /// </para>
        /// <para>
        /// api/Academico/Preinscripcion/ObtenerEstadosCiviles
        /// </para>
        /// 
        /// </summary>
        ///
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
        /// Consideraciones: Devuele los departamentos según el ID del país seleccionado. 
        /// <para>
        /// Tipo: GET
        /// </para>
        /// <para>
        /// Parámetros: idPais (string)
        /// </para>
        /// api/Academico/Preinscripcion/ObtenerEstadosCiviles
        /// <para>
        /// </para>
        /// 
        /// </summary>
        ///
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
        /// Consideraciones: Devuele la lista de los departamentos de Bolivia.
        /// <para>
        /// Tipo: GET
        /// </para>
        /// 

        /// <para>
        /// api/Academico/Preinscripcion/ObtenerEstadosCiviles
        /// </para>
        /// 
        /// </summary>
        ///
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
        /// Consideraciones: Devuele la de provincias según el departamento seleccionado
        /// <para>
        /// Tipo: GET
        /// </para>
        /// <para>
        /// Parámetros: idDepartamento (String)
        /// </para>
        /// <para>
        /// api/Academico/Preinscripcion/ObtenerEstadosCiviles
        /// </para>
        /// 
        /// </summary>
        ///
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
        /// Consideraciones: Devuele la lista de los Municipios según la Provincia seleccionada.
        /// <para>
        /// Tipo: GET
        /// </para>
        /// <para>
        /// Parámetros: idProvincia(String)
        /// </para>
        /// <para>
        /// api/Academico/Preinscripcion/ObtenerEstadosCiviles
        /// </para>
        /// 
        /// </summary>
        ///
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
        /// Consideraciones: Devuele la lista de las Zonas según el Municipo seleccionado
        /// <para>
        /// Tipo: GET
        /// </para>
        /// <para>
        /// Parámetros: idMunicipio(String)
        /// </para>
        /// <para>
        /// api/Academico/Preinscripcion/ObtenerEstadosCiviles 
        /// </para>
        /// 
        /// </summary>
        ///
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
        /// Consideraciones: Devuele la lista de colegios a partir de un ID provincia.
        /// <para>
        /// Tipo: GET
        /// </para>
        /// <para>
        /// Parámetros: idProvincia (String)
        /// </para>
        /// <para>
        /// api/Academico/Preinscripcion/ObtenerEstadosCiviles
        /// </para>
        /// 
        /// </summary>
        ///
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
        /// Consideraciones: Devuele la lista de profesiones de la lista de la Base de Datos.
        /// <para>
        /// Tipo: GET
        /// </para>
        /// <para>
        /// </para>
        /// <para>
        /// api/Academico/Preinscripcion/ObtenerEstadosCiviles
        /// </para>
        /// 
        /// </summary>
        ///
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
        /// Guarda una nueva Pre-Inscripción.
        /// <para>
        /// Tipo: POST
        /// </para>
        /// <para>
        /// Formato del PayLoad de Pre-Inscripción:
        /// </para>
        /// <para>
        /// Tipo: POST
        /// </para>
        /// 
        /// <code language="cs">
        ///{
        ///  "informacionGeneral": {
        ///   "idCarrera": "B65EJjJsnGXhytmZHqfQ==",
        ///   "idPeriodoAcademico": "gh8GelCVbXqMH9ij444w==",
        ///   "fechaInscripcion": "2019-08-28",
        ///   "observacion": "Sin observaciones"
        /// },
        ///  "datosPersonales": {
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
        ///  "datosColegio": {
        ///   "idColegio": "6RGxgBKQ/HgJoq40MiHfw==",
        ///   "idDepartamento":"ooo408KdnMovKywZ6qzQ==",
        ///   "idProvincia": "ooo40MWdnMovKywZ6qzQ==",
        ///   "valorTurno": "ooo40MKdnMovKywZ6qzQ==",
        ///   "valorTipoColegio": "ooo40MW8KdnvKywZ6qzQ==",
        ///   "anioEgreso": 2020
        /// },
        ///  "datosPadre": {
        ///   "primerApellido": "Rojas",
        ///   "segundoApellido": "Garcia",
        ///   "nombres": "Ignacio",
        ///   "direccion": "Av. America",
        ///   "idDepartamento": "oooMW8KdnMovKywZ6qzQ==",
        ///   "telefonos": "78958963",
        ///   "idProfesion": "Psoyk2MVUIYwxyzBWsNSg==",
        ///   "lugarDeTrabajo": "UMSS"
        /// },
        ///  "datosMadre": {
        ///   "primerApellido": "Rojas",
        ///   "segundoApellido": "Garcia",
        ///   "nombres": "Luz",
        ///   "direccion": "Av. America",
        ///   "idDepartamento": "ooo40MW8KMovKywZ6qzQ==",
        ///   "telefonos": "78969637",
        ///   "idProfesion": "Psoyk2MVU7IYwxyzBNSg==",
        ///   "lugarTrabajo": "UMSS"
        /// },
        ///  "autorizaciones": [
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
        /// </summary>
        /// <param name="GuardarPreInscripcion">Es la inscripcion que se realizara <seealso cref="GuardarPreInscripcion"/></param>
        /// <returns>Retorna el idMunicipio según la Provincia.</returns>
        /// 
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
