using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class ETareasJustificacionRechazo
{
    public int CnIdTarea { get; set; }

    public DateTime CfFechaHoraRechazo { get; set; }

    public string CtDescripcionRechazo { get; set; } = null!;

    public int CnIdTareaRechazo { get; set; }

    public virtual ETareas CnIdTareaNavigation { get; set; } = null!;
}
