using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.API.Domain.Entities
{
    public class Usuario
    {
        public int IdUsuario { get; private set; }

        public string Nombre { get; private set; } = string.Empty;

        public Usuario(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre es obligatorio.");

            Nombre = nombre;
        }
    }
}
