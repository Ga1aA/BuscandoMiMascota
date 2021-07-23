using System;
using Xunit;
using buscandomimascota;
using buscandomimascota.Exceptions;

namespace XUnitTestProject
{
    public class UnitTestBuscandoMiMascota
    {
        [Fact]
        public void CrearUsuario()
        {
            BuscandoMascotaAdmin administrador = new BuscandoMascotaAdmin();
            administrador.AgregarUsuario("nombre", "apellido", 123, "usuario", "pass");
            Assert.True(administrador.CantidadUsuarios() > 0, "No se creo el usuario");
        }

        [Fact]
        public void VerificarDatosUsuario()
        {
            BuscandoMascotaAdmin administrador = new BuscandoMascotaAdmin();
            administrador.AgregarUsuario("nombre", "apellido", 123, "usuario", "pass");
            Usuario usuario = administrador.ObtenerDatosUsuario("usuario");
            Assert.Equal("nombre", usuario.Nombre);
            Assert.Equal(123, usuario.Telf);
        }

        [Fact]
        public void VerificarCreacionUsuarioDuplicado()
        {
            BuscandoMascotaAdmin administrador = new BuscandoMascotaAdmin();
            administrador.AgregarUsuario("Robert", "Bateon", 72778944, "Robey", "rbateon123");
            try
            {
                administrador.AgregarUsuario("Robertinho", "Nieves", 78948955, "Robey", "jnieves00");
            }
            catch (ExcepcionDeUsuario e)
            {
                Assert.True(e.Message == "El nombre de usuario ya existe", e.Message);
            }
            Assert.True(administrador.CantidadUsuarios() == 1, "Existen 2 usuarios con el mismo nombre");
        }

        //Crear una Mascota
        //Verificar datos mascota
        //Crear un duenho
        //Anhadir vacuna a mascota
        //Verificar que no se creen dos Usuarios con el mismo NombreUsuario
    }
}
