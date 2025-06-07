using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class EPrioridades
{
    public byte CnIdPrioridad { get; set; }

    public string CtNombrePrioridad { get; set; } = null!;

    public string CtDescripcionPrioridad { get; set; } = null!;

    public virtual ICollection<ETareas> ETareas { get; set; } = new List<ETareas>();
}
