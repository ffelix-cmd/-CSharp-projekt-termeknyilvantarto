using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terméknyilvántartó
{
    public partial class ModositoForm : UjTermekForm
    {
        private Termek eredetiT;
        public ModositoForm(Termek T) : base()
        {
            InitializeComponent();
            btnRogzit.Text = "Mentés";

            rbUjElek.Visible = false;
            rbUjTermek.Visible = false;


            eredetiT = T;

            tbUjNev.Text = T.Nev;
            tbUjAr.Text = T.Ar.ToString();
            tbUjKeszl.Text = T.Keszlet.ToString();

            if (T is ElektronikaiTermek elekT)
            {
                tbUjGar.Text = elekT.Garancia.ToString();
                tbUjGar.Visible = true;
                label5.Visible = true;
                label1.Visible = true;

            }

            else
            {
                tbUjGar.Visible = false;
                label5.Visible = false;
            }

        }

        private void btnRogzit_Click(object sender, EventArgs e)
        {
            eredetiT.Nev = tbUjNev.Text;
            eredetiT.Ar = Convert.ToInt32(tbUjAr.Text);
            eredetiT.Keszlet = Convert.ToInt32(tbUjKeszl.Text);

            if (eredetiT is ElektronikaiTermek et)
            {
                et.Garancia = Convert.ToInt32(tbUjGar.Text);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnMegse_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
