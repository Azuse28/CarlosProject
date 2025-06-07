using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class EAcciones
{
    public int CnIdAccion { get; set; }

    public string CtDescripcionAccion { get; set; } = null!;

    public virtual ICollection<EBitacoraAcciones> EBitacoraAcciones { get; set; } = new List<EBitacoraAcciones>();

    public virtual ICollection<EiRolXPantallaXAccion> EiRolXPantallaXAccions { get; set; } = new List<EiRolXPantallaXAccion>();
}
