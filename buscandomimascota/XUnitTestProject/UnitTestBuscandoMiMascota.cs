using Xunit;
using buscandomimascota;
using System;
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
        public void VerificarCrearMascota()
        {
            DateTime date1 = new DateTime(2020,10,10);
            BuscandoMascotaAdmin administrador = new BuscandoMascotaAdmin();
            administrador.AgregarMascota("nombre", Mascota.tipoMascota.Perro, date1,"");
            Assert.True(administrador.CantidadMascotas() > 0, "No se creo la mascota");
        }

        [Fact]
        public void VerificarDatosMascota()
        {
            BuscandoMascotaAdmin administrador = new BuscandoMascotaAdmin();
            administrador.AgregarMascota("Bobby", Mascota.tipoMascota.Perro, new DateTime(2019, 12, 12), "Pepito");
            Mascota mascota = administrador.ObtenerDatosMascota("Bobby");
            Assert.Equal("Bobby", mascota.Nombre);
            Assert.Equal("Perro", mascota.Tipo);
            Assert.Equal(new DateTime(2019, 12, 12), mascota.FechaPerdido);
        }

        [Fact]
        public void VerificarCrearDuenho()
        {
            BuscandoMascotaAdmin administrador = new BuscandoMascotaAdmin();
            administrador.AgregarMascota("Boby", Mascota.tipoMascota.Perro, new DateTime(2019, 12, 12), "Pepo");
            administrador.AgregarDuenho("Jose", "apellido", 123, "usuario", "pass");
            Duenho duenho = administrador.ObtenerDatosDuenho("Jose");
            duenho.email = "a@a";
            Console.WriteLine(duenho.email);
            Assert.Equal("Jose", duenho.Nombre);
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
    }
}
