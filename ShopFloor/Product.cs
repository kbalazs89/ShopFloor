using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopFloor.dal;

namespace ShopFloor
{
    public class Product : BaseModel
    {
        string _name;
        int _price;
        int _quantity;
        string _cathegory;
        int _nrOfSeats;
        int _flightRange;
        int _nrOfEngines;

        public string Name { get { return _name; } set { _name = value; OnPropertyChange(); } }
        public int Price { get { return _price; } set { _price = value; OnPropertyChange(); } }
        public int Quantity { get { return _quantity; } set { _quantity = value; OnPropertyChange(); } }
        public string Cathegory { get { return _cathegory; } set { _cathegory = value; OnPropertyChange(); } }
        public int NrOfSeats { get { return _nrOfSeats; } set { _nrOfSeats = value; OnPropertyChange(); } }
        public int FlightRange { get { return _flightRange; } set { _flightRange = value; OnPropertyChange(); } }
        public int NrOfEngines { get { return _nrOfEngines; } set { _nrOfEngines = value; OnPropertyChange(); } }

        /*public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Cathegory { get; set; }
        public int NrOfSeats { get; set; }
        public int FlightRange { get; set; }
        public int NrOfEngines { get; set; }*/

        public Product(ProductDBModel dbModel)
        {
            Name = dbModel.Name;
            Price = dbModel.Price;
            Quantity = dbModel.Quantity;
            Cathegory = dbModel.Cathegory;
            NrOfSeats = dbModel.NrOfSeats;
            FlightRange = dbModel.FlightRange;
            NrOfEngines = dbModel.NrOfEngines;
        }
        public Product()
        {

        }
    }
}
