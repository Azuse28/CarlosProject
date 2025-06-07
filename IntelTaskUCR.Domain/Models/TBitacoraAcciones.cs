using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class TBitacoraAcciones
{
    public int CnIdBitacora { get; set; }

    public DateTime CfFechaHoraRegistro { get; set; }

    public int CnIdAccion { get; set; }

    public int CnIdPantalla { get; set; }

    public int CnIdUsuario { get; set; }

    public string CtInformacionImportante { get; set; } = null!;

    public int CnIdTipoDocumento { get; set; }

    /// <summary>
    /// Campo llave del documentos
    /// </summary>
    public int? CnDocumento { get; set; }

    public virtual TAcciones CnIdAccionNavigation { get; set; } = null!;

    public virtual TPantallas CnIdPantallaNavigation { get; set; } = null!;

    public virtual TTiposDocumentos CnIdTipoDocumentoNavigation { get; set; } = null!;

    public virtual TUsuarios CnIdUsuarioNavigation { get; set; } = null!;
}
