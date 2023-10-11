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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblmdp = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtEquipement = new System.Windows.Forms.TextBox();
            this.btnEditer = new System.Windows.Forms.Button();
            this.btnVoirMdp = new System.Windows.Forms.Button();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(140, 90);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(124, 22);
            this.txtNom.TabIndex = 0;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(140, 155);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(180, 22);
            this.txtAdresse.TabIndex = 1;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(140, 224);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(180, 22);
            this.txtTel.TabIndex = 2;
            this.txtTel.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(140, 288);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(100, 22);
            this.txtMdp.TabIndex = 3;
            this.txtMdp.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(39, 90);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 16);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(39, 155);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(64, 16);
            this.lblAdresse.TabIndex = 5;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(39, 224);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(33, 16);
            this.lblTel.TabIndex = 6;
            this.lblTel.Text = "Tel :";
            // 
            // lblmdp
            // 
            this.lblmdp.AutoSize = true;
            this.lblmdp.Location = new System.Drawing.Point(39, 288);
            this.lblmdp.Name = "lblmdp";
            this.lblmdp.Size = new System.Drawing.Size(95, 16);
            this.lblmdp.TabIndex = 7;
            this.lblmdp.Text = "Mot de passe :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(542, 74);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(205, 134);
            this.txtDescription.TabIndex = 8;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtEquipement
            // 
            this.txtEquipement.Location = new System.Drawing.Point(542, 251);
            this.txtEquipement.Multiline = true;
            this.txtEquipement.Name = "txtEquipement";
            this.txtEquipement.Size = new System.Drawing.Size(205, 134);
            this.txtEquipement.TabIndex = 9;
            // 
            // btnEditer
            // 
            this.btnEditer.Location = new System.Drawing.Point(35, 392);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(99, 30);
            this.btnEditer.TabIndex = 10;
            this.btnEditer.Text = "Modifier";
            this.btnEditer.UseVisualStyleBackColor = true;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // btnVoirMdp
            // 
            this.btnVoirMdp.Location = new System.Drawing.Point(256, 283);
            this.btnVoirMdp.Name = "btnVoirMdp";
            this.btnVoirMdp.Size = new System.Drawing.Size(31, 32);
            this.btnVoirMdp.TabIndex = 11;
            this.btnVoirMdp.UseVisualStyleBackColor = true;
            this.btnVoirMdp.Click += new System.EventHandler(this.btnVoirMdp_Click);
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(140, 344);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(63, 22);
            this.txtPrix.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Prix :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 39);
            this.label2.TabIndex = 14;
            this.label2.Text = "Informations :";
            // 
            // FrmGererHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.btnVoirMdp);
            this.Controls.Add(this.btnEditer);
            this.Controls.Add(this.txtEquipement);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblmdp);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtNom);
            this.Name = "FrmGererHotel";
            this.Text = "FrmGererHotel";
            this.Load += new System.EventHandler(this.FrmGererHotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblmdp;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtEquipement;
        private System.Windows.Forms.Button btnEditer;
        private System.Windows.Forms.Button btnVoirMdp;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}