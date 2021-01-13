﻿using BusinessLayer;
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
    public partial class Ugaona : Form
    {
        private readonly NamestajBusiness namestajBusiness;
        private readonly KorisnikBusiness korisnikBusiness;
        public int idProizvoda = 5;
        public Korisnik k;

        public Ugaona()
        {
            this.namestajBusiness = new NamestajBusiness();
            this.korisnikBusiness = new KorisnikBusiness();
            InitializeComponent();
        }

        public Ugaona(Korisnik k)
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

        private void btBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(k);
            f1.Show();
            this.Hide();
        }
        public void GetData()
        {
            Namestaj n = new Namestaj();
            n = this.namestajBusiness.GetNamestaj(idProizvoda);

            lbIme.Text = n.Naziv.ToString();
            lbVelicina.Text = n.Velicina.ToString();
            lbIznos.Text = n.Cena.ToString();
            if (n.Stanje > 0)
            {
                lbStanje.Text = "NA STANJU";
            }
            else
            {
                lbStanje.Text = "TRENUTNO NEMA NA STANJU";
            }
        }
        private void Ugaona4_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void btKupovina8_Click(object sender, EventArgs e)
        {
            decimal cenaKreveta = Convert.ToDecimal(lbIznos.Text);
            decimal iznosNaRacunu = Convert.ToDecimal(k.Racun);
            decimal razlika = iznosNaRacunu - cenaKreveta;
            string stanje = lbStanje.Text;
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
