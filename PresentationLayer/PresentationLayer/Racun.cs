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
    public partial class Racun : Form
    {
        private readonly KorisnikBusiness korisnikBusiness;
        public Racun()
        {
            this.korisnikBusiness = new KorisnikBusiness();
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string suma = tbNovac.Text;
            Korisnik k = new Korisnik();
            k = this.korisnikBusiness.CheckKorisnik(username, password);
            if (k.Id != 0)
            {
                int novaSuma = k.Racun + Convert.ToInt32(suma);
                k.Racun = novaSuma;
                this.korisnikBusiness.UpdateKorisnik(k);
                MessageBox.Show("Uspešno dodat iznos na račun !");
                Form1 f = new Form1(k);
                f.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Korisnik sa unetim korisničkim imenom i lozinkom ne postoji !");
            }
        }
    }
}
