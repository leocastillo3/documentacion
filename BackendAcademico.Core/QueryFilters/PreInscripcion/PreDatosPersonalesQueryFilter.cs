namespace BackendAcademico.Core.QueryFilters.PreInscripcion
{
    using System;

    public class PreDatosPersonalesQueryFilter
    {
        public int IdPreInscripcion { get; set; }
        public string DocumentoIdentidad { get; set; }
        public string NumeroRegistro { get; set; }
        public int ValorTipoDocumento{ get; set; }
        public int IdDepartamentoExpedido { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string TercerApellido { get; set; }
        public string Nombres { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdPaisNacionalidad { get; set; }
        public int IdDepartamentoNacimiento { get; set; }
        public int ValorSexo { get; set; }
        public int ValorEstadoCivil { get; set; }
        public int ValorTipoSangre { get; set; }
        public string Direccion { get; set; }
        public int IdZona { get; set; }
        public string Telefonos { get; set; }
        public string Celulares { get; set; }
        public string CorreoElectronico { get; set; }
        public bool Trabaja { get; set; }
        public string LugarDeTrabajo { get; set; }
    }
}
