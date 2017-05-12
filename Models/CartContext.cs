using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyShoppingCartTrial.Models
{
    public class CartContext : DbContext
    {
        public DbSet<Item> Item { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Login> Login { get; set; }
    }
}