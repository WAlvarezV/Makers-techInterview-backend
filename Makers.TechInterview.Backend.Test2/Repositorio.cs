namespace Makers.TechInterview.Backend.Test2
{
    /// <summary>
    /// The repositorio.
    /// </summary>
    internal class Repositorio : IRepositorio
    {
        /// <summary>
        /// Obteners the libros.
        /// </summary>
        /// <returns><![CDATA[IEnumerable<Libro>]]></returns>
        public IEnumerable<Libro> ObtenerLibros()
        {
            return Enumerable.Empty<Libro>();
        }

        /// <summary>
        /// Obteners the autores.
        /// </summary>
        /// <returns><![CDATA[IEnumerable<AutorLibro>]]></returns>
        public IEnumerable<AutorLibro> ObtenerAutores()
        {
            return Enumerable.Empty<AutorLibro>();
        }


        /// <summary>
        /// Obteners the ciudad.
        /// </summary>
        /// <returns>A Ciudad.</returns>
        public Ciudad ObtenerCiudad()
        {
            return new();
        }

        public IEnumerable<Ciudad> ObtenerCiudades()
        {
            return Enumerable.Empty<Ciudad>();
        }
    }
}
