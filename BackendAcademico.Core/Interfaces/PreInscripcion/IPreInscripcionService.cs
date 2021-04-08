namespace BackendAcademico.Core.Interfaces.PreInscripcion
{
    using BackendAcademico.Core.CustomEntities.Response;
    using BackendAcademico.Core.QueryFilters.PreInscripcion;
    using System.Threading.Tasks;

    public interface IPreInscripcionService
    {
        Task<ResponseGet> GetPeridosAcademicos();
        Task<ResponseGet> GetCarreras();
        Task<ResponseGet> GetNacionalidades();
        Task<ResponseGet> GetValoresPorDominio(string dominio);
        Task<ResponseGet> GetDepartamentosPorPais(int idPais);
        Task<ResponseGet> GetDepartamentosBolivia();
        Task<ResponseGet> GetProvinciasPorDepartamento(int idDepartamento);
        Task<ResponseGet> GetMunicipiosPorProvincia(int idProvincia);
        Task<ResponseGet> GetZonasPorMunicipio(int idMunicipio);
        Task<ResponseGet> GetColegiosPorProvincia(int idProvincia);
        Task<ResponseGet> GetProfesiones();
        Task<ResponsePost> InsPreInscripcion(PreInscripcionQueryFilter preInscripcionQueryFilter);
    }
}
