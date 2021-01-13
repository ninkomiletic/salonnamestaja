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
    public partial class Logovanje : Form
    {
        private readonly KorisnikBusiness korisnikBusiness;
        public Logovanje()
        {
            this.korisnikBusiness = new KorisnikBusiness();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            Korisnik k = new Korisnik();
            k = this.korisnikBusiness.CheckKorisnik(username, password);
            if (k.Id != 0)
            {
                MessageBox.Show("Uspešno logovanje !");
                Form1 f = new Form1(k);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Korisnik sa unetim korisničkim imenom i lozinkom ne postoji !");
                tbPassword.ResetText();
                tbUsername.ResetText();
            }
        }
    }
}
