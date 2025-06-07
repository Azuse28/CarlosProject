using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class EUsuarios
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

    public virtual ERoles CnIdRolNavigation { get; set; } = null!;

    public virtual ICollection<EAdjuntos> EAdjuntos { get; set; } = new List<EAdjuntos>();

    public virtual ICollection<EBitacoraAcciones> EBitacoraAcciones { get; set; } = new List<EBitacoraAcciones>();

    public virtual ICollection<EBitacoraCambioEstados> EBitacoraCambiosEstados { get; set; } = new List<EBitacoraCambioEstados>();

    public virtual ICollection<EFrecuenciaRecordatorio> EFrecuenciaRecordatorios { get; set; } = new List<EFrecuenciaRecordatorio>();

    public virtual ICollection<EPermisos> EPermisos { get; set; } = new List<EPermisos>();

    public virtual ICollection<ETareas> ETareaCnUsuarioAsignadoNavigations { get; set; } = new List<ETareas>();

    public virtual ICollection<ETareas> ETareaCnUsuarioCreadorNavigations { get; set; } = new List<ETareas>();

    public virtual ICollection<EiNotificacionesXUsuarios> EiNotificacionesXUsuarios { get; set; } = new List<EiNotificacionesXUsuarios>();

    public virtual ICollection<EOficinas> CnCodigoOficinas { get; set; } = new List<EOficinas>();
}
