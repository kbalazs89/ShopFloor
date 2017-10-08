using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopFloor.dal
{
    public class ProductDBModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Cathegory { get; set; }
        public int NrOfSeats { get; set; }
        public int FlightRange { get; set; }
        public int NrOfEngines { get; set; }
    }
}
