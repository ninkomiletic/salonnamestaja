
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
            this.lbIme6 = new System.Windows.Forms.Label();
            this.lbVelicina6 = new System.Windows.Forms.Label();
            this.lbIznos6 = new System.Windows.Forms.Label();
            this.lbStanje6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername6 = new System.Windows.Forms.TextBox();
            this.tbSifra6 = new System.Windows.Forms.TextBox();
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
            // lbIme6
            // 
            this.lbIme6.AutoSize = true;
            this.lbIme6.Location = new System.Drawing.Point(19, 42);
            this.lbIme6.Name = "lbIme6";
            this.lbIme6.Size = new System.Drawing.Size(53, 13);
            this.lbIme6.TabIndex = 3;
            this.lbIme6.Text = "Fotelja 03";
            // 
            // lbVelicina6
            // 
            this.lbVelicina6.AutoSize = true;
            this.lbVelicina6.Location = new System.Drawing.Point(19, 78);
            this.lbVelicina6.Name = "lbVelicina6";
            this.lbVelicina6.Size = new System.Drawing.Size(65, 13);
            this.lbVelicina6.TabIndex = 4;
            this.lbVelicina6.Text = "64 x 87 x 74";
            // 
            // lbIznos6
            // 
            this.lbIznos6.AutoSize = true;
            this.lbIznos6.Location = new System.Drawing.Point(88, 322);
            this.lbIznos6.Name = "lbIznos6";
            this.lbIznos6.Size = new System.Drawing.Size(66, 13);
            this.lbIznos6.TabIndex = 5;
            this.lbIznos6.Text = "27,000 RSD";
            // 
            // lbStanje6
            // 
            this.lbStanje6.AutoSize = true;
            this.lbStanje6.Location = new System.Drawing.Point(233, 322);
            this.lbStanje6.Name = "lbStanje6";
            this.lbStanje6.Size = new System.Drawing.Size(35, 13);
            this.lbStanje6.TabIndex = 6;
            this.lbStanje6.Text = "label1";
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
            // tbUsername6
            // 
            this.tbUsername6.Location = new System.Drawing.Point(601, 43);
            this.tbUsername6.Name = "tbUsername6";
            this.tbUsername6.Size = new System.Drawing.Size(165, 20);
            this.tbUsername6.TabIndex = 9;
            this.tbUsername6.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbSifra6
            // 
            this.tbSifra6.Location = new System.Drawing.Point(601, 83);
            this.tbSifra6.Name = "tbSifra6";
            this.tbSifra6.Size = new System.Drawing.Size(165, 20);
            this.tbSifra6.TabIndex = 10;
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
            this.Controls.Add(this.tbSifra6);
            this.Controls.Add(this.tbUsername6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbStanje6);
            this.Controls.Add(this.lbIznos6);
            this.Controls.Add(this.lbVelicina6);
            this.Controls.Add(this.lbIme6);
            this.Controls.Add(this.pbTrosed1);
            this.MaximizeBox = false;
            this.Name = "Ugaona2";
            this.Text = "Trosed1";
            ((System.ComponentModel.ISupportInitialize)(this.pbTrosed1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTrosed1;
        private System.Windows.Forms.Label lbIme6;
        private System.Windows.Forms.Label lbVelicina6;
        private System.Windows.Forms.Label lbIznos6;
        private System.Windows.Forms.Label lbStanje6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername6;
        private System.Windows.Forms.TextBox tbSifra6;
        private System.Windows.Forms.Button btKupovina6;
        private System.Windows.Forms.Button btBack;
    }
}