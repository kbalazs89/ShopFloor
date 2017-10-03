using System;
using System.Collections.Generic;
using System.Text;

namespace ShopFloor.dal
{
    public class ProductDBModel
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Cathegory { get; set; }
        public int NrOfSeats { get; set; }
        public int FlightRange { get; set; }
        public byte NrOfEngines { get; set; }
    }
}
