using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class TTareasJustificacionRechazo
{
    public int CnIdTarea { get; set; }

    public DateTime CfFechaHoraRechazo { get; set; }

    public string CtDescripcionRechazo { get; set; } = null!;

    public int CnIdTareaRechazo { get; set; }

    public virtual TTareas CnIdTareaNavigation { get; set; } = null!;
}
