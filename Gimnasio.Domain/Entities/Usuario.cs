using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.API.Domain.Entities
{
    /// <summary>
    /// Entidad de dominio de Usuario.
    /// Los nombres de propiedades coinciden con
    /// Gimnasio.API.Infrastructure.Persistence.Models.Usuario
    /// para que el mapeo con Mapperly sea automático.
    /// </summary>
    public class Usuario
    {
        public int UsuarioId { get; set; }

        /// <summary>Gimnasio (tenant) al que pertenece el usuario. Obligatorio.</summary>
        public int GimnasioId { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string ApellidoPaterno { get; set; } = string.Empty;

        public string? ApellidoMaterno { get; set; }

        public string Correo { get; set; } = string.Empty;

        public string? Telefono { get; set; }

        public string TipoAutenticacion { get; set; } = string.Empty;

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaActualizacion { get; set; }

        public Usuario()
        {
        }

        public Usuario(string nombre, string apellidoPaterno, string correo, int gimnasioId, string tipoAutenticacion = "Local")
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre es obligatorio.", nameof(nombre));

            if (string.IsNullOrWhiteSpace(apellidoPaterno))
                throw new ArgumentException("El apellido paterno es obligatorio.", nameof(apellidoPaterno));

            if (string.IsNullOrWhiteSpace(correo))
                throw new ArgumentException("El correo es obligatorio.", nameof(correo));

            if (gimnasioId <= 0)
                throw new ArgumentException("El gimnasio (GimnasioId) es obligatorio.", nameof(gimnasioId));

            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            Correo = correo;
            GimnasioId = gimnasioId;
            TipoAutenticacion = tipoAutenticacion;
            Activo = true;
            FechaCreacion = DateTime.UtcNow;
        }
    }
}
