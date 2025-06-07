using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class EOficinas
{
    public int CnCodigoOficina { get; set; }

    public string CtNombreOficina { get; set; } = null!;

    public int? CnOficinaEncargada { get; set; }

    public virtual ICollection<EUsuarios> CnIdUsuarios { get; set; } = new List<EUsuarios>();
}
