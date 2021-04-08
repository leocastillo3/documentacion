namespace BackendAcademico.Core.Services.PreInscripcion
{
    using BackendAcademico.Core.CustomEntities;
    using BackendAcademico.Core.CustomEntities.Response;
    using BackendAcademico.Core.Enums;
    using BackendAcademico.Core.Enums.PreInscripcion;
    using BackendAcademico.Core.Interfaces.PreInscripcion;
    using BackendAcademico.Core.Interfaces.Validators.PreInscripcion;
    using BackendAcademico.Core.QueryFilters.PreInscripcion;
    using Microsoft.Extensions.Options;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;

    public class PreInscripcionService : IPreInscripcionService
    {
        #region Atributos
        private readonly PaginationOptions _paginationOptions;
        private readonly IPreInscripcionRepository _preInscripcionRepository;
        private readonly IPreInscripcionRepositoryVal _preInscripcionRepositoryVal;
        ResponseGet responseGet;
        #endregion

        #region Constructores
        public PreInscripcionService(IOptions<PaginationOptions> options, IPreInscripcionRepository preInscripcionRepository,
             IPreInscripcionRepositoryVal preInscripcionRepositoryVal)
        {
            _paginationOptions = options.Value;
            _preInscripcionRepository = preInscripcionRepository;
            _preInscripcionRepositoryVal = preInscripcionRepositoryVal;
        }
        #endregion

        #region Métodos
        public async Task<ResponseGet> GetCarreras()
        {
            var carreras = await _preInscripcionRepository.GetCarreras();
            if (carreras.Count() > 0)
            {
                responseGet = new ResponseGet()
                {
                    Data = carreras,
                    StatusCode = HttpStatusCode.OK
                };
            }
            else
            {
                responseGet = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.information.ToString(), Description = "No se encontraron datos en Carrera." } },
                    StatusCode = HttpStatusCode.NotFound
                };
            }
            return responseGet;
        }

        public async Task<ResponseGet> GetNacionalidades()
        {
            var nacionalidades = await _preInscripcionRepository.GetNacionalidades();
            if (nacionalidades.Count() > 0)
            {
                responseGet = new ResponseGet()
                {
                    Data = nacionalidades,
                    StatusCode = HttpStatusCode.OK
                };
            }
            else
            {
                responseGet = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.information.ToString(), Description = "No se encontraron datos en Nacionalidad." } },
                    StatusCode = HttpStatusCode.NotFound
                };
            }
            return responseGet;
        }

        public async Task<ResponseGet> GetPeridosAcademicos()
        {
            var periodosAcademicos = await _preInscripcionRepository.GetPeriodosAcademicos();
            if (periodosAcademicos.Count() > 0)
            {
                responseGet = new ResponseGet()
                {
                    Data = periodosAcademicos,
                    StatusCode = HttpStatusCode.OK
                };
            }
            else
            {
                responseGet = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.information.ToString(), Description = "No se encontraron datos en Periodo Académico" } },
                    StatusCode = HttpStatusCode.NotFound
                };
            }
            return responseGet;
        }

        public async Task<ResponseGet> GetValoresPorDominio(string dominio)
        {        
            var valores = await _preInscripcionRepository.GetValoresPorDominio(dominio);
            if (valores.Count() > 0)
            {
                responseGet = new ResponseGet()
                {
                    Data = valores,
                    StatusCode = HttpStatusCode.OK
                };
            }
            else
            {
                responseGet = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.information.ToString(), Description = $"No se encontraron datos en el dominio {dominio}." } },
                    StatusCode = HttpStatusCode.NotFound
                };
            }
            return responseGet;
        }

        public async Task<ResponseGet> GetDepartamentosPorPais(int idPais)
        {
            #region IdValidator
            var responseModel = _preInscripcionRepositoryVal.ValidateId(idPais);
            if (!responseModel.IsValid)
            {
                return new ResponseGet()
                {
                    Messages = responseModel.ValidationMessages.ToArray(),
                    StatusCode = HttpStatusCode.BadRequest
                };
            }
            #endregion

            var departamentos = await _preInscripcionRepository.GetDepartamentosPorPais(idPais);
            if (departamentos.Count() > 0)
            {
                responseGet = new ResponseGet()
                {
                    Data = departamentos,
                    StatusCode = HttpStatusCode.OK
                };
            }
            else
            {
                responseGet = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.information.ToString(), Description = "No se encontraron datos en Departamento." } },
                    StatusCode = HttpStatusCode.NotFound
                };
            }
            return responseGet;
        }

        public async Task<ResponseGet> GetDepartamentosBolivia()
        {
            var departamentos = await _preInscripcionRepository.GetDepartamentosBolivia();
            if (departamentos.Count() > 0)
            {
                responseGet = new ResponseGet()
                {
                    Data = departamentos,
                    StatusCode = HttpStatusCode.OK
                };
            }
            else
            {
                responseGet = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.information.ToString(), Description = "No se encontraron datos en Departamento." } },
                    StatusCode = HttpStatusCode.NotFound
                };
            }
            return responseGet;
        }

        public async Task<ResponseGet> GetProvinciasPorDepartamento(int idDepartamento)
        {
            #region IdValidator
            var responseModel = _preInscripcionRepositoryVal.ValidateId(idDepartamento);
            if (!responseModel.IsValid)
            {
                return new ResponseGet()
                {
                    Messages = responseModel.ValidationMessages.ToArray(),
                    StatusCode = HttpStatusCode.BadRequest
                };
            }
            #endregion

            var provincias = await _preInscripcionRepository.GetProvinciasPorDepartamento(idDepartamento);
            if (provincias.Count() > 0)
            {
                responseGet = new ResponseGet()
                {
                    Data = provincias,
                    StatusCode = HttpStatusCode.OK
                };
            }
            else
            {
                responseGet = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.information.ToString(), Description = "No se encontraron datos en Departamento." } },
                    StatusCode = HttpStatusCode.NotFound
                };
            }
            return responseGet;
        }

        public async Task<ResponseGet> GetMunicipiosPorProvincia(int idProvincia)
        {
            #region IdValidator
            var responseModel = _preInscripcionRepositoryVal.ValidateId(idProvincia);
            if (!responseModel.IsValid)
            {
                return new ResponseGet()
                {
                    Messages = responseModel.ValidationMessages.ToArray(),
                    StatusCode = HttpStatusCode.BadRequest
                };
            }
            #endregion

            var municipios = await _preInscripcionRepository.GetMunicipiosPorProvincia(idProvincia);
            if (municipios.Count() > 0)
            {
                responseGet = new ResponseGet()
                {
                    Data = municipios,
                    StatusCode = HttpStatusCode.OK
                };
            }
            else
            {
                responseGet = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.information.ToString(), Description = "No se encontraron datos en Departamento." } },
                    StatusCode = HttpStatusCode.NotFound
                };
            }
            return responseGet;
        }

        public async Task<ResponseGet> GetZonasPorMunicipio(int idMunicipio)
        {
            #region IDValidator
            var responseModel = _preInscripcionRepositoryVal.ValidateId(idMunicipio);
            if (!responseModel.IsValid)
            {
                return new ResponseGet()
                {
                    Messages = responseModel.ValidationMessages.ToArray(),
                    StatusCode = HttpStatusCode.BadRequest
                };
            }
            #endregion

            var zonas = await _preInscripcionRepository.GetZonasPorMunicipio(idMunicipio);
            if (zonas.Count() > 0)
            {
                responseGet = new ResponseGet()
                {
                    Data = zonas,
                    StatusCode = HttpStatusCode.OK
                };
            }
            else
            {
                responseGet = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.information.ToString(), Description = "No se encontraron datos en Zona." } },
                    StatusCode = HttpStatusCode.NotFound
                };
            }
            return responseGet;
        }

        public async Task<ResponseGet> GetColegiosPorProvincia(int idProvincia)
        {
            #region  IdValidator
            var responseModel = _preInscripcionRepositoryVal.ValidateId(idProvincia);
            if (!responseModel.IsValid)
            {
                return new ResponseGet()
                {
                    Messages = responseModel.ValidationMessages.ToArray(),
                    StatusCode = HttpStatusCode.BadRequest
                };
            }
            #endregion

            var colegios = await _preInscripcionRepository.GetColegiosPorProvincia(idProvincia);
            if (colegios.Count() > 0)
            {
                responseGet = new ResponseGet()
                {
                    Data = colegios,
                    StatusCode = HttpStatusCode.OK
                };
            }
            else
            {
                responseGet = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.information.ToString(), Description = "No se encontraron datos en Colegio." } },
                    StatusCode = HttpStatusCode.NotFound
                };
            }
            return responseGet;
        }

        public async Task<ResponseGet> GetProfesiones()
        {
            var profesiones = await _preInscripcionRepository.GetProfesiones();
            if (profesiones.Count() > 0)
            {
                responseGet = new ResponseGet()
                {
                    Data = profesiones,
                    StatusCode = HttpStatusCode.OK
                };
            }
            else
            {
                responseGet = new ResponseGet()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.information.ToString(), Description = "No se encontraron datos en Profesión." } },
                    StatusCode = HttpStatusCode.NotFound
                };
            }
            return responseGet;

        }

        public async Task<ResponsePost> InsPreInscripcion(PreInscripcionQueryFilter preInscripcionQueryFilter)
        {
            #region PreInscripcion Validator
            var responseModel = _preInscripcionRepositoryVal.ValidatePreInscripcion(preInscripcionQueryFilter);
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
            if(preInscripcionQueryFilter.Autorizaciones!= null)
            {
                var autorizacionesDuplicadas = preInscripcionQueryFilter.Autorizaciones.GroupBy(autorizacion => autorizacion.Nombre).Where(autorizacion => autorizacion.Count() > 1).Count();
                if (autorizacionesDuplicadas > 0)
                {
                    return new ResponsePost()
                    {
                        Messages = new Message[] { new Message() { Type = TypeMessage.warning.ToString(), Description = "Los nombres de las personas autorizadas están duplicados." } },
                        StatusCode = HttpStatusCode.BadRequest
                    };
                }
            }
            if (preInscripcionQueryFilter.Hermanos != null)
            {
                var hermanosDuplicados = preInscripcionQueryFilter.Hermanos.GroupBy(hermano => hermano.NumeroDocumento).Where(hermano => hermano.Count() > 1).Count();
                if (hermanosDuplicados > 0)
                {
                    return new ResponsePost()
                    {
                        Messages = new Message[] { new Message() { Type = TypeMessage.warning.ToString(), Description = "Los documentos de identidad de los hermanos están duplicados." } },
                        StatusCode = HttpStatusCode.BadRequest
                    };
                }
            }  
            if (preInscripcionQueryFilter.DatosPersonales.PrimerApellido == null && preInscripcionQueryFilter.DatosPersonales.SegundoApellido == null) {
                return new ResponsePost()
                {
                    Messages = new Message[] { new Message() { Type = TypeMessage.warning.ToString(), Description = "El registro de al menos un apellido es obligatorio." } },
                    StatusCode = HttpStatusCode.BadRequest
                };
            }
            #endregion

            var idPreInscripcion =(int)await _preInscripcionRepository.GetValorSecuenciaPreInscripcion();
            preInscripcionQueryFilter.DatosPersonales.IdPreInscripcion = idPreInscripcion;
            await _preInscripcionRepository.InsDatosPersonales(preInscripcionQueryFilter.DatosPersonales);
            preInscripcionQueryFilter.DatosColegio.IdPreInscripcion = idPreInscripcion;
            await _preInscripcionRepository.InsDatosColegio(preInscripcionQueryFilter.DatosColegio);
            preInscripcionQueryFilter.ViveCon.IdPreInscripcion = idPreInscripcion;
            await _preInscripcionRepository.InsViveCon(preInscripcionQueryFilter.ViveCon);
            preInscripcionQueryFilter.Discapacidades.IdPreInscripcion = idPreInscripcion;
            await _preInscripcionRepository.InsPreDiscapacidad(preInscripcionQueryFilter.Discapacidades);
            preInscripcionQueryFilter.InformacionGeneral.IdPreInscripcion = idPreInscripcion;
            preInscripcionQueryFilter.InformacionGeneral.EstadoTransaccion = (int)EstadoPreInscripcion.enEspera;
            var preInscripcionInsert = await _preInscripcionRepository.InsInformacionGeneral(preInscripcionQueryFilter.InformacionGeneral);
            if (preInscripcionQueryFilter.Discapacidades.TrastornosAprendizajeDetalle != null)
            {
                foreach (var trastornoAprendizaje in preInscripcionQueryFilter.Discapacidades.TrastornosAprendizajeDetalle)
                {
                    trastornoAprendizaje.IdPreInscripcion = idPreInscripcion;
                    trastornoAprendizaje.Dominio = TiposDominio.TIPO_TRAS_APRENDIZAJE.ToString();
                    await _preInscripcionRepository.InsPreDiscapacidadDetalle(trastornoAprendizaje);
                }
            }
            if (preInscripcionQueryFilter.Discapacidades.TrastornosDetalle != null)
            {
                foreach (var trastorno in preInscripcionQueryFilter.Discapacidades.TrastornosDetalle)
                {
                    trastorno.IdPreInscripcion = idPreInscripcion;
                    trastorno.Dominio = TiposDominio.TIPO_TRASTORNO.ToString();
                    await _preInscripcionRepository.InsPreDiscapacidadDetalle(trastorno);
                }
            }
            if (preInscripcionQueryFilter.Discapacidades.DiscapacidadesDetalle != null)
            {
                foreach (var discapacidad in preInscripcionQueryFilter.Discapacidades.DiscapacidadesDetalle)
                {
                    discapacidad.IdPreInscripcion = idPreInscripcion;
                    discapacidad.Dominio = TiposDominio.TIPO_DISCAPACIDAD.ToString();
                    await _preInscripcionRepository.InsPreDiscapacidadDetalle(discapacidad);
                }
            }
            if (preInscripcionQueryFilter.Autorizaciones != null)
            {
                foreach (var autorizacion in preInscripcionQueryFilter.Autorizaciones)
                {
                    autorizacion.IdPreInscripcion = idPreInscripcion;
                    await _preInscripcionRepository.InsPreAutorizacion(autorizacion);
                }
            }
            if(preInscripcionQueryFilter.DatosPadre != null)
            {
                preInscripcionQueryFilter.DatosPadre.IdPreInscripcion = idPreInscripcion;
                preInscripcionQueryFilter.DatosPadre.Tipo = (int)TipoPadre.padre;
                await _preInscripcionRepository.InsDatosPadre(preInscripcionQueryFilter.DatosPadre);
            }
            if (preInscripcionQueryFilter.DatosMadre != null)
            {
                preInscripcionQueryFilter.DatosMadre.IdPreInscripcion = idPreInscripcion;
                preInscripcionQueryFilter.DatosMadre.Tipo = (int)TipoPadre.madre;
                await _preInscripcionRepository.InsDatosPadre(preInscripcionQueryFilter.DatosMadre);
            }

            if (preInscripcionQueryFilter.Hermanos != null)
            {
                foreach (var hermano in preInscripcionQueryFilter.Hermanos)
                {
                    hermano.IdPreInscripcion = idPreInscripcion;
                    hermano.TieneHermanos = (int)TieneHermano.si;
                    await _preInscripcionRepository.InsPreHermanos(hermano);
                }
            }
            if (preInscripcionInsert.AffectedRows > 0)
            {
                return new ResponsePost()
                {
                    Response = preInscripcionInsert,
                    StatusCode = HttpStatusCode.OK
                };
            }
            else
            {
                return new ResponsePost()
                {
                    Response = preInscripcionInsert,
                    StatusCode = HttpStatusCode.NoContent 
                };
            }
        }
        #endregion
    }
}
