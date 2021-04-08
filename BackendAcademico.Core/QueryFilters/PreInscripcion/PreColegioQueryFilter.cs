
namespace BackendAcademico.Core.QueryFilters.PreInscripcion
{
    public class PreColegioQueryFilter
    {
        public int IdPreInscripcion { get; set; }
        public int IdColegio { get; set; }
        public int IdDepartamento { get; set; }
        public int IdProvincia { get; set; }
        public int ValorTurno { get; set; }
        public int ValorTipoColegio { get; set; }
        public int AnioEgreso { get; set; }
    }
}
