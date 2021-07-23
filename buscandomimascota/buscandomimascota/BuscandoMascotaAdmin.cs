using System;
using System.Collections.Generic;

namespace buscandomimascota
{
    public class BuscandoMascotaAdmin
    {
        private List<Usuario> listaUsuarios = new List<Usuario>();
        private List<Mascota> listaMascota = new List<Mascota>();

        public void AgregarUsuario(string nombre, string apellido, int telf, string usuario, string password)
        {
                Usuario newUser = new Usuario(nombre, apellido, telf, usuario, password);
                listaUsuarios.Add(newUser);
        }
        public void AgregarMascota(string nombre, Mascota.tipoMascota tipoMascota, DateTime fechaPerdido, string usuario)
        {
            Mascota newMascota = new Mascota(nombre, tipoMascota, fechaPerdido, usuario);
            listaMascota.Add(newMascota);
        }    

        public int CantidadUsuarios()
        {
            return listaUsuarios.Count;
        }
        
        public int CantidadMascotas()
        {
            return listaMascota.Count;
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

        public Mascota ObtenerDatosMascota(string nombreMascota)
        {
            foreach (Mascota mascotas in listaMascota)
            {
                if (nombreMascota == mascotas.Nombre)
                {
                    return mascotas;
                }
            };
            return null;
        }

    }

    
}

