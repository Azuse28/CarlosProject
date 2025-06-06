using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class TiNotificacionesXUsuarios
{
    public int CnIdNotificacion { get; set; }

    public int CnIdUsuario { get; set; }

    public string CtCorreoDestino { get; set; } = null!;

    public virtual TNotificaciones CnIdNotificacionNavigation { get; set; } = null!;

    public virtual TUsuario CnIdUsuarioNavigation { get; set; } = null!;
}
