using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terméknyilvántartó
{
    public partial class Terméknyilvántartó : Form
    {
        public static List<Termek> termekek = new List<Termek>();
        public Terméknyilvántartó()
        {
            InitializeComponent();
            Beolvasas();
        }


        //megadom a lista parameteret, igy meg tudja vizsgalni melyek a mar letezo azonositok
        public static int SzabAzon(List<Termek> termekek)
        {
            //HashSetben eltaroljuk a meglevo indexeket, majd addig leptetjuk a ciklust amig olyan nem lesz ami szabad
            HashSet<int> fogAzon = termekek.Select(t => t.Azonosito).ToHashSet();

            int i = 1;
            while (fogAzon.Contains(i))
            {
                i++;
            }
            return i;
        }

        private void Beolvasas()
        {
            if (File.Exists("Termekek.txt"))
            {
                StreamReader r = new StreamReader("Termekek.txt");

                while (!r.EndOfStream)
                {
                    Termek t;
                    string[] sor = r.ReadLine().Split(';');

                    if (sor.Length == 4)
                    {
                        t = new Termek(Convert.ToInt32(sor[0]), sor[1], Convert.ToInt32(sor[2]), Convert.ToInt32(sor[3]));
                        termekek.Add(t);
                        lbTermekek.Items.Add(t);
                    }
                    else if (sor.Length == 5)
                    {
                        t = new ElektronikaiTermek(Convert.ToInt32(sor[0]), sor[1], Convert.ToInt32(sor[2]), Convert.ToInt32(sor[3]), Convert.ToInt32(sor[4]));
                        termekek.Add(t);
                        lbElektr.Items.Add(t);
                    }
                }

                r.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rbTermekek_CheckedChanged(object sender, EventArgs e)
        {
            lbElektr.ClearSelected();

            if (rbTermekek.Checked)
            {
                tbAzon.Text = "";
                tbNev.Text = "";
                tbAr.Text = "";
                tbKeszl.Text = "";
                tbGar.Text = "";

                lbTermekek.Visible = true;
                label1.Visible = true;
                lbElektr.Visible = false;
                label2.Visible = false;
                tbGar.Visible = false;
                label6.Visible = false;
                label10.Visible = false;
            }
        }

        private void rbElektr_CheckedChanged(object sender, EventArgs e)
        {
            lbTermekek.ClearSelected();

            if (rbElektr.Checked)
            {
                tbAzon.Text = "";
                tbNev.Text = "";
                tbAr.Text = "";
                tbKeszl.Text = "";
                tbGar.Text = "";

                lbElektr.Visible = true;
                label2.Visible = true;
                tbGar.Visible = true;
                label6.Visible = true;
                label10.Visible = true;
                lbTermekek.Visible = false;
                label1.Visible = false;
            }
        }

        private void termékHozzáadásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UjTermekForm uj = new UjTermekForm();
            if (uj.ShowDialog() == DialogResult.OK)
            {
                termekek.Add(uj.T);

                if (uj.T is ElektronikaiTermek)
                {
                    lbElektr.Items.Add(uj.T);
                }
                else
                {
                    lbTermekek.Items.Add(uj.T);
                }

            }
        }

        private void lbElektr_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTermekek.ClearSelected();
            Kiiras();
        }

        private void Kiiras()
        {
            if (lbTermekek.SelectedItem is Termek termek && !(termek is ElektronikaiTermek))
            {
                tbAzon.Text = termek.Azonosito.ToString();
                tbNev.Text = termek.Nev;
                tbAr.Text = termek.Ar.ToString();
                tbKeszl.Text = termek.Keszlet.ToString();
            }
            else if (lbElektr.SelectedItem is ElektronikaiTermek Elektermek)
            {
                tbAzon.Text = Elektermek.Azonosito.ToString();
                tbNev.Text = Elektermek.Nev;
                tbAr.Text = Elektermek.Ar.ToString();
                tbKeszl.Text = Elektermek.Keszlet.ToString();
                tbGar.Text = Elektermek.Garancia.ToString();
            }
        }

        private void lbTermekek_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbElektr.ClearSelected();
            Kiiras();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lbElektr.SelectedIndex >= 0)
            {
                int index = lbElektr.SelectedIndex;
                var csakElekt = termekek.OfType<ElektronikaiTermek>().ToList();
                ElektronikaiTermek torles = csakElekt[index];

                termekek.Remove(torles);
                lbElektr.Items.RemoveAt(index);

                MessageBox.Show("Elektronikai termék törölve!");
            }

            else if (lbTermekek.SelectedIndex >= 0)
            {
                int index = lbTermekek.SelectedIndex;
                List<Termek> csakTerm = new List<Termek>();

                foreach (Termek t in termekek)
                {
                    if (!(t is ElektronikaiTermek))
                    {
                        csakTerm.Add(t);
                    }
                
                }
                
                
                Termek torles = csakTerm[index]; //index alapjan kivalasztom a torlendo elemet

                termekek.Remove(torles);
                lbTermekek.Items.RemoveAt(index);

                MessageBox.Show("Termék törölve!");
            }
            else
            {
                MessageBox.Show("Nincs kijelölve termék!");
            }
            File.WriteAllLines("Termekek.txt", termekek.Select(t => t.FileToString())); //fajlbol torles

            //textboxokbol torles
            tbAzon.Text = "";
            tbNev.Text = "";
            tbAr.Text = "";
            tbKeszl.Text = "";
            tbGar.Text = "";
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            Termek valTermek = null;

            if (rbTermekek.Checked && lbTermekek.SelectedItem != null)
            {
                valTermek = lbTermekek.SelectedItem as Termek;
            }
            else if (rbElektr.Checked && lbElektr.SelectedItem != null)
            {
                valTermek = lbElektr.SelectedItem as Termek;
            }

            if (valTermek != null)
            {
                ModositoForm modosito = new ModositoForm(valTermek);
                if (modosito.ShowDialog() == DialogResult.OK)
                {

                    File.WriteAllLines("Termekek.txt", termekek.Select(t => t.FileToString()));

                    // Lista frissitese adatmodositas utan
                    lbTermekek.Items.Clear();
                    lbElektr.Items.Clear();

                    tbAzon.Text = "";
                    tbNev.Text = "";
                    tbAr.Text = "";
                    tbKeszl.Text = "";
                    tbGar.Text = "";

                    foreach (Termek t in termekek)
                    {
                        if (t is ElektronikaiTermek)
                            lbElektr.Items.Add(t);
                        else
                            lbTermekek.Items.Add(t);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nincs kiválasztott termék!");
            }
        }
    }
}
