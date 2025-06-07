using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class ETareas
{
    public int CnIdTarea { get; set; }

    public int? CnTareaOrigen { get; set; }

    public string? CtTituloTarea { get; set; }

    public string CtDescripcionTarea { get; set; } = null!;

    public string? CtDescripcionEspera { get; set; }

    public byte CnIdComplejidad { get; set; }

    public byte CnIdEstado { get; set; }

    public byte CnIdPrioridad { get; set; }

    public string? CnNumeroGis { get; set; }

    public DateTime CfFechaAsignacion { get; set; }

    public DateTime CfFechaLimite { get; set; }

    public DateTime CfFechaFinalizacion { get; set; }

    public int CnUsuarioCreador { get; set; }

    public int? CnUsuarioAsignado { get; set; }

    public virtual EComplejidades CnIdComplejidadNavigation { get; set; } = null!;

    public virtual EEstados CnIdEstadoNavigation { get; set; } = null!;

    public virtual EPrioridades CnIdPrioridadNavigation { get; set; } = null!;

    public virtual ETareas? CnTareaOrigenNavigation { get; set; }

    public virtual EUsuarios? CnUsuarioAsignadoNavigation { get; set; }

    public virtual EUsuarios CnUsuarioCreadorNavigation { get; set; } = null!;

    public virtual ICollection<ETareas> InverseCnTareaOrigenNavigation { get; set; } = new List<ETareas>();

    public virtual ICollection<EAdjuntos> EAdjuntos { get; set; } = new List<EAdjuntos>();

    public virtual ICollection<ETareasIncumplimientos> ETareasIncumplimientos { get; set; } = new List<ETareasIncumplimientos>();

    public virtual ICollection<ETareasJustificacionRechazo> ETareasJustificacionRechazos { get; set; } = new List<ETareasJustificacionRechazo>();

    public virtual ICollection<ETareasSeguimiento> ETareasSeguimientos { get; set; } = new List<ETareasSeguimiento>();
}
