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
      public int KapadociaCapacity() 
      {
     var value=db.Location.Where(x=>x.LocationCity=="Kapadokya").Select(y => y.LocationCapacity).FirstOrDefault();
         var deger = value > 0 ? value : 0;
         return (int)deger;
      }
      public string TrAvgCapacity()
      {

         var value=db.Location.Where(x=>x.LocationCountry=="Türkiye").Average(y=>y.LocationCapacity);
         var deger = value.ToString();
         return deger;
      }
      public string RomaGuideName()
      {
         var value = db.Location.Where(x => x.LocationCity == "Roma").Select(y => y.GüideID).FirstOrDefault();
         var GuideName=db.Güide.Where(x=>x.GüideID==value).Select(y=>y.GüideName+""+y.GüideSurname).FirstOrDefault();
         return GuideName;
      }
      public string MaxTours()
      {
         var maxTour=db.Location.Max(x=>x.LocationCapacity);
         var value = db.Location.Where(x => x.LocationCapacity == maxTour).Select(y=>y.LocationCountry).FirstOrDefault().ToString();
         return value;
      }
      public string MaxPrice()
      {
         var value = db.Location.Max(x=>x.LocationPrice);
         var maxTour=db.Location.Where(x=>x.LocationPrice==value).Select(y=>y.LocationCity).FirstOrDefault().ToString();
         return maxTour;
      }
      public string RanaTourNumber()
      {
         var value = db.Güide.Where(x => x.GüideName == "Rana").Select(y=>y.GüideID).FirstOrDefault();
         var RanaTourNumberSum = db.Location.Where(x => x.GüideID == value).Count().ToString();
         return RanaTourNumberSum;
      }

   }
   
   }
