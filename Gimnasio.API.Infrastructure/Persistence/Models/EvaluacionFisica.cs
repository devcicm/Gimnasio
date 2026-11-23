using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class EvaluacionFisica
{
    public long EvaluacionFisicaId { get; set; }

    public int SocioId { get; set; }

    public int? InstructorId { get; set; }

    public int UsuarioRegistroId { get; set; }

    public DateTime FechaEvaluacion { get; set; }

    public decimal? PesoKg { get; set; }

    public decimal? EstaturaCm { get; set; }

    public decimal? PorcentajeGrasa { get; set; }

    public decimal? PorcentajeMusculo { get; set; }

    public decimal? Imc { get; set; }

    public decimal? MedidaPechoCm { get; set; }

    public decimal? MedidaCinturaCm { get; set; }

    public decimal? MedidaCaderaCm { get; set; }

    public decimal? MedidaBrazoCm { get; set; }

    public decimal? MedidaPiernaCm { get; set; }

    public string? Observaciones { get; set; }

    public virtual Instructor? Instructor { get; set; }

    public virtual Socio Socio { get; set; } = null!;

    public virtual Usuario UsuarioRegistro { get; set; } = null!;
}
