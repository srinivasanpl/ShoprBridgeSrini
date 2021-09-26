using System;
using System.Collections.Generic;

namespace WebAPICore.Models
{
    public partial class InventoryData
    {
        public int InventoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
    }
}
