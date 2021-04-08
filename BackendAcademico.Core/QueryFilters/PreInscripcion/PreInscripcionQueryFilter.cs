using System.Collections.Generic;

namespace BackendAcademico.Core.QueryFilters.PreInscripcion
{
   public class PreInscripcionQueryFilter
    {
        public int IdPreInscripcion { get; set; }
        public InformacionGeneralQueryFilter InformacionGeneral  { get; set; }
        public PreDatosPersonalesQueryFilter DatosPersonales { get; set; }
        public PreColegioQueryFilter DatosColegio { get; set; }
        public PreDatosPadresQueryFilter DatosPadre { get; set; }
        public PreDatosPadresQueryFilter DatosMadre { get; set; }
        public List<PreAutorizacionesQueryFilter> Autorizaciones { get; set; }
        public List<PreHermanosQueryFilter> Hermanos { get; set; }
        public PreDiscapacidadesQueryFilter Discapacidades { get; set; }
        public PreViveConQueryFilter ViveCon { get; set; }
    }
}
