using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class ConfiguracionGeneral
{
    public int GimnasioId { get; set; }

    public int ConfiguracionGeneralId { get; set; }

    public string Moneda { get; set; } = null!;

    public string Pais { get; set; } = null!;

    public string Idioma { get; set; } = null!;

    public string ZonaHoraria { get; set; } = null!;

    public string FormatoFecha { get; set; } = null!;

    public string FormatoHora { get; set; } = null!;

    public bool PermitirAccesoSocios { get; set; }

    public bool PermitirReservaciones { get; set; }

    public bool PermitirVentaSinSocio { get; set; }

    public bool PermitirSaldoAfavor { get; set; }

    public bool NotificarMembresiaPorVencer { get; set; }

    public int DiasAnticipacionVencimiento { get; set; }

    public bool NotificarMembresiaVencida { get; set; }

    public bool NotificarInasistencia { get; set; }

    public DateTime FechaActualizacion { get; set; }

    public virtual CatGimnasio Gimnasio { get; set; } = null!;
}
