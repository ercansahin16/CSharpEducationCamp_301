﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_EducationCamp.EntityLayer.Concrete
{
   public class Category
   {
      [Key]
      public int CategoryId { get; set; }

      public string CategoryName { get; set; }

      public bool CategoryStatus { get; set; }
      public List<Product> Products { get; set; }
   }
}
