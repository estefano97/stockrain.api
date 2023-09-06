using System;
using System.Collections.Generic;

namespace stockrain.infrestructure.Models;

public partial class MarketCapExtFinance
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public decimal RegularPrice { get; set; }

    public decimal PreviousClose { get; set; }

    public DateTime TimeRegistry { get; set; }
}
