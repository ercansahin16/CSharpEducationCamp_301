using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_EducationCamp.EntityLayer.Concrete
{
   public class Order
   {
      public int OrderID { get; set; }

      public int ProductId { get; set; }
      public virtual Product Products { get; set; }

      public int Quantity { get; set; }
      public Decimal UnitPrice { get; set; }

      public decimal TotalPrice { get; set; }

      public int CustomerId { get; set; }
      public virtual Customer Customers { get; set; }
   }
}
