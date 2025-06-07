using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class TTiposDocumentos
{
    public int CnIdTipoDocumento { get; set; }

    public string CtNombreTipoDocumento { get; set; } = null!;

    public virtual ICollection<TBitacoraAcciones> TBitacoraAcciones { get; set; } = new List<TBitacoraAcciones>();
}
