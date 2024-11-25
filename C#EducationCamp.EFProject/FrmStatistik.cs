using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_EducationCamp.EFProject
{
   public partial class FrmStatistik : Form
   {
      public FrmStatistik()
      {
         InitializeComponent();
      }
      CsharpEducationCamp301Db_TravelEntities db=new CsharpEducationCamp301Db_TravelEntities();
      Voids voids=new Voids();
      private void FrmStatistik_Load(object sender, EventArgs e)
      {
         LblLocationCount.Text=db.Location.Count().ToString();//Lokasyon sayısı
         LblCapacityCount.Text = db.Location.Sum(x=>x.LocationCapacity).ToString();//Toplam Kapasite
         LblGuideCount.Text = db.Güide.Count().ToString();//Rehber Sayısı
         LblOrtalamaCapacity.Text = voids.ortalama().ToString();//ortalama kapasite
         LblAvgPrice.Text = voids.avgprice().ToString()+"₺";
         LblLastCountry.Text = voids.lastCountry();
         lblcapadociaCapacity.Text = voids.KapadociaCapacity().ToString();
         LblTrAvgCapacity.Text=voids.TrAvgCapacity();
         LblRomaGuideName.Text = voids.RomaGuideName();
         LblMaxTour.Text=voids.MaxTours();
         LblMaxPrice.Text = voids.MaxPrice();
         LblTourNumber.Text=voids.RanaTourNumber();
      }
     
      private void panel10_Paint(object sender, PaintEventArgs e)
      {

      }
   }
}
