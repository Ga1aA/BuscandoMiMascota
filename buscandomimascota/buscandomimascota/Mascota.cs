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
        private string tipo;
        private DateTime fechaPerdido;
        private string usuario;
        public enum tipoMascota { Perro, Gato, Loro, Hamster };


        public Mascota(string nombre, tipoMascota tipoMascota, DateTime fechaPerdido, string usuario)
         {
            this.nombre = nombre;
            this.tipo = tipoMascota.ToString();
            this.fechaPerdido = fechaPerdido;
            this.usuario = usuario;
            
         }
        public string Nombre { get { return nombre; } }
        public string Tipo { get { return tipo; } }
        public string Propietario { get { return usuario; } }
        public DateTime FechaPerdido { get { return fechaPerdido; } }
    }
        
}