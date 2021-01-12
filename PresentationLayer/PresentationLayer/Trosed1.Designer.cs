
namespace PresentationLayer
{
    partial class Trosed1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trosed1));
            this.pbTrosed1 = new System.Windows.Forms.PictureBox();
            this.lbIme1 = new System.Windows.Forms.Label();
            this.lbVelicina1 = new System.Windows.Forms.Label();
            this.lbIznos1 = new System.Windows.Forms.Label();
            this.lbStanje1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername1 = new System.Windows.Forms.TextBox();
            this.tbSifra1 = new System.Windows.Forms.TextBox();
            this.btKupovina1 = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrosed1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTrosed1
            // 
            this.pbTrosed1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTrosed1.Image = ((System.Drawing.Image)(resources.GetObject("pbTrosed1.Image")));
            this.pbTrosed1.Location = new System.Drawing.Point(22, 110);
            this.pbTrosed1.Name = "pbTrosed1";
            this.pbTrosed1.Size = new System.Drawing.Size(369, 209);
            this.pbTrosed1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrosed1.TabIndex = 0;
            this.pbTrosed1.TabStop = false;
            // 
            // lbIme1
            // 
            this.lbIme1.AutoSize = true;
            this.lbIme1.Location = new System.Drawing.Point(19, 42);
            this.lbIme1.Name = "lbIme1";
            this.lbIme1.Size = new System.Drawing.Size(104, 13);
            this.lbIme1.TabIndex = 3;
            this.lbIme1.Text = "Ime troseda1 iz baze";
            // 
            // lbVelicina1
            // 
            this.lbVelicina1.AutoSize = true;
            this.lbVelicina1.Location = new System.Drawing.Point(19, 78);
            this.lbVelicina1.Name = "lbVelicina1";
            this.lbVelicina1.Size = new System.Drawing.Size(132, 13);
            this.lbVelicina1.TabIndex = 4;
            this.lbVelicina1.Text = "Dimenzije troseda1 iz baze";
            // 
            // lbIznos1
            // 
            this.lbIznos1.AutoSize = true;
            this.lbIznos1.Location = new System.Drawing.Point(69, 331);
            this.lbIznos1.Name = "lbIznos1";
            this.lbIznos1.Size = new System.Drawing.Size(112, 13);
            this.lbIznos1.TabIndex = 5;
            this.lbIznos1.Text = "Cena troseda1 iz baze";
            // 
            // lbStanje1
            // 
            this.lbStanje1.AutoSize = true;
            this.lbStanje1.Location = new System.Drawing.Point(244, 331);
            this.lbStanje1.Name = "lbStanje1";
            this.lbStanje1.Size = new System.Drawing.Size(35, 13);
            this.lbStanje1.TabIndex = 6;
            this.lbStanje1.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(498, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(498, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sifra";
            // 
            // tbUsername1
            // 
            this.tbUsername1.Location = new System.Drawing.Point(601, 43);
            this.tbUsername1.Name = "tbUsername1";
            this.tbUsername1.Size = new System.Drawing.Size(165, 20);
            this.tbUsername1.TabIndex = 9;
            this.tbUsername1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbSifra1
            // 
            this.tbSifra1.Location = new System.Drawing.Point(601, 83);
            this.tbSifra1.Name = "tbSifra1";
            this.tbSifra1.Size = new System.Drawing.Size(165, 20);
            this.tbSifra1.TabIndex = 10;
            // 
            // btKupovina1
            // 
            this.btKupovina1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKupovina1.Location = new System.Drawing.Point(551, 166);
            this.btKupovina1.Name = "btKupovina1";
            this.btKupovina1.Size = new System.Drawing.Size(149, 50);
            this.btKupovina1.TabIndex = 11;
            this.btKupovina1.Text = "Kupi proizvod";
            this.btKupovina1.UseVisualStyleBackColor = true;
            this.btKupovina1.Click += new System.EventHandler(this.btKupovina1_Click);
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btBack.Location = new System.Drawing.Point(742, 331);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(72, 26);
            this.btBack.TabIndex = 12;
            this.btBack.Text = "Povratak";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // Trosed1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(810, 355);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btKupovina1);
            this.Controls.Add(this.tbSifra1);
            this.Controls.Add(this.tbUsername1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbStanje1);
            this.Controls.Add(this.lbIznos1);
            this.Controls.Add(this.lbVelicina1);
            this.Controls.Add(this.lbIme1);
            this.Controls.Add(this.pbTrosed1);
            this.MaximizeBox = false;
            this.Name = "Trosed1";
            this.Text = "Trosed1";
            this.Load += new System.EventHandler(this.Trosed1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrosed1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTrosed1;
        private System.Windows.Forms.Label lbIme1;
        private System.Windows.Forms.Label lbVelicina1;
        private System.Windows.Forms.Label lbIznos1;
        private System.Windows.Forms.Label lbStanje1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername1;
        private System.Windows.Forms.TextBox tbSifra1;
        private System.Windows.Forms.Button btKupovina1;
        private System.Windows.Forms.Button btBack;
    }
}