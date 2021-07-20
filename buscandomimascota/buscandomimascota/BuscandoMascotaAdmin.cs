using System;
using System.Collections.Generic;

namespace buscandomimascota
{
    public class BuscandoMascotaAdmin
    {
        private List<Usuario> listaUsuarios = new List<Usuario>();
        private List<Mascota> listaMascotas = new List<Mascota>();

        public void AgregarUsuario(string nombre, string apellido, int telf, string usuario, string password)
        {
            if (!UsuarioExists(usuario))
            {
                Usuario newUser = new Usuario(nombre, apellido, telf, usuario, password);
                listaUsuarios.Add(newUser);
            }
            else
                Console.WriteLine("El nombre de usuario ya existe.");
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

        public Boolean UsuarioExists(string nombreUsuario)
        {

            foreach (Usuario usuarios in listaUsuarios)
            {
                if (nombreUsuario == usuarios.NombreUsuario)
                {
                    return true;
                }
            };
            return false;

        }

        public void AgregarMascota(string nombre, int edad, string tipoMascota, DateTime fechaPerdido, string descripcion)
        {
            Mascota newPet = new Mascota(nombre, edad, tipoMascota, fechaPerdido, descripcion);
            listaMascotas.Add(newPet);
        }

        public int CantidadMascotas()
        {
            return listaMascotas.Count;
        }

        public Mascota ObtenerDatosMascota(string nombreMascota)
        {
            foreach (Mascota mascotas in listaMascotas)
            {
                if (nombreMascota == mascotas.NombreMascota)
                {
                    return mascotas;
                }
            };
            return null;
        }

        public List<Usuario> Listausuarios { get { return listaUsuarios; } }

    }
}
