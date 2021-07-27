using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buscandomimascota
{
  public class Duenho : Usuario
  {
    //private List<Mascota> mascotas;
    public string email { get; set; }

    public Duenho(string nombre, string apellido, int telefono, string usuario, string password, List<Mascota> mascotas) : base(nombre, apellido, telefono, usuario, password)
    {
      //this.mascotas = mascotas;
      this.Mascotas = mascotas;
    }

    public List<Mascota> Mascotas{ get; set; }
  }
}
