using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C_EducationCamp.EFProject
{
   public partial class FrmGüide : Form
   {
      public FrmGüide()
      {
         InitializeComponent();
      }
      CsharpEducationCamp301Db_TravelEntities dbTravel = new CsharpEducationCamp301Db_TravelEntities();
      private void label1_Click(object sender, EventArgs e)
      {

      }

      private void btnList_Click(object sender, EventArgs e)
      {

            
         var values=dbTravel.Güide.ToList();
         Dataview.DataSource= values;
      }
      public  void Yenile()
      {
         var getList = dbTravel.Güide.ToList();
         Dataview.DataSource = getList;
      }

      private void btnAdd_Click(object sender, EventArgs e)
      {
         Güide güide =new Güide();
         güide.GüideName = texBoxName.Text;
         güide.GüideSurname = textBoxSurname.Text;

         dbTravel.Güide.Add(güide);
         dbTravel.SaveChanges();
         MessageBox.Show("Ekleme Yapıldı");
         Yenile();
      }

      private void btnDelete_Click(object sender, EventArgs e)
      {
         
         int id =int.Parse( textBoxID.Text);
       
            var removeValue = dbTravel.Güide.Find(id);
            dbTravel.Güide.Remove(removeValue);
            dbTravel.SaveChanges();
         textBoxID.Clear();
        
           MessageBox.Show("Rehber Silindi.");
         Yenile();



      }

      private void btnUpdate_Click(object sender, EventArgs e)
      {
         int id=int.Parse( textBoxID.Text);
         var UpdateValue = dbTravel.Güide.Find(id);
         UpdateValue.GüideName=texBoxName.Text;
         UpdateValue.GüideSurname=textBoxSurname.Text;
         dbTravel.SaveChanges();
         textBoxID.Clear() ;
         texBoxName.Clear();
         textBoxSurname.Clear();
         MessageBox.Show($"{id} Numaralı ID  Güncellendi");
         Yenile();

      }

      private void btnGetByID_Click(object sender, EventArgs e)
      {
         int id = int.Parse(textBoxID.Text);
         var value = dbTravel.Güide.Where(x=>x.GüideID==id).ToList();
         Dataview.DataSource = value;


      }

      private void button1_Click(object sender, EventArgs e)
      {
         textBoxID.Clear();
         texBoxName.Clear() ;
         textBoxSurname.Clear() ;
         //Dataview.DataSource=null;
         Dataview.DataSource = new DataView();
      }

      private void button2_Click(object sender, EventArgs e)
      {

      }
   }
}
