namespace BackendAcademico.Core.CustomEntities
{
    public class Pagination
    {
        public int TotalRegistros { get; set; }
        public int TamanoDePagina { get; set; }
        public int PaginaActual { get; set; }
        public int TotalPaginas { get; set; }
        public bool TienePaginaAnterior { get; set; }
        public bool TienePaginaSiguiente { get; set; }
    }
}