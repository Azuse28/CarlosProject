using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class TPermisos
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

    public virtual TEstados CnIdEstadoNavigation { get; set; } = null!;

    public virtual TUsuarios CnUsuarioCreadorNavigation { get; set; } = null!;

    public virtual ICollection<TAdjuntos> TAdjuntos { get; set; } = new List<TAdjuntos>();
}
