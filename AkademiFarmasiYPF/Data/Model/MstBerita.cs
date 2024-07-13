using System;
using System.Collections.Generic;

namespace AkademiFarmasiYPF.Data.Model;

public partial class MstBerita
{
    public int Id { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public bool Active { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Content { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string CreateBy { get; set; } = null!;

    public DateTime? TglTerbit { get; set; }
}
