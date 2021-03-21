namespace CoreEscuela.Entidades
{
    class Escuela
    {
        public string nombre { get; set; }
        public int anoCreacion { get; set; }
        public string direccion { get; set; }
        public string pais { get; set; }
        public string ciudades { get; set; }
        public TiposEscuela tipoEscuela { get; set; }

        public Escuela(string nombre) => this.nombre = nombre;

        public override string ToString()
        {
            return $"Nombre: {nombre}, Tipo: {tipoEscuela}";
        }

    }
}