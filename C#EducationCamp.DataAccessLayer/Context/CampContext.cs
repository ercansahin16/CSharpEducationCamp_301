using C_EducationCamp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_EducationCamp.DataAccessLayer.Context
{
   public class CampContext:DbContext
   {




      public DbSet<Category> categories { get; set; }
      public DbSet<Order> orders { get; set; }
      public DbSet<Product> products { get; set; }
      public DbSet<Customer> customers { get; set; }
      public DbSet<Admin> admins { get; set; }
   }
}
