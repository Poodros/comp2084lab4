using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }


    }
}