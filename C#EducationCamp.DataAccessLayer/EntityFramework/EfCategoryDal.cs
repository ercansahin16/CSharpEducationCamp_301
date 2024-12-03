using C_EducationCamp.DataAccessLayer.Abstrack;
using C_EducationCamp.DataAccessLayer.Repositories;
using C_EducationCamp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_EducationCamp.DataAccessLayer.EntityFramework
{
   public class EfCategoryDal:GenericRepository<Category>,ICategoryDal
   {
   }
}
