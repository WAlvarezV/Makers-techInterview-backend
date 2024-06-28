namespace Makers.TechInterview.Backend.Test2
{
    /// <summary>
    /// Correciones, los tipos de datos estaban despues del nombre de la propiedad
    /// no contaba con los modificadores para la encapsulación de los mismos
    /// AnioPublicacion no tenía punto y como en el set
    /// </summary>
    internal class Libro
    {
        /// <summary>
        /// Gets or Sets the libro id.
        /// </summary>
        public int LibroId { get; set; }
        /// <summary>
        /// Gets or Sets the nombre.
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Gets or Sets the anio publicacion.
        /// </summary>
        public int AnioPublicacion { get; set; }
        /// <summary>
        /// Gets or Sets the autor id.
        /// </summary>
        public int AutorId { get; set; }
        public virtual AutorLibro Autor { get; set; }
    }
}
