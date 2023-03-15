using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace egyetemMan
{
    public partial class Teendok_Form : Form
    {
        private String Adatok;
        private String nev; // Adott kurzus neve
        private List<String> jegyzetek = new List<String>();    // A teendőkre list
        private int pontok; // pontszámolás
        private int index; // index -> mennyi panelt kell létrehozni (mennyi "teendő" van)
        
        
        



        public Teendok_Form(String fajlnev, String adatok)
        {
            InitializeComponent();
            this.nev = fajlnev;
            this.Adatok = adatok;
            
            
        }
        
        // ----- Fájlba történő írás "mentés céljából" -----
        public void fajl_iras()
        {
            StreamWriter sw = new StreamWriter(@".\txt_fajlok\Login\" + Adatok + @"\" + nev + @"\" + nev + ".txt");
            
            if (index != 0)
            {
                for(int i = 0; i < index; i++)
                {
                    sw.Write(jegyzetek[i]+"\n");
                }
            }
            sw.Close();
        }

        // --x-- Fájlba történő írás "mentés céljából" --x--

        // ----- Fájl olvasása az ablak betöltését követően -> visszatölti a "mentett" teendőket -----
        public void fajl_olvas()
        {
            StreamReader sr = new StreamReader(@".\txt_fajlok\Login\" + Adatok + @"\" + nev + @"\" + nev + ".txt");
            
            while (sr.Peek() >= 0)
            {
                jegyzetek.Add(sr.ReadLine());
            }
            sr.Close();
            index = jegyzetek.Count;

        }

        // --x-- Fájl olvasása az ablak betöltését követően -> visszatölti a "mentett" teendőket --x--

        // ----- Pontok lekérése a fájlból -----
        public int fajl_pontok_lekerese()
        {
            StreamReader sr = new StreamReader(@".\txt_fajlok\Login\" + Adatok + @"\" + nev + @"\" + nev + "_pont.txt");
            int eredmeny = Convert.ToInt16(sr.ReadLine());
            sr.Close();

            return eredmeny;
        }

        // --x-- Pontok lekérése a fájlból --x--

        // ----- Pontok "mentése" a fájlba -----
        public void fajl_pontok_atadasa()
        {
            StreamWriter sw = new StreamWriter(@".\txt_fajlok\Login\" + Adatok + @"\" + nev + @"\" + nev + "_pont.txt");
            sw.WriteLine(pontok);
            sw.Close();
        }

        // --x-- Pontok "mentése" a fájlba --x--

        // ----- panelek megjelenítése -----

        public void panel_keszit()
        {
            
            pnl_teendok_fo.Controls.Clear();
            
            for(int i = 0; i < index; i++)
            {
                Panel panel = new Panel();
                panel.Name = "pnl_" + i;
                panel.Dock = DockStyle.Top;
                panel.Height = 60;
                panel.Location = new Point(0, i * 60);

                FontFamily family = new FontFamily("Century Gothic");
                Label lbl_jegyzet = new Label();
                lbl_jegyzet.Text = jegyzetek[i];
                lbl_jegyzet.Location = new Point(21, 18);
                Font font = new Font(family, 15, FontStyle.Bold);
                lbl_jegyzet.Font = font;
                lbl_jegyzet.AutoSize = true;
                lbl_jegyzet.ForeColor = System.Drawing.Color.FromArgb(247, 146, 86);

                Button btn_torles = new Button();
                btn_torles.Name = "btn_torles_" + i;
                btn_torles.Size = new Size(25, 25);
                btn_torles.FlatStyle = FlatStyle.Flat;
                Bitmap bitmap = new Bitmap(Path.Combine(Environment.CurrentDirectory, @"ikonok\kuka_ikon.png"));
                btn_torles.Image = bitmap;
                btn_torles.Text = "";
                btn_torles.Location = new Point(290, 18);
                btn_torles.FlatAppearance.BorderSize = 0;
                btn_torles.ImageAlign = ContentAlignment.MiddleCenter;
                btn_torles.Click += new EventHandler(btn_torles_Click);

                Button btn_pipa = new Button();
                btn_pipa.Name = "btn_pipa_" + i;
                btn_pipa.Size = new Size(25, 25);
                btn_pipa.FlatStyle = FlatStyle.Flat;
                Bitmap b = new Bitmap(Path.Combine(Environment.CurrentDirectory, @"ikonok\pipa_ikon.png"));
                btn_pipa.Image = b;
                btn_pipa.Text = "";
                btn_pipa.Location = new Point(328, 18);
                btn_pipa.FlatAppearance.BorderSize = 0;
                btn_pipa.ImageAlign = ContentAlignment.MiddleCenter;
                btn_pipa.Click += new EventHandler(btn_pipa_Click);

                panel.Controls.Add(lbl_jegyzet);
                panel.Controls.Add(btn_torles);
                panel.Controls.Add(btn_pipa);
                
                pnl_teendok_fo.Controls.Add(panel);
                panel.Show();
            }
            
            
        }

        // --x-- panelek megjelenítése --x--

        // ----- Fájlok készítése abban az esetben ha nem léteznek -----
        public void fajl_keszites()
        {
            
            StreamWriter fajl = File.CreateText(@".\txt_fajlok\Login\" + Adatok + @"\" + nev + @"\" + nev + ".txt");
            fajl.Close();
            StreamWriter fajl_pt = File.CreateText(@".\txt_fajlok\Login\" + Adatok + @"\" + nev + @"\" + nev + "_pont.txt");
            fajl_pt.Close();

            
        }

        // --x-- Fájlok készítése abban az esetben ha nem léteznek --x--


        // ----- "Teendő" törlése -----
        public void elem_torles(int pnl_index)
        {
            jegyzetek.RemoveAt(pnl_index);
            index = jegyzetek.Count;
            panel_keszit();
        }

        // --x-- "Teendő" törlése --x--

        // ----- "Teendő" hozzáadása -----
        public void elem_hozzaadas()
        {
            jegyzetek.Add(txt_teendo_hozzaadas.Text);
            index = jegyzetek.Count;
            if(index <= 6)
            {
                panel_keszit();
            }
            else
            {
                MessageBox.Show("Először oldd meg a jelenlegi teendőket!");
            }

            
        }

        // --x-- "Teendő" hozzáadása --x--

        // ----- Placeholder szöveg -----
        private void txt_teendo_hozzaadas_TextChanged(object sender, EventArgs e)
        {

        }

        // --x-- Placeholder szöveg --x--

        // ----- Törlés gomb event -----
        private void btn_torles_Click(object sender, EventArgs e)
        {
            Button akt_btn = (Button)sender;
            int pnl_index = Convert.ToInt16(akt_btn.Name.Substring(11));
            elem_torles(pnl_index);

        }

        // --x-- Törlés gomb event --x--

        // ----- Pipa gomb event -----
        private void btn_pipa_Click(object sender, EventArgs e)
        {
            Button akt_btn = (Button )sender;
            int pnl_index = Convert.ToInt16(akt_btn.Name.Substring(9));
            pontok = fajl_pontok_lekerese();
            lbl_megoldott.Text = "Megoldott: " + pontok;
            elem_torles(pnl_index);
            pontok += 1;
            fajl_pontok_atadasa();

        }

        // --x-- Pipa gomb event --x--

        // ----- A form betöltése -----
        private void Teendok_Form_Load(object sender, EventArgs e)
        {
            
            
            if (!File.Exists(@".\txt_fajlok\Login\" + Adatok + @"\" + nev + @"\" + nev + ".txt") && !File.Exists(@".\txt_fajlok\Login\" + Adatok + @"\" + nev + @"\" + nev + "_pont.txt"))
            {
                fajl_keszites();
            }
            else
            {
                
                txt_teendo_hozzaadas.Focus();
                pontok = fajl_pontok_lekerese();
                lbl_megoldott.Text = "Megoldott: " + pontok;

                fajl_olvas();
                panel_keszit();
                
            }
            
            
        }

        // --x-- A form betöltése --x--

        // ----- Hozzáad gomb event -----
        private void btn_teendok_hozzaad_Click(object sender, EventArgs e)
        {
            elem_hozzaadas();
            txt_teendo_hozzaadas.Clear();
            txt_teendo_hozzaadas.Focus();
            
        }

        // --x-- Hozzáad gomb event --x--

        // ----- Kilépés gomb event -----
        private void btn_kilepes_Click(object sender, EventArgs e)
        {
            fajl_iras();
            StreamReader sr = new StreamReader(@".\txt_fajlok\Osszpont_" + Adatok + ".txt");
            int osszpont = Convert.ToInt16(sr.ReadLine());
            sr.Close();
            StreamWriter sw = new StreamWriter(@".\txt_fajlok\Osszpont_" + Adatok + ".txt");
            osszpont += pontok;
            sw.WriteLine(osszpont);
            sw.Close();


            this.Close();
        }

        // --x-- Kilépés gomb event --x--
    }
}
