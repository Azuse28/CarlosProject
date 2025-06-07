using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class EAdjuntos
{
    public int CnIdAdjuntos { get; set; }

    public int CnDocumento { get; set; }

    public string CtArchivoRuta { get; set; } = null!;

    public int CnUsuarioAccion { get; set; }

    public DateTime CfFechaRegistro { get; set; }

    public virtual ETareas CnDocumento1 { get; set; } = null!;

    public virtual EPermisos CnDocumentoNavigation { get; set; } = null!;

    public virtual EUsuarios CnUsuarioAccionNavigation { get; set; } = null!;
}
