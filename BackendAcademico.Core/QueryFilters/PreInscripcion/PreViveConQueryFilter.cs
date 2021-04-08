namespace BackendAcademico.Core.QueryFilters.PreInscripcion
{
    public class PreViveConQueryFilter
    {
        public int IdPreInscripcion { get; set; }
        public int ValorViveCon { get; set; }
        public string NombreTutor { get; set; }
        public string Telefonos { get; set; }
        public string Celulares { get; set; }
        public bool TieneProblemasSalud { get; set; }
        public string ProblemaSaludDetalle { get; set; }
    }
}
