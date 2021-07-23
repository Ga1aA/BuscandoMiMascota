using Xunit;
using buscandomimascota;
using System;
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
        public void VerificarDatosMascota()
        {
            BuscandoMascotaAdmin administrador = new BuscandoMascotaAdmin();
            administrador.AgregarMascota("Bobby", "Perro", new DateTime(2019, 12, 12), "Pepito");
            Mascota mascota = administrador.ObtenerDatosMascota("Bobby");
            Assert.Equal("Bobby", mascota.Nombre);
            Assert.Equal("Perro", mascota.Tipo);
            Assert.Equal(new DateTime(2019, 12, 12), mascota.FechaPerdido);
        }
         [Fact]
        public void VerificarCrearMascota()
        {
            DateTime date1 = new DateTime(2020,10,10);
            BuscandoMascotaAdmin administrador = new BuscandoMascotaAdmin();
            administrador.AgregarMascota("nombre", "perro",date1,"");
            Assert.True(administrador.CantidadMascotas() > 0, "No se creo la mascota");
        }
    }
}
