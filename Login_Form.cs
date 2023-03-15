using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egyetemMan
{
    public partial class Login_Form : Form
    {
        public List<String> adatok = new List<String>();
        public Login_Form()
        {
            InitializeComponent();
            
        }

        
        public bool felhasznalo_adatok()
        {
            try
            {
                String eleresi_ut = @".\txt_fajlok\Login\" + txt_nkod.Text + @"\" + txt_nkod.Text + ".txt";
                StreamReader olvas = new StreamReader(eleresi_ut);
                while(olvas.Peek() > 0)
                {
                    adatok.Add(olvas.ReadLine());
                }
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("Rossz felhasználónév!");
                return false;
            }
            
        }

        // ----- Neptun kód és jelszó ellenőrzése -----
        private void btn_login_Click(object sender, EventArgs e)
        {
            bool jo_felh = felhasznalo_adatok();
            if (jo_felh)
            {
                if (adatok[3] == txt_jelszo.Text)
                {
                    this.Hide();
                    Console.WriteLine(adatok[0]);

                    Dashboard_Form form = new Dashboard_Form(adatok[0]);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Hibás jelszó!");
                }
            }
            
            
        }
        // --x-- Neptun kód és jelszó ellenőrzése --x--
        private void Login_Form_Load(object sender, EventArgs e)
        {
            txt_nkod.Focus();
        }

        private void btn_uj_felh_Click(object sender, EventArgs e)
        {
            Uj_Felhasznalo_Form form = new Uj_Felhasznalo_Form();
            form.Show();
        }

        private void btn_login_kilep_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
