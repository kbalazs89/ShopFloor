using System.Collections.ObjectModel;

namespace ShopFloor
{
    public static class StaticClass
    {
        public static ObservableCollection<Product> PurchasedProducts { get; set; } = new ObservableCollection<Product>();
        public static User LoggedUser{get;set;}
    }
}
