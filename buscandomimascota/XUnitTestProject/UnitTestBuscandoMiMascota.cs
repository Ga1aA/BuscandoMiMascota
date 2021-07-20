using Xunit;
using buscandomimascota;

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

        //Crear una Mascota
        //Verificar datos mascota
        //Crear un duenho
        //Anhadir vacuna a mascota
        //Verificar que no se creen dos Usuarios con el mismo NombreUsuario
    }
}
