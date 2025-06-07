using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class ENotificaciones
{
    public int CnIdNotificacion { get; set; }

    public int CnTipoNotificacion { get; set; }

    public string CtTituloNotificacion { get; set; } = null!;

    public string CtTextoNotificacion { get; set; } = null!;

    public string CtCorreoOrigen { get; set; } = null!;

    public DateTime CfFechaRegistro { get; set; }

    public DateTime CfFechaNotificacion { get; set; }

    public int? CnIdRecordatorio { get; set; }

    public virtual EFrecuenciaRecordatorio? CnIdRecordatorioNavigation { get; set; }

    public virtual ICollection<EiNotificacionesXUsuarios> EiNotificacionesXUsuarios { get; set; } = new List<EiNotificacionesXUsuarios>();
}
