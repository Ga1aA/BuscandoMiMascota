using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buscandomimascota
{
    public class Mascota
    {

        private string nombre;
        private int edad;
        private string tipoMascota;
        private DateTime fechaPerdido;
        private string descripcion;

        public Mascota(string nombre, int edad, string tipoMascota, DateTime fechaPerdido, string descripcion)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.tipoMascota = tipoMascota;
            this.fechaPerdido = fechaPerdido;
            this.descripcion = descripcion;
        }

        public string NombreMascota { get { return nombre; } }
        public string TipoMascota { get { return tipoMascota; } }
        public string Descripcion { get { return descripcion; } }
        public DateTime FechaPerdido { get { return fechaPerdido; } }

    }
}