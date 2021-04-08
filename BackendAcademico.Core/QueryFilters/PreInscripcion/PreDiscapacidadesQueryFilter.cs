using System.Collections.Generic;

namespace BackendAcademico.Core.QueryFilters.PreInscripcion
{
    public class PreDiscapacidadesQueryFilter
    {
        public int IdPreInscripcion { get; set; }
        public bool RequiereApoyoEnsenianza { get; set; }
        public bool PresentaTrastornoAprendizaje { get; set; }
        public bool PresentaDiscapacidad { get; set; }
        public bool TieneTrastorno { get; set; }
        public List<PreDiscapacidadDetalleQueryFilter> TrastornosAprendizajeDetalle { get; set; }
        public List<PreDiscapacidadDetalleQueryFilter> DiscapacidadesDetalle { get; set; }
        public List<PreDiscapacidadDetalleQueryFilter> TrastornosDetalle { get; set; }

    }
}
