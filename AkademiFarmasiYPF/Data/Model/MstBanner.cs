using System;
using System.Collections.Generic;

namespace AkademiFarmasiYPF.Data.Model;

public partial class MstBanner
{
    public int Id { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateBy { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public bool Active { get; set; }

    public string ImagePath { get; set; } = null!;

    public int? Index { get; set; }

    public DateTime TglKadaluarsa { get; set; }
}
