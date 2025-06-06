using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class TRoles
{
    public int CnIdRol { get; set; }

    public string? CtNombreRol { get; set; }

    public int? CnJerarquia { get; set; }

    public virtual ICollection<TUsuario> TUsuarios { get; set; } = new List<TUsuario>();

    public virtual ICollection<TiRolXPantallaXAccion> TiRolXPantallaXAccions { get; set; } = new List<TiRolXPantallaXAccion>();
}
