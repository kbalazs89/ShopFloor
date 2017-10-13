/*using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopFloor.dal
{
    public class PurchaseDBModel
    {
        [Key]
        public int Id { get; set; }
        public UserDBModel User { get; set; }
        public DateTime Timestamp { get; set; }
        public ICollection<ProductDBModel> Products { get; set; }
    }
}
*/