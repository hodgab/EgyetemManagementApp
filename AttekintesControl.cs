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
    public partial class AttekintesControl : UserControl
    {
        public static AttekintesControl ControlInstance;
        public String felh_nev;
        public AttekintesControl()
        {
            InitializeComponent();
            ControlInstance = this;
            
        }



        private void btn_kalk_Click(object sender, EventArgs e)
        {
            
            Button kattint = (Button)sender;
            String nev = kattint.Name;
            nev = nev.Substring(4);
            Teendok_Form form = new Teendok_Form(nev,felh_nev);
            form.Show();
        }
    }
}
    

