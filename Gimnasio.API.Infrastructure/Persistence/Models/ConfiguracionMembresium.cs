using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class ConfiguracionMembresium
{
    public int ConfiguracionMembresiaId { get; set; }

    public bool PermitirCambiosPlan { get; set; }

    public bool ConservarDiasRestantes { get; set; }

    public string PoliticaCambioPlanMayor { get; set; } = null!;

    public string PoliticaCambioPlanMenor { get; set; } = null!;

    public bool PermitirCancelarFuturas { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public byte[] Version { get; set; } = null!;
}
