namespace C_EducationCamp.PresentationLayer
{
   partial class FrmCategory
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
         this.txtCategoryId = new System.Windows.Forms.TextBox();
         this.btnList = new System.Windows.Forms.Button();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.txtCategoryName = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.rdbactive = new System.Windows.Forms.RadioButton();
         this.rdbpassive = new System.Windows.Forms.RadioButton();
         this.btnAdd = new System.Windows.Forms.Button();
         this.btnUpdate = new System.Windows.Forms.Button();
         this.btnDelete = new System.Windows.Forms.Button();
         this.btnGetById = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(77, 55);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(69, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Kategory ID :";
         // 
         // txtCategoryId
         // 
         this.txtCategoryId.Location = new System.Drawing.Point(184, 48);
         this.txtCategoryId.Name = "txtCategoryId";
         this.txtCategoryId.Size = new System.Drawing.Size(100, 20);
         this.txtCategoryId.TabIndex = 1;
         // 
         // btnList
         // 
         this.btnList.Location = new System.Drawing.Point(80, 165);
         this.btnList.Name = "btnList";
         this.btnList.Size = new System.Drawing.Size(86, 23);
         this.btnList.TabIndex = 2;
         this.btnList.Text = "LİSTELE";
         this.btnList.UseVisualStyleBackColor = true;
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Location = new System.Drawing.Point(360, 48);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.Size = new System.Drawing.Size(240, 198);
         this.dataGridView1.TabIndex = 3;
         // 
         // txtCategoryName
         // 
         this.txtCategoryName.Location = new System.Drawing.Point(184, 90);
         this.txtCategoryName.Name = "txtCategoryName";
         this.txtCategoryName.Size = new System.Drawing.Size(100, 20);
         this.txtCategoryName.TabIndex = 5;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(77, 97);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(73, 13);
         this.label2.TabIndex = 4;
         this.label2.Text = "Kategory Adı :";
         this.label2.Click += new System.EventHandler(this.label2_Click);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(77, 138);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(89, 13);
         this.label3.TabIndex = 6;
         this.label3.Text = "Kategory Durum :";
         // 
         // rdbactive
         // 
         this.rdbactive.AutoSize = true;
         this.rdbactive.Location = new System.Drawing.Point(184, 137);
         this.rdbactive.Name = "rdbactive";
         this.rdbactive.Size = new System.Drawing.Size(46, 17);
         this.rdbactive.TabIndex = 7;
         this.rdbactive.TabStop = true;
         this.rdbactive.Text = "Aktif";
         this.rdbactive.UseVisualStyleBackColor = true;
         // 
         // rdbpassive
         // 
         this.rdbpassive.AutoSize = true;
         this.rdbpassive.Location = new System.Drawing.Point(238, 137);
         this.rdbpassive.Name = "rdbpassive";
         this.rdbpassive.Size = new System.Drawing.Size(48, 17);
         this.rdbpassive.TabIndex = 8;
         this.rdbpassive.TabStop = true;
         this.rdbpassive.Text = "Pasif";
         this.rdbpassive.UseVisualStyleBackColor = true;
         // 
         // btnAdd
         // 
         this.btnAdd.Location = new System.Drawing.Point(198, 165);
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.Size = new System.Drawing.Size(86, 23);
         this.btnAdd.TabIndex = 9;
         this.btnAdd.Text = "EKLE";
         this.btnAdd.UseVisualStyleBackColor = true;
         // 
         // btnUpdate
         // 
         this.btnUpdate.Location = new System.Drawing.Point(198, 194);
         this.btnUpdate.Name = "btnUpdate";
         this.btnUpdate.Size = new System.Drawing.Size(86, 23);
         this.btnUpdate.TabIndex = 11;
         this.btnUpdate.Text = "GÜNCELLE";
         this.btnUpdate.UseVisualStyleBackColor = true;
         // 
         // btnDelete
         // 
         this.btnDelete.Location = new System.Drawing.Point(80, 194);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(86, 23);
         this.btnDelete.TabIndex = 10;
         this.btnDelete.Text = "SİL";
         this.btnDelete.UseVisualStyleBackColor = true;
         // 
         // btnGetById
         // 
         this.btnGetById.Location = new System.Drawing.Point(80, 223);
         this.btnGetById.Name = "btnGetById";
         this.btnGetById.Size = new System.Drawing.Size(206, 23);
         this.btnGetById.TabIndex = 12;
         this.btnGetById.Text = "ID YE GÖRE GETİR";
         this.btnGetById.UseVisualStyleBackColor = true;
         // 
         // FrmCategory
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(621, 287);
         this.Controls.Add(this.btnGetById);
         this.Controls.Add(this.btnUpdate);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.btnAdd);
         this.Controls.Add(this.rdbpassive);
         this.Controls.Add(this.rdbactive);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.txtCategoryName);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.dataGridView1);
         this.Controls.Add(this.btnList);
         this.Controls.Add(this.txtCategoryId);
         this.Controls.Add(this.label1);
         this.Name = "FrmCategory";
         this.Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtCategoryId;
      private System.Windows.Forms.Button btnList;
      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.TextBox txtCategoryName;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.RadioButton rdbactive;
      private System.Windows.Forms.RadioButton rdbpassive;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.Button btnUpdate;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.Button btnGetById;
   }
}

