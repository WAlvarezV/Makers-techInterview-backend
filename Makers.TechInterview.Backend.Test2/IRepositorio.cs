
namespace Makers.TechInterview.Backend.Test2
{
    internal interface IRepositorio
    {
        IEnumerable<AutorLibro> ObtenerAutores();
        Ciudad ObtenerCiudad();
        IEnumerable<Ciudad> ObtenerCiudades();
        IEnumerable<Libro> ObtenerLibros();
    }
}