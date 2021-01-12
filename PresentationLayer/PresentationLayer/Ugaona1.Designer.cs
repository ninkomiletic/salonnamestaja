
namespace PresentationLayer
{
    partial class Ugaona1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ugaona1));
            this.pbTrosed1 = new System.Windows.Forms.PictureBox();
            this.lbIme5 = new System.Windows.Forms.Label();
            this.lbVelicina5 = new System.Windows.Forms.Label();
            this.lbIznos5 = new System.Windows.Forms.Label();
            this.lbStanje5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername5 = new System.Windows.Forms.TextBox();
            this.tbSifra5 = new System.Windows.Forms.TextBox();
            this.btKupovina5 = new System.Windows.Forms.Button();
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
            // lbIme5
            // 
            this.lbIme5.AutoSize = true;
            this.lbIme5.Location = new System.Drawing.Point(19, 42);
            this.lbIme5.Name = "lbIme5";
            this.lbIme5.Size = new System.Drawing.Size(93, 13);
            this.lbIme5.TabIndex = 3;
            this.lbIme5.Text = "BOLOGNA Fotelja";
            // 
            // lbVelicina5
            // 
            this.lbVelicina5.AutoSize = true;
            this.lbVelicina5.Location = new System.Drawing.Point(19, 78);
            this.lbVelicina5.Name = "lbVelicina5";
            this.lbVelicina5.Size = new System.Drawing.Size(65, 13);
            this.lbVelicina5.TabIndex = 4;
            this.lbVelicina5.Text = "95 x 95 x 95";
            // 
            // lbIznos5
            // 
            this.lbIznos5.AutoSize = true;
            this.lbIznos5.Location = new System.Drawing.Point(84, 322);
            this.lbIznos5.Name = "lbIznos5";
            this.lbIznos5.Size = new System.Drawing.Size(66, 13);
            this.lbIznos5.TabIndex = 5;
            this.lbIznos5.Text = "22,000 RSD";
            // 
            // lbStanje5
            // 
            this.lbStanje5.AutoSize = true;
            this.lbStanje5.Location = new System.Drawing.Point(257, 322);
            this.lbStanje5.Name = "lbStanje5";
            this.lbStanje5.Size = new System.Drawing.Size(35, 13);
            this.lbStanje5.TabIndex = 6;
            this.lbStanje5.Text = "label1";
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
            // tbUsername5
            // 
            this.tbUsername5.Location = new System.Drawing.Point(601, 43);
            this.tbUsername5.Name = "tbUsername5";
            this.tbUsername5.Size = new System.Drawing.Size(165, 20);
            this.tbUsername5.TabIndex = 9;
            this.tbUsername5.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbSifra5
            // 
            this.tbSifra5.Location = new System.Drawing.Point(601, 83);
            this.tbSifra5.Name = "tbSifra5";
            this.tbSifra5.Size = new System.Drawing.Size(165, 20);
            this.tbSifra5.TabIndex = 10;
            // 
            // btKupovina5
            // 
            this.btKupovina5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKupovina5.Location = new System.Drawing.Point(551, 166);
            this.btKupovina5.Name = "btKupovina5";
            this.btKupovina5.Size = new System.Drawing.Size(149, 50);
            this.btKupovina5.TabIndex = 11;
            this.btKupovina5.Text = "Kupi proizvod";
            this.btKupovina5.UseVisualStyleBackColor = true;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(735, 332);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 12;
            this.btBack.Text = "Povratak";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // Ugaona1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(810, 355);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btKupovina5);
            this.Controls.Add(this.tbSifra5);
            this.Controls.Add(this.tbUsername5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbStanje5);
            this.Controls.Add(this.lbIznos5);
            this.Controls.Add(this.lbVelicina5);
            this.Controls.Add(this.lbIme5);
            this.Controls.Add(this.pbTrosed1);
            this.MaximizeBox = false;
            this.Name = "Ugaona1";
            this.Text = "Trosed1";
            this.Load += new System.EventHandler(this.Fotelja1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrosed1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTrosed1;
        private System.Windows.Forms.Label lbIme5;
        private System.Windows.Forms.Label lbVelicina5;
        private System.Windows.Forms.Label lbIznos5;
        private System.Windows.Forms.Label lbStanje5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername5;
        private System.Windows.Forms.TextBox tbSifra5;
        private System.Windows.Forms.Button btKupovina5;
        private System.Windows.Forms.Button btBack;
    }
}