
namespace PresentationLayer
{
    partial class UgaonaBez
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UgaonaBez));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btKonverzija = new System.Windows.Forms.Button();
            this.btRegistracija = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.Detail1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCena3 = new System.Windows.Forms.Label();
            this.lbNaziv3 = new System.Windows.Forms.Label();
            this.lbCena2 = new System.Windows.Forms.Label();
            this.lbNaziv1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btKonverzija);
            this.panel1.Controls.Add(this.btRegistracija);
            this.panel1.Controls.Add(this.tbKonvert2);
            this.panel1.Controls.Add(this.tbKonvert1);
            this.panel1.Controls.Add(this.cmbVal2);
            this.panel1.Controls.Add(this.cmbVal1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 118);
            this.panel1.TabIndex = 0;
            // 
            // btKonverzija
            // 
            this.btKonverzija.Location = new System.Drawing.Point(625, 0);
            this.btKonverzija.Name = "btKonverzija";
            this.btKonverzija.Size = new System.Drawing.Size(51, 21);
            this.btKonverzija.TabIndex = 5;
            this.btKonverzija.Text = "=";
            this.btKonverzija.UseVisualStyleBackColor = true;
            this.btKonverzija.Click += new System.EventHandler(this.btKonverzija_Click);
            // 
            // btRegistracija
            // 
            this.btRegistracija.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btRegistracija.Location = new System.Drawing.Point(791, 0);
            this.btRegistracija.Name = "btRegistracija";
            this.btRegistracija.Size = new System.Drawing.Size(99, 32);
            this.btRegistracija.TabIndex = 4;
            this.btRegistracija.Text = "Registracija";
            this.btRegistracija.UseVisualStyleBackColor = true;
            this.btRegistracija.Click += new System.EventHandler(this.btRegistracija_Click);
            // 
            // tbKonvert2
            // 
            this.tbKonvert2.Location = new System.Drawing.Point(653, 1);
            this.tbKonvert2.Name = "tbKonvert2";
            this.tbKonvert2.Size = new System.Drawing.Size(76, 20);
            this.tbKonvert2.TabIndex = 3;
            // 
            // tbKonvert1
            // 
            this.tbKonvert1.Location = new System.Drawing.Point(571, 1);
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
            this.cmbVal1.Location = new System.Drawing.Point(506, 0);
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
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.Detail1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lbCena3);
            this.panel3.Controls.Add(this.lbNaziv3);
            this.panel3.Controls.Add(this.lbCena2);
            this.panel3.Controls.Add(this.lbNaziv1);
            this.panel3.Location = new System.Drawing.Point(202, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(687, 372);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(613, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Detaljnije";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Detail1
            // 
            this.Detail1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Detail1.Location = new System.Drawing.Point(279, 151);
            this.Detail1.Name = "Detail1";
            this.Detail1.Size = new System.Drawing.Size(75, 23);
            this.Detail1.TabIndex = 15;
            this.Detail1.Text = "Detaljnije";
            this.Detail1.UseVisualStyleBackColor = true;
            this.Detail1.Click += new System.EventHandler(this.Detail1_Click);
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
            this.pictureBox1.Size = new System.Drawing.Size(315, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbCena3
            // 
            this.lbCena3.AutoSize = true;
            this.lbCena3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCena3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbCena3.Location = new System.Drawing.Point(523, 153);
            this.lbCena3.Name = "lbCena3";
            this.lbCena3.Size = new System.Drawing.Size(87, 19);
            this.lbCena3.TabIndex = 7;
            this.lbCena3.Text = "64,000 RSD";
            // 
            // lbNaziv3
            // 
            this.lbNaziv3.AutoSize = true;
            this.lbNaziv3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNaziv3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbNaziv3.Location = new System.Drawing.Point(368, 153);
            this.lbNaziv3.Name = "lbNaziv3";
            this.lbNaziv3.Size = new System.Drawing.Size(149, 19);
            this.lbNaziv3.TabIndex = 6;
            this.lbNaziv3.Text = "CONTESSA Garnitura";
            // 
            // lbCena2
            // 
            this.lbCena2.AutoSize = true;
            this.lbCena2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCena2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbCena2.Location = new System.Drawing.Point(186, 151);
            this.lbCena2.Name = "lbCena2";
            this.lbCena2.Size = new System.Drawing.Size(87, 19);
            this.lbCena2.TabIndex = 3;
            this.lbCena2.Text = "72,000 RSD";
            // 
            // lbNaziv1
            // 
            this.lbNaziv1.AutoSize = true;
            this.lbNaziv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNaziv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbNaziv1.Location = new System.Drawing.Point(29, 151);
            this.lbNaziv1.Name = "lbNaziv1";
            this.lbNaziv1.Size = new System.Drawing.Size(151, 19);
            this.lbNaziv1.TabIndex = 1;
            this.lbNaziv1.Text = "AVANGARD Garnitura";
            // 
            // UgaonaBez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 487);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UgaonaBez";
            this.Text = "Salon namestaja";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btKonverzija;
        private System.Windows.Forms.Button btRegistracija;
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
        private System.Windows.Forms.Label lbCena3;
        private System.Windows.Forms.Label lbNaziv3;
        private System.Windows.Forms.Label lbCena2;
        private System.Windows.Forms.Label lbNaziv1;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Detail1;
    }
}

