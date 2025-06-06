using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class TAcciones
{
    public int CnIdAccion { get; set; }

    public string CtDescripcionAccion { get; set; } = null!;

    public virtual ICollection<TBitacoraAcciones> TBitacoraAcciones { get; set; } = new List<TBitacoraAcciones>();

    public virtual ICollection<TiRolXPantallaXAccion> TiRolXPantallaXAccions { get; set; } = new List<TiRolXPantallaXAccion>();
}
