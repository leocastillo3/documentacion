namespace BackendAcademico.Core.QueryFilters.PreInscripcion
{
    public class PreDatosPadresQueryFilter
    {
        public int IdPreInscripcion { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public int IdDepartamento { get; set; }
        public string Telefonos { get; set; }
        public int IdProfesion  { get; set; }
        public string LugarDeTrabajo { get; set; }
        public int Tipo { get; set; }
    }
}
