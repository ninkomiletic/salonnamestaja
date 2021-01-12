
namespace PresentationLayer
{
    partial class Trosed4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trosed4));
            this.pbTrosed1 = new System.Windows.Forms.PictureBox();
            this.lbIme4 = new System.Windows.Forms.Label();
            this.lbVelicina4 = new System.Windows.Forms.Label();
            this.lbIznos4 = new System.Windows.Forms.Label();
            this.lbStanje4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername4 = new System.Windows.Forms.TextBox();
            this.tbSifra4 = new System.Windows.Forms.TextBox();
            this.btKupovina4 = new System.Windows.Forms.Button();
            this.btBack4 = new System.Windows.Forms.Button();
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
            // lbIme4
            // 
            this.lbIme4.AutoSize = true;
            this.lbIme4.Location = new System.Drawing.Point(19, 42);
            this.lbIme4.Name = "lbIme4";
            this.lbIme4.Size = new System.Drawing.Size(104, 13);
            this.lbIme4.TabIndex = 3;
            this.lbIme4.Text = "Ime troseda4 iz baze";
            // 
            // lbVelicina4
            // 
            this.lbVelicina4.AutoSize = true;
            this.lbVelicina4.Location = new System.Drawing.Point(19, 78);
            this.lbVelicina4.Name = "lbVelicina4";
            this.lbVelicina4.Size = new System.Drawing.Size(132, 13);
            this.lbVelicina4.TabIndex = 4;
            this.lbVelicina4.Text = "Dimenzije troseda4 iz baze";
            // 
            // lbIznos4
            // 
            this.lbIznos4.AutoSize = true;
            this.lbIznos4.Location = new System.Drawing.Point(83, 322);
            this.lbIznos4.Name = "lbIznos4";
            this.lbIznos4.Size = new System.Drawing.Size(112, 13);
            this.lbIznos4.TabIndex = 5;
            this.lbIznos4.Text = "Cena troseda4 iz baze";
            // 
            // lbStanje4
            // 
            this.lbStanje4.AutoSize = true;
            this.lbStanje4.Location = new System.Drawing.Point(248, 322);
            this.lbStanje4.Name = "lbStanje4";
            this.lbStanje4.Size = new System.Drawing.Size(35, 13);
            this.lbStanje4.TabIndex = 6;
            this.lbStanje4.Text = "label1";
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
            // tbUsername4
            // 
            this.tbUsername4.Location = new System.Drawing.Point(601, 43);
            this.tbUsername4.Name = "tbUsername4";
            this.tbUsername4.Size = new System.Drawing.Size(165, 20);
            this.tbUsername4.TabIndex = 9;
            this.tbUsername4.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbSifra4
            // 
            this.tbSifra4.Location = new System.Drawing.Point(601, 83);
            this.tbSifra4.Name = "tbSifra4";
            this.tbSifra4.Size = new System.Drawing.Size(165, 20);
            this.tbSifra4.TabIndex = 10;
            // 
            // btKupovina4
            // 
            this.btKupovina4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKupovina4.Location = new System.Drawing.Point(551, 166);
            this.btKupovina4.Name = "btKupovina4";
            this.btKupovina4.Size = new System.Drawing.Size(149, 50);
            this.btKupovina4.TabIndex = 11;
            this.btKupovina4.Text = "Kupi proizvod";
            this.btKupovina4.UseVisualStyleBackColor = true;
            // 
            // btBack4
            // 
            this.btBack4.Location = new System.Drawing.Point(735, 333);
            this.btBack4.Name = "btBack4";
            this.btBack4.Size = new System.Drawing.Size(75, 23);
            this.btBack4.TabIndex = 12;
            this.btBack4.Text = "Povratak";
            this.btBack4.UseVisualStyleBackColor = true;
            this.btBack4.Click += new System.EventHandler(this.btBack4_Click);
            // 
            // Trosed4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(810, 355);
            this.Controls.Add(this.btBack4);
            this.Controls.Add(this.btKupovina4);
            this.Controls.Add(this.tbSifra4);
            this.Controls.Add(this.tbUsername4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbStanje4);
            this.Controls.Add(this.lbIznos4);
            this.Controls.Add(this.lbVelicina4);
            this.Controls.Add(this.lbIme4);
            this.Controls.Add(this.pbTrosed1);
            this.MaximizeBox = false;
            this.Name = "Trosed4";
            this.Text = "Trosed1";
            ((System.ComponentModel.ISupportInitialize)(this.pbTrosed1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTrosed1;
        private System.Windows.Forms.Label lbIme4;
        private System.Windows.Forms.Label lbVelicina4;
        private System.Windows.Forms.Label lbIznos4;
        private System.Windows.Forms.Label lbStanje4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername4;
        private System.Windows.Forms.TextBox tbSifra4;
        private System.Windows.Forms.Button btKupovina4;
        private System.Windows.Forms.Button btBack4;
    }
}