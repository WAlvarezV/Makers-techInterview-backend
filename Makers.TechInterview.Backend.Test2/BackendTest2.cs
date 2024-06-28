namespace Makers.TechInterview.Backend.Test2
{
    /// <summary>
    /// The backend test2.
    /// </summary>
    public class BackendTest2 : IBackendTest2
    {
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<ClaseResultado> StartAbc()
        {
            /*
            public async IEnumerable<ClaseResultado> abc() // nombre del método no descriptivo, mlas uso de la plabra async, no se esta trabajando con programación asincrona
            {
                var repositorio = new claseRepositorio(); // nombre de la clase respositorio debería iniciar con mayuscula, y se debería usar inyección de dependencias para in inicializar clases en un método
                Libro newLibro = repositorio.ObtenerLibros(); // se espera un listado por lo cual no debería se una declaración de instancia de clase
                AutorLibro newAutor = repositorio.ObtenerAutores(); // se espera un listado por lo cual no debería se una declaración de instancia de clase
                Ciudades newCiudad = repositorio.ObtenerCiudad(); // el método esta nombrado como para obtener una ciudad sin embargoi no recibe por ejemplo un identificados paara buscarla
                                                                  // adicional no se usa esta variable asi que se podría omitir en el método
                var result = from l in newLibro
                             join a in newAutor on l.AutorId = a.AutorId
                             group a by a.Nombre into g
                             select new ClaseResultado()
                             {
                                 Nombre = a.Nombre
                                 Total = a.Count(x => x.Total)
                             }
            // consulta linq que realiza un join entre lo que sería el listado de libros y autores, y dando como resultado un listado de cada autor 
            // y la cantidad de libros por autor


                if (result.Count() > 0) // validación de resultados, se podrís usar Any();
                    return result.ToList(); // innecesaria conversión o boxing de el resultado al 
                return new claseResultado(); // si no hay resultados devuelve uns instancia de la clase generando excepción porque se espera un listado de intancias de esta clase
            }
            */
            return abc();

        }

        internal IEnumerable<ClaseResultado> abc()
        {
            var repositorio = new Repositorio();
            IEnumerable<Libro> newLibro = repositorio.ObtenerLibros();
            IEnumerable<AutorLibro> newAutor = repositorio.ObtenerAutores();
            Ciudad newCiudad = repositorio.ObtenerCiudad();
            var result = from l in newLibro
                         join a in newAutor on l.AutorId equals a.AutorId
                         group new { a } by new { a.Nombre } into g
                         select new ClaseResultado()
                         {
                             Nombre = g.Key.Nombre,
                             Total = g.Count(),
                         };

            if (result.Any())
                return result;

            return Enumerable.Empty<ClaseResultado>();
        }

        public void StartObtenerLibros() => ObtenerLibros();

        internal IEnumerable<LibroResultadoDto> ObtenerLibros()
        {
            var repositorio = new Repositorio();
            IEnumerable<Libro> libros = repositorio.ObtenerLibros();
            IEnumerable<AutorLibro> autores = repositorio.ObtenerAutores();
            IEnumerable<Ciudad> ciudades = repositorio.ObtenerCiudades();
            var result = from l in libros
                         join a in autores on l.AutorId equals a.AutorId
                         join c in ciudades on a.CiudadId equals c.CiudadId
                         group new { l } by new { l } into g
                         select new LibroResultadoDto(Libro: g.Key.l, NombreLibro: g.Key.l.Nombre, CiudadAutor: g.Key.l.Autor.Ciudad);

            if (result.Any())
                return result;

            return Enumerable.Empty<LibroResultadoDto>();
        }
    }
}
