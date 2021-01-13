using BusinessLayer;
using DataAccessLayer.Models;
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
    public partial class Trosed2 : Form
    {
        private readonly NamestajBusiness namestajBusiness;
        private readonly KorisnikBusiness korisnikBusiness;
        public int idProizvoda = 10;
        public Korisnik k;

        public Trosed2()
        {
            this.namestajBusiness = new NamestajBusiness();
            this.korisnikBusiness = new KorisnikBusiness();
            InitializeComponent();
        }

        public Trosed2(Korisnik k)
        {
            this.namestajBusiness = new NamestajBusiness();
            this.korisnikBusiness = new KorisnikBusiness();
            InitializeComponent();
            this.k = k;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbStanje2_Click(object sender, EventArgs e)
        {

        }

        private void btBack2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(k);
            f1.Show();
            this.Hide();
        }
        public void GetData()
        {
            Namestaj n = new Namestaj();
            n = this.namestajBusiness.GetNamestaj(idProizvoda);

            lbIme2.Text = n.Naziv.ToString();
            lbVelicina2.Text = n.Velicina.ToString();
            lbIznos2.Text = n.Cena.ToString();
            if (n.Stanje > 0)
            {
                lbStanje2.Text = "NA STANJU";
            }
            else
            {
                lbStanje2.Text = "TRENUTNO NEMA NA STANJU";
            }
        }

        private void Trosed2_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void btKupovina2_Click(object sender, EventArgs e)
        {
            decimal cenaKreveta = Convert.ToDecimal(lbIznos2.Text);
            decimal iznosNaRacunu = Convert.ToDecimal(k.Racun);
            decimal razlika = iznosNaRacunu - cenaKreveta;
            string stanje = lbStanje2.Text;
            if (stanje == "NA STANJU")
            {
                if (razlika >= 0)
                {
                    MessageBox.Show("Uspešno kupljen proizvod !");
                    k.Racun = Convert.ToInt32(razlika);
                    this.korisnikBusiness.UpdateKorisnik(k);
                    Form1 f1 = new Form1(k);
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nemate dovoljno novca na računu da kupite ovaj proizvod !");
                    Form1 f1 = new Form1(k);
                    f1.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Proizvod trenutno nije dostupan !");
            }
        }
    }
}
