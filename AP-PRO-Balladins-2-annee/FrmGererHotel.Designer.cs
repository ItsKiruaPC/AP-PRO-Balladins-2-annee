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
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblAdresse1 = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblmdp = new System.Windows.Forms.Label();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtCourt = new System.Windows.Forms.TextBox();
            this.btnEditer = new System.Windows.Forms.Button();
            this.label_prix = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.btnVoirMdp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAdresse2 = new System.Windows.Forms.Label();
            this.txtAdr2 = new System.Windows.Forms.TextBox();
            this.chklist = new System.Windows.Forms.CheckedListBox();
            this.txtAdr1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(132, 55);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(131, 20);
            this.txtNom.TabIndex = 0;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(132, 92);
            this.txtTel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(131, 20);
            this.txtTel.TabIndex = 2;
            this.txtTel.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(132, 254);
            this.txtMdp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(62, 20);
            this.txtMdp.TabIndex = 3;
            this.txtMdp.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.White;
            this.lblNom.Location = new System.Drawing.Point(11, 53);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 20);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom";
            // 
            // lblAdresse1
            // 
            this.lblAdresse1.AutoSize = true;
            this.lblAdresse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse1.ForeColor = System.Drawing.Color.White;
            this.lblAdresse1.Location = new System.Drawing.Point(15, 134);
            this.lblAdresse1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresse1.Name = "lblAdresse1";
            this.lblAdresse1.Size = new System.Drawing.Size(85, 20);
            this.lblAdresse1.TabIndex = 5;
            this.lblAdresse1.Text = "Adresse 1:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.White;
            this.lblTel.Location = new System.Drawing.Point(15, 92);
            this.lblTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(38, 20);
            this.lblTel.TabIndex = 6;
            this.lblTel.Text = "Tel :";
            // 
            // lblmdp
            // 
            this.lblmdp.AutoSize = true;
            this.lblmdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmdp.ForeColor = System.Drawing.Color.White;
            this.lblmdp.Location = new System.Drawing.Point(11, 255);
            this.lblmdp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmdp.Name = "lblmdp";
            this.lblmdp.Size = new System.Drawing.Size(113, 20);
            this.lblmdp.TabIndex = 7;
            this.lblmdp.Text = "Mot de passe :";
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(320, 45);
            this.txtLong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLong.Multiline = true;
            this.txtLong.Name = "txtLong";
            this.txtLong.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLong.Size = new System.Drawing.Size(181, 109);
            this.txtLong.TabIndex = 8;
            // 
            // txtCourt
            // 
            this.txtCourt.Location = new System.Drawing.Point(320, 199);
            this.txtCourt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCourt.Multiline = true;
            this.txtCourt.Name = "txtCourt";
            this.txtCourt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCourt.Size = new System.Drawing.Size(181, 109);
            this.txtCourt.TabIndex = 9;
            // 
            // btnEditer
            // 
            this.btnEditer.Location = new System.Drawing.Point(79, 333);
            this.btnEditer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(83, 28);
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
            this.label_prix.Location = new System.Drawing.Point(15, 211);
            this.label_prix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_prix.Name = "label_prix";
            this.label_prix.Size = new System.Drawing.Size(42, 20);
            this.label_prix.TabIndex = 11;
            this.label_prix.Text = "Prix :";
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(132, 213);
            this.txtPrix.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(62, 20);
            this.txtPrix.TabIndex = 12;
            this.txtPrix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrix_KeyPress);
            // 
            // btnVoirMdp
            // 
            this.btnVoirMdp.Location = new System.Drawing.Point(221, 260);
            this.btnVoirMdp.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoirMdp.Name = "btnVoirMdp";
            this.btnVoirMdp.Size = new System.Drawing.Size(22, 15);
            this.btnVoirMdp.TabIndex = 13;
            this.btnVoirMdp.UseVisualStyleBackColor = true;
            this.btnVoirMdp.Click += new System.EventHandler(this.btnVoirMdp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(320, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Description longue:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(320, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Description courte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(513, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Equipements:";
            // 
            // lblAdresse2
            // 
            this.lblAdresse2.AutoSize = true;
            this.lblAdresse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse2.ForeColor = System.Drawing.Color.White;
            this.lblAdresse2.Location = new System.Drawing.Point(11, 172);
            this.lblAdresse2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresse2.Name = "lblAdresse2";
            this.lblAdresse2.Size = new System.Drawing.Size(89, 20);
            this.lblAdresse2.TabIndex = 19;
            this.lblAdresse2.Text = " Adresse 2:";
            // 
            // txtAdr2
            // 
            this.txtAdr2.Location = new System.Drawing.Point(132, 172);
            this.txtAdr2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAdr2.Name = "txtAdr2";
            this.txtAdr2.Size = new System.Drawing.Size(131, 20);
            this.txtAdr2.TabIndex = 18;
            // 
            // chklist
            // 
            this.chklist.CheckOnClick = true;
            this.chklist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklist.FormattingEnabled = true;
            this.chklist.IntegralHeight = false;
            this.chklist.Location = new System.Drawing.Point(513, 45);
            this.chklist.Name = "chklist";
            this.chklist.Size = new System.Drawing.Size(186, 263);
            this.chklist.TabIndex = 20;
            // 
            // txtAdr1
            // 
            this.txtAdr1.Location = new System.Drawing.Point(132, 134);
            this.txtAdr1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAdr1.Name = "txtAdr1";
            this.txtAdr1.Size = new System.Drawing.Size(131, 20);
            this.txtAdr1.TabIndex = 21;
            // 
            // FrmGererHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(22)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(711, 449);
            this.Controls.Add(this.txtAdr1);
            this.Controls.Add(this.chklist);
            this.Controls.Add(this.lblAdresse2);
            this.Controls.Add(this.txtAdr2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoirMdp);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.label_prix);
            this.Controls.Add(this.btnEditer);
            this.Controls.Add(this.txtCourt);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.lblmdp);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblAdresse1);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmGererHotel";
            this.Load += new System.EventHandler(this.FrmGererHotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckedListBox chklist;

        private System.Windows.Forms.Label lblAdresse2;
        private System.Windows.Forms.TextBox txtAdr2;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Button btnVoirMdp;

        private System.Windows.Forms.Label label_prix;

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtAdr1;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblAdresse1;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblmdp;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtCourt;
        private System.Windows.Forms.Button btnEditer;

        #endregion
    }
}