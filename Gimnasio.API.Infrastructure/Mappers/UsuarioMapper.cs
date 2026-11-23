using Gimnasio.API.Domain.Entities;
using Gimnasio.API.Infrastructure.Persistence.Models;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.API.Infrastructure.Mappers
{
    [Mapper]
    public partial class UsuarioMapper
    {
        public partial Domain.Entities.Usuario ToModel(Persistence.Models.Usuario usuario);

        public partial Persistence.Models.Usuario ToDomain(Domain.Entities.Usuario model);
    }
}
