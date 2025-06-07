using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class TTareasSeguimiento
{
    public int CnIdSeguimiento { get; set; }

    public int CnIdTarea { get; set; }

    public string? CtComentario { get; set; }

    public DateTime CfFechaSeguimiento { get; set; }

    public virtual TTareas CnIdTareaNavigation { get; set; } = null!;
}
