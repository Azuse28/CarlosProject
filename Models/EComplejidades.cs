using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class EComplejidades
{
    public byte CnIdComplejidad { get; set; }

    public string CtNombre { get; set; } = null!;

    public virtual ICollection<ETareas> ETareas { get; set; } = new List<ETareas>();
}
