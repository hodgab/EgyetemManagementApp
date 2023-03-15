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
    public partial class HataridokControl : UserControl
    {
        public static HataridokControl ControlInstance;
        public String felh_nev;
        public List<String> hataridok_targy = new List<String>();
        public List<DateTime> hataridok_datum = new List<DateTime>();
        public HataridokControl()
        {
            InitializeComponent();
            ControlInstance= this;
        }

        private void btn_hatarido_hozzaad_Click(object sender, EventArgs e)
        {
            HataridoHozzaad_Form form = new HataridoHozzaad_Form(felh_nev);
            form.Show();
            
        }
    }
}
