using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class TOficinas
{
    public int CnCodigoOficina { get; set; }

    public string CtNombreOficina { get; set; } = null!;

    public int? CnOficinaEncargada { get; set; }

    public virtual ICollection<TUsuarios> CnIdUsuarios { get; set; } = new List<TUsuarios>();
}
