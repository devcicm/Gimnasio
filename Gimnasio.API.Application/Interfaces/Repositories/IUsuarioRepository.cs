using Gimnasio.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.API.Application.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        Task AgregarAsync(Usuario usuario);
    }
}
