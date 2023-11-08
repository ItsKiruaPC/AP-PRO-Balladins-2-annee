using System.ComponentModel;

namespace AP_PRO_Balladins_2_annee
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_deconnect = new System.Windows.Forms.Button();
            this.btn_Hotel = new System.Windows.Forms.Button();
            this.btn_Chambre = new System.Windows.Forms.Button();
            this.btn_Reserv = new System.Windows.Forms.Button();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_Form = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Bienvenue sur l\'application";
            this.notifyIcon1.BalloonTipTitle = "Balladin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.btn_deconnect);
            this.panel1.Controls.Add(this.btn_Hotel);
            this.panel1.Controls.Add(this.btn_Chambre);
            this.panel1.Controls.Add(this.btn_Reserv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 784);
            this.panel1.TabIndex = 0;
            // 
            // btn_deconnect
            // 
            this.btn_deconnect.Location = new System.Drawing.Point(28, 721);
            this.btn_deconnect.Name = "btn_deconnect";
            this.btn_deconnect.Size = new System.Drawing.Size(253, 51);
            this.btn_deconnect.TabIndex = 6;
            this.btn_deconnect.Text = "Déconnexion";
            this.btn_deconnect.UseVisualStyleBackColor = true;
            this.btn_deconnect.Visible = false;
            this.btn_deconnect.Click += new System.EventHandler(this.btn_deconnect_Click);
            // 
            // btn_Hotel
            // 
            this.btn_Hotel.Location = new System.Drawing.Point(28, 478);
            this.btn_Hotel.Name = "btn_Hotel";
            this.btn_Hotel.Size = new System.Drawing.Size(253, 51);
            this.btn_Hotel.TabIndex = 5;
            this.btn_Hotel.Text = "Modification";
            this.btn_Hotel.UseVisualStyleBackColor = true;
            this.btn_Hotel.Click += new System.EventHandler(this.btn_Hotel_Click);
            // 
            // btn_Chambre
            // 
            this.btn_Chambre.Location = new System.Drawing.Point(28, 321);
            this.btn_Chambre.Name = "btn_Chambre";
            this.btn_Chambre.Size = new System.Drawing.Size(253, 51);
            this.btn_Chambre.TabIndex = 4;
            this.btn_Chambre.Text = "Chambre";
            this.btn_Chambre.UseVisualStyleBackColor = true;
            this.btn_Chambre.Click += new System.EventHandler(this.btn_Chambre_Click);
            // 
            // btn_Reserv
            // 
            this.btn_Reserv.Location = new System.Drawing.Point(28, 167);
            this.btn_Reserv.Name = "btn_Reserv";
            this.btn_Reserv.Size = new System.Drawing.Size(253, 51);
            this.btn_Reserv.TabIndex = 3;
            this.btn_Reserv.Text = "Réservation";
            this.btn_Reserv.UseVisualStyleBackColor = true;
            this.btn_Reserv.Click += new System.EventHandler(this.btn_Reserv_Click);
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold);
            this.lbl_Nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.lbl_Nom.Location = new System.Drawing.Point(311, 63);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(0, 62);
            this.lbl_Nom.TabIndex = 1;
            this.lbl_Nom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(195)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lbl_Nom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(304, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 149);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.btn_Maximize);
            this.panel3.Controls.Add(this.btn_Minimize);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1107, 41);
            this.panel3.TabIndex = 2;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.Image = global::AP_PRO_Balladins_2_annee.Properties.Resources.window_regular_24;
            this.btn_Maximize.Location = new System.Drawing.Point(1021, 0);
            this.btn_Maximize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(43, 38);
            this.btn_Maximize.TabIndex = 20;
            this.btn_Maximize.UseVisualStyleBackColor = true;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.Image = global::AP_PRO_Balladins_2_annee.Properties.Resources.minus_regular_24;
            this.btn_Minimize.Location = new System.Drawing.Point(978, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(40, 38);
            this.btn_Minimize.TabIndex = 19;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::AP_PRO_Balladins_2_annee.Properties.Resources.x_regular_24;
            this.button1.Location = new System.Drawing.Point(1067, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 38);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_Form
            // 
            this.panel_Form.Controls.Add(this.label3);
            this.panel_Form.Controls.Add(this.label2);
            this.panel_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Form.Location = new System.Drawing.Point(304, 149);
            this.panel_Form.Name = "panel_Form";
            this.panel_Form.Size = new System.Drawing.Size(1107, 635);
            this.panel_Form.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(215, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(701, 62);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bienvenus chez Balladins\r\n";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(229, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(701, 62);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bienvenus chez Balladins\r\n";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(22)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1411, 784);
            this.Controls.Add(this.panel_Form);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel_Form.ResumeLayout(false);
            this.panel_Form.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Button btn_deconnect;

        private System.Windows.Forms.NotifyIcon notifyIcon1;

        private System.Windows.Forms.Button btn_Reserv;


        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Maximize;
        private System.Windows.Forms.Button btn_Minimize;

        private System.Windows.Forms.Button btn_Hotel;
        private System.Windows.Forms.Button btn_Chambre;

        private System.Windows.Forms.Panel panel_Form;

        private System.Windows.Forms.Label lbl_Nom;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}