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
    /// <summary>
    /// Mapeo entre la entidad de dominio y el modelo de persistencia.
    /// RequiredMapping.None: los miembros sin correspondencia (Version rowversion,
    /// PasswordHash, navegaciones, campos de auditoría) se dejan intencionalmente sin mapear;
    /// los campos de negocio comparten nombre en ambos lados y se mapean automáticamente.
    /// </summary>
    [Mapper(RequiredMappingStrategy = RequiredMappingStrategy.None)]
    public partial class UsuarioMapper
    {
        public partial Persistence.Models.Usuario ToPersistence(Domain.Entities.Usuario usuario);

        public partial Domain.Entities.Usuario ToDomain(Persistence.Models.Usuario model);
    }
}
