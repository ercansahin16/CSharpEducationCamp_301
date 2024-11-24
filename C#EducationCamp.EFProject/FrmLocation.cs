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

      }
   }
}
