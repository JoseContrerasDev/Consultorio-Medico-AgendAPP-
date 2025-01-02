﻿using System;
using System.Collections.Generic;

namespace AgendApp.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Dni { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public string? Contrasenia { get; set; }

    public int? IdRol { get; set; }

    public virtual ICollection<Administradore> Administradores { get; set; } = new List<Administradore>();

    public virtual Role? IdRolNavigation { get; set; }

    public virtual ICollection<Medico> Medicos { get; set; } = new List<Medico>();

    public virtual ICollection<Paciente> Pacientes { get; set; } = new List<Paciente>();
}
