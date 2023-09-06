using System;
using System.Collections.Generic;

namespace stockrain.infrestructure.Models;

public partial class User
{
    public string Username { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool? IsLogginIn { get; set; }

    public Guid IdUsuario { get; set; }
}
