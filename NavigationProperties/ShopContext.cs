using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationProperties
{
    public class ShopContext : DbContext
    {
        public DbSet<Person> People{get;set;}
        public DbSet<Order> Orders { get; set; }

    }
}
