using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class EBitacoraAcciones
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

    public virtual EAcciones CnIdAccionNavigation { get; set; } = null!;

    public virtual EPantallas CnIdPantallaNavigation { get; set; } = null!;

    public virtual ETiposDocumentos CnIdTipoDocumentoNavigation { get; set; } = null!;

    public virtual EUsuarios CnIdUsuarioNavigation { get; set; } = null!;
}
