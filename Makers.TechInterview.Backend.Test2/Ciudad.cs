namespace Makers.TechInterview.Backend.Test2
{
    /// <summary>
    /// Correciones, los tipos de datos estaban despues del nombre de la propiedad
    /// no contaba con los modificadores para la encapsulación de los mismos
    /// CiudadId no tenía tipo de dato, siguiendo la misma línea de identificadores se asignó un tipo int
    /// Nommbre se asigna de tipo string y se corrigé el ger por get
    /// Se le cambia el nombre al tratarse de una entidad la cual debería manejar nombre en singular
    /// </summary>
    internal class Ciudad
    {
        /// <summary>
        /// Gets or Sets the ciudad id.
        /// </summary>
        public int CiudadId { get; set; }
        /// <summary>
        /// Gets or Sets the nombre.
        /// </summary>
        public string Nombre { get; set; }

    }
}
