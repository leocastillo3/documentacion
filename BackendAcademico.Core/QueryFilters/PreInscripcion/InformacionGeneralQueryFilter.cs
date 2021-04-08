namespace BackendAcademico.Core.QueryFilters.PreInscripcion
{
    using System;

    public class InformacionGeneralQueryFilter
    {
        public int IdPreInscripcion { get; set; }
        public int IdCarrera { get; set; }
        public int IdPeriodoAcademico { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public string Observacion { get; set; }
        public int EstadoTransaccion { get; set; }


    }
}
