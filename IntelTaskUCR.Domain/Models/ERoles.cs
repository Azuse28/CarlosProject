using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class ERoles
{
    public int CnIdRol { get; set; }

    public string? CtNombreRol { get; set; }

    public int? CnJerarquia { get; set; }

    public virtual ICollection<EUsuarios> EUsuarios { get; set; } = new List<EUsuarios>();

    public virtual ICollection<EiRolXPantallaXAccion> EiRolXPantallaXAccions { get; set; } = new List<EiRolXPantallaXAccion>();
}
