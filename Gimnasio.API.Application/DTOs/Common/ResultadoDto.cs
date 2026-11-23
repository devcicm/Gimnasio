using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.API.Application.DTOs.Common
{
    public class ResultadoDto
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; } = string.Empty;
    }
}
