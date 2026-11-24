using Gimnasio.API.Application.Interfaces.Repositories;
using Gimnasio.API.Domain.Entities;
using Gimnasio.API.Infrastructure.Mappers;
using Gimnasio.API.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.API.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly GimnasioDbContext _context;
        private readonly UsuarioMapper _mapper;

        public UsuarioRepository(GimnasioDbContext context, UsuarioMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AgregarAsync(Usuario usuario)
        {
            var model = _mapper.ToPersistence(usuario);

            await _context.Usuarios.AddAsync(model);
            await _context.SaveChangesAsync();
        }
    }
}
