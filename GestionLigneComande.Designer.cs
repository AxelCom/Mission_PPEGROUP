namespace commergnat_boutique
{
    partial class GestionLigneComande
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDetCom = new System.Windows.Forms.Label();
            this.dgListCli = new System.Windows.Forms.DataGridView();
            this.txtbVilleCli = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbNumCom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenPDF = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnDern = new System.Windows.Forms.Button();
            this.btnSuiv = new System.Windows.Forms.Button();
            this.btnPrece = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgListCli)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "GESTION COMMANDES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ajout d\'un bon de commande";
            // 
            // lblDetCom
            // 
            this.lblDetCom.AutoSize = true;
            this.lblDetCom.Location = new System.Drawing.Point(338, 76);
            this.lblDetCom.Name = "lblDetCom";
            this.lblDetCom.Size = new System.Drawing.Size(108, 13);
            this.lblDetCom.TabIndex = 20;
            this.lblDetCom.Text = "Détails Commande n°";
            // 
            // dgListCli
            // 
            this.dgListCli.AllowUserToAddRows = false;
            this.dgListCli.AllowUserToDeleteRows = false;
            this.dgListCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListCli.Location = new System.Drawing.Point(179, 92);
            this.dgListCli.Name = "dgListCli";
            this.dgListCli.Size = new System.Drawing.Size(444, 95);
            this.dgListCli.TabIndex = 21;
            this.dgListCli.Click += new System.EventHandler(this.dgListCli_Click);
            // 
            // txtbVilleCli
            // 
            this.txtbVilleCli.Location = new System.Drawing.Point(204, 369);
            this.txtbVilleCli.Name = "txtbVilleCli";
            this.txtbVilleCli.ReadOnly = true;
            this.txtbVilleCli.Size = new System.Drawing.Size(112, 20);
            this.txtbVilleCli.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Quantité :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Libelle Produit :";
            // 
            // txtbNumCom
            // 
            this.txtbNumCom.Location = new System.Drawing.Point(204, 290);
            this.txtbNumCom.Name = "txtbNumCom";
            this.txtbNumCom.ReadOnly = true;
            this.txtbNumCom.Size = new System.Drawing.Size(112, 20);
            this.txtbNumCom.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Numéro Commande :";
            // 
            // btnGenPDF
            // 
            this.btnGenPDF.Location = new System.Drawing.Point(44, 212);
            this.btnGenPDF.Name = "btnGenPDF";
            this.btnGenPDF.Size = new System.Drawing.Size(355, 36);
            this.btnGenPDF.TabIndex = 38;
            this.btnGenPDF.Text = "Génerer le bon commande en PDF";
            this.btnGenPDF.UseVisualStyleBackColor = true;
            this.btnGenPDF.Click += new System.EventHandler(this.btnGenPDF_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnSuppr);
            this.groupBox1.Controls.Add(this.btnModif);
            this.groupBox1.Controls.Add(this.btnAjout);
            this.groupBox1.Controls.Add(this.btnDern);
            this.groupBox1.Controls.Add(this.btnSuiv);
            this.groupBox1.Controls.Add(this.btnPrece);
            this.groupBox1.Controls.Add(this.btnPremier);
            this.groupBox1.Location = new System.Drawing.Point(446, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 186);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestions du bon de commande ";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Enabled = false;
            this.btnAnnuler.Location = new System.Drawing.Point(140, 135);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(51, 45);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(212, 78);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(51, 48);
            this.btnSuppr.TabIndex = 6;
            this.btnSuppr.Text = "Suppr.";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(140, 78);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(51, 48);
            this.btnModif.TabIndex = 5;
            this.btnModif.Text = "Modif.";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(71, 78);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(51, 48);
            this.btnAjout.TabIndex = 4;
            this.btnAjout.Text = "Ajout.";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnDern
            // 
            this.btnDern.Location = new System.Drawing.Point(238, 17);
            this.btnDern.Name = "btnDern";
            this.btnDern.Size = new System.Drawing.Size(51, 48);
            this.btnDern.TabIndex = 3;
            this.btnDern.Text = ">>";
            this.btnDern.UseVisualStyleBackColor = true;
            this.btnDern.Click += new System.EventHandler(this.btnDern_Click);
            // 
            // btnSuiv
            // 
            this.btnSuiv.Location = new System.Drawing.Point(170, 17);
            this.btnSuiv.Name = "btnSuiv";
            this.btnSuiv.Size = new System.Drawing.Size(51, 48);
            this.btnSuiv.TabIndex = 2;
            this.btnSuiv.Text = ">";
            this.btnSuiv.UseVisualStyleBackColor = true;
            this.btnSuiv.Click += new System.EventHandler(this.btnSuiv_Click);
            // 
            // btnPrece
            // 
            this.btnPrece.Location = new System.Drawing.Point(113, 17);
            this.btnPrece.Name = "btnPrece";
            this.btnPrece.Size = new System.Drawing.Size(51, 48);
            this.btnPrece.TabIndex = 1;
            this.btnPrece.Text = "<";
            this.btnPrece.UseVisualStyleBackColor = true;
            this.btnPrece.Click += new System.EventHandler(this.btnPrece_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(43, 17);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(51, 48);
            this.btnPremier.TabIndex = 0;
            this.btnPremier.Text = "<<";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(204, 330);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 39;
            // 
            // GestionLigneComande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 412);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnGenPDF);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbVilleCli);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbNumCom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgListCli);
            this.Controls.Add(this.lblDetCom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionLigneComande";
            this.Text = "GestionLigneComande";
            this.Load += new System.EventHandler(this.GestionLigneComande_Load);
            this.Enter += new System.EventHandler(this.GestionLigneComande_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgListCli)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDetCom;
        private System.Windows.Forms.DataGridView dgListCli;
        private System.Windows.Forms.TextBox txtbVilleCli;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbNumCom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenPDF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnDern;
        private System.Windows.Forms.Button btnSuiv;
        private System.Windows.Forms.Button btnPrece;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}