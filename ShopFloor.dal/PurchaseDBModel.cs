using System;
using System.Collections.Generic;
using System.Text;

namespace ShopFloor.dal
{
    class PurchaseDBModel
    {
        public UserDBModel User { get; set; }
        public DateTime Timestamp { get; set; }
        public ICollection<ProductDBModel> Products { get; set; }
    }
}
