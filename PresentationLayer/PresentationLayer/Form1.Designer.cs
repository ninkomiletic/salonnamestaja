﻿
namespace PresentationLayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btKonverzija = new System.Windows.Forms.Button();
            this.tbKonvert2 = new System.Windows.Forms.TextBox();
            this.tbKonvert1 = new System.Windows.Forms.TextBox();
            this.cmbVal2 = new System.Windows.Forms.ComboBox();
            this.cmbVal1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btFilter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbBraon = new System.Windows.Forms.RadioButton();
            this.rbBez = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbUgaona = new System.Windows.Forms.RadioButton();
            this.rbTrosed = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Detail4 = new System.Windows.Forms.Button();
            this.Detail3 = new System.Windows.Forms.Button();
            this.Detail2 = new System.Windows.Forms.Button();
            this.Detail1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCena4 = new System.Windows.Forms.Label();
            this.lbCena5 = new System.Windows.Forms.Label();
            this.lbCena3 = new System.Windows.Forms.Label();
            this.lbNaziv3 = new System.Windows.Forms.Label();
            this.lbNaziv4 = new System.Windows.Forms.Label();
            this.lbNaziv2 = new System.Windows.Forms.Label();
            this.lbCena2 = new System.Windows.Forms.Label();
            this.lbNaziv1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbKorisnik = new System.Windows.Forms.Label();
            this.lbRacun = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lbRacun);
            this.panel1.Controls.Add(this.lbKorisnik);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btKonverzija);
            this.panel1.Controls.Add(this.tbKonvert2);
            this.panel1.Controls.Add(this.tbKonvert1);
            this.panel1.Controls.Add(this.cmbVal2);
            this.panel1.Controls.Add(this.cmbVal1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 118);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dodaj novac";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btKonverzija
            // 
            this.btKonverzija.Location = new System.Drawing.Point(615, 0);
            this.btKonverzija.Name = "btKonverzija";
            this.btKonverzija.Size = new System.Drawing.Size(51, 21);
            this.btKonverzija.TabIndex = 5;
            this.btKonverzija.Text = "=";
            this.btKonverzija.UseVisualStyleBackColor = true;
            this.btKonverzija.Click += new System.EventHandler(this.btKonverzija_Click);
            // 
            // tbKonvert2
            // 
            this.tbKonvert2.Location = new System.Drawing.Point(663, 1);
            this.tbKonvert2.Name = "tbKonvert2";
            this.tbKonvert2.Size = new System.Drawing.Size(66, 20);
            this.tbKonvert2.TabIndex = 3;
            // 
            // tbKonvert1
            // 
            this.tbKonvert1.Location = new System.Drawing.Point(562, 1);
            this.tbKonvert1.Name = "tbKonvert1";
            this.tbKonvert1.Size = new System.Drawing.Size(57, 20);
            this.tbKonvert1.TabIndex = 2;
            // 
            // cmbVal2
            // 
            this.cmbVal2.FormattingEnabled = true;
            this.cmbVal2.Items.AddRange(new object[] {
            "EUR",
            "RSD",
            "USD",
            "CHF",
            "GBP"});
            this.cmbVal2.Location = new System.Drawing.Point(726, 0);
            this.cmbVal2.Name = "cmbVal2";
            this.cmbVal2.Size = new System.Drawing.Size(68, 21);
            this.cmbVal2.TabIndex = 1;
            // 
            // cmbVal1
            // 
            this.cmbVal1.FormattingEnabled = true;
            this.cmbVal1.Items.AddRange(new object[] {
            "RSD",
            "EUR",
            "USD",
            "CHF",
            "GBP"});
            this.cmbVal1.Location = new System.Drawing.Point(496, 0);
            this.cmbVal1.Name = "cmbVal1";
            this.cmbVal1.Size = new System.Drawing.Size(69, 21);
            this.cmbVal1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.btFilter);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 372);
            this.panel2.TabIndex = 1;
            // 
            // btFilter
            // 
            this.btFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btFilter.Location = new System.Drawing.Point(40, 283);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(100, 36);
            this.btFilter.TabIndex = 3;
            this.btFilter.Text = "Primeni filter";
            this.btFilter.UseVisualStyleBackColor = true;
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBraon);
            this.groupBox2.Controls.Add(this.rbBez);
            this.groupBox2.Location = new System.Drawing.Point(14, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 112);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prema boji";
            // 
            // rbBraon
            // 
            this.rbBraon.AutoSize = true;
            this.rbBraon.Location = new System.Drawing.Point(4, 64);
            this.rbBraon.Name = "rbBraon";
            this.rbBraon.Size = new System.Drawing.Size(53, 17);
            this.rbBraon.TabIndex = 3;
            this.rbBraon.TabStop = true;
            this.rbBraon.Text = "Braon";
            this.rbBraon.UseVisualStyleBackColor = true;
            // 
            // rbBez
            // 
            this.rbBez.AutoSize = true;
            this.rbBez.Location = new System.Drawing.Point(4, 28);
            this.rbBez.Name = "rbBez";
            this.rbBez.Size = new System.Drawing.Size(43, 17);
            this.rbBez.TabIndex = 2;
            this.rbBez.TabStop = true;
            this.rbBez.Text = "Bež";
            this.rbBez.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbUgaona);
            this.groupBox1.Controls.Add(this.rbTrosed);
            this.groupBox1.Location = new System.Drawing.Point(14, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prema predmetu";
            // 
            // rbUgaona
            // 
            this.rbUgaona.AutoSize = true;
            this.rbUgaona.Location = new System.Drawing.Point(6, 64);
            this.rbUgaona.Name = "rbUgaona";
            this.rbUgaona.Size = new System.Drawing.Size(107, 17);
            this.rbUgaona.TabIndex = 1;
            this.rbUgaona.TabStop = true;
            this.rbUgaona.Text = "Ugaona garnitura";
            this.rbUgaona.UseVisualStyleBackColor = true;
            // 
            // rbTrosed
            // 
            this.rbTrosed.AutoSize = true;
            this.rbTrosed.Location = new System.Drawing.Point(4, 28);
            this.rbTrosed.Name = "rbTrosed";
            this.rbTrosed.Size = new System.Drawing.Size(58, 17);
            this.rbTrosed.TabIndex = 0;
            this.rbTrosed.TabStop = true;
            this.rbTrosed.Text = "Trosed";
            this.rbTrosed.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filteri:";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.Detail4);
            this.panel3.Controls.Add(this.Detail3);
            this.panel3.Controls.Add(this.Detail2);
            this.panel3.Controls.Add(this.Detail1);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lbCena4);
            this.panel3.Controls.Add(this.lbCena5);
            this.panel3.Controls.Add(this.lbCena3);
            this.panel3.Controls.Add(this.lbNaziv3);
            this.panel3.Controls.Add(this.lbNaziv4);
            this.panel3.Controls.Add(this.lbNaziv2);
            this.panel3.Controls.Add(this.lbCena2);
            this.panel3.Controls.Add(this.lbNaziv1);
            this.panel3.Location = new System.Drawing.Point(202, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(687, 372);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Detail4
            // 
            this.Detail4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Detail4.Location = new System.Drawing.Point(588, 298);
            this.Detail4.Name = "Detail4";
            this.Detail4.Size = new System.Drawing.Size(75, 23);
            this.Detail4.TabIndex = 17;
            this.Detail4.Text = "Detaljnije";
            this.Detail4.UseVisualStyleBackColor = true;
            this.Detail4.Click += new System.EventHandler(this.Detail4_Click);
            // 
            // Detail3
            // 
            this.Detail3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Detail3.Location = new System.Drawing.Point(260, 298);
            this.Detail3.Name = "Detail3";
            this.Detail3.Size = new System.Drawing.Size(75, 23);
            this.Detail3.TabIndex = 16;
            this.Detail3.Text = "Detaljnije";
            this.Detail3.UseVisualStyleBackColor = true;
            this.Detail3.Click += new System.EventHandler(this.Detail3_Click);
            // 
            // Detail2
            // 
            this.Detail2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Detail2.Location = new System.Drawing.Point(585, 144);
            this.Detail2.Name = "Detail2";
            this.Detail2.Size = new System.Drawing.Size(75, 23);
            this.Detail2.TabIndex = 15;
            this.Detail2.Text = "Detaljnije";
            this.Detail2.UseVisualStyleBackColor = true;
            this.Detail2.Click += new System.EventHandler(this.Detail2_Click);
            // 
            // Detail1
            // 
            this.Detail1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Detail1.Location = new System.Drawing.Point(260, 146);
            this.Detail1.Name = "Detail1";
            this.Detail1.Size = new System.Drawing.Size(75, 23);
            this.Detail1.TabIndex = 14;
            this.Detail1.Text = "Detaljnije";
            this.Detail1.UseVisualStyleBackColor = true;
            this.Detail1.Click += new System.EventHandler(this.Detail1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(368, 173);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(306, 122);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(29, 173);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(306, 122);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(368, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(306, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbCena4
            // 
            this.lbCena4.AutoSize = true;
            this.lbCena4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCena4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbCena4.Location = new System.Drawing.Point(169, 300);
            this.lbCena4.Name = "lbCena4";
            this.lbCena4.Size = new System.Drawing.Size(87, 19);
            this.lbCena4.TabIndex = 9;
            this.lbCena4.Text = "68,000 RSD";
            // 
            // lbCena5
            // 
            this.lbCena5.AutoSize = true;
            this.lbCena5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCena5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbCena5.Location = new System.Drawing.Point(489, 300);
            this.lbCena5.Name = "lbCena5";
            this.lbCena5.Size = new System.Drawing.Size(87, 19);
            this.lbCena5.TabIndex = 8;
            this.lbCena5.Text = "60,000 RSD";
            // 
            // lbCena3
            // 
            this.lbCena3.AutoSize = true;
            this.lbCena3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCena3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbCena3.Location = new System.Drawing.Point(492, 146);
            this.lbCena3.Name = "lbCena3";
            this.lbCena3.Size = new System.Drawing.Size(87, 19);
            this.lbCena3.TabIndex = 7;
            this.lbCena3.Text = "42,000 RSD";
            // 
            // lbNaziv3
            // 
            this.lbNaziv3.AutoSize = true;
            this.lbNaziv3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNaziv3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbNaziv3.Location = new System.Drawing.Point(368, 146);
            this.lbNaziv3.Name = "lbNaziv3";
            this.lbNaziv3.Size = new System.Drawing.Size(102, 19);
            this.lbNaziv3.TabIndex = 6;
            this.lbNaziv3.Text = "JOLLY Trosed";
            // 
            // lbNaziv4
            // 
            this.lbNaziv4.AutoSize = true;
            this.lbNaziv4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNaziv4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbNaziv4.Location = new System.Drawing.Point(368, 300);
            this.lbNaziv4.Name = "lbNaziv4";
            this.lbNaziv4.Size = new System.Drawing.Size(115, 19);
            this.lbNaziv4.TabIndex = 5;
            this.lbNaziv4.Text = "ROMA Garnitura";
            // 
            // lbNaziv2
            // 
            this.lbNaziv2.AutoSize = true;
            this.lbNaziv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNaziv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbNaziv2.Location = new System.Drawing.Point(29, 300);
            this.lbNaziv2.Name = "lbNaziv2";
            this.lbNaziv2.Size = new System.Drawing.Size(134, 19);
            this.lbNaziv2.TabIndex = 4;
            this.lbNaziv2.Text = "ADRIANA Garnitura";
            // 
            // lbCena2
            // 
            this.lbCena2.AutoSize = true;
            this.lbCena2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCena2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbCena2.Location = new System.Drawing.Point(163, 148);
            this.lbCena2.Name = "lbCena2";
            this.lbCena2.Size = new System.Drawing.Size(87, 19);
            this.lbCena2.TabIndex = 3;
            this.lbCena2.Text = "47,000 RSD";
            // 
            // lbNaziv1
            // 
            this.lbNaziv1.AutoSize = true;
            this.lbNaziv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNaziv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbNaziv1.Location = new System.Drawing.Point(29, 148);
            this.lbNaziv1.Name = "lbNaziv1";
            this.lbNaziv1.Size = new System.Drawing.Size(128, 19);
            this.lbNaziv1.TabIndex = 1;
            this.lbNaziv1.Text = "BOLOGNA Trosed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Korisnik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Račun:";
            // 
            // lbKorisnik
            // 
            this.lbKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKorisnik.Location = new System.Drawing.Point(82, 11);
            this.lbKorisnik.Name = "lbKorisnik";
            this.lbKorisnik.Size = new System.Drawing.Size(163, 16);
            this.lbKorisnik.TabIndex = 9;
            // 
            // lbRacun
            // 
            this.lbRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRacun.Location = new System.Drawing.Point(82, 39);
            this.lbRacun.Name = "lbRacun";
            this.lbRacun.Size = new System.Drawing.Size(163, 16);
            this.lbRacun.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 487);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Salon namestaja";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btKonverzija;
        private System.Windows.Forms.TextBox tbKonvert2;
        private System.Windows.Forms.TextBox tbKonvert1;
        private System.Windows.Forms.ComboBox cmbVal2;
        private System.Windows.Forms.ComboBox cmbVal1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbBraon;
        private System.Windows.Forms.RadioButton rbBez;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbUgaona;
        private System.Windows.Forms.RadioButton rbTrosed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbCena4;
        private System.Windows.Forms.Label lbCena5;
        private System.Windows.Forms.Label lbCena3;
        private System.Windows.Forms.Label lbNaziv3;
        private System.Windows.Forms.Label lbNaziv4;
        private System.Windows.Forms.Label lbNaziv2;
        private System.Windows.Forms.Label lbCena2;
        private System.Windows.Forms.Label lbNaziv1;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Detail4;
        private System.Windows.Forms.Button Detail3;
        private System.Windows.Forms.Button Detail2;
        private System.Windows.Forms.Button Detail1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbRacun;
        private System.Windows.Forms.Label lbKorisnik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

