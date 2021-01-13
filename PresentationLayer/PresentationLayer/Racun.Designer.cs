
namespace PresentationLayer
{
    partial class Racun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Racun));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNovac = new System.Windows.Forms.TextBox();
            this.btDodaj = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite potrebne podatke";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 4);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sifra";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(101, 72);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(137, 20);
            this.tbUsername.TabIndex = 4;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(101, 108);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(137, 20);
            this.tbPassword.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Unesite iznos koji zelite da dodate na racun:";
            // 
            // tbNovac
            // 
            this.tbNovac.Location = new System.Drawing.Point(290, 163);
            this.tbNovac.Name = "tbNovac";
            this.tbNovac.Size = new System.Drawing.Size(136, 20);
            this.tbNovac.TabIndex = 7;
            // 
            // btDodaj
            // 
            this.btDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDodaj.Location = new System.Drawing.Point(453, 156);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(86, 32);
            this.btDodaj.TabIndex = 8;
            this.btDodaj.Text = "Dodaj";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(476, -4);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 9;
            this.btBack.Text = "Povratak";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // Racun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(551, 216);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.tbNovac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Racun";
            this.Text = "Racun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNovac;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.Button btBack;
    }
}