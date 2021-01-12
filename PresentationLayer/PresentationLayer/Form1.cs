using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btKonverzija_Click(object sender, EventArgs e)
        {
            double i = double.Parse(tbKonvert1.Text);
            if (cmbVal1.SelectedItem == "RSD" && cmbVal2.SelectedItem == "RSD")
            {
                double conver = i;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "RSD" && cmbVal2.SelectedItem == "EUR")
            {
                double conver = i / 117.5696;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "RSD" && cmbVal2.SelectedItem == "USD")
            {
                double conver = i / 98.9393;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "RSD" && cmbVal2.SelectedItem == "CHF")
            {
                double conver = i / 108.7198;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "RSD" && cmbVal2.SelectedItem == "GBP")
            {
                double conver = i / 131.3774;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "EUR" && cmbVal2.SelectedItem == "EUR")
            {
                double conver = i;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "EUR" && cmbVal2.SelectedItem == "RSD")
            {
                double conver = i * 117.561;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "EUR" && cmbVal2.SelectedItem == "USD")
            {
                double conver = i * 1.18578;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "EUR" && cmbVal2.SelectedItem == "CHF")
            {
                double conver = i * 1.08015;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "EUR" && cmbVal2.SelectedItem == "GBP")
            {
                double conver = i * 0.892437;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "USD" && cmbVal2.SelectedItem == "USD")
            {
                double conver = i;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "USD" && cmbVal2.SelectedItem == "EUR")
            {
                double conver = i * 0.843328;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "USD" && cmbVal2.SelectedItem == "RSD")
            {
                double conver = i * 99.1421;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "USD" && cmbVal2.SelectedItem == "CHF")
            {
                double conver = i * 0.910923;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "USD" && cmbVal2.SelectedItem == "GBP")
            {
                double conver = i * 0.752617; ;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "CHF" && cmbVal2.SelectedItem == "CHF")
            {
                double conver = i;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "CHF" && cmbVal2.SelectedItem == "EUR")
            {
                double conver = i * 0.925795; ;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "CHF" && cmbVal2.SelectedItem == "RSD")
            {
                double conver = i * 108.837; ;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "CHF" && cmbVal2.SelectedItem == "USD")
            {
                double conver = i * 1.09779;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "CHF" && cmbVal2.SelectedItem == "GBP")
            {
                double conver = i * 0.826213;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "GBP" && cmbVal2.SelectedItem == "GBP")
            {
                double conver = i;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "GBP" && cmbVal2.SelectedItem == "EUR")
            {
                double conver = i * 1.12053;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "GBP" && cmbVal2.SelectedItem == "RSD")
            {
                double conver = i * 131.730;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "GBP" && cmbVal2.SelectedItem == "CHF")
            {
                double conver = i * 0.826213;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
            if (cmbVal1.SelectedItem == "GBP" && cmbVal2.SelectedItem == "USD")
            {
                double conver = i * 1.32870;
                conver = Math.Round(conver, 2);
                tbKonvert2.Text = "" + conver;
            }
        }

        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            if(rbBez.Checked && rbTrosed.Checked)
            {
                TrosedBez tbe = new TrosedBez();
                tbe.Show();
                this.Hide();
            }

            if (rbBraon.Checked && rbTrosed.Checked)
            {
                TrosedBraon tbr = new TrosedBraon();
                tbr.Show();
                this.Hide();
            }

            if (rbBez.Checked && rbUgaona.Checked)
            {
                UgaonaBez ube = new UgaonaBez();
                ube.Show();
                this.Hide();
            }

            if (rbBraon.Checked && rbUgaona.Checked)
            {
                UgaonaBraon ubr = new UgaonaBraon();
                ubr.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btRegistracija_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }

        private void Detail1_Click(object sender, EventArgs e)
        {
            Trosed1 t1 = new Trosed1();
            t1.Show();
            this.Hide();
        }

        private void Detail2_Click(object sender, EventArgs e)
        {
            Trosed2 t2 = new Trosed2();
            t2.Show();
            this.Hide();
        }

        private void Detail3_Click(object sender, EventArgs e)
        {
            Ugaona2 u2 = new Ugaona2();
            u2.Show();
            this.Hide();
        }

        private void Detail4_Click(object sender, EventArgs e)
        {
            Ugaona4 u4 = new Ugaona4();
            u4.Show();
            this.Hide();
        }
    }
}
