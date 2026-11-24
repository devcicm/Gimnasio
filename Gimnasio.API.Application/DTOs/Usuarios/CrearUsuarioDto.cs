using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.API.Application.DTOs.Usuarios
{
    /// <summary>
    /// Datos para registrar un usuario.
    /// NOTA: GimnasioId se recibe temporalmente en el cuerpo; en Fase 1
    /// vendrá del token JWT (tenant context) y se eliminará del DTO.
    /// </summary>
    public class CrearUsuarioDto
    {
        public int GimnasioId { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string ApellidoPaterno { get; set; } = string.Empty;

        public string? ApellidoMaterno { get; set; }

        public string Correo { get; set; } = string.Empty;

        public string? Telefono { get; set; }

        public string TipoAutenticacion { get; set; } = "Local";
    }
}
