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
        // operandy
        double mdblCislo1,mdblCislo2, mdblVysledek;

        //-------------------------------------------------------
        // konstruktor
        //-------------------------------------------------------
        public Form1()
        {
            InitializeComponent();

            // nastavit kalkulačku do výchozího stavu
            SmazatVse();
        }

        //-------------------------------------------------------
        // rutina obsluhuje stisky tlacitek cisel
        //-------------------------------------------------------
        private void btCislo1_Click(object sender, EventArgs e)
        {
            Button MojeTlacitko; ;

            MojeTlacitko = (Button)sender;

            // test zda na diplay není nula
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }

            // připojit stisknuté číslo na display
            txtDisplay.Text = txtDisplay.Text + MojeTlacitko.Text;
        }

        //-------------------------------------------------------
        // vyčistit kalkulačku
        //-------------------------------------------------------
        private void btSmazat_Click(object sender, EventArgs e)
        {
            SmazatVse();
        }

        //-------------------------------------------------------
        // vyčištění kalkulačky do základního stavu
        //-------------------------------------------------------
        private void SmazatVse()
        {
            txtDisplay.Text = "0";
            mdblVysledek = mdblCislo2 = mdblCislo1 = 0;
        }

        //-------------------------------------------------------
        // ošetření zvolené operace
        //-------------------------------------------------------
        private void btOperace_Click(object sender, EventArgs e)
        {
            Button MojeTlacitko; ;

            MojeTlacitko = (Button)sender;

            ZapsatCisla();
        }

        //-------------------------------------------------------
        // posunout a zapsat cisla
        //-------------------------------------------------------
        private void ZapsatCisla()
        {
            try
            {
                mdblCislo2 = mdblCislo1;
                mdblCislo1 = Convert.ToDouble(txtDisplay.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Asi máš špatně číslo");
                SmazatVse();
            }
        }
    }
}
