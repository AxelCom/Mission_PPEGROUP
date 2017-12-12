namespace commergnat_boutique
{
    partial class GestionClient
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgListCli = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbNumCli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbNomCli = new System.Windows.Forms.TextBox();
            this.txtbPrenomCli = new System.Windows.Forms.TextBox();
            this.txtbAdrCli = new System.Windows.Forms.TextBox();
            this.txtbCodePostalCli = new System.Windows.Forms.TextBox();
            this.txtbVilleCli = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnDern = new System.Windows.Forms.Button();
            this.btnSuiv = new System.Windows.Forms.Button();
            this.btnPrece = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.btnGenererPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListCli)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION CLIENTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consultation / Ajout / Modification / Suppression";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Listes Clients";
            // 
            // dgListCli
            // 
            this.dgListCli.AllowUserToAddRows = false;
            this.dgListCli.AllowUserToDeleteRows = false;
            this.dgListCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListCli.Location = new System.Drawing.Point(65, 93);
            this.dgListCli.Name = "dgListCli";
            this.dgListCli.Size = new System.Drawing.Size(643, 102);
            this.dgListCli.TabIndex = 3;
            this.dgListCli.Click += new System.EventHandler(this.dgListCli_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numéro Client :";
            // 
            // txtbNumCli
            // 
            this.txtbNumCli.Location = new System.Drawing.Point(100, 289);
            this.txtbNumCli.Name = "txtbNumCli";
            this.txtbNumCli.ReadOnly = true;
            this.txtbNumCli.Size = new System.Drawing.Size(112, 20);
            this.txtbNumCli.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nom Client :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Prénom Client :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Code Postal :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Adresse :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ville :";
            // 
            // txtbNomCli
            // 
            this.txtbNomCli.Location = new System.Drawing.Point(100, 329);
            this.txtbNomCli.Name = "txtbNomCli";
            this.txtbNomCli.ReadOnly = true;
            this.txtbNomCli.Size = new System.Drawing.Size(112, 20);
            this.txtbNomCli.TabIndex = 11;
            // 
            // txtbPrenomCli
            // 
            this.txtbPrenomCli.Location = new System.Drawing.Point(100, 365);
            this.txtbPrenomCli.Name = "txtbPrenomCli";
            this.txtbPrenomCli.ReadOnly = true;
            this.txtbPrenomCli.Size = new System.Drawing.Size(112, 20);
            this.txtbPrenomCli.TabIndex = 12;
            // 
            // txtbAdrCli
            // 
            this.txtbAdrCli.Location = new System.Drawing.Point(317, 289);
            this.txtbAdrCli.Name = "txtbAdrCli";
            this.txtbAdrCli.ReadOnly = true;
            this.txtbAdrCli.Size = new System.Drawing.Size(112, 20);
            this.txtbAdrCli.TabIndex = 13;
            // 
            // txtbCodePostalCli
            // 
            this.txtbCodePostalCli.Location = new System.Drawing.Point(317, 329);
            this.txtbCodePostalCli.Name = "txtbCodePostalCli";
            this.txtbCodePostalCli.ReadOnly = true;
            this.txtbCodePostalCli.Size = new System.Drawing.Size(112, 20);
            this.txtbCodePostalCli.TabIndex = 14;
            // 
            // txtbVilleCli
            // 
            this.txtbVilleCli.Location = new System.Drawing.Point(317, 365);
            this.txtbVilleCli.Name = "txtbVilleCli";
            this.txtbVilleCli.ReadOnly = true;
            this.txtbVilleCli.Size = new System.Drawing.Size(112, 20);
            this.txtbVilleCli.TabIndex = 15;
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
            this.groupBox1.Location = new System.Drawing.Point(445, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 186);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestions des Clients";
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
            // btnGenererPDF
            // 
            this.btnGenererPDF.Location = new System.Drawing.Point(65, 214);
            this.btnGenererPDF.Name = "btnGenererPDF";
            this.btnGenererPDF.Size = new System.Drawing.Size(355, 40);
            this.btnGenererPDF.TabIndex = 17;
            this.btnGenererPDF.Text = "Générer la liste en PDF";
            this.btnGenererPDF.UseVisualStyleBackColor = true;
            this.btnGenererPDF.Click += new System.EventHandler(this.btnGenererPDF_Click);
            // 
            // GestionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 412);
            this.Controls.Add(this.btnGenererPDF);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbVilleCli);
            this.Controls.Add(this.txtbCodePostalCli);
            this.Controls.Add(this.txtbAdrCli);
            this.Controls.Add(this.txtbPrenomCli);
            this.Controls.Add(this.txtbNomCli);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbNumCli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgListCli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionClient";
            this.Text = "GestionClient";
            this.Load += new System.EventHandler(this.GestionClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListCli)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgListCli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbNumCli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbNomCli;
        private System.Windows.Forms.TextBox txtbPrenomCli;
        private System.Windows.Forms.TextBox txtbAdrCli;
        private System.Windows.Forms.TextBox txtbCodePostalCli;
        private System.Windows.Forms.TextBox txtbVilleCli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDern;
        private System.Windows.Forms.Button btnSuiv;
        private System.Windows.Forms.Button btnPrece;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnGenererPDF;
    }
}