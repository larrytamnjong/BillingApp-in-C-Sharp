using System;
using System.Collections.Generic;

namespace DataAccessLayer.Model;

public partial class TblProduct
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Category { get; set; }

    public string Description { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Qty { get; set; }

    public DateTime? AddedDate { get; set; }

    public int? AddedBy { get; set; }
}
