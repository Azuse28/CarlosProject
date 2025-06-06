using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class TEstados
{
    public byte CnIdEstado { get; set; }

    public string CtEstado { get; set; } = null!;

    public string? CtDescripcion { get; set; }

    public virtual ICollection<TBitacoraCambioEstados> TBitacoraCambiosEstadoCnIdEstadoAnteriorNavigations { get; set; } = new List<TBitacoraCambioEstados>();

    public virtual ICollection<TBitacoraCambioEstados> TBitacoraCambiosEstadoCnIdEstadoNuevoNavigations { get; set; } = new List<TBitacoraCambioEstados>();

    public virtual ICollection<TPermisos> TPermisos { get; set; } = new List<TPermisos>();

    public virtual ICollection<TTareas> TTareas { get; set; } = new List<TTareas>();
}
