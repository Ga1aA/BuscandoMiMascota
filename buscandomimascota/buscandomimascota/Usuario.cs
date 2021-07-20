namespace buscandomimascota
{
    public class Usuario
    {
        private string nombre;
        private string apellido;
        private int telf;
        private string usuario;
        private string password;

        public Usuario(string nombre, string apellido, int telefono, string usuario, string password)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telf = telefono;
            this.usuario = usuario;
            this.password = password;
        }
        public string Nombre { get { return nombre; } }
        public int Telf { get { return telf; } }
        public string NombreUsuario { get { return usuario; } }
    }
}
