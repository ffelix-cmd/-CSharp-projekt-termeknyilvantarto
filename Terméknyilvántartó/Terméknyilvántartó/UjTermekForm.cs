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

namespace Terméknyilvántartó
{
    public partial class UjTermekForm: Form
    {
        Termek t;

        internal Termek T
        {
            get
            {
                return t;
            }
            set
            {
                t = value;
            }
        
        
        }
        public UjTermekForm()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRogzit_Click(object sender, EventArgs e)
        {
            if (tbUjNev.Text !="")
            {
                //meghivom a metodust, megadom neki a termeklistat, visszaadja a legkisebb nem foglalt hianyzo szamot a SzabadAzon valtozoba.
                int SzabadAzon = Terméknyilvántartó.SzabAzon(Terméknyilvántartó.termekek);

                if (rbUjTermek.Checked == true)
                {
                   
                    
                    T = new Termek(SzabadAzon, tbUjNev.Text, Convert.ToInt32(tbUjAr.Text),
                        Convert.ToInt32(tbUjKeszl.Text));
                    

                }
                else
                {
                    
                    T = new ElektronikaiTermek(SzabadAzon, tbUjNev.Text, Convert.ToInt32(tbUjAr.Text),
                        Convert.ToInt32(tbUjKeszl.Text), Convert.ToInt32(tbUjGar.Text));
                    
                }

               

                StreamWriter w = new StreamWriter("Termekek.txt", true);
                w.WriteLine(T.FileToString());
                w.Close();

                DialogResult = DialogResult.OK;
            }
            
            else
            {
                MessageBox.Show("Hiányzó adatok!");
                DialogResult = DialogResult.Cancel;
            }
           
        }

        private void rbUjTermek_CheckedChanged(object sender, EventArgs e)
        {
            tbUjGar.Visible = false;
            label5.Visible = false;
            label_honap.Visible = false;
        }

        private void rbUjElek_CheckedChanged(object sender, EventArgs e)
        {
            tbUjGar.Visible = true;
            label5.Visible = true;
            label_honap.Visible = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
