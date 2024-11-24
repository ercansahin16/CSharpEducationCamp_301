namespace C_EducationCamp.EFProject
{
   partial class FrmLocation
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.button1 = new System.Windows.Forms.Button();
         this.btnAdd = new System.Windows.Forms.Button();
         this.btnDelete = new System.Windows.Forms.Button();
         this.btnUpdate = new System.Windows.Forms.Button();
         this.btnGetByID = new System.Windows.Forms.Button();
         this.txtLocationCountry = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.txtLocationCity = new System.Windows.Forms.TextBox();
         this.txtLocationCitylabel = new System.Windows.Forms.Label();
         this.Dataview = new System.Windows.Forms.DataGridView();
         this.btnList = new System.Windows.Forms.Button();
         this.txtLocationID = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.txtLocationDay = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.txtLocationPrice = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.txtLocationBalance = new System.Windows.Forms.NumericUpDown();
         this.txtLocationGüide = new System.Windows.Forms.ComboBox();
         ((System.ComponentModel.ISupportInitialize)(this.Dataview)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtLocationBalance)).BeginInit();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
         this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.button1.Location = new System.Drawing.Point(906, 378);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(117, 36);
         this.button1.TabIndex = 26;
         this.button1.Text = "Temizle";
         this.button1.UseVisualStyleBackColor = false;
         // 
         // btnAdd
         // 
         this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
         this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.btnAdd.Location = new System.Drawing.Point(609, 378);
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.Size = new System.Drawing.Size(110, 36);
         this.btnAdd.TabIndex = 25;
         this.btnAdd.Text = "Ekle";
         this.btnAdd.UseVisualStyleBackColor = false;
         this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
         // 
         // btnDelete
         // 
         this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
         this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.btnDelete.Location = new System.Drawing.Point(766, 336);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(106, 36);
         this.btnDelete.TabIndex = 24;
         this.btnDelete.Text = "Sil";
         this.btnDelete.UseVisualStyleBackColor = false;
         this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
         // 
         // btnUpdate
         // 
         this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
         this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.btnUpdate.Location = new System.Drawing.Point(766, 378);
         this.btnUpdate.Name = "btnUpdate";
         this.btnUpdate.Size = new System.Drawing.Size(106, 36);
         this.btnUpdate.TabIndex = 23;
         this.btnUpdate.Text = "Güncelle";
         this.btnUpdate.UseVisualStyleBackColor = false;
         // 
         // btnGetByID
         // 
         this.btnGetByID.BackColor = System.Drawing.SystemColors.ActiveCaption;
         this.btnGetByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.btnGetByID.Location = new System.Drawing.Point(906, 336);
         this.btnGetByID.Name = "btnGetByID";
         this.btnGetByID.Size = new System.Drawing.Size(117, 36);
         this.btnGetByID.TabIndex = 22;
         this.btnGetByID.Text = "ID\'ye Göre Getir";
         this.btnGetByID.UseVisualStyleBackColor = false;
         // 
         // txtLocationCountry
         // 
         this.txtLocationCountry.Location = new System.Drawing.Point(74, 166);
         this.txtLocationCountry.Name = "txtLocationCountry";
         this.txtLocationCountry.Size = new System.Drawing.Size(171, 20);
         this.txtLocationCountry.TabIndex = 21;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.label3.Location = new System.Drawing.Point(38, 170);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(33, 13);
         this.label3.TabIndex = 20;
         this.label3.Text = "Ülke";
         this.label3.Click += new System.EventHandler(this.label3_Click);
         // 
         // txtLocationCity
         // 
         this.txtLocationCity.Location = new System.Drawing.Point(74, 135);
         this.txtLocationCity.Name = "txtLocationCity";
         this.txtLocationCity.Size = new System.Drawing.Size(171, 20);
         this.txtLocationCity.TabIndex = 19;
         // 
         // txtLocationCitylabel
         // 
         this.txtLocationCitylabel.AutoSize = true;
         this.txtLocationCitylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.txtLocationCitylabel.Location = new System.Drawing.Point(36, 142);
         this.txtLocationCitylabel.Name = "txtLocationCitylabel";
         this.txtLocationCitylabel.Size = new System.Drawing.Size(36, 13);
         this.txtLocationCitylabel.TabIndex = 18;
         this.txtLocationCitylabel.Text = "Şehir";
         // 
         // Dataview
         // 
         this.Dataview.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
         this.Dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.Dataview.Location = new System.Drawing.Point(260, 109);
         this.Dataview.Name = "Dataview";
         this.Dataview.Size = new System.Drawing.Size(881, 206);
         this.Dataview.TabIndex = 17;
         // 
         // btnList
         // 
         this.btnList.BackColor = System.Drawing.SystemColors.ActiveCaption;
         this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.btnList.Location = new System.Drawing.Point(609, 336);
         this.btnList.Name = "btnList";
         this.btnList.Size = new System.Drawing.Size(110, 36);
         this.btnList.TabIndex = 16;
         this.btnList.Text = "Listele";
         this.btnList.UseVisualStyleBackColor = false;
         this.btnList.Click += new System.EventHandler(this.btnList_Click);
         // 
         // txtLocationID
         // 
         this.txtLocationID.Location = new System.Drawing.Point(74, 102);
         this.txtLocationID.Name = "txtLocationID";
         this.txtLocationID.Size = new System.Drawing.Size(171, 20);
         this.txtLocationID.TabIndex = 15;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.label1.Location = new System.Drawing.Point(8, 106);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(69, 13);
         this.label1.TabIndex = 14;
         this.label1.Text = "LocationID";
         // 
         // txtLocationDay
         // 
         this.txtLocationDay.Location = new System.Drawing.Point(74, 266);
         this.txtLocationDay.Name = "txtLocationDay";
         this.txtLocationDay.Size = new System.Drawing.Size(171, 20);
         this.txtLocationDay.TabIndex = 32;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.label4.Location = new System.Drawing.Point(9, 270);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(66, 13);
         this.label4.TabIndex = 31;
         this.label4.Text = "Gün/Gece";
         // 
         // txtLocationPrice
         // 
         this.txtLocationPrice.Location = new System.Drawing.Point(74, 236);
         this.txtLocationPrice.Name = "txtLocationPrice";
         this.txtLocationPrice.Size = new System.Drawing.Size(171, 20);
         this.txtLocationPrice.TabIndex = 30;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.label5.Location = new System.Drawing.Point(38, 242);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(34, 13);
         this.label5.TabIndex = 29;
         this.label5.Text = "Fiyat";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.label6.Location = new System.Drawing.Point(19, 206);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(56, 13);
         this.label6.TabIndex = 27;
         this.label6.Text = "Kapasite";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.label9.Location = new System.Drawing.Point(25, 300);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(48, 13);
         this.label9.TabIndex = 33;
         this.label9.Text = "Rehber";
         // 
         // txtLocationBalance
         // 
         this.txtLocationBalance.Location = new System.Drawing.Point(74, 204);
         this.txtLocationBalance.Name = "txtLocationBalance";
         this.txtLocationBalance.Size = new System.Drawing.Size(171, 20);
         this.txtLocationBalance.TabIndex = 35;
         // 
         // txtLocationGüide
         // 
         this.txtLocationGüide.FormattingEnabled = true;
         this.txtLocationGüide.Location = new System.Drawing.Point(74, 294);
         this.txtLocationGüide.Name = "txtLocationGüide";
         this.txtLocationGüide.Size = new System.Drawing.Size(171, 21);
         this.txtLocationGüide.TabIndex = 37;
         // 
         // FrmLocation
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1322, 551);
         this.Controls.Add(this.txtLocationGüide);
         this.Controls.Add(this.txtLocationBalance);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.txtLocationDay);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.txtLocationPrice);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.btnAdd);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.btnUpdate);
         this.Controls.Add(this.btnGetByID);
         this.Controls.Add(this.txtLocationCountry);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.txtLocationCity);
         this.Controls.Add(this.txtLocationCitylabel);
         this.Controls.Add(this.Dataview);
         this.Controls.Add(this.btnList);
         this.Controls.Add(this.txtLocationID);
         this.Controls.Add(this.label1);
         this.Name = "FrmLocation";
         this.Text = "FrmLocation";
         ((System.ComponentModel.ISupportInitialize)(this.Dataview)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtLocationBalance)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.Button btnUpdate;
      private System.Windows.Forms.Button btnGetByID;
      private System.Windows.Forms.TextBox txtLocationCountry;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox txtLocationCity;
      private System.Windows.Forms.Label txtLocationCitylabel;
      private System.Windows.Forms.DataGridView Dataview;
      private System.Windows.Forms.Button btnList;
      private System.Windows.Forms.TextBox txtLocationID;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtLocationDay;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtLocationPrice;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.NumericUpDown txtLocationBalance;
      private System.Windows.Forms.ComboBox txtLocationGüide;
   }
}