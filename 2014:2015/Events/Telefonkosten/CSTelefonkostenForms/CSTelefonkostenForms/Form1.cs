using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
/*
 * Michael Köppl 3AHIF
 * Telefonkosten (C# Windows Forms)
 * 2014/2015
 */

using System.Windows.Forms;

namespace CSTelefonkostenForms
{
    public partial class Form1 : Form
    {

        Gespraech g;

        public Form1()
        {
            InitializeComponent();
            KostenLabel.Text = "";
        }

        private void AbhebenButton_Click(object sender, EventArgs e)
        {
            KostenLabel.Text = "";

            if (IntervallBox.Text != "" && PreisBox.Text != "")
            {
                g = new Gespraech(Convert.ToInt32(IntervallBox.Text), Convert.ToDouble(PreisBox.Text), this);
                g.abheben();
            }
            else
            {
                g = new Gespraech(1000, 10, this);
                g.abheben();
                MessageBox.Show("Standardwert 10c/Sekunde wurde eingefügt.", "Information");
            }
        }

        private void AuflegenButton_Click(object sender, EventArgs e)
        {
            g.auflegen();
            printKosten(g.gesamtkosten);
        }

        public void printKosten(double k)
        {
            KostenLabel.Text = k.ToString() + " cent";
        }
    }
}
