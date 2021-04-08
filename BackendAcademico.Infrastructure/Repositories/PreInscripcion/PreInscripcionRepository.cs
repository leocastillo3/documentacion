namespace BackendAcademico.Infrastructure.Repositories.PreInscripcion
{
    using BackendAcademico.Core.CustomEntities;
    using BackendAcademico.Core.CustomEntities.Response;
    using BackendAcademico.Core.Entities.PreInscripcion;
    using BackendAcademico.Core.Enums;
    using BackendAcademico.Core.Interfaces.Data;
    using BackendAcademico.Core.Interfaces.PreInscripcion;
    using BackendAcademico.Core.QueryFilters.PreInscripcion;
    using BackendAcademico.Infrastructure.Data;
    using Microsoft.Extensions.Options;
    using Oracle.ManagedDataAccess.Client;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Threading.Tasks;

    public class PreInscripcionRepository : IPreInscripcionRepository
    {
        #region Atributos
        private readonly IConeccion _coneccion;
        private readonly PaginationOptions _paginationOptions;
        private ResponseGet responseGet;
        private ResponseGetPagination responseGetPagination;
        private ResponsePost responsePost;
        #endregion

        #region Constructores
        public PreInscripcionRepository(IConeccion coneccion, IOptions<PaginationOptions> options)
        {
            _coneccion = coneccion;
            _paginationOptions = options.Value;
            responseGet = new ResponseGet();
            responseGetPagination = new ResponseGetPagination();
            responsePost = new ResponsePost();
        }
        #endregion

        #region Métodos
        public async Task<IEnumerable<PeriodoAcademico>> GetPeriodosAcademicos()
        {
            try
            {
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("CUR_LISTA_PERIODOS", OracleDbType.RefCursor, ParameterDirection.Output);
                var query = "ACADEMICO.PREINSCRIPCION.SP_OBTENER_PERIODOS_ACTIVOS";
                return await _coneccion.GetData<PeriodoAcademico>(dyParam, query);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public async Task<IEnumerable<Carrera>> GetCarreras()
        {
            try
            {
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("CUR_LISTA_CARRERAS", OracleDbType.RefCursor, ParameterDirection.Output);
                var query = "ACADEMICO.PREINSCRIPCION.SP_OBTENER_CARRERAS";
                return await _coneccion.GetData<Carrera>(dyParam, query);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public async Task<IEnumerable<NacionalidadPais>> GetNacionalidades()
        {
            try
            {
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("CUR_LISTA_NACIONALIDADES", OracleDbType.RefCursor, ParameterDirection.Output);
                var query = "ACADEMICO.PREINSCRIPCION.SP_OBTENER_NACIONALIDADES";
                return await _coneccion.GetData<NacionalidadPais>(dyParam, query);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public async Task<IEnumerable<Departamento>> GetDepartamentosPorPais(int idPais)
        {
            try
            {
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("CUR_LISTA_DEPARTAMENTOS", OracleDbType.RefCursor, ParameterDirection.Output);
                dyParam.Add("idPais", OracleDbType.Int32, ParameterDirection.Input,idPais);
                var query = "ACADEMICO.PREINSCRIPCION.SP_OBTENER_DEPTOS_POR_PAIS";
                return await _coneccion.GetData<Departamento>(dyParam, query);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public async Task<IEnumerable<Departamento>> GetDepartamentosBolivia()
        {
            try
            {
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("CUR_LISTA_DEPARTAMENTOS", OracleDbType.RefCursor, ParameterDirection.Output);
                var query = "ACADEMICO.PREINSCRIPCION.SP_OBTENER_DEPTOS_BOLIVIA";
                return await _coneccion.GetData<Departamento>(dyParam, query);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public async Task<IEnumerable<Provincia>> GetProvinciasPorDepartamento(int idDepartamento)
        {
            try
            {
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("CUR_LISTA_PROVINCIAS", OracleDbType.RefCursor, ParameterDirection.Output);
                dyParam.Add("idDepartamento", OracleDbType.Int32, ParameterDirection.Input, idDepartamento);
                var query = "ACADEMICO.PREINSCRIPCION.SP_OBTENER_PROVS_POR_DEPTO";
                return await _coneccion.GetData<Provincia>(dyParam, query);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public async Task<IEnumerable<Municipio>> GetMunicipiosPorProvincia(int idProvincia)
        {
            try
            {
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("CUR_LISTA_MUNICIPIOS", OracleDbType.RefCursor, ParameterDirection.Output);
                dyParam.Add("idProvincia", OracleDbType.Int32, ParameterDirection.Input, idProvincia);
                var query = "ACADEMICO.PREINSCRIPCION.SP_OBTENER_MPIOS_POR_PROV";
                return await _coneccion.GetData<Municipio>(dyParam, query);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public async Task<IEnumerable<Zona>> GetZonasPorMunicipio(int idMunicipio)
        {
            try
            {
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("CUR_LISTA_ZONAS", OracleDbType.RefCursor, ParameterDirection.Output);
                dyParam.Add("idMunicipio", OracleDbType.Int32, ParameterDirection.Input, idMunicipio);
                var query = "ACADEMICO.PREINSCRIPCION.SP_OBTENER_ZONAS_POR_MPIO";
                return await _coneccion.GetData<Zona>(dyParam, query);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public async Task<IEnumerable<Dominio>> GetValoresPorDominio(string dominio)
        {
            try
            {
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("CUR_LISTA_DOMINIOS", OracleDbType.RefCursor, ParameterDirection.Output);
                dyParam.Add("tipoDominio", OracleDbType.Varchar2, ParameterDirection.Input, dominio);
                var query = "ACADEMICO.PREINSCRIPCION.SP_OBTENER_VALORES_POR_DOMINIO";
                return await _coneccion.GetData<Dominio>(dyParam, query);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }


        public async Task<IEnumerable<Colegio>> GetColegiosPorProvincia(int idProvincia)
        {
            try
            {
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("CUR_LISTA_COLEGIOS", OracleDbType.RefCursor, ParameterDirection.Output);
                dyParam.Add("idProvincia", OracleDbType.Int32, ParameterDirection.Input, idProvincia);
                var query = "ACADEMICO.PREINSCRIPCION.SP_OBTENER_COLEGIOS_POR_PROV";
                return await _coneccion.GetData<Colegio>(dyParam, query);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public async Task<IEnumerable<Profesion>> GetProfesiones()
        {
            try
            {
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("CUR_LISTA_PROFESIONES", OracleDbType.RefCursor, ParameterDirection.Output);
                var query = "ACADEMICO.PREINSCRIPCION.SP_OBTENER_PROFESIONES";
                return await _coneccion.GetData<Profesion>(dyParam, query);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
        public async Task<ResponsePostDetail> InsInformacionGeneral(InformacionGeneralQueryFilter informacionGeneralQueryFilter)
        {
            try
            {
                var affectedRows = 0;
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("id_pre_inscripcion", OracleDbType.Int32, ParameterDirection.Input, informacionGeneralQueryFilter.IdPreInscripcion);
                dyParam.Add("id_carrera", OracleDbType.Int32, ParameterDirection.Input, informacionGeneralQueryFilter.IdCarrera);
                dyParam.Add("id_periodo_academico", OracleDbType.Int32, ParameterDirection.Input, informacionGeneralQueryFilter.IdPeriodoAcademico);
                dyParam.Add("fecha_inscripcion", OracleDbType.Date, ParameterDirection.Input, informacionGeneralQueryFilter.FechaInscripcion);
                dyParam.Add("observacion", OracleDbType.Varchar2, ParameterDirection.Input, informacionGeneralQueryFilter.Observacion);
                dyParam.Add("estado_transaccion", OracleDbType.Varchar2, ParameterDirection.Input, informacionGeneralQueryFilter.EstadoTransaccion);
                dyParam.Add("affected_rows", OracleDbType.Int32, ParameterDirection.Output, 0);
                var query = "ACADEMICO.PREINSCRIPCION.SP_INSERTAR_INSCRIPCION";
                await _coneccion.InsData(dyParam, query);
                affectedRows = dyParam.Get("affected_rows");
                return new ResponsePostDetail()
                {
                    Process = "Pre Inscripcion",
                    AffectedRows = affectedRows
                };
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public async Task<ResponsePostDetail> InsDatosPersonales(PreDatosPersonalesQueryFilter datosPersonalesQueryFilter)
        {
            try
            {
                var affectedRows = 0;
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("id_pre_inscripcion", OracleDbType.Int32, ParameterDirection.Input, datosPersonalesQueryFilter.IdPreInscripcion);
                dyParam.Add("documento_identidad", OracleDbType.Varchar2, ParameterDirection.Input, datosPersonalesQueryFilter.DocumentoIdentidad);
                dyParam.Add("numero_registro", OracleDbType.Varchar2, ParameterDirection.Input, datosPersonalesQueryFilter.NumeroRegistro);
                dyParam.Add("tipo_doc", OracleDbType.Int32, ParameterDirection.Input, datosPersonalesQueryFilter.ValorTipoDocumento);
                dyParam.Add("id_departamento_exp", OracleDbType.Int32, ParameterDirection.Input, datosPersonalesQueryFilter.IdDepartamentoExpedido);
                dyParam.Add("primer_apellido", OracleDbType.Varchar2, ParameterDirection.Input, datosPersonalesQueryFilter.PrimerApellido);
                dyParam.Add("segundo_apellido", OracleDbType.Varchar2, ParameterDirection.Input, datosPersonalesQueryFilter.SegundoApellido);
                dyParam.Add("tercer_apellido", OracleDbType.Varchar2, ParameterDirection.Input, datosPersonalesQueryFilter.TercerApellido);
                dyParam.Add("nombre", OracleDbType.Varchar2, ParameterDirection.Input, datosPersonalesQueryFilter.Nombres);
                dyParam.Add("fecha_nacimiento", OracleDbType.Date, ParameterDirection.Input, datosPersonalesQueryFilter.FechaNacimiento);
                dyParam.Add("id_pais_nacionalidad", OracleDbType.Int32, ParameterDirection.Input, datosPersonalesQueryFilter.IdPaisNacionalidad);
                dyParam.Add("id_departamento_nacimiento", OracleDbType.Int32, ParameterDirection.Input, datosPersonalesQueryFilter.IdDepartamentoNacimiento);
                dyParam.Add("sexo", OracleDbType.Int32, ParameterDirection.Input, datosPersonalesQueryFilter.ValorSexo);
                dyParam.Add("estado_civil", OracleDbType.Int32, ParameterDirection.Input, datosPersonalesQueryFilter.ValorEstadoCivil);
                dyParam.Add("tipo_sangre", OracleDbType.Int32, ParameterDirection.Input, datosPersonalesQueryFilter.ValorTipoSangre);
                dyParam.Add("direccion", OracleDbType.Varchar2, ParameterDirection.Input, datosPersonalesQueryFilter.Direccion);
                dyParam.Add("id_zona", OracleDbType.Int32, ParameterDirection.Input, datosPersonalesQueryFilter.IdZona);
                dyParam.Add("telefono", OracleDbType.Varchar2, ParameterDirection.Input, datosPersonalesQueryFilter.Telefonos);
                dyParam.Add("celular", OracleDbType.Varchar2, ParameterDirection.Input, datosPersonalesQueryFilter.Celulares);
                dyParam.Add("email", OracleDbType.Varchar2, ParameterDirection.Input, datosPersonalesQueryFilter.CorreoElectronico);
                dyParam.Add("trabaja", OracleDbType.Int32, ParameterDirection.Input, (int)(datosPersonalesQueryFilter.Trabaja ? TipoBooleano.si : TipoBooleano.no));
                dyParam.Add("lugar_trabaja", OracleDbType.Varchar2, ParameterDirection.Input, datosPersonalesQueryFilter.LugarDeTrabajo);
                dyParam.Add("affected_rows", OracleDbType.Int32, ParameterDirection.Output, 0);
                var query = "ACADEMICO.PREINSCRIPCION.SP_INSERTAR_DATOS_PERSONALES";
                await _coneccion.InsData(dyParam, query);
                affectedRows = dyParam.Get("affected_rows");
                return new ResponsePostDetail()
                {
                    Process = "Pre Inscripcion",
                    AffectedRows = affectedRows
                };
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public async Task<ResponsePostDetail> InsDatosColegio(PreColegioQueryFilter preColegioQueryFilter)
        {
            try
            {
                var affectedRows = 0;
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("id_pre_inscripcion", OracleDbType.Int32, ParameterDirection.Input, preColegioQueryFilter.IdPreInscripcion);
                dyParam.Add("id_colegio", OracleDbType.Int32, ParameterDirection.Input, preColegioQueryFilter.IdColegio);
                dyParam.Add("id_departamento", OracleDbType.Int32, ParameterDirection.Input, preColegioQueryFilter.IdDepartamento);
                dyParam.Add("id_provincia", OracleDbType.Int32, ParameterDirection.Input, preColegioQueryFilter.IdProvincia);
                dyParam.Add("turno", OracleDbType.Int32, ParameterDirection.Input, preColegioQueryFilter.ValorTurno);
                dyParam.Add("tipo_colegio", OracleDbType.Int32, ParameterDirection.Input, preColegioQueryFilter.ValorTipoColegio);
                dyParam.Add("anio_egreso", OracleDbType.Int32, ParameterDirection.Input, preColegioQueryFilter.AnioEgreso);
                dyParam.Add("affected_rows", OracleDbType.Int32, ParameterDirection.Output, 0);
                var query = "ACADEMICO.PREINSCRIPCION.SP_INSERTAR_COLEGIO";
                await _coneccion.InsData(dyParam, query);
                affectedRows = dyParam.Get("affected_rows");
                return new ResponsePostDetail()
                {
                    Process = "Pre Inscripcion",
                    AffectedRows = affectedRows
                };
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public async Task<ResponsePostDetail> InsDatosPadre(PreDatosPadresQueryFilter preDatosPadresQueryFilter)
        {
            try
            {
                var affectedRows = 0;
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("id_pre_inscripcion", OracleDbType.Int32, ParameterDirection.Input, preDatosPadresQueryFilter.IdPreInscripcion);
                dyParam.Add("ap_paterno", OracleDbType.Varchar2, ParameterDirection.Input, preDatosPadresQueryFilter.PrimerApellido);
                dyParam.Add("ap_materno", OracleDbType.Varchar2, ParameterDirection.Input, preDatosPadresQueryFilter.SegundoApellido);
                dyParam.Add("nombre", OracleDbType.Varchar2, ParameterDirection.Input, preDatosPadresQueryFilter.Nombres);
                dyParam.Add("direccion", OracleDbType.Varchar2, ParameterDirection.Input, preDatosPadresQueryFilter.Direccion);
                dyParam.Add("id_departamento", OracleDbType.Int32, ParameterDirection.Input, preDatosPadresQueryFilter.IdDepartamento);
                dyParam.Add("telefono", OracleDbType.Varchar2, ParameterDirection.Input, preDatosPadresQueryFilter.Telefonos);
                dyParam.Add("id_profesion", OracleDbType.Int32, ParameterDirection.Input, preDatosPadresQueryFilter.IdProfesion);
                dyParam.Add("lugar_trabaja", OracleDbType.Varchar2, ParameterDirection.Input, preDatosPadresQueryFilter.LugarDeTrabajo);
                dyParam.Add("tipo", OracleDbType.Int32, ParameterDirection.Input, preDatosPadresQueryFilter.Tipo);
                dyParam.Add("affected_rows", OracleDbType.Int32, ParameterDirection.Output, 0);
                var query = "ACADEMICO.PREINSCRIPCION.SP_INSERTAR_DATOS_PADRES";
                await _coneccion.InsData(dyParam, query);
                affectedRows = dyParam.Get("affected_rows");
                return new ResponsePostDetail()
                {
                    Process = "Pre Inscripcion",
                    AffectedRows = affectedRows
                };
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public async Task<ResponsePostDetail> InsViveCon(PreViveConQueryFilter preViveConQueryFilter)
        {
            try
            {
                var affectedRows = 0;
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("id_pre_inscripcion", OracleDbType.Int32, ParameterDirection.Input, preViveConQueryFilter.IdPreInscripcion);
                dyParam.Add("vive_con", OracleDbType.Int32, ParameterDirection.Input, preViveConQueryFilter.ValorViveCon);
                dyParam.Add("nombre_tutor", OracleDbType.Varchar2, ParameterDirection.Input, preViveConQueryFilter.NombreTutor);
                dyParam.Add("telefono", OracleDbType.Varchar2, ParameterDirection.Input, preViveConQueryFilter.Telefonos);
                dyParam.Add("celular", OracleDbType.Varchar2, ParameterDirection.Input, preViveConQueryFilter.Celulares);
                dyParam.Add("problema_salud", OracleDbType.Int32, ParameterDirection.Input, (int)(preViveConQueryFilter.TieneProblemasSalud ? TipoBooleano.si : TipoBooleano.no));
                dyParam.Add("problema_salud_detalle", OracleDbType.Varchar2, ParameterDirection.Input, preViveConQueryFilter.ProblemaSaludDetalle);
                dyParam.Add("affected_rows", OracleDbType.Int32, ParameterDirection.Output, 0);
                var query = "ACADEMICO.PREINSCRIPCION.SP_INSERTAR_VIVE_CON";
                await _coneccion.InsData(dyParam, query);
                affectedRows = dyParam.Get("affected_rows");
                return new ResponsePostDetail()
                {
                    Process = "Pre Inscripcion",
                    AffectedRows = affectedRows
                };
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public async Task<ResponsePostDetail> InsPreDiscapacidadDetalle(PreDiscapacidadDetalleQueryFilter preDiscapacidadDetalleQueryFilter)
        {
            try
            {
                var affectedRows = 0;
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("id_pre_inscripcion", OracleDbType.Int32, ParameterDirection.Input, preDiscapacidadDetalleQueryFilter.IdPreInscripcion);
                dyParam.Add("valor", OracleDbType.Int32, ParameterDirection.Input, preDiscapacidadDetalleQueryFilter.ValorDiscapacidad);
                dyParam.Add("dominio", OracleDbType.Varchar2, ParameterDirection.Input, preDiscapacidadDetalleQueryFilter.Dominio);
                dyParam.Add("descripcion", OracleDbType.Varchar2, ParameterDirection.Input, preDiscapacidadDetalleQueryFilter.Descripcion);
                dyParam.Add("affected_rows", OracleDbType.Int32, ParameterDirection.Output, 0);
                var query = "ACADEMICO.PREINSCRIPCION.SP_INSERTAR_DISCAPACIDAD_DET";
                await _coneccion.InsData(dyParam, query);
                affectedRows = dyParam.Get("affected_rows");
                return new ResponsePostDetail()
                {
                    Process = "Pre Inscripcion",
                    AffectedRows = affectedRows
                };
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public async Task<ResponsePostDetail> InsPreDiscapacidad(PreDiscapacidadesQueryFilter preDiscapacidadesQueryFilter)
        {
            try
            {
                var affectedRows = 0;
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("id_pre_inscripcion", OracleDbType.Int32, ParameterDirection.Input, preDiscapacidadesQueryFilter.IdPreInscripcion);
                dyParam.Add("apoyo_ensenianza", OracleDbType.Int32, ParameterDirection.Input, (int)(preDiscapacidadesQueryFilter.RequiereApoyoEnsenianza ? TipoBooleano.si : TipoBooleano.no));
                dyParam.Add("trastorno_aprendizaje", OracleDbType.Varchar2, ParameterDirection.Input, (int)(preDiscapacidadesQueryFilter.PresentaTrastornoAprendizaje ? TipoBooleano.si : TipoBooleano.no));
                dyParam.Add("discapacidad", OracleDbType.Varchar2, ParameterDirection.Input, (int)(preDiscapacidadesQueryFilter.PresentaDiscapacidad ? TipoBooleano.si : TipoBooleano.no));
                dyParam.Add("trastorno", OracleDbType.Varchar2, ParameterDirection.Input, (int)(preDiscapacidadesQueryFilter.TieneTrastorno ? TipoBooleano.si : TipoBooleano.no));
                dyParam.Add("affected_rows", OracleDbType.Int32, ParameterDirection.Output, 0);
                var query = "ACADEMICO.PREINSCRIPCION.SP_INSERTAR_DISCAPACIDAD";
                await _coneccion.InsData(dyParam, query);
                affectedRows = dyParam.Get("affected_rows");
                return new ResponsePostDetail()
                {
                    Process = "Pre Inscripcion",
                    AffectedRows = affectedRows
                };
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
        public async Task<ResponsePostDetail> InsPreAutorizacion(PreAutorizacionesQueryFilter preAutorizacionesQueryFilter)
        {
            try
            {
                var affectedRows = 0;
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("id_pre_inscripcion", OracleDbType.Int32, ParameterDirection.Input, preAutorizacionesQueryFilter.IdPreInscripcion);
                dyParam.Add("nombre", OracleDbType.Varchar2, ParameterDirection.Input, preAutorizacionesQueryFilter.Nombre);
                dyParam.Add("email", OracleDbType.Varchar2, ParameterDirection.Input, preAutorizacionesQueryFilter.CorreoElectronico);
                dyParam.Add("affected_rows", OracleDbType.Int32, ParameterDirection.Output, 0);
                var query = "ACADEMICO.PREINSCRIPCION.SP_INSERTAR_AUTORIZACION";
                await _coneccion.InsData(dyParam, query);
                affectedRows = dyParam.Get("affected_rows");
                return new ResponsePostDetail()
                {
                    Process = "Pre Inscripcion",
                    AffectedRows = affectedRows
                };
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public async Task<ResponsePostDetail> InsPreHermanos(PreHermanosQueryFilter preHermanosQueryFilter)
        {
            try
            {
                var affectedRows = 0;
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("id_pre_inscripcion", OracleDbType.Int32, ParameterDirection.Input, preHermanosQueryFilter.IdPreInscripcion);
                dyParam.Add("tiene_hermanos", OracleDbType.Int32, ParameterDirection.Input, preHermanosQueryFilter.TieneHermanos);
                dyParam.Add("nombre", OracleDbType.Varchar2, ParameterDirection.Input, preHermanosQueryFilter.Nombre);
                dyParam.Add("num_documento", OracleDbType.Varchar2, ParameterDirection.Input, preHermanosQueryFilter.NumeroDocumento);
                dyParam.Add("affected_rows", OracleDbType.Int32, ParameterDirection.Output, 0);
                var query = "ACADEMICO.PREINSCRIPCION.SP_INSERTAR_HERMANOS";
                await _coneccion.InsData(dyParam, query);
                affectedRows = dyParam.Get("affected_rows");
                return new ResponsePostDetail()
                {
                    Process = "Pre Inscripcion",
                    AffectedRows = affectedRows
                };
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public async Task<object> GetValorSecuenciaPreInscripcion()
        {
            try
            {
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("param", OracleDbType.Varchar2, ParameterDirection.Input, "ACADEMICO.PREINSCRIPCION_SEC");
                var query = "SELECT ACADEMICO.helpers.Fn_GetSequence(:param) FROM DUAL";
                return await _coneccion.GetDataEscalar(dyParam, query);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
        #endregion
    }
}
