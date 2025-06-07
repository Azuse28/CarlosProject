using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class TComplejidades
{
    public byte CnIdComplejidad { get; set; }

    public string CtNombre { get; set; } = null!;

    public virtual ICollection<TTareas> TTareas { get; set; } = new List<TTareas>();
}
