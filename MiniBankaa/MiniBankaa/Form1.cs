using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniBankaa
{
    public partial class Form1: Form
    {
        double bakiye = 1000;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnYatir_Click(object sender, EventArgs e)
        {
           
        {
            try
            {
                double tutar = Convert.ToDouble(txtTutar.Text);

                if (tutar <= 0)
                {
                    MessageBox.Show("Lütfen pozitif bir tutar giriniz.");
                    return;
                }

                bakiye += tutar;
                    lstIslemler.Items.Add("Para Yatırıldı: +" + tutar + " TL");
                    lblBakiye.Text = "Bakiye: " + bakiye + " TL";
                txtTutar.Clear();
            }
            catch
            {
                MessageBox.Show("Lütfen sadece sayı giriniz.");
            }
        }
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
          
        {
            try
            {
                double tutar = Convert.ToDouble(txtTutar.Text);

                if (tutar <= 0)
                {
                    MessageBox.Show("Lütfen pozitif bir tutar giriniz.");
                    return;
                }

                if (tutar > bakiye)
                {
                    MessageBox.Show("Yetersiz bakiye!");
                    return;
                }

                bakiye -= tutar;

                lblBakiye.Text = "Bakiye: " + bakiye + " TL";
                txtTutar.Clear();
            }
            catch
            {
                MessageBox.Show("Lütfen sadece sayı giriniz.");
            }
        }
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            lblBakiye.Text = "Bakiye: " + bakiye + " TL";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
