using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class TUsuarios
{
    public int CnIdUsuario { get; set; }

    public string CtNombreUsuario { get; set; } = null!;

    public string CtCorreoUsuario { get; set; } = null!;

    public DateOnly? CfFechaNacimiento { get; set; }

    public string CtContrasenna { get; set; } = null!;

    public bool CbEstadoUsuario { get; set; }

    public DateOnly? CfFechaCreacionUsuario { get; set; }

    public DateOnly? CfFechaModificacionUsuario { get; set; }

    public int CnIdRol { get; set; }

    public virtual TRoles CnIdRolNavigation { get; set; } = null!;

    public virtual ICollection<TAdjuntos> TAdjuntos { get; set; } = new List<TAdjuntos>();

    public virtual ICollection<TBitacoraAcciones> TBitacoraAcciones { get; set; } = new List<TBitacoraAcciones>();

    public virtual ICollection<TBitacoraCambioEstados> TBitacoraCambiosEstados { get; set; } = new List<TBitacoraCambioEstados>();

    public virtual ICollection<TFrecuenciaRecordatorio> TFrecuenciaRecordatorios { get; set; } = new List<TFrecuenciaRecordatorio>();

    public virtual ICollection<TPermisos> TPermisos { get; set; } = new List<TPermisos>();

    public virtual ICollection<TTareas> TTareaCnUsuarioAsignadoNavigations { get; set; } = new List<TTareas>();

    public virtual ICollection<TTareas> TTareaCnUsuarioCreadorNavigations { get; set; } = new List<TTareas>();

    public virtual ICollection<TiNotificacionesXUsuarios> TiNotificacionesXUsuarios { get; set; } = new List<TiNotificacionesXUsuarios>();

    public virtual ICollection<TOficinas> CnCodigoOficinas { get; set; } = new List<TOficinas>();
}
