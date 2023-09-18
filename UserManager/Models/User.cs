﻿using System;
using System.Collections.Generic;

namespace UserManager.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordSha { get; set; } = null!;
}
