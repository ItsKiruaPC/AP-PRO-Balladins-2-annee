using System.ComponentModel;

namespace AP_PRO_Balladins_2_annee
{
    partial class FrmReservation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReservation));
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.tab_control = new System.Windows.Forms.TabControl();
            this.tab_reserv = new System.Windows.Forms.TabPage();
            this.btn_reinit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_fin_edit = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.date_debut_edit = new System.Windows.Forms.DateTimePicker();
            this.txt_mail_edit = new System.Windows.Forms.TextBox();
            this.txt_nom_edit = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.grd_liste = new System.Windows.Forms.DataGridView();
            this.tab_add = new System.Windows.Forms.TabPage();
            this.btn_tout = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.chk_chambre = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.date_fin = new System.Windows.Forms.DateTimePicker();
            this.date_debut = new System.Windows.Forms.DateTimePicker();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tab_control.SuspendLayout();
            this.tab_reserv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_liste)).BeginInit();
            this.tab_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 31);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(23, 23);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // datePicker
            // 
            this.datePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(98, 28);
            this.datePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePicker.MinDate = new System.DateTime(2023, 11, 5, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(380, 32);
            this.datePicker.TabIndex = 0;
            // 
            // tab_control
            // 
            this.tab_control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_control.Controls.Add(this.tab_reserv);
            this.tab_control.Controls.Add(this.tab_add);
            this.tab_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_control.Location = new System.Drawing.Point(0, 51);
            this.tab_control.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(1065, 534);
            this.tab_control.TabIndex = 1;
            // 
            // tab_reserv
            // 
            this.tab_reserv.Controls.Add(this.btn_reinit);
            this.tab_reserv.Controls.Add(this.label11);
            this.tab_reserv.Controls.Add(this.btn_search);
            this.tab_reserv.Controls.Add(this.btn_delete);
            this.tab_reserv.Controls.Add(this.label5);
            this.tab_reserv.Controls.Add(this.label4);
            this.tab_reserv.Controls.Add(this.label3);
            this.tab_reserv.Controls.Add(this.date_fin_edit);
            this.tab_reserv.Controls.Add(this.label2);
            this.tab_reserv.Controls.Add(this.date_debut_edit);
            this.tab_reserv.Controls.Add(this.txt_mail_edit);
            this.tab_reserv.Controls.Add(this.txt_nom_edit);
            this.tab_reserv.Controls.Add(this.btn_edit);
            this.tab_reserv.Controls.Add(this.grd_liste);
            this.tab_reserv.Controls.Add(this.datePicker);
            this.tab_reserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_reserv.Location = new System.Drawing.Point(4, 34);
            this.tab_reserv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_reserv.Name = "tab_reserv";
            this.tab_reserv.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_reserv.Size = new System.Drawing.Size(1057, 496);
            this.tab_reserv.TabIndex = 0;
            this.tab_reserv.Text = "Réservations";
            this.tab_reserv.UseVisualStyleBackColor = true;
            // 
            // btn_reinit
            // 
            this.btn_reinit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_reinit.AutoSize = true;
            this.btn_reinit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reinit.Location = new System.Drawing.Point(8, 28);
            this.btn_reinit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reinit.Name = "btn_reinit";
            this.btn_reinit.Size = new System.Drawing.Size(68, 35);
            this.btn_reinit.TabIndex = 17;
            this.btn_reinit.Text = "Tout";
            this.btn_reinit.UseVisualStyleBackColor = true;
            this.btn_reinit.Click += new System.EventHandler(this.btn_reinit_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(700, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(357, 29);
            this.label11.TabIndex = 16;
            this.label11.Text = "Modification de la réservation";
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_search.AutoSize = true;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(512, 24);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(178, 39);
            this.btn_search.TabIndex = 15;
            this.btn_search.Text = "Rechercher";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.AutoSize = true;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(887, 440);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(163, 49);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Supprimer";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(850, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mail";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(850, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nom";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(832, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date fin";
            // 
            // date_fin_edit
            // 
            this.date_fin_edit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.date_fin_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_fin_edit.Location = new System.Drawing.Point(764, 209);
            this.date_fin_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_fin_edit.MinDate = new System.DateTime(2023, 11, 5, 0, 0, 0, 0);
            this.date_fin_edit.Name = "date_fin_edit";
            this.date_fin_edit.Size = new System.Drawing.Size(245, 27);
            this.date_fin_edit.TabIndex = 10;
            this.date_fin_edit.Validating += new System.ComponentModel.CancelEventHandler(this.date_fin_edit_Validating);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(814, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date début";
            // 
            // date_debut_edit
            // 
            this.date_debut_edit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.date_debut_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_debut_edit.Location = new System.Drawing.Point(764, 123);
            this.date_debut_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_debut_edit.MinDate = new System.DateTime(2023, 11, 5, 0, 0, 0, 0);
            this.date_debut_edit.Name = "date_debut_edit";
            this.date_debut_edit.Size = new System.Drawing.Size(245, 27);
            this.date_debut_edit.TabIndex = 8;
            this.date_debut_edit.Validating += new System.ComponentModel.CancelEventHandler(this.date_debut_edit_Validating);
            // 
            // txt_mail_edit
            // 
            this.txt_mail_edit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mail_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mail_edit.Location = new System.Drawing.Point(764, 357);
            this.txt_mail_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mail_edit.Name = "txt_mail_edit";
            this.txt_mail_edit.Size = new System.Drawing.Size(245, 26);
            this.txt_mail_edit.TabIndex = 6;
            // 
            // txt_nom_edit
            // 
            this.txt_nom_edit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nom_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom_edit.Location = new System.Drawing.Point(764, 279);
            this.txt_nom_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nom_edit.Name = "txt_nom_edit";
            this.txt_nom_edit.Size = new System.Drawing.Size(245, 26);
            this.txt_nom_edit.TabIndex = 5;
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.AutoSize = true;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(726, 440);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(134, 49);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Confirmer";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // grd_liste
            // 
            this.grd_liste.AllowUserToAddRows = false;
            this.grd_liste.AllowUserToDeleteRows = false;
            this.grd_liste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_liste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_liste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_liste.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd_liste.Location = new System.Drawing.Point(8, 69);
            this.grd_liste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_liste.Name = "grd_liste";
            this.grd_liste.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_liste.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_liste.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grd_liste.RowTemplate.Height = 28;
            this.grd_liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_liste.Size = new System.Drawing.Size(691, 403);
            this.grd_liste.TabIndex = 1;
            this.grd_liste.SelectionChanged += new System.EventHandler(this.grd_liste_SelectionChanged);
            // 
            // tab_add
            // 
            this.tab_add.Controls.Add(this.btn_tout);
            this.tab_add.Controls.Add(this.label10);
            this.tab_add.Controls.Add(this.chk_chambre);
            this.tab_add.Controls.Add(this.label9);
            this.tab_add.Controls.Add(this.label8);
            this.tab_add.Controls.Add(this.label7);
            this.tab_add.Controls.Add(this.label6);
            this.tab_add.Controls.Add(this.btn_add);
            this.tab_add.Controls.Add(this.date_fin);
            this.tab_add.Controls.Add(this.date_debut);
            this.tab_add.Controls.Add(this.txt_mail);
            this.tab_add.Controls.Add(this.txt_nom);
            this.tab_add.Location = new System.Drawing.Point(4, 34);
            this.tab_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_add.Name = "tab_add";
            this.tab_add.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_add.Size = new System.Drawing.Size(1057, 496);
            this.tab_add.TabIndex = 1;
            this.tab_add.Text = "Ajouter";
            this.tab_add.UseVisualStyleBackColor = true;
            // 
            // btn_tout
            // 
            this.btn_tout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_tout.AutoSize = true;
            this.btn_tout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tout.Location = new System.Drawing.Point(827, 423);
            this.btn_tout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tout.Name = "btn_tout";
            this.btn_tout.Size = new System.Drawing.Size(91, 35);
            this.btn_tout.TabIndex = 15;
            this.btn_tout.Text = "Tout";
            this.btn_tout.UseVisualStyleBackColor = true;
            this.btn_tout.Click += new System.EventHandler(this.btn_tout_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(808, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 26);
            this.label10.TabIndex = 14;
            this.label10.Text = "Chambres";
            // 
            // chk_chambre
            // 
            this.chk_chambre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_chambre.CheckOnClick = true;
            this.chk_chambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_chambre.FormattingEnabled = true;
            this.chk_chambre.Location = new System.Drawing.Point(755, 253);
            this.chk_chambre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_chambre.Name = "chk_chambre";
            this.chk_chambre.Size = new System.Drawing.Size(235, 166);
            this.chk_chambre.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(507, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 26);
            this.label9.TabIndex = 12;
            this.label9.Text = "Mail";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(507, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nom";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(799, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date de fin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(102, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date de début";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_add.AutoSize = true;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(440, 369);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(194, 68);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Ajouter";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // date_fin
            // 
            this.date_fin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date_fin.CustomFormat = "dd/MM/yyyy";
            this.date_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_fin.Location = new System.Drawing.Point(662, 138);
            this.date_fin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_fin.Name = "date_fin";
            this.date_fin.Size = new System.Drawing.Size(389, 32);
            this.date_fin.TabIndex = 7;
            this.date_fin.Validating += new System.ComponentModel.CancelEventHandler(this.date_fin_Validating);
            // 
            // date_debut
            // 
            this.date_debut.CustomFormat = "dd/MM/yyyy";
            this.date_debut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_debut.Location = new System.Drawing.Point(8, 138);
            this.date_debut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_debut.Name = "date_debut";
            this.date_debut.Size = new System.Drawing.Size(389, 32);
            this.date_debut.TabIndex = 6;
            this.date_debut.Validating += new System.ComponentModel.CancelEventHandler(this.date_debut_Validating);
            // 
            // txt_mail
            // 
            this.txt_mail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_mail.Location = new System.Drawing.Point(452, 288);
            this.txt_mail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(165, 32);
            this.txt_mail.TabIndex = 3;
            // 
            // txt_nom
            // 
            this.txt_nom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_nom.Location = new System.Drawing.Point(452, 198);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(165, 32);
            this.txt_nom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(402, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Réservation";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 54);
            this.panel1.TabIndex = 3;
            // 
            // FrmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(22)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1066, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tab_control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReservation";
            this.Load += new System.EventHandler(this.FrmReservation_Load);
            this.tab_control.ResumeLayout(false);
            this.tab_reserv.ResumeLayout(false);
            this.tab_reserv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_liste)).EndInit();
            this.tab_add.ResumeLayout(false);
            this.tab_add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btn_tout;

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_reinit;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.ErrorProvider errorProvider1;

        private System.Windows.Forms.Button btn_search;

        private System.Windows.Forms.Button btn_delete;

        private System.Windows.Forms.CheckedListBox chk_chambre;
        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.DateTimePicker date_debut_edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_fin_edit;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_mail_edit;
        private System.Windows.Forms.TextBox txt_nom_edit;

        private System.Windows.Forms.DateTimePicker date_debut;
        private System.Windows.Forms.DateTimePicker date_fin;
        private System.Windows.Forms.Button btn_edit;

        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_mail;

        private System.Windows.Forms.DataGridView grd_liste;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage tab_reserv;
        private System.Windows.Forms.TabPage tab_add;

        private System.Windows.Forms.DateTimePicker datePicker;

        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;

        #endregion
    }
}