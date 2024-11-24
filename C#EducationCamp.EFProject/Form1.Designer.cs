namespace C_EducationCamp.EFProject
{
   partial class FrmGüide
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
         this.label1 = new System.Windows.Forms.Label();
         this.textBoxID = new System.Windows.Forms.TextBox();
         this.btnList = new System.Windows.Forms.Button();
         this.Dataview = new System.Windows.Forms.DataGridView();
         this.texBoxName = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.textBoxSurname = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.btnGetByID = new System.Windows.Forms.Button();
         this.btnUpdate = new System.Windows.Forms.Button();
         this.btnDelete = new System.Windows.Forms.Button();
         this.btnAdd = new System.Windows.Forms.Button();
         this.button1 = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.Dataview)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(6, 53);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(89, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Rehber ID         : ";
         this.label1.Click += new System.EventHandler(this.label1_Click);
         // 
         // textBoxID
         // 
         this.textBoxID.Location = new System.Drawing.Point(90, 46);
         this.textBoxID.Name = "textBoxID";
         this.textBoxID.Size = new System.Drawing.Size(171, 20);
         this.textBoxID.TabIndex = 1;
         // 
         // btnList
         // 
         this.btnList.BackColor = System.Drawing.SystemColors.ActiveCaption;
         this.btnList.Location = new System.Drawing.Point(90, 145);
         this.btnList.Name = "btnList";
         this.btnList.Size = new System.Drawing.Size(171, 36);
         this.btnList.TabIndex = 2;
         this.btnList.Text = "Listele";
         this.btnList.UseVisualStyleBackColor = false;
         this.btnList.Click += new System.EventHandler(this.btnList_Click);
         // 
         // Dataview
         // 
         this.Dataview.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
         this.Dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.Dataview.Location = new System.Drawing.Point(276, 53);
         this.Dataview.Name = "Dataview";
         this.Dataview.Size = new System.Drawing.Size(414, 338);
         this.Dataview.TabIndex = 3;
         // 
         // texBoxName
         // 
         this.texBoxName.Location = new System.Drawing.Point(90, 82);
         this.texBoxName.Name = "texBoxName";
         this.texBoxName.Size = new System.Drawing.Size(171, 20);
         this.texBoxName.TabIndex = 5;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(6, 89);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(90, 13);
         this.label2.TabIndex = 4;
         this.label2.Text = "Rehber Adı        : ";
         // 
         // textBoxSurname
         // 
         this.textBoxSurname.Location = new System.Drawing.Point(90, 110);
         this.textBoxSurname.Name = "textBoxSurname";
         this.textBoxSurname.Size = new System.Drawing.Size(171, 20);
         this.textBoxSurname.TabIndex = 7;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(6, 117);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(89, 13);
         this.label3.TabIndex = 6;
         this.label3.Text = "Rehber Soyadı  : ";
         // 
         // btnGetByID
         // 
         this.btnGetByID.BackColor = System.Drawing.SystemColors.ActiveCaption;
         this.btnGetByID.Location = new System.Drawing.Point(90, 313);
         this.btnGetByID.Name = "btnGetByID";
         this.btnGetByID.Size = new System.Drawing.Size(171, 36);
         this.btnGetByID.TabIndex = 9;
         this.btnGetByID.Text = "ID\'ye Göre Getir";
         this.btnGetByID.UseVisualStyleBackColor = false;
         this.btnGetByID.Click += new System.EventHandler(this.btnGetByID_Click);
         // 
         // btnUpdate
         // 
         this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
         this.btnUpdate.Location = new System.Drawing.Point(90, 271);
         this.btnUpdate.Name = "btnUpdate";
         this.btnUpdate.Size = new System.Drawing.Size(171, 36);
         this.btnUpdate.TabIndex = 10;
         this.btnUpdate.Text = "Güncelle";
         this.btnUpdate.UseVisualStyleBackColor = false;
         this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
         // 
         // btnDelete
         // 
         this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
         this.btnDelete.Location = new System.Drawing.Point(90, 229);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(171, 36);
         this.btnDelete.TabIndex = 11;
         this.btnDelete.Text = "Sil";
         this.btnDelete.UseVisualStyleBackColor = false;
         this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
         // 
         // btnAdd
         // 
         this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
         this.btnAdd.Location = new System.Drawing.Point(90, 187);
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.Size = new System.Drawing.Size(171, 36);
         this.btnAdd.TabIndex = 12;
         this.btnAdd.Text = "Ekle";
         this.btnAdd.UseVisualStyleBackColor = false;
         this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
         this.button1.Location = new System.Drawing.Point(90, 355);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(171, 36);
         this.button1.TabIndex = 13;
         this.button1.Text = "Temizle";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // FrmGüide
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(774, 478);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.btnAdd);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.btnUpdate);
         this.Controls.Add(this.btnGetByID);
         this.Controls.Add(this.textBoxSurname);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.texBoxName);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.Dataview);
         this.Controls.Add(this.btnList);
         this.Controls.Add(this.textBoxID);
         this.Controls.Add(this.label1);
         this.Name = "FrmGüide";
         this.Text = "Rehber İşlemleri";
         ((System.ComponentModel.ISupportInitialize)(this.Dataview)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox textBoxID;
      private System.Windows.Forms.Button btnList;
      private System.Windows.Forms.DataGridView Dataview;
      private System.Windows.Forms.TextBox texBoxName;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox textBoxSurname;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button btnGetByID;
      private System.Windows.Forms.Button btnUpdate;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.Button button1;
   }
}

