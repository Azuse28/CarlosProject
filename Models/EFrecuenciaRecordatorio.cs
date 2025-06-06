﻿using System;
using System.Collections.Generic;

namespace IntelTaskUCR.Domain.Models;

public partial class EFrecuenciaRecordatorio
{
    public int CnIdRecordatorio { get; set; }

    public string CtTextoRecordatorio { get; set; } = null!;

    public DateTime CfFechaHoraRegistro { get; set; }

    public DateTime CfFechaHoraRecordatorio { get; set; }

    public DateTime CfFechaFinalEvento { get; set; }

    public DateTime? CfFechaHoraEventoPospuesto { get; set; }

    public int CnFrecuenciaRecordatorio { get; set; }

    public int CnIdUsuarioCreador { get; set; }

    public bool CbEstado { get; set; }

    public virtual EUsuarios CnIdUsuarioCreadorNavigation { get; set; } = null!;

    public virtual ICollection<ENotificaciones> ENotificaciones { get; set; } = new List<ENotificaciones>();
}
