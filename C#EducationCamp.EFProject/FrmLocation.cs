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
   public partial class FrmLocation : Form
   {
      public FrmLocation()
      {
         InitializeComponent();
      }
      CsharpEducationCamp301Db_TravelEntities db= new CsharpEducationCamp301Db_TravelEntities();
      private void label3_Click(object sender, EventArgs e)
      {

      }

      private void btnList_Click(object sender, EventArgs e)
      {
         var values=db.Location.ToList();
         Dataview.DataSource = values;
        
      }
      void refresh()
      {
         var value=db.Location.ToList();
         Dataview.DataSource=value;
      }
      private void btnDelete_Click(object sender, EventArgs e)
      {
         int id = int.Parse(txtLocationID.Text);
         var value=db.Location.Find(id);
         db.Location.Remove(value);
         db.SaveChanges();
         txtLocationID.Clear();
         refresh();
         MessageBox.Show("Silindi");

      }

      private void btnAdd_Click(object sender, EventArgs e)
      {
         Location location= new Location();
         location.LocationCity = txtLocationCity.Text;
         location.LocationCountry = txtLocationCountry.Text;
         location.LocationCapacity = byte.Parse(txtLocationBalance.Text);
         location.LocationCity=txtLocationCity.Text;
         location.DayNight= txtLocationDay.Text;
         location.LocationPrice=decimal.Parse(txtLocationPrice.Text);
         location.GüideID = int.Parse(txtLocationGüide.SelectedValue.ToString());
         db.Location.Add(location);
         db.SaveChanges() ;
         refresh();
         MessageBox.Show("Eklendi");




      }

      private void FrmLocation_Load(object sender, EventArgs e)
      {
         var values = db.Güide.Select(x => new
         {
            FullName=x.GüideName+" "+x.GüideSurname,x.GüideID
         }).ToList();
         txtLocationGüide.DisplayMember = "FullName";
         txtLocationGüide.ValueMember = "GüideID";
         txtLocationGüide.DataSource = values;
      }

      private void btnUpdate_Click(object sender, EventArgs e)
      {
         int id=int.Parse(txtLocationID.Text);
         var updateValue = db.Location.Find(id);
         updateValue.LocationCity = txtLocationCity.Text;
         updateValue.LocationCountry = txtLocationCountry.Text;
         updateValue.LocationCapacity = byte.Parse(txtLocationBalance.Text);
         updateValue.LocationCity = txtLocationCity.Text;
         updateValue.DayNight = txtLocationDay.Text;
         updateValue.LocationPrice = decimal.Parse(txtLocationPrice.Text);
         updateValue.GüideID = int.Parse(txtLocationGüide.SelectedValue.ToString());
         db.SaveChanges();
         refresh();
         MessageBox.Show($"{id} numaralı Lokasyon Güncellendi");
      }
   }
}
