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
    public partial class Dashboard_Form : Form
    {
        String login_adat;
        public Dashboard_Form(String felh_nev)
        {
            InitializeComponent();
            
            this.login_adat = felh_nev;
        }

        
        // ----- Az indikátor panel "mozgása" az aktiv menüpontra az oldal menün -----
        private void btn_attekintes_Click(object sender, EventArgs e)
        {
            pnl_active_btn.Top = btn_attekintes.Top;
            pnl_active_btn.Height = btn_attekintes.Height;
            lbl_cim.Text = btn_attekintes.Text;
            ctrl_attekintes.BringToFront();
            
            
        }

        private void btn_hataridok_Click(object sender, EventArgs e)
        {
            pnl_active_btn.Top = btn_hataridok.Top;
            pnl_active_btn.Height = btn_hataridok.Height;
            lbl_cim.Text = btn_hataridok.Text;
            ctrl_hataridok.BringToFront();
        }

        private void btn_profil_Click(object sender, EventArgs e)
        {
            pnl_active_btn.Top = btn_profil.Top;
            pnl_active_btn.Height = btn_profil.Height;
            lbl_cim.Text = btn_profil.Text;
        }

        private void btn_fajlok_Click(object sender, EventArgs e)
        {
            pnl_active_btn.Top = btn_fajlok.Top;
            pnl_active_btn.Height = btn_fajlok.Height;
            lbl_cim.Text = btn_fajlok.Text;
            
        }
        
        // --x-- Az indikátor panel "mozgása" az aktiv menüpontra az oldal menün --x--
        
        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            pnl_active_btn.Top = btn_attekintes.Top;
            pnl_active_btn.Height = btn_attekintes.Height;
            lbl_cim.Text = btn_attekintes.Text;
            ctrl_attekintes.BringToFront();
            AttekintesControl.ControlInstance.felh_nev = login_adat;
            HataridokControl.ControlInstance.felh_nev = login_adat;
            StreamReader sr = new StreamReader(@".\txt_fajlok\Osszpont_"+login_adat+".txt");
            lbl_osszpontszam.Text = "Összpontszám: "+sr.ReadLine();
            sr.Close();
            
            
        }

        private void btn_dashboard_kilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_pont_frissit_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@".\txt_fajlok\Osszpont_" + login_adat + ".txt");
            lbl_osszpontszam.Text = "Összpontszám: " + sr.ReadLine();
            sr.Close();
        }
    }
}
