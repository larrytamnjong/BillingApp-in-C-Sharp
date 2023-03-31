using System;
using System.Collections.Generic;

namespace DataAccessLayer.Model;

public partial class TblTransactionDetail
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Total { get; set; }

    public int? DeaCustId { get; set; }

    public DateTime? AddedDate { get; set; }

    public int? AddedBy { get; set; }
}
