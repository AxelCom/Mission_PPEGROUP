namespace commergnat_boutique
{
    partial class GestionProduits
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
            this.dgListProd = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbNumProd = new System.Windows.Forms.TextBox();
            this.txtbNomProd = new System.Windows.Forms.TextBox();
            this.txtbPrixProd = new System.Windows.Forms.TextBox();
            this.txtbQteStock = new System.Windows.Forms.TextBox();
            this.cbNomFourn = new System.Windows.Forms.ComboBox();
            this.cbNomCat = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnDern = new System.Windows.Forms.Button();
            this.btnSuiv = new System.Windows.Forms.Button();
            this.btnPrece = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.btnGenPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListProd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION PRODUITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consultation / Ajout / Modification / Suppression";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Listes Produits";
            // 
            // dgListProd
            // 
            this.dgListProd.AllowUserToAddRows = false;
            this.dgListProd.AllowUserToDeleteRows = false;
            this.dgListProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListProd.Location = new System.Drawing.Point(71, 92);
            this.dgListProd.Name = "dgListProd";
            this.dgListProd.Size = new System.Drawing.Size(643, 102);
            this.dgListProd.TabIndex = 4;
            this.dgListProd.Click += new System.EventHandler(this.dgListProd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numéro Produit :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nom Produit :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Prix Produit :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Quantité en stock :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nom Fournisseur :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(226, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Nom Categorie :";
            // 
            // txtbNumProd
            // 
            this.txtbNumProd.Location = new System.Drawing.Point(100, 307);
            this.txtbNumProd.Name = "txtbNumProd";
            this.txtbNumProd.ReadOnly = true;
            this.txtbNumProd.Size = new System.Drawing.Size(112, 20);
            this.txtbNumProd.TabIndex = 11;
            // 
            // txtbNomProd
            // 
            this.txtbNomProd.Location = new System.Drawing.Point(100, 333);
            this.txtbNomProd.Name = "txtbNomProd";
            this.txtbNomProd.ReadOnly = true;
            this.txtbNomProd.Size = new System.Drawing.Size(112, 20);
            this.txtbNomProd.TabIndex = 12;
            // 
            // txtbPrixProd
            // 
            this.txtbPrixProd.Location = new System.Drawing.Point(100, 360);
            this.txtbPrixProd.Name = "txtbPrixProd";
            this.txtbPrixProd.ReadOnly = true;
            this.txtbPrixProd.Size = new System.Drawing.Size(112, 20);
            this.txtbPrixProd.TabIndex = 13;
            // 
            // txtbQteStock
            // 
            this.txtbQteStock.Location = new System.Drawing.Point(329, 307);
            this.txtbQteStock.Name = "txtbQteStock";
            this.txtbQteStock.ReadOnly = true;
            this.txtbQteStock.Size = new System.Drawing.Size(112, 20);
            this.txtbQteStock.TabIndex = 14;
            // 
            // cbNomFourn
            // 
            this.cbNomFourn.Enabled = false;
            this.cbNomFourn.FormattingEnabled = true;
            this.cbNomFourn.Location = new System.Drawing.Point(329, 333);
            this.cbNomFourn.Name = "cbNomFourn";
            this.cbNomFourn.Size = new System.Drawing.Size(112, 21);
            this.cbNomFourn.TabIndex = 15;
            // 
            // cbNomCat
            // 
            this.cbNomCat.Enabled = false;
            this.cbNomCat.FormattingEnabled = true;
            this.cbNomCat.Location = new System.Drawing.Point(329, 359);
            this.cbNomCat.Name = "cbNomCat";
            this.cbNomCat.Size = new System.Drawing.Size(112, 21);
            this.cbNomCat.TabIndex = 16;
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
            this.groupBox1.Location = new System.Drawing.Point(451, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 186);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestions des Produits";
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
            this.btnPrece.Click += new System.EventHandler(this.btnPrec_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(43, 17);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(51, 48);
            this.btnPremier.TabIndex = 0;
            this.btnPremier.Text = "<<";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPrem_Click);
            // 
            // btnGenPDF
            // 
            this.btnGenPDF.Location = new System.Drawing.Point(71, 231);
            this.btnGenPDF.Name = "btnGenPDF";
            this.btnGenPDF.Size = new System.Drawing.Size(355, 36);
            this.btnGenPDF.TabIndex = 18;
            this.btnGenPDF.Text = "Génerer la liste en PDF";
            this.btnGenPDF.UseVisualStyleBackColor = true;
            this.btnGenPDF.Click += new System.EventHandler(this.btnGenPDF_Click);
            // 
            // GestionProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 412);
            this.Controls.Add(this.btnGenPDF);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbNomCat);
            this.Controls.Add(this.cbNomFourn);
            this.Controls.Add(this.txtbQteStock);
            this.Controls.Add(this.txtbPrixProd);
            this.Controls.Add(this.txtbNomProd);
            this.Controls.Add(this.txtbNumProd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgListProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionProduits";
            this.Text = "GestionProduits";
            this.Load += new System.EventHandler(this.GestionProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListProd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgListProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbNumProd;
        private System.Windows.Forms.TextBox txtbNomProd;
        private System.Windows.Forms.TextBox txtbPrixProd;
        private System.Windows.Forms.TextBox txtbQteStock;
        private System.Windows.Forms.ComboBox cbNomFourn;
        private System.Windows.Forms.ComboBox cbNomCat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnDern;
        private System.Windows.Forms.Button btnSuiv;
        private System.Windows.Forms.Button btnPrece;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Button btnGenPDF;
    }
}