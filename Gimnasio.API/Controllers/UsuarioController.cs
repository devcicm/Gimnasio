using Gimnasio.API.Application.DTOs.Usuarios;
using Gimnasio.API.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gimnasio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public async Task<IActionResult> Crear(CrearUsuarioDto dto)
        {
            var resultado = await _usuarioService.CrearAsync(dto);

            return Ok(resultado);
        }
    }
}
