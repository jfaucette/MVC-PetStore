using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Pet_Store.Models
{
    public class Animal
    {
        public int AnimalID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public DateTime DateRecieved { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }

    public class AnimalDBContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
    }

}