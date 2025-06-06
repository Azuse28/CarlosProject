using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class TAdjuntos
{
    public int CnIdAdjuntos { get; set; }

    public int CnDocumento { get; set; }

    public string CtArchivoRuta { get; set; } = null!;

    public int CnUsuarioAccion { get; set; }

    public DateTime CfFechaRegistro { get; set; }

    public virtual TTareas CnDocumento1 { get; set; } = null!;

    public virtual TPermisos CnDocumentoNavigation { get; set; } = null!;

    public virtual TUsuario CnUsuarioAccionNavigation { get; set; } = null!;
}
