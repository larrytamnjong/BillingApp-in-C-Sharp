using System;
using System.Collections.Generic;

namespace DataAccessLayer.Model;

public partial class TblCategory
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public DateTime? AddedDate { get; set; }

    public int? AddedBy { get; set; }
}
