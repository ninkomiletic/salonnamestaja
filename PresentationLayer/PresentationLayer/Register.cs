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
    public partial class Register : Form
    {
        private readonly KorisnikBusiness korisnikBusiness;
        public Register()
        {
            this.korisnikBusiness = new KorisnikBusiness();
            InitializeComponent();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            Korisnik k = new Korisnik();

            k.Adresa = tbAdresa.Text;
            k.Ime = tbIme.Text;
            k.Prezime = tbPrezime.Text;
            k.JMBG = tbMaticni.Text;
            k.Telefon = tbTelefon.Text;
            k.Racun = Convert.ToInt32(tbIznosNovac.Text);
            k.Email = tbMejl.Text;
            k.Username = tbUsername.Text;
            k.Password = tbSifra.Text;

            if (this.korisnikBusiness.InsertKorisnik(k) ==true)
            {
                Logovanje l = new Logovanje();
                l.Show();
                MessageBox.Show("Uspešno kreiran korisnik !");
                this.Close();
            }

        }
    }
}
