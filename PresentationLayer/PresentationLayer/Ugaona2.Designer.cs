
namespace PresentationLayer
{
    partial class Ugaona2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ugaona2));
            this.pbTrosed1 = new System.Windows.Forms.PictureBox();
            this.lbIme = new System.Windows.Forms.Label();
            this.lbVelicina = new System.Windows.Forms.Label();
            this.lbIznos = new System.Windows.Forms.Label();
            this.lbStanje = new System.Windows.Forms.Label();
            this.btKupovina6 = new System.Windows.Forms.Button();
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
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Location = new System.Drawing.Point(19, 42);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(53, 13);
            this.lbIme.TabIndex = 3;
            this.lbIme.Text = "Fotelja 03";
            // 
            // lbVelicina
            // 
            this.lbVelicina.AutoSize = true;
            this.lbVelicina.Location = new System.Drawing.Point(19, 78);
            this.lbVelicina.Name = "lbVelicina";
            this.lbVelicina.Size = new System.Drawing.Size(65, 13);
            this.lbVelicina.TabIndex = 4;
            this.lbVelicina.Text = "64 x 87 x 74";
            // 
            // lbIznos
            // 
            this.lbIznos.AutoSize = true;
            this.lbIznos.Location = new System.Drawing.Point(88, 322);
            this.lbIznos.Name = "lbIznos";
            this.lbIznos.Size = new System.Drawing.Size(66, 13);
            this.lbIznos.TabIndex = 5;
            this.lbIznos.Text = "27,000 RSD";
            // 
            // lbStanje
            // 
            this.lbStanje.AutoSize = true;
            this.lbStanje.Location = new System.Drawing.Point(233, 322);
            this.lbStanje.Name = "lbStanje";
            this.lbStanje.Size = new System.Drawing.Size(35, 13);
            this.lbStanje.TabIndex = 6;
            this.lbStanje.Text = "label1";
            // 
            // btKupovina6
            // 
            this.btKupovina6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKupovina6.Location = new System.Drawing.Point(551, 166);
            this.btKupovina6.Name = "btKupovina6";
            this.btKupovina6.Size = new System.Drawing.Size(149, 50);
            this.btKupovina6.TabIndex = 11;
            this.btKupovina6.Text = "Kupi proizvod";
            this.btKupovina6.UseVisualStyleBackColor = true;
            this.btKupovina6.Click += new System.EventHandler(this.btKupovina6_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(738, 332);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 12;
            this.btBack.Text = "Povratak";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // Ugaona2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(810, 355);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btKupovina6);
            this.Controls.Add(this.lbStanje);
            this.Controls.Add(this.lbIznos);
            this.Controls.Add(this.lbVelicina);
            this.Controls.Add(this.lbIme);
            this.Controls.Add(this.pbTrosed1);
            this.MaximizeBox = false;
            this.Name = "Ugaona2";
            this.Text = "Trosed1";
            this.Load += new System.EventHandler(this.Ugaona2_Load);
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
        private System.Windows.Forms.Button btKupovina6;
        private System.Windows.Forms.Button btBack;
    }
}