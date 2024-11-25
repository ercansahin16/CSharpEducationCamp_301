using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_EducationCamp.EFProject
{
   
   public class Voids
   {
      CsharpEducationCamp301Db_TravelEntities db=new CsharpEducationCamp301Db_TravelEntities();
      public int ortalama()//Ortalama kapasite işi
      {
         int avg = ((int)db.Location.Average(x => x.LocationCapacity));
         return avg;
      }
      public int avgprice()
      {
        int value=((int)db.Location.Average(x=>x.LocationPrice));
         return value;
      }
     public string  lastCountry()
      {
         int lastcountryID = db.Location.Max(x=>x.LocationID);
         string countryName = db.Location.Where(x => x.LocationID == lastcountryID).Select(y => y.LocationCountry).FirstOrDefault();
       return countryName;
      }

   }
   
   }
