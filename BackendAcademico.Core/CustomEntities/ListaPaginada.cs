namespace BackendAcademico.Core.CustomEntities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ListaPaginada<T> : List<T>
    {
        public int PaginaActual { get; set; }
        public int TotalPaginas { get; set; }
        public int TamanoDePagina { get; set; }
        public int TotalRegistros { get; set; }

        public bool TienePaginaAnterior => PaginaActual > 1;
        public bool TienePaginaSiguiente => PaginaActual < TotalPaginas;
        public int? NumeroPaginaSiguiente => TienePaginaSiguiente ? PaginaActual + 1 : (int?)null;
        public int? NumeroPaginaAnterior => TienePaginaAnterior ? PaginaActual - 1 : (int?)null;

        public ListaPaginada(List<T> datos, int count, int numeroDePagina, int tamanoDePagina)
        {
            TotalRegistros = count;
            TamanoDePagina = tamanoDePagina;
            PaginaActual = numeroDePagina;
            TotalPaginas = (int)Math.Ceiling(TotalRegistros / (double)TamanoDePagina);

            AddRange(datos);
        }

        public static ListaPaginada<T> Crear(IEnumerable<T> registros, int numeroDePagina, int tamanoDePagina)
        {
            var count = registros.Count();
            var datos = registros.Skip((numeroDePagina - 1) * tamanoDePagina).Take(tamanoDePagina).ToList();
            return new ListaPaginada<T>(datos, count, numeroDePagina, tamanoDePagina);
        }
    }
}
