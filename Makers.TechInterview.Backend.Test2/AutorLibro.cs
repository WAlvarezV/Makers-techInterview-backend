namespace Makers.TechInterview.Backend.Test2
{
    /// <summary>
    /// Correciones, los tipos de datos estaban despues del nombre de la propiedad
    /// no contaba con los modificadores para la encapsulación de los mismos
    /// CiudadId no tenía tipo de dato, siguiendo la misma línea de identificadores se asignó un tipo int
    /// </summary>
    internal class AutorLibro
    {
        /// <summary>
        /// Gets or Sets the autor id.
        /// </summary>
        public int AutorId { get; set; }
        /// <summary>
        /// Gets or Sets the nombre.
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Gets or Sets the ciudad id.
        /// </summary>
        public int CiudadId { get; set; }
        public virtual Ciudad Ciudad { get; set; }
    }
}
