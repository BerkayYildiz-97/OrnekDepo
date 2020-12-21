using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsformapp_araçkayıt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btngirişyap_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtkullanıcı.Text.ToLower();
            string sifre = txtşifre.Text;
            string mesaj = " ";
            switch (kullaniciadi)
            {
                case "bilgeadam":
                    switch (sifre)
                    {
                        case "1234":
                            Form1 frm = new Form1();
                            frm.Show();
                            this.Hide();
                            break;

                        default:
                            mesaj = "kullanıcı adı doğru , şifre yanlış";
                            lblinfo.Text = mesaj;
                            break;


                    }
                    break;
                default:
                    mesaj = "kullanıcı adı yanlış";
                    lblinfo.Text = mesaj;
                    break;
            }
            

        }
    }
}
