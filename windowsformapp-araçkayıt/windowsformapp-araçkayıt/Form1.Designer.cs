
namespace windowsformapp_araçkayıt
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbmarka = new System.Windows.Forms.ComboBox();
            this.cmbmodel = new System.Windows.Forms.ComboBox();
            this.cmbyakıt = new System.Windows.Forms.ComboBox();
            this.cmbvites = new System.Windows.Forms.ComboBox();
            this.cmbkasa = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnrenk = new System.Windows.Forms.Button();
            this.dtpmodelyılı = new System.Windows.Forms.DateTimePicker();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.lvaraçözellikleri = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbvites);
            this.groupBox1.Controls.Add(this.btnkaydet);
            this.groupBox1.Controls.Add(this.cmbmarka);
            this.groupBox1.Controls.Add(this.dtpmodelyılı);
            this.groupBox1.Controls.Add(this.cmbmodel);
            this.groupBox1.Controls.Add(this.btnrenk);
            this.groupBox1.Controls.Add(this.cmbyakıt);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cmbkasa);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 344);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Özellikleri";
            // 
            // cmbmarka
            // 
            this.cmbmarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmarka.FormattingEnabled = true;
            this.cmbmarka.Location = new System.Drawing.Point(39, 30);
            this.cmbmarka.Name = "cmbmarka";
            this.cmbmarka.Size = new System.Drawing.Size(121, 21);
            this.cmbmarka.TabIndex = 0;
            this.cmbmarka.SelectedIndexChanged += new System.EventHandler(this.cmbmarka_SelectedIndexChanged);
            // 
            // cmbmodel
            // 
            this.cmbmodel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmodel.FormattingEnabled = true;
            this.cmbmodel.Location = new System.Drawing.Point(39, 71);
            this.cmbmodel.Name = "cmbmodel";
            this.cmbmodel.Size = new System.Drawing.Size(121, 21);
            this.cmbmodel.TabIndex = 0;
            // 
            // cmbyakıt
            // 
            this.cmbyakıt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbyakıt.FormattingEnabled = true;
            this.cmbyakıt.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "Lpg"});
            this.cmbyakıt.Location = new System.Drawing.Point(39, 113);
            this.cmbyakıt.Name = "cmbyakıt";
            this.cmbyakıt.Size = new System.Drawing.Size(121, 21);
            this.cmbyakıt.TabIndex = 0;
            // 
            // cmbvites
            // 
            this.cmbvites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbvites.FormattingEnabled = true;
            this.cmbvites.Items.AddRange(new object[] {
            "Düz Vites",
            "Otomatik",
            "Yarı otomatik"});
            this.cmbvites.Location = new System.Drawing.Point(39, 154);
            this.cmbvites.Name = "cmbvites";
            this.cmbvites.Size = new System.Drawing.Size(121, 21);
            this.cmbvites.TabIndex = 0;
            // 
            // cmbkasa
            // 
            this.cmbkasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbkasa.FormattingEnabled = true;
            this.cmbkasa.Items.AddRange(new object[] {
            "sedan",
            "hatchback",
            "cabrio"});
            this.cmbkasa.Location = new System.Drawing.Point(39, 196);
            this.cmbkasa.Name = "cmbkasa";
            this.cmbkasa.Size = new System.Drawing.Size(121, 21);
            this.cmbkasa.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Marka seçin:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Model seçin:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Yakıt seçin:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Vites seçin:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Kasa seçin:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 220);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Renk";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Model Yılı";
            // 
            // btnrenk
            // 
            this.btnrenk.Location = new System.Drawing.Point(39, 236);
            this.btnrenk.Name = "btnrenk";
            this.btnrenk.Size = new System.Drawing.Size(121, 23);
            this.btnrenk.TabIndex = 2;
            this.btnrenk.Text = "renk seç";
            this.btnrenk.UseVisualStyleBackColor = true;
            this.btnrenk.Click += new System.EventHandler(this.btnrenk_Click);
            // 
            // dtpmodelyılı
            // 
            this.dtpmodelyılı.CustomFormat = "yyyy";
            this.dtpmodelyılı.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpmodelyılı.Location = new System.Drawing.Point(39, 278);
            this.dtpmodelyılı.Name = "dtpmodelyılı";
            this.dtpmodelyılı.Size = new System.Drawing.Size(174, 20);
            this.dtpmodelyılı.TabIndex = 3;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(39, 304);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(121, 23);
            this.btnkaydet.TabIndex = 4;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // lvaraçözellikleri
            // 
            this.lvaraçözellikleri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvaraçözellikleri.GridLines = true;
            this.lvaraçözellikleri.HideSelection = false;
            this.lvaraçözellikleri.Location = new System.Drawing.Point(253, 19);
            this.lvaraçözellikleri.Name = "lvaraçözellikleri";
            this.lvaraçözellikleri.Size = new System.Drawing.Size(548, 355);
            this.lvaraçözellikleri.TabIndex = 6;
            this.lvaraçözellikleri.UseCompatibleStateImageBehavior = false;
            this.lvaraçözellikleri.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Marka";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Model";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yakıt";
            this.columnHeader3.Width = 68;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Vites";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kasa";
            this.columnHeader5.Width = 72;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Renk";
            this.columnHeader6.Width = 73;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Model Yılı";
            this.columnHeader7.Width = 87;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.lvaraçözellikleri);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbvites;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.ComboBox cmbmarka;
        private System.Windows.Forms.DateTimePicker dtpmodelyılı;
        private System.Windows.Forms.ComboBox cmbmodel;
        private System.Windows.Forms.Button btnrenk;
        private System.Windows.Forms.ComboBox cmbyakıt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbkasa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView lvaraçözellikleri;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

