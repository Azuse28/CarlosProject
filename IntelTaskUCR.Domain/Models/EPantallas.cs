using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class EPantallas
{
    public int CnIdPantalla { get; set; }

    public string? CtDescripcion { get; set; }

    public virtual ICollection<EBitacoraAcciones> EBitacoraAcciones { get; set; } = new List<EBitacoraAcciones>();

    public virtual ICollection<EiRolXPantallaXAccion> EiRolXPantallaXAccions { get; set; } = new List<EiRolXPantallaXAccion>();
}
