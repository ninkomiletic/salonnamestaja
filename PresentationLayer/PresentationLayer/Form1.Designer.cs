
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTrosed = new System.Windows.Forms.RadioButton();
            this.rbFotelja = new System.Windows.Forms.RadioButton();
            this.rbBela = new System.Windows.Forms.RadioButton();
            this.rbSiva = new System.Windows.Forms.RadioButton();
            this.cbVal1 = new System.Windows.Forms.ComboBox();
            this.cbVal2 = new System.Windows.Forms.ComboBox();
            this.tbIznos1 = new System.Windows.Forms.TextBox();
            this.tbIznos2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btKonverzija = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbCena1 = new System.Windows.Forms.Label();
            this.lbNaziv1 = new System.Windows.Forms.Label();
            this.lbCena2 = new System.Windows.Forms.Label();
            this.lbNaziv2 = new System.Windows.Forms.Label();
            this.lbNaziv4 = new System.Windows.Forms.Label();
            this.lbNaziv3 = new System.Windows.Forms.Label();
            this.lbCena3 = new System.Windows.Forms.Label();
            this.lbCena5 = new System.Windows.Forms.Label();
            this.lbCena4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btKonverzija);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbIznos2);
            this.panel1.Controls.Add(this.tbIznos1);
            this.panel1.Controls.Add(this.cbVal2);
            this.panel1.Controls.Add(this.cbVal1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 150);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 309);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbCena4);
            this.panel3.Controls.Add(this.lbCena5);
            this.panel3.Controls.Add(this.lbCena3);
            this.panel3.Controls.Add(this.lbNaziv3);
            this.panel3.Controls.Add(this.lbNaziv4);
            this.panel3.Controls.Add(this.lbNaziv2);
            this.panel3.Controls.Add(this.lbCena2);
            this.panel3.Controls.Add(this.lbNaziv1);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(202, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(687, 309);
            this.panel3.TabIndex = 2;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFotelja);
            this.groupBox1.Controls.Add(this.rbTrosed);
            this.groupBox1.Location = new System.Drawing.Point(14, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prema predmetu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSiva);
            this.groupBox2.Controls.Add(this.rbBela);
            this.groupBox2.Location = new System.Drawing.Point(14, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 112);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prema boji";
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
            // rbFotelja
            // 
            this.rbFotelja.AutoSize = true;
            this.rbFotelja.Location = new System.Drawing.Point(6, 64);
            this.rbFotelja.Name = "rbFotelja";
            this.rbFotelja.Size = new System.Drawing.Size(56, 17);
            this.rbFotelja.TabIndex = 1;
            this.rbFotelja.TabStop = true;
            this.rbFotelja.Text = "Fotelja";
            this.rbFotelja.UseVisualStyleBackColor = true;
            // 
            // rbBela
            // 
            this.rbBela.AutoSize = true;
            this.rbBela.Location = new System.Drawing.Point(4, 28);
            this.rbBela.Name = "rbBela";
            this.rbBela.Size = new System.Drawing.Size(46, 17);
            this.rbBela.TabIndex = 2;
            this.rbBela.TabStop = true;
            this.rbBela.Text = "Bela";
            this.rbBela.UseVisualStyleBackColor = true;
            // 
            // rbSiva
            // 
            this.rbSiva.AutoSize = true;
            this.rbSiva.Location = new System.Drawing.Point(4, 64);
            this.rbSiva.Name = "rbSiva";
            this.rbSiva.Size = new System.Drawing.Size(46, 17);
            this.rbSiva.TabIndex = 3;
            this.rbSiva.TabStop = true;
            this.rbSiva.Text = "Siva";
            this.rbSiva.UseVisualStyleBackColor = true;
            // 
            // cbVal1
            // 
            this.cbVal1.FormattingEnabled = true;
            this.cbVal1.Items.AddRange(new object[] {
            "RSD",
            "EUR",
            "USD",
            "CHF",
            "GBP"});
            this.cbVal1.Location = new System.Drawing.Point(444, 2);
            this.cbVal1.Name = "cbVal1";
            this.cbVal1.Size = new System.Drawing.Size(78, 21);
            this.cbVal1.TabIndex = 0;
            // 
            // cbVal2
            // 
            this.cbVal2.FormattingEnabled = true;
            this.cbVal2.Items.AddRange(new object[] {
            "EUR",
            "RSD",
            "USD",
            "CHF",
            "GBP"});
            this.cbVal2.Location = new System.Drawing.Point(740, 2);
            this.cbVal2.Name = "cbVal2";
            this.cbVal2.Size = new System.Drawing.Size(78, 21);
            this.cbVal2.TabIndex = 1;
            // 
            // tbIznos1
            // 
            this.tbIznos1.Location = new System.Drawing.Point(519, 3);
            this.tbIznos1.Name = "tbIznos1";
            this.tbIznos1.Size = new System.Drawing.Size(78, 20);
            this.tbIznos1.TabIndex = 2;
            // 
            // tbIznos2
            // 
            this.tbIznos2.Location = new System.Drawing.Point(665, 3);
            this.tbIznos2.Name = "tbIznos2";
            this.tbIznos2.Size = new System.Drawing.Size(78, 20);
            this.tbIznos2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(815, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Korpa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btKonverzija
            // 
            this.btKonverzija.Location = new System.Drawing.Point(594, 1);
            this.btKonverzija.Name = "btKonverzija";
            this.btKonverzija.Size = new System.Drawing.Size(75, 23);
            this.btKonverzija.TabIndex = 5;
            this.btKonverzija.Text = "=";
            this.btKonverzija.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbCena1);
            this.panel4.Location = new System.Drawing.Point(44, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 136);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(44, 161);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(275, 136);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(379, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(275, 136);
            this.panel6.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(379, 161);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(275, 136);
            this.panel7.TabIndex = 2;
            // 
            // lbCena1
            // 
            this.lbCena1.AutoSize = true;
            this.lbCena1.Location = new System.Drawing.Point(149, 136);
            this.lbCena1.Name = "lbCena1";
            this.lbCena1.Size = new System.Drawing.Size(60, 13);
            this.lbCena1.TabIndex = 0;
            this.lbCena1.Text = "labelaCena";
            // 
            // lbNaziv1
            // 
            this.lbNaziv1.AutoSize = true;
            this.lbNaziv1.Location = new System.Drawing.Point(85, 145);
            this.lbNaziv1.Name = "lbNaziv1";
            this.lbNaziv1.Size = new System.Drawing.Size(62, 13);
            this.lbNaziv1.TabIndex = 1;
            this.lbNaziv1.Text = "labelaNaziv";
            // 
            // lbCena2
            // 
            this.lbCena2.AutoSize = true;
            this.lbCena2.Location = new System.Drawing.Point(212, 145);
            this.lbCena2.Name = "lbCena2";
            this.lbCena2.Size = new System.Drawing.Size(60, 13);
            this.lbCena2.TabIndex = 3;
            this.lbCena2.Text = "labelaCena";
            // 
            // lbNaziv2
            // 
            this.lbNaziv2.AutoSize = true;
            this.lbNaziv2.Location = new System.Drawing.Point(85, 296);
            this.lbNaziv2.Name = "lbNaziv2";
            this.lbNaziv2.Size = new System.Drawing.Size(62, 13);
            this.lbNaziv2.TabIndex = 4;
            this.lbNaziv2.Text = "labelaNaziv";
            // 
            // lbNaziv4
            // 
            this.lbNaziv4.AutoSize = true;
            this.lbNaziv4.Location = new System.Drawing.Point(437, 296);
            this.lbNaziv4.Name = "lbNaziv4";
            this.lbNaziv4.Size = new System.Drawing.Size(62, 13);
            this.lbNaziv4.TabIndex = 5;
            this.lbNaziv4.Text = "labelaNaziv";
            // 
            // lbNaziv3
            // 
            this.lbNaziv3.AutoSize = true;
            this.lbNaziv3.Location = new System.Drawing.Point(437, 145);
            this.lbNaziv3.Name = "lbNaziv3";
            this.lbNaziv3.Size = new System.Drawing.Size(62, 13);
            this.lbNaziv3.TabIndex = 6;
            this.lbNaziv3.Text = "labelaNaziv";
            // 
            // lbCena3
            // 
            this.lbCena3.AutoSize = true;
            this.lbCena3.Location = new System.Drawing.Point(555, 145);
            this.lbCena3.Name = "lbCena3";
            this.lbCena3.Size = new System.Drawing.Size(60, 13);
            this.lbCena3.TabIndex = 7;
            this.lbCena3.Text = "labelaCena";
            // 
            // lbCena5
            // 
            this.lbCena5.AutoSize = true;
            this.lbCena5.Location = new System.Drawing.Point(555, 296);
            this.lbCena5.Name = "lbCena5";
            this.lbCena5.Size = new System.Drawing.Size(60, 13);
            this.lbCena5.TabIndex = 8;
            this.lbCena5.Text = "labelaCena";
            // 
            // lbCena4
            // 
            this.lbCena4.AutoSize = true;
            this.lbCena4.Location = new System.Drawing.Point(212, 296);
            this.lbCena4.Name = "lbCena4";
            this.lbCena4.Size = new System.Drawing.Size(60, 13);
            this.lbCena4.TabIndex = 9;
            this.lbCena4.Text = "labelaCena";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 459);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Salon namestaja";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btKonverzija;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbIznos2;
        private System.Windows.Forms.TextBox tbIznos1;
        private System.Windows.Forms.ComboBox cbVal2;
        private System.Windows.Forms.ComboBox cbVal1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSiva;
        private System.Windows.Forms.RadioButton rbBela;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFotelja;
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
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbCena1;
    }
}

