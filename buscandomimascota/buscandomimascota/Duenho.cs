using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buscandomimascota
{
  public class Duenho : Usuario
  {
    public string email { get; set; }

    public Duenho(string nombre, string apellido, int telefono, string usuario, string password, Mascota mascota) : base(nombre, apellido, telefono, usuario, password)
    {
      this.Mascotas = new List<Mascota>();
      this.Mascotas.Add(mascota);
    }

    public List<Mascota> Mascotas{ get; set; }
  }
}
