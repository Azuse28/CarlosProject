using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class TRoles
{
    public int CnIdRol { get; set; }

    public string? CtNombreRol { get; set; }

    public int? CnJerarquia { get; set; }

    public virtual ICollection<TUsuarios> TUsuarios { get; set; } = new List<TUsuarios>();

    public virtual ICollection<TiRolXPantallaXAccion> TiRolXPantallaXAccions { get; set; } = new List<TiRolXPantallaXAccion>();
}
