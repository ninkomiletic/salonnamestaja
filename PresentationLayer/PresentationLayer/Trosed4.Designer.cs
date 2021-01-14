
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
            this.lbIme = new System.Windows.Forms.Label();
            this.lbVelicina = new System.Windows.Forms.Label();
            this.lbIznos = new System.Windows.Forms.Label();
            this.lbStanje = new System.Windows.Forms.Label();
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
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Location = new System.Drawing.Point(19, 42);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(104, 13);
            this.lbIme.TabIndex = 3;
            this.lbIme.Text = "Ime troseda4 iz baze";
            this.lbIme.Click += new System.EventHandler(this.lbIme4_Click);
            // 
            // lbVelicina
            // 
            this.lbVelicina.AutoSize = true;
            this.lbVelicina.Location = new System.Drawing.Point(19, 78);
            this.lbVelicina.Name = "lbVelicina";
            this.lbVelicina.Size = new System.Drawing.Size(132, 13);
            this.lbVelicina.TabIndex = 4;
            this.lbVelicina.Text = "Dimenzije troseda4 iz baze";
            // 
            // lbIznos
            // 
            this.lbIznos.AutoSize = true;
            this.lbIznos.Location = new System.Drawing.Point(83, 322);
            this.lbIznos.Name = "lbIznos";
            this.lbIznos.Size = new System.Drawing.Size(112, 13);
            this.lbIznos.TabIndex = 5;
            this.lbIznos.Text = "Cena troseda4 iz baze";
            // 
            // lbStanje
            // 
            this.lbStanje.AutoSize = true;
            this.lbStanje.Location = new System.Drawing.Point(248, 322);
            this.lbStanje.Name = "lbStanje";
            this.lbStanje.Size = new System.Drawing.Size(35, 13);
            this.lbStanje.TabIndex = 6;
            this.lbStanje.Text = "label1";
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
            this.btKupovina4.Click += new System.EventHandler(this.btKupovina4_Click);
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
            this.Controls.Add(this.lbStanje);
            this.Controls.Add(this.lbIznos);
            this.Controls.Add(this.lbVelicina);
            this.Controls.Add(this.lbIme);
            this.Controls.Add(this.pbTrosed1);
            this.MaximizeBox = false;
            this.Name = "Trosed4";
            this.Text = "Trosed1";
            this.Load += new System.EventHandler(this.Trosed4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrosed1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTrosed1;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.Label lbVelicina;
        private System.Windows.Forms.Label lbIznos;
        private System.Windows.Forms.Label lbStanje;
        private System.Windows.Forms.Button btKupovina4;
        private System.Windows.Forms.Button btBack4;
    }
}