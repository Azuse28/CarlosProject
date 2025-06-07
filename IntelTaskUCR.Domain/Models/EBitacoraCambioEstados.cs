using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class EBitacoraCambioEstados
{
    public int CnIdCambioEstado { get; set; }

    public int CnIdEntidadAfectada { get; set; }

    public string CtTipoEntidad { get; set; } = null!;

    public byte CnIdEstadoAnterior { get; set; }

    public byte CnIdEstadoNuevo { get; set; }

    public DateTime CfFechaHoraCambio { get; set; }

    public int CnIdUsuarioResponsable { get; set; }

    public string? CtObservaciones { get; set; }

    public virtual EEstados CnIdEstadoAnteriorNavigation { get; set; } = null!;

    public virtual EEstados CnIdEstadoNuevoNavigation { get; set; } = null!;

    public virtual EUsuarios CnIdUsuarioResponsableNavigation { get; set; } = null!;
}
