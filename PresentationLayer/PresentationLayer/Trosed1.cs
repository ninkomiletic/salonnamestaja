﻿using System;
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
    public partial class Trosed1 : Form
    {
        private int ImageNumber = 1;
        public Trosed1()
        {
            InitializeComponent();
        }

        private void Slider()
        {
            if(ImageNumber == 2)
            {
                ImageNumber = 1;

            }
            pbTrosed1.ImageLocation = string.Format(@"Images\trosed1\{0}.jpg", ImageNumber);
            ImageNumber++;
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Trosed1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Slider();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btKupovina1_Click(object sender, EventArgs e)
        {
            double racun = 0;
            
        }
    }
}
