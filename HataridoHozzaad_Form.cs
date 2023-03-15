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
    public partial class HataridoHozzaad_Form : Form
    {
        private String felh_nev;
        public HataridoHozzaad_Form(string felh_nev)
        {
            InitializeComponent();
            this.felh_nev = felh_nev;   
        }

        public void fajl_iras()
        {
            if (!File.Exists(@".\txt_fajlok\Hataridok\" + this.felh_nev + @"\targyak.txt") && !File.Exists(@".\txt_fajlok\Hataridok\" + this.felh_nev + @"\hataridok.txt"))
            {
                StreamWriter targy = File.CreateText(@".\txt_fajlok\Hataridok\" + this.felh_nev + @"\targyak.txt");
                targy.Close();
                StreamWriter hataridok = File.CreateText(@".\txt_fajlok\Hataridok\" + this.felh_nev + @"\hataridok.txt");
                hataridok.Close();

            }
            else
            {
                //....
            }
        }

        private void btn_megse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_hatarido_hozzaad_Click(object sender, EventArgs e)
        {
            if(txt_targy_hozzaad.Text == "" && dtp_idopont_hozzaad.Value >= DateTime.Now)
            {
                fajl_iras();
            }
            /*
             * Keszülőben....
             */
            
        }
    }
}
