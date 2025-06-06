using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class TiRolXPantallaXAccion
{
    public int CnIdPantalla { get; set; }

    public int CnIdAccion { get; set; }

    public int CnIdRol { get; set; }

    public virtual TAcciones CnIdAccionNavigation { get; set; } = null!;

    public virtual TPantallas CnIdPantallaNavigation { get; set; } = null!;

    public virtual TRoles CnIdRolNavigation { get; set; } = null!;
}
