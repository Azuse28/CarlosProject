using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class EiNotificacionesXUsuarios
{
    public int CnIdNotificacion { get; set; }

    public int CnIdUsuario { get; set; }

    public string CtCorreoDestino { get; set; } = null!;

    public virtual ENotificaciones CnIdNotificacionNavigation { get; set; } = null!;

    public virtual EUsuarios CnIdUsuarioNavigation { get; set; } = null!;
}
