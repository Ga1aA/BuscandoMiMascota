using buscandomimascota.Exceptions;
using System.Collections.Generic;

namespace buscandomimascota
{
    public class BuscandoMascotaAdmin
    {
        private List<Usuario> listaUsuarios = new List<Usuario>();

        public void AgregarUsuario(string nombre, string apellido, int telf, string usuario, string password)
        {
            if (nombre == string.Empty || nombre == null)
            {
                throw new ExcepcionDeUsuario("El usuario creado tiene nombre vacio");
            }

            foreach (Usuario usuariod in listaUsuarios)
            {
                if (usuario == usuariod.NombreUsuario)
                {
                    throw new ExcepcionDeUsuario("El nombre de usuario ya existe");
                }
            }

            Usuario newUser = new Usuario(nombre, apellido, telf, usuario, password);
            listaUsuarios.Add(newUser);
        }

        public int CantidadUsuarios()
        {
            return listaUsuarios.Count;
        }

        public Usuario ObtenerDatosUsuario(string nombreUsuario)
        {
            foreach (Usuario usuario in listaUsuarios)
            {
                if (nombreUsuario == usuario.NombreUsuario)
                {
                    return usuario;
                }
            };
            return null;
        }

    }
}
