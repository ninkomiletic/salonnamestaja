
namespace PresentationLayer
{
    partial class Trosed3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trosed3));
            this.pbTrosed1 = new System.Windows.Forms.PictureBox();
            this.lbIme = new System.Windows.Forms.Label();
            this.lbVelicina = new System.Windows.Forms.Label();
            this.lbIznos = new System.Windows.Forms.Label();
            this.lbStanje = new System.Windows.Forms.Label();
            this.btKupovina3 = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.btBack3 = new System.Windows.Forms.Button();
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
            this.lbIme.Text = "Ime troseda3 iz baze";
            // 
            // lbVelicina
            // 
            this.lbVelicina.AutoSize = true;
            this.lbVelicina.Location = new System.Drawing.Point(19, 78);
            this.lbVelicina.Name = "lbVelicina";
            this.lbVelicina.Size = new System.Drawing.Size(132, 13);
            this.lbVelicina.TabIndex = 4;
            this.lbVelicina.Text = "Dimenzije troseda3 iz baze";
            // 
            // lbIznos
            // 
            this.lbIznos.AutoSize = true;
            this.lbIznos.Location = new System.Drawing.Point(64, 322);
            this.lbIznos.Name = "lbIznos";
            this.lbIznos.Size = new System.Drawing.Size(112, 13);
            this.lbIznos.TabIndex = 5;
            this.lbIznos.Text = "Cena troseda3 iz baze";
            // 
            // lbStanje
            // 
            this.lbStanje.AutoSize = true;
            this.lbStanje.Location = new System.Drawing.Point(278, 322);
            this.lbStanje.Name = "lbStanje";
            this.lbStanje.Size = new System.Drawing.Size(35, 13);
            this.lbStanje.TabIndex = 6;
            this.lbStanje.Text = "label1";
            // 
            // btKupovina3
            // 
            this.btKupovina3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKupovina3.Location = new System.Drawing.Point(551, 166);
            this.btKupovina3.Name = "btKupovina3";
            this.btKupovina3.Size = new System.Drawing.Size(149, 50);
            this.btKupovina3.TabIndex = 11;
            this.btKupovina3.Text = "Kupi proizvod";
            this.btKupovina3.UseVisualStyleBackColor = true;
            this.btKupovina3.Click += new System.EventHandler(this.btKupovina3_Click);
            // 
            // btBack
            // 
            this.btBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.btBack.Location = new System.Drawing.Point(0, 0);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(810, 0);
            this.btBack.TabIndex = 12;
            this.btBack.Text = "Povratak";
            this.btBack.UseVisualStyleBackColor = true;
            // 
            // btBack3
            // 
            this.btBack3.Location = new System.Drawing.Point(737, 332);
            this.btBack3.Name = "btBack3";
            this.btBack3.Size = new System.Drawing.Size(75, 23);
            this.btBack3.TabIndex = 13;
            this.btBack3.Text = "Povratak";
            this.btBack3.UseVisualStyleBackColor = true;
            this.btBack3.Click += new System.EventHandler(this.btBack3_Click);
            // 
            // Trosed3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(810, 355);
            this.Controls.Add(this.btBack3);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btKupovina3);
            this.Controls.Add(this.lbStanje);
            this.Controls.Add(this.lbIznos);
            this.Controls.Add(this.lbVelicina);
            this.Controls.Add(this.lbIme);
            this.Controls.Add(this.pbTrosed1);
            this.MaximizeBox = false;
            this.Name = "Trosed3";
            this.Text = "Trosed1";
            this.Load += new System.EventHandler(this.Trosed3_Load);
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
        private System.Windows.Forms.Button btKupovina3;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btBack3;
    }
}