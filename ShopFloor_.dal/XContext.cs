/*using System;
using System.Collections.Generic;
using System.Text;

namespace ShopFloor.dal
{
    public class XContext
    {
        public List<ProductDBModel> Products { get; } = new List<ProductDBModel>
            {
                new ProductDBModel{Name="A380",Price=432,Quantity=40, Cathegory="_1", NrOfSeats=615, FlightRange=15700, NrOfEngines=4},
                new ProductDBModel{Name="737",Price=200,Quantity=80, Cathegory="_2", NrOfSeats=380, FlightRange=12300, NrOfEngines=2},
            };
        public List<UserDBModel> Users { get; } = new List<UserDBModel>
        {
            new UserDBModel { Username = "asdf", Password = "asdf", Cash = 2500 }
        };

        public List<PurchaseDBModel> Purchases { get; }

        public XContext()
        {
            Purchases = new List<PurchaseDBModel>
            {
                new PurchaseDBModel
                {
                    User = Users[0],
                    Timestamp = DateTime.Now,
                    Products = new List<ProductDBModel>
                    {
                        Products[0]
                    }
                }
            };
        }
    }
}
*/
