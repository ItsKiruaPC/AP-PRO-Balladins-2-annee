namespace AP_PRO_Balladins_2_annee
{
    partial class FrmGererHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGererHotel));
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblmdp = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCourt = new System.Windows.Forms.TextBox();
            this.btnEditer = new System.Windows.Forms.Button();
            this.label_prix = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.btnVoirMdp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(159, 60);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(140, 26);
            this.txtNom.TabIndex = 0;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(187, 141);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(165, 26);
            this.txtAdresse.TabIndex = 1;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(133, 228);
            this.txtTel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(147, 26);
            this.txtTel.TabIndex = 2;
            this.txtTel.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(240, 308);
            this.txtMdp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(112, 26);
            this.txtMdp.TabIndex = 3;
            this.txtMdp.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.White;
            this.lblNom.Location = new System.Drawing.Point(55, 56);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(77, 29);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.ForeColor = System.Drawing.Color.White;
            this.lblAdresse.Location = new System.Drawing.Point(55, 137);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(114, 29);
            this.lblAdresse.TabIndex = 5;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.White;
            this.lblTel.Location = new System.Drawing.Point(55, 224);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(61, 29);
            this.lblTel.TabIndex = 6;
            this.lblTel.Text = "Tel :";
            // 
            // lblmdp
            // 
            this.lblmdp.AutoSize = true;
            this.lblmdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmdp.ForeColor = System.Drawing.Color.White;
            this.lblmdp.Location = new System.Drawing.Point(55, 304);
            this.lblmdp.Name = "lblmdp";
            this.lblmdp.Size = new System.Drawing.Size(170, 29);
            this.lblmdp.TabIndex = 7;
            this.lblmdp.Text = "Mot de passe :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(480, 69);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(270, 166);
            this.txtDescription.TabIndex = 8;
            // 
            // txtCourt
            // 
            this.txtCourt.Location = new System.Drawing.Point(480, 306);
            this.txtCourt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCourt.Multiline = true;
            this.txtCourt.Name = "txtCourt";
            this.txtCourt.Size = new System.Drawing.Size(270, 166);
            this.txtCourt.TabIndex = 9;
            // 
            // btnEditer
            // 
            this.btnEditer.Location = new System.Drawing.Point(158, 454);
            this.btnEditer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(111, 38);
            this.btnEditer.TabIndex = 10;
            this.btnEditer.Text = "Editer";
            this.btnEditer.UseVisualStyleBackColor = true;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // label_prix
            // 
            this.label_prix.AutoSize = true;
            this.label_prix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prix.ForeColor = System.Drawing.Color.White;
            this.label_prix.Location = new System.Drawing.Point(55, 361);
            this.label_prix.Name = "label_prix";
            this.label_prix.Size = new System.Drawing.Size(66, 29);
            this.label_prix.TabIndex = 11;
            this.label_prix.Text = "Prix :";
            this.label_prix.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(133, 365);
            this.txtPrix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(112, 26);
            this.txtPrix.TabIndex = 12;
            // 
            // btnVoirMdp
            // 
            this.btnVoirMdp.Location = new System.Drawing.Point(385, 308);
            this.btnVoirMdp.Name = "btnVoirMdp";
            this.btnVoirMdp.Size = new System.Drawing.Size(33, 23);
            this.btnVoirMdp.TabIndex = 13;
            this.btnVoirMdp.UseVisualStyleBackColor = true;
            this.btnVoirMdp.Click += new System.EventHandler(this.btnVoirMdp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(480, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Description longue:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(480, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Description courte:";
            // 
            // FrmGererHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(22)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1067, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoirMdp);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.label_prix);
            this.Controls.Add(this.btnEditer);
            this.Controls.Add(this.txtCourt);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblmdp);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmGererHotel";
            this.Load += new System.EventHandler(this.FrmGererHotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Button btnVoirMdp;

        private System.Windows.Forms.Label label_prix;

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblmdp;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCourt;
        private System.Windows.Forms.Button btnEditer;

        #endregion
    }
}