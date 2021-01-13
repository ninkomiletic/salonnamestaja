
namespace PresentationLayer
{
    partial class Trosed2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trosed2));
            this.pbTrosed1 = new System.Windows.Forms.PictureBox();
            this.lbIme2 = new System.Windows.Forms.Label();
            this.lbVelicina2 = new System.Windows.Forms.Label();
            this.lbIznos2 = new System.Windows.Forms.Label();
            this.lbStanje2 = new System.Windows.Forms.Label();
            this.btKupovina2 = new System.Windows.Forms.Button();
            this.btBack2 = new System.Windows.Forms.Button();
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
            // lbIme2
            // 
            this.lbIme2.AutoSize = true;
            this.lbIme2.Location = new System.Drawing.Point(19, 42);
            this.lbIme2.Name = "lbIme2";
            this.lbIme2.Size = new System.Drawing.Size(104, 13);
            this.lbIme2.TabIndex = 3;
            this.lbIme2.Text = "Ime troseda2 iz baze";
            // 
            // lbVelicina2
            // 
            this.lbVelicina2.AutoSize = true;
            this.lbVelicina2.Location = new System.Drawing.Point(19, 78);
            this.lbVelicina2.Name = "lbVelicina2";
            this.lbVelicina2.Size = new System.Drawing.Size(132, 13);
            this.lbVelicina2.TabIndex = 4;
            this.lbVelicina2.Text = "Dimenzije troseda2 iz baze";
            // 
            // lbIznos2
            // 
            this.lbIznos2.AutoSize = true;
            this.lbIznos2.Location = new System.Drawing.Point(65, 334);
            this.lbIznos2.Name = "lbIznos2";
            this.lbIznos2.Size = new System.Drawing.Size(112, 13);
            this.lbIznos2.TabIndex = 5;
            this.lbIznos2.Text = "Cena troseda2 iz baze";
            // 
            // lbStanje2
            // 
            this.lbStanje2.AutoSize = true;
            this.lbStanje2.Location = new System.Drawing.Point(259, 334);
            this.lbStanje2.Name = "lbStanje2";
            this.lbStanje2.Size = new System.Drawing.Size(35, 13);
            this.lbStanje2.TabIndex = 6;
            this.lbStanje2.Text = "label1";
            this.lbStanje2.Click += new System.EventHandler(this.lbStanje2_Click);
            // 
            // btKupovina2
            // 
            this.btKupovina2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKupovina2.Location = new System.Drawing.Point(551, 166);
            this.btKupovina2.Name = "btKupovina2";
            this.btKupovina2.Size = new System.Drawing.Size(149, 50);
            this.btKupovina2.TabIndex = 11;
            this.btKupovina2.Text = "Kupi proizvod";
            this.btKupovina2.UseVisualStyleBackColor = true;
            this.btKupovina2.Click += new System.EventHandler(this.btKupovina2_Click);
            // 
            // btBack2
            // 
            this.btBack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btBack2.Location = new System.Drawing.Point(741, 347);
            this.btBack2.Name = "btBack2";
            this.btBack2.Size = new System.Drawing.Size(72, 26);
            this.btBack2.TabIndex = 13;
            this.btBack2.Text = "Povratak";
            this.btBack2.UseVisualStyleBackColor = true;
            this.btBack2.Click += new System.EventHandler(this.btBack2_Click);
            // 
            // Trosed2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(810, 368);
            this.Controls.Add(this.btBack2);
            this.Controls.Add(this.btKupovina2);
            this.Controls.Add(this.lbStanje2);
            this.Controls.Add(this.lbIznos2);
            this.Controls.Add(this.lbVelicina2);
            this.Controls.Add(this.lbIme2);
            this.Controls.Add(this.pbTrosed1);
            this.MaximizeBox = false;
            this.Name = "Trosed2";
            this.Text = "Trosed1";
            this.Load += new System.EventHandler(this.Trosed2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrosed1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTrosed1;
        private System.Windows.Forms.Label lbIme2;
        private System.Windows.Forms.Label lbVelicina2;
        private System.Windows.Forms.Label lbIznos2;
        private System.Windows.Forms.Label lbStanje2;
        private System.Windows.Forms.Button btKupovina2;
        private System.Windows.Forms.Button btBack2;
    }
}