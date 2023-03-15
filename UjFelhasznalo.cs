using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egyetemMan
{
    internal class UjFelhasznalo
    {
        private String Nkod;
        private String TNev;
        private String Email;
        private String Jelszo;

        public UjFelhasznalo(String nkod, String tnev, String email, String jelszo)
        {
            this.Nkod = nkod;
            this.TNev = tnev;
            this.Email = email;
            this.Jelszo = jelszo;
        }

        public bool fajl_letrehozas()
        {
            String[] kurzusok = { "adatbazis", "algo", "halozat", "kalk", "nummod", "prog", "progmod", "python" };
            String eleres = @".\txt_fajlok\Login\" + Nkod;
            if(!Directory.Exists(eleres))
            {
                Directory.CreateDirectory(eleres);
                String uj_eleres = eleres + @"\";
                for(int i = 0; i < kurzusok.Length; i++)
                {
                    Directory.CreateDirectory(uj_eleres + kurzusok[i]);
                }

                StreamWriter keszit = File.CreateText(uj_eleres+Nkod+".txt");
                keszit.Close();

                StreamWriter osszpont_keszit = File.CreateText(@".\txt_fajlok\Osszpont_" + Nkod + ".txt");
                osszpont_keszit.WriteLine("0");
                osszpont_keszit.Close();

                StreamWriter sw = new StreamWriter(uj_eleres+Nkod+".txt");
                sw.WriteLine(Nkod);
                sw.WriteLine(TNev);
                sw.WriteLine(Email);
                sw.WriteLine(Jelszo);
                sw.Close();
                
                
                return false;

            }
            else
            {
                MessageBox.Show("Ez a felhasználó már létezik!");
                return true;
            }
        }
    }
}
