using Gimnasio.API.Application.DTOs.Common;
using Gimnasio.API.Application.DTOs.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.API.Application.Interfaces.Services
{
    public interface IUsuarioService
    {
        Task<ResultadoDto> CrearAsync(CrearUsuarioDto dto);
    }
}
