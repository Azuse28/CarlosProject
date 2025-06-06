using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class TDiasNoHabiles
{
    public int CnIdDiasNoHabiles { get; set; }

    public DateOnly CfFechaInicio { get; set; }

    public DateOnly CfFechaFin { get; set; }

    public string CtDescripcion { get; set; } = null!;

    public bool CbActivo { get; set; }
}
