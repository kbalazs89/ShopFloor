namespace ShopFloor.dal
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Cont : DbContext
    {
        public Cont()
            : base("name=Cont")
        {
        }

        public virtual DbSet<ProductDBModel> Products { get; set; }
        public virtual DbSet<UserDBModel> Users { get; set; }
    }
}