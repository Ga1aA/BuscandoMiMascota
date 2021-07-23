using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buscandomimascota.Exceptions
{
    public class ExcepcionDeUsuario : Exception
    {
        public const string MensajeDeError = "Fallo al crear usuario";
        public ExcepcionDeUsuario()
        {
        }

        public ExcepcionDeUsuario(string message) : base(message)
        {
        }

        public ExcepcionDeUsuario(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}