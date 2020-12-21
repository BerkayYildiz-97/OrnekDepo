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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbmarka.Items.Add("Volkswagen");
            cmbmarka.Items.Add("Audi");
            cmbmarka.Items.Add("Mercedes");
            cmbmarka.Items.Add("BMW");
            cmbmarka.Items.Add("Kuş Serisi");

        }

        private void cmbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbmodel.Items.Clear();
            switch (cmbmarka.Text)
            {
                case "Volkswagen":
                    cmbmodel.Items.Add("Passat");
                    cmbmodel.Items.Add("Golf");
                    cmbmodel.Items.Add("Polo");
                    break;
                case "Audi":
                    cmbmodel.Items.Add("A1");
                    cmbmodel.Items.Add("A2");
                    cmbmodel.Items.Add("A3");
                    break;
                case "BMW":
                    cmbmodel.Items.Add("1");
                    cmbmodel.Items.Add("2");
                    cmbmodel.Items.Add("3");
                    break;
                case "Mercedes":
                    cmbmodel.Items.Add("A");
                    cmbmodel.Items.Add("B");
                    cmbmodel.Items.Add("C");
                    break;
                case "Kuş Serisi":
                    cmbmodel.Items.Add("Şahin");
                    cmbmodel.Items.Add("Doğan");
                    cmbmodel.Items.Add("Kartal");
                    break;
            }
        }

        private void btnrenk_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                btnrenk.BackColor = colorDialog1.Color;
            }
            else
            {
                MessageBox.Show("Vazgeçildi");
            }

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();

            lvi.UseItemStyleForSubItems = false;

            lvi.Text = cmbmarka.Text;
            lvi.SubItems.Add(cmbmodel.Text);
            lvi.SubItems.Add(cmbyakıt.Text);
            lvi.SubItems.Add(cmbvites.Text);
            lvi.SubItems.Add(cmbkasa.Text);
            lvi.SubItems.Add("");
            lvi.SubItems[5].BackColor = btnrenk.BackColor;
            lvaraçözellikleri.Items.Add(lvi);

        }
    }
}
