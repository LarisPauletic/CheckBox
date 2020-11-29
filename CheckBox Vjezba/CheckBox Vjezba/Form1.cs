using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_Vjezba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPošalji_Click(object sender, EventArgs e)
        {
            txtBx.Text = "";
            txtBx.Visible = true;
            txtBx.Text += "Odabrali ste : " + System.Environment.NewLine;

            if (btnDoručak.Checked)
            {
                txtBx.Text += "Doručak" + System.Environment.NewLine;
            }

            if (btnRučak.Checked)
            {
                txtBx.Text += "Ručak" + System.Environment.NewLine;
            }

            if (btnVečera.Checked)
            {
                txtBx.Text += "Večera" + System.Environment.NewLine;
            }

            if (sakrijNarudzbu.Checked)
            {
                txtBx.Visible = false;
            }
        }
    }
}
