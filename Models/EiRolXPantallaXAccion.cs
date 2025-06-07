using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class EiRolXPantallaXAccion
{
    public int CnIdPantalla { get; set; }

    public int CnIdAccion { get; set; }

    public int CnIdRol { get; set; }

    public virtual EAcciones CnIdAccionNavigation { get; set; } = null!;

    public virtual EPantallas CnIdPantallaNavigation { get; set; } = null!;

    public virtual ERoles CnIdRolNavigation { get; set; } = null!;
}
