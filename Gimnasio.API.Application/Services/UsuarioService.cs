using Gimnasio.API.Application.DTOs.Common;
using Gimnasio.API.Application.DTOs.Usuarios;
using Gimnasio.API.Application.Interfaces.Repositories;
using Gimnasio.API.Application.Interfaces.Services;
using Gimnasio.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.API.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<ResultadoDto> CrearAsync(CrearUsuarioDto dto)
        {
            try
            {
                var usuario = new Usuario(dto.Nombre, dto.ApellidoPaterno, dto.Correo, dto.GimnasioId, dto.TipoAutenticacion)
                {
                    ApellidoMaterno = dto.ApellidoMaterno,
                    Telefono = dto.Telefono,
                };

                await _usuarioRepository.AgregarAsync(usuario);

                return new ResultadoDto
                {
                    Exitoso = true,
                    Mensaje = "Usuario registrado correctamente."
                };
            }
            catch (ArgumentException ex)
            {
                return new ResultadoDto
                {
                    Exitoso = false,
                    Mensaje = ex.Message
                };
            }
        }
    }
}
