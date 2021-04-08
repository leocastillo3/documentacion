namespace BackendAcademico.Core.Interfaces.PreInscripcion
{
    using BackendAcademico.Core.CustomEntities.Response;
    using BackendAcademico.Core.Entities.PreInscripcion;
    using BackendAcademico.Core.QueryFilters.PreInscripcion;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IPreInscripcionRepository
    {
        Task<IEnumerable<PeriodoAcademico>> GetPeriodosAcademicos();
        Task<IEnumerable<Carrera>> GetCarreras();
        Task<IEnumerable<NacionalidadPais>> GetNacionalidades();
        Task<IEnumerable<Departamento>> GetDepartamentosPorPais(int idPais);
        Task<IEnumerable<Departamento>> GetDepartamentosBolivia();
        Task<IEnumerable<Provincia>> GetProvinciasPorDepartamento(int idDepartamento);
        Task<IEnumerable<Municipio>> GetMunicipiosPorProvincia(int idProvincia);
        Task<IEnumerable<Zona>> GetZonasPorMunicipio(int idMunicipio);
        Task<IEnumerable<Dominio>> GetValoresPorDominio(string dominio);
        Task<IEnumerable<Colegio>> GetColegiosPorProvincia(int idProvincia);
        Task<IEnumerable<Profesion>> GetProfesiones();
        Task<ResponsePostDetail> InsInformacionGeneral(InformacionGeneralQueryFilter informacionGeneralQueryFilter);
        Task<ResponsePostDetail> InsDatosPersonales(PreDatosPersonalesQueryFilter datosPersonalesQueryFilter);
        Task<ResponsePostDetail> InsDatosColegio(PreColegioQueryFilter preColegioQueryFilter);
        Task<ResponsePostDetail> InsDatosPadre(PreDatosPadresQueryFilter preDatosPadresQueryFilter);
        Task<ResponsePostDetail> InsViveCon(PreViveConQueryFilter preViveConQueryFilter);
        Task<ResponsePostDetail> InsPreDiscapacidadDetalle(PreDiscapacidadDetalleQueryFilter preDiscapacidadDetalleQueryFilter);
        Task<ResponsePostDetail> InsPreDiscapacidad(PreDiscapacidadesQueryFilter preDiscapacidadesQueryFilter);
        Task<ResponsePostDetail> InsPreAutorizacion(PreAutorizacionesQueryFilter preAutorizacionesQueryFilter);
        Task<ResponsePostDetail> InsPreHermanos(PreHermanosQueryFilter preHermanosQueryFilter);
        Task<object> GetValorSecuenciaPreInscripcion();
    }
}
