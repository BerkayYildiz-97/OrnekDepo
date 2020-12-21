
namespace windowsformapp_araçkayıt
{
    partial class Form2
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
            this.lblinfo = new System.Windows.Forms.Label();
            this.btngirişyap = new System.Windows.Forms.Button();
            this.txtşifre = new System.Windows.Forms.TextBox();
            this.txtkullanıcı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblinfo);
            this.groupBox1.Controls.Add(this.btngirişyap);
            this.groupBox1.Controls.Add(this.txtşifre);
            this.groupBox1.Controls.Add(this.txtkullanıcı);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(202, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Yap";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.ForeColor = System.Drawing.Color.Red;
            this.lblinfo.Location = new System.Drawing.Point(126, 15);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(35, 13);
            this.lblinfo.TabIndex = 4;
            this.lblinfo.Text = "label3";
            // 
            // btngirişyap
            // 
            this.btngirişyap.Location = new System.Drawing.Point(110, 96);
            this.btngirişyap.Name = "btngirişyap";
            this.btngirişyap.Size = new System.Drawing.Size(101, 25);
            this.btngirişyap.TabIndex = 3;
            this.btngirişyap.Text = "Giriş Yap";
            this.btngirişyap.UseVisualStyleBackColor = true;
            this.btngirişyap.Click += new System.EventHandler(this.btngirişyap_Click);
            // 
            // txtşifre
            // 
            this.txtşifre.Location = new System.Drawing.Point(110, 61);
            this.txtşifre.Name = "txtşifre";
            this.txtşifre.Size = new System.Drawing.Size(101, 20);
            this.txtşifre.TabIndex = 2;
            // 
            // txtkullanıcı
            // 
            this.txtkullanıcı.Location = new System.Drawing.Point(110, 31);
            this.txtkullanıcı.Name = "txtkullanıcı";
            this.txtkullanıcı.Size = new System.Drawing.Size(101, 20);
            this.txtkullanıcı.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Button btngirişyap;
        private System.Windows.Forms.TextBox txtşifre;
        private System.Windows.Forms.TextBox txtkullanıcı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}