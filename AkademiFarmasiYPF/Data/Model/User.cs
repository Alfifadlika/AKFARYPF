using System;
using System.Collections.Generic;

namespace AkademiFarmasiYPF.Data.Model;

public partial class User
{
    public Guid IdUser { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public bool Active { get; set; }

    public string CreateBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
