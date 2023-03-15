using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egyetemMan
{
    public partial class Uj_Felhasznalo_Form : Form
    {
        public Uj_Felhasznalo_Form()
        {
            InitializeComponent();
        }

        private void Uj_Felhasznalo_Form_Load(object sender, EventArgs e)
        {
            txt_uj_nkod.Focus();
        }

        private void btn_regisztracio_Click(object sender, EventArgs e)
        {
            UjFelhasznalo uj_felh = new UjFelhasznalo(txt_uj_nkod.Text, txt_uj_tnev.Text, txt_uj_email.Text, txt_uj_jelszo.Text);
            bool letezik_e = uj_felh.fajl_letrehozas();
            if (letezik_e)
            {
                foreach(Control c in pnl_regisztracio_fo.Controls.OfType<TextBox>())
                {
                    c.ResetText();
                }
                txt_uj_nkod.Focus();
            }
            else
            {
                this.Close();
                MessageBox.Show("Sikeres regisztráció!");
            }

        }
    }
}
