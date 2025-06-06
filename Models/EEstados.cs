using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class EEstados
{
    public byte CnIdEstado { get; set; }

    public string CtEstado { get; set; } = null!;

    public string? CtDescripcion { get; set; }

    public virtual ICollection<EBitacoraCambioEstados> EBitacoraCambiosEstadoCnIdEstadoAnteriorNavigations { get; set; } = new List<EBitacoraCambioEstados>();

    public virtual ICollection<EBitacoraCambioEstados> EBitacoraCambiosEstadoCnIdEstadoNuevoNavigations { get; set; } = new List<EBitacoraCambioEstados>();

    public virtual ICollection<EPermisos> EPermisos { get; set; } = new List<EPermisos>();

    public virtual ICollection<ETareas> ETareas { get; set; } = new List<ETareas>();
}
