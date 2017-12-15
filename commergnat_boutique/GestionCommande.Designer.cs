namespace commergnat_boutique
{
    partial class GestionCommande
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblListe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbNumCom = new System.Windows.Forms.TextBox();
            this.txtbDateCom = new System.Windows.Forms.TextBox();
            this.cbNomCli = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnDern = new System.Windows.Forms.Button();
            this.btnSuiv = new System.Windows.Forms.Button();
            this.btnPrec = new System.Windows.Forms.Button();
            this.btnPrem = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRecCli = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultation / Ajout / Modification / Suppression";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(213, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(341, 107);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // lblListe
            // 
            this.lblListe.AutoSize = true;
            this.lblListe.Location = new System.Drawing.Point(340, 75);
            this.lblListe.Name = "lblListe";
            this.lblListe.Size = new System.Drawing.Size(90, 13);
            this.lblListe.TabIndex = 2;
            this.lblListe.Text = "Liste Commandes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "GESTION COMMANDES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numéro Commande :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date Commande :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nom Client :";
            // 
            // txtbNumCom
            // 
            this.txtbNumCom.Location = new System.Drawing.Point(149, 225);
            this.txtbNumCom.Name = "txtbNumCom";
            this.txtbNumCom.ReadOnly = true;
            this.txtbNumCom.Size = new System.Drawing.Size(121, 20);
            this.txtbNumCom.TabIndex = 7;
            // 
            // txtbDateCom
            // 
            this.txtbDateCom.Location = new System.Drawing.Point(149, 259);
            this.txtbDateCom.Name = "txtbDateCom";
            this.txtbDateCom.ReadOnly = true;
            this.txtbDateCom.Size = new System.Drawing.Size(121, 20);
            this.txtbDateCom.TabIndex = 8;
            // 
            // cbNomCli
            // 
            this.cbNomCli.Enabled = false;
            this.cbNomCli.FormattingEnabled = true;
            this.cbNomCli.Location = new System.Drawing.Point(149, 291);
            this.cbNomCli.Name = "cbNomCli";
            this.cbNomCli.Size = new System.Drawing.Size(121, 21);
            this.cbNomCli.TabIndex = 9;

            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnModif);
            this.groupBox1.Controls.Add(this.btnSuppr);
            this.groupBox1.Controls.Add(this.btnAjout);
            this.groupBox1.Controls.Add(this.btnDern);
            this.groupBox1.Controls.Add(this.btnSuiv);
            this.groupBox1.Controls.Add(this.btnPrec);
            this.groupBox1.Controls.Add(this.btnPrem);
            this.groupBox1.Location = new System.Drawing.Point(326, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 109);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion des Commandes";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Enabled = false;
            this.btnAnnuler.Location = new System.Drawing.Point(292, 67);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(88, 36);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(366, 25);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(45, 36);
            this.btnModif.TabIndex = 6;
            this.btnModif.Text = "Modif.";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(315, 25);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(45, 36);
            this.btnSuppr.TabIndex = 5;
            this.btnSuppr.Text = "Supp.";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(264, 25);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(45, 36);
            this.btnAjout.TabIndex = 4;
            this.btnAjout.Text = "Ajout.";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnDern
            // 
            this.btnDern.Location = new System.Drawing.Point(194, 25);
            this.btnDern.Name = "btnDern";
            this.btnDern.Size = new System.Drawing.Size(45, 36);
            this.btnDern.TabIndex = 3;
            this.btnDern.Text = ">>";
            this.btnDern.UseVisualStyleBackColor = true;
            this.btnDern.Click += new System.EventHandler(this.btnDern_Click);
            // 
            // btnSuiv
            // 
            this.btnSuiv.Location = new System.Drawing.Point(133, 25);
            this.btnSuiv.Name = "btnSuiv";
            this.btnSuiv.Size = new System.Drawing.Size(45, 36);
            this.btnSuiv.TabIndex = 2;
            this.btnSuiv.Text = ">";
            this.btnSuiv.UseVisualStyleBackColor = true;
            this.btnSuiv.Click += new System.EventHandler(this.btnSuiv_Click);
            // 
            // btnPrec
            // 
            this.btnPrec.Location = new System.Drawing.Point(80, 25);
            this.btnPrec.Name = "btnPrec";
            this.btnPrec.Size = new System.Drawing.Size(45, 36);
            this.btnPrec.TabIndex = 1;
            this.btnPrec.Text = "<";
            this.btnPrec.UseVisualStyleBackColor = true;
            this.btnPrec.Click += new System.EventHandler(this.btnPrec_Click);
            // 
            // btnPrem
            // 
            this.btnPrem.Location = new System.Drawing.Point(17, 25);
            this.btnPrem.Name = "btnPrem";
            this.btnPrem.Size = new System.Drawing.Size(45, 36);
            this.btnPrem.TabIndex = 0;
            this.btnPrem.Text = "<<";
            this.btnPrem.UseVisualStyleBackColor = true;
            this.btnPrem.Click += new System.EventHandler(this.btnPrem_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(618, 127);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(88, 36);
            this.btnDetails.TabIndex = 11;
            this.btnDetails.Text = "Détails Commande";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Recherche par Client :";
            // 
            // txtRecCli
            // 
            this.txtRecCli.Location = new System.Drawing.Point(48, 107);
            this.txtRecCli.Name = "txtRecCli";
            this.txtRecCli.Size = new System.Drawing.Size(110, 20);
            this.txtRecCli.TabIndex = 13;
            this.txtRecCli.TextChanged += new System.EventHandler(this.txtRecCli_TextChanged);
            // 
            // GestionCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 412);
            this.Controls.Add(this.txtRecCli);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbNomCli);
            this.Controls.Add(this.txtbDateCom);
            this.Controls.Add(this.txtbNumCom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblListe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionCommande";
            this.Text = "GestionCommande";
            this.Load += new System.EventHandler(this.GestionCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblListe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbNumCom;
        private System.Windows.Forms.TextBox txtbDateCom;
        private System.Windows.Forms.ComboBox cbNomCli;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnDern;
        private System.Windows.Forms.Button btnSuiv;
        private System.Windows.Forms.Button btnPrec;
        private System.Windows.Forms.Button btnPrem;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRecCli;
    }
}