using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class ETiposDocumentos
{
    public int CnIdTipoDocumento { get; set; }

    public string CtNombreTipoDocumento { get; set; } = null!;

    public virtual ICollection<EBitacoraAcciones> EBitacoraAcciones { get; set; } = new List<EBitacoraAcciones>();
}
