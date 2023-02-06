using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_bufe_satis_uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasaTutar = 0;
        private void btn_Hesapla_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam;
            misir = Convert.ToInt16(txt_misir.Text);
            bilet = Convert.ToInt16(txt_bilet.Text);
            su = Convert.ToInt16(txt_su.Text);
            cay = Convert.ToInt16(txt_cay.Text);

            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;
            lbl_toplam.Text = toplam.ToString() + " TL";

            kasaTutar = kasaTutar + toplam;
            lbl_kasa_toplam.Text = kasaTutar.ToString() + " TL";

        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            txt_bilet.Text = "";
            txt_cay.Text = "";
            txt_misir.Text = "";
            txt_su.Text = "";
            txt_misir.Focus();

        }
    }
}
