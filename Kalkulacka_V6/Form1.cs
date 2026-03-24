using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulacka_V6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------
        // rutina obsluhuje stisky tlacitek cisel
        //-------------------------------------------------------
        private void btCislo1_Click(object sender, EventArgs e)
        {
            // test zda na diplay není nula
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }

            // připojit stisknuté číslo na display
            txtDisplay.Text = txtDisplay.Text + "1";
        }
    }
}
