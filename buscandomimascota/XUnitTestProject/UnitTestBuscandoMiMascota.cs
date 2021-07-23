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
            administrador.AgregarMascota("Bobby", 1, "Perro", new DateTime(2019, 12, 12), "Color cafe con manchas blancas.");
            Mascota mascota = administrador.ObtenerDatosMascota("Bobby");
            Assert.Equal("Bobby", mascota.NombreMascota);
            Assert.Equal("Perro", mascota.TipoMascota);
            Assert.Equal(new DateTime(2019, 12, 12), mascota.FechaPerdido);
        }
}
