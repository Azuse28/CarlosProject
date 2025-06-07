using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class TPantallas
{
    public int CnIdPantalla { get; set; }

    public string? CtDescripcion { get; set; }

    public virtual ICollection<TBitacoraAcciones> TBitacoraAcciones { get; set; } = new List<TBitacoraAcciones>();

    public virtual ICollection<TiRolXPantallaXAccion> TiRolXPantallaXAccions { get; set; } = new List<TiRolXPantallaXAccion>();
}
