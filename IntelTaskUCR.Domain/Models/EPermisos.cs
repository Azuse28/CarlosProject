using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class EPermisos
{
    public int CnIdPermiso { get; set; }

    public string? CtTituloPermiso { get; set; }

    public string CtDescripcionPermiso { get; set; } = null!;

    public byte CnIdEstado { get; set; }

    public string? CtDescripcionRechazo { get; set; }

    public DateTime CfFechaHoraRegistro { get; set; }

    public DateTime CfFechaHoraInicioPermiso { get; set; }

    public DateTime CfFechaHoraFinPermiso { get; set; }

    public int CnUsuarioCreador { get; set; }

    public virtual EEstados CnIdEstadoNavigation { get; set; } = null!;

    public virtual EUsuarios CnUsuarioCreadorNavigation { get; set; } = null!;

    public virtual ICollection<EAdjuntos> EAdjuntos { get; set; } = new List<EAdjuntos>();
}
