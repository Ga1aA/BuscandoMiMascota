using System;
using System.Collections.Generic;
using buscandomimascota.Exceptions;

namespace buscandomimascota
{
    public class BuscandoMascotaAdmin
    {
        private List<Usuario> listaUsuarios = new List<Usuario>();
        private List<Mascota> listaMascota = new List<Mascota>();

        public void AgregarUsuario(string nombre, string apellido, int telf, string usuario, string password)
        {
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
        public void AgregarMascota(string nombre, Mascota.tipoMascota tipoMascota, DateTime fechaPerdido, string usuario)
        {
            Mascota newMascota = new Mascota(nombre, tipoMascota, fechaPerdido, usuario);
            listaMascota.Add(newMascota);
        }

    public void AgregarDuenho(string nombre, string apellido, int telf, string usuario, string password)
    {
          Mascota ultimaMascota = listaMascota[listaMascota.Count - 1];
          Duenho newDuenho = new Duenho(nombre, apellido, telf, usuario, password, ultimaMascota);
          listaUsuarios.Add(newDuenho);
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

        public Duenho ObtenerDatosDuenho(string usuarioEsDuenho)
        {
          foreach (Duenho duenho in listaUsuarios)
          {
            if (typeof(Duenho).ToString().Contains("Duenho"))
            {
              return duenho;
            }
          }
          return null;
        }

  }
}

