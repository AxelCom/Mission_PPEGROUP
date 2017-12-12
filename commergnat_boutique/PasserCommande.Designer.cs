namespace commergnat_boutique
{
    partial class PasserCommande
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
            this.btnGenPDF = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnDern = new System.Windows.Forms.Button();
            this.btnSuiv = new System.Windows.Forms.Button();
            this.btnPrece = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.cbNomCat = new System.Windows.Forms.ComboBox();
            this.cbNomFourn = new System.Windows.Forms.ComboBox();
            this.txtbQteStock = new System.Windows.Forms.TextBox();
            this.txtbNomProd = new System.Windows.Forms.TextBox();
            this.txtbNumProd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgListCommandePassee = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListCommandePassee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenPDF
            // 
            this.btnGenPDF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGenPDF.Location = new System.Drawing.Point(70, 233);
            this.btnGenPDF.Name = "btnGenPDF";
            this.btnGenPDF.Size = new System.Drawing.Size(355, 36);
            this.btnGenPDF.TabIndex = 36;
            this.btnGenPDF.Text = "Commande reçue";
            this.btnGenPDF.UseVisualStyleBackColor = false;
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
            this.groupBox1.Location = new System.Drawing.Point(450, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 186);
            this.groupBox1.TabIndex = 35;
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
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(140, 78);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(51, 48);
            this.btnModif.TabIndex = 5;
            this.btnModif.Text = "Modif.";
            this.btnModif.UseVisualStyleBackColor = true;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(71, 78);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(51, 48);
            this.btnAjout.TabIndex = 4;
            this.btnAjout.Text = "Ajout.";
            this.btnAjout.UseVisualStyleBackColor = true;
            // 
            // btnDern
            // 
            this.btnDern.Location = new System.Drawing.Point(238, 17);
            this.btnDern.Name = "btnDern";
            this.btnDern.Size = new System.Drawing.Size(51, 48);
            this.btnDern.TabIndex = 3;
            this.btnDern.Text = ">>";
            this.btnDern.UseVisualStyleBackColor = true;
            // 
            // btnSuiv
            // 
            this.btnSuiv.Location = new System.Drawing.Point(170, 17);
            this.btnSuiv.Name = "btnSuiv";
            this.btnSuiv.Size = new System.Drawing.Size(51, 48);
            this.btnSuiv.TabIndex = 2;
            this.btnSuiv.Text = ">";
            this.btnSuiv.UseVisualStyleBackColor = true;
            // 
            // btnPrece
            // 
            this.btnPrece.Location = new System.Drawing.Point(113, 17);
            this.btnPrece.Name = "btnPrece";
            this.btnPrece.Size = new System.Drawing.Size(51, 48);
            this.btnPrece.TabIndex = 1;
            this.btnPrece.Text = "<";
            this.btnPrece.UseVisualStyleBackColor = true;
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(43, 17);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(51, 48);
            this.btnPremier.TabIndex = 0;
            this.btnPremier.Text = "<<";
            this.btnPremier.UseVisualStyleBackColor = true;
            // 
            // cbNomCat
            // 
            this.cbNomCat.Enabled = false;
            this.cbNomCat.FormattingEnabled = true;
            this.cbNomCat.Location = new System.Drawing.Point(332, 335);
            this.cbNomCat.Name = "cbNomCat";
            this.cbNomCat.Size = new System.Drawing.Size(112, 21);
            this.cbNomCat.TabIndex = 34;
            // 
            // cbNomFourn
            // 
            this.cbNomFourn.Enabled = false;
            this.cbNomFourn.FormattingEnabled = true;
            this.cbNomFourn.Location = new System.Drawing.Point(332, 309);
            this.cbNomFourn.Name = "cbNomFourn";
            this.cbNomFourn.Size = new System.Drawing.Size(112, 21);
            this.cbNomFourn.TabIndex = 33;
            // 
            // txtbQteStock
            // 
            this.txtbQteStock.Location = new System.Drawing.Point(110, 362);
            this.txtbQteStock.Name = "txtbQteStock";
            this.txtbQteStock.ReadOnly = true;
            this.txtbQteStock.Size = new System.Drawing.Size(112, 20);
            this.txtbQteStock.TabIndex = 32;
            // 
            // txtbNomProd
            // 
            this.txtbNomProd.Location = new System.Drawing.Point(110, 336);
            this.txtbNomProd.Name = "txtbNomProd";
            this.txtbNomProd.ReadOnly = true;
            this.txtbNomProd.Size = new System.Drawing.Size(112, 20);
            this.txtbNomProd.TabIndex = 30;
            // 
            // txtbNumProd
            // 
            this.txtbNumProd.Location = new System.Drawing.Point(110, 309);
            this.txtbNumProd.Name = "txtbNumProd";
            this.txtbNumProd.ReadOnly = true;
            this.txtbNumProd.Size = new System.Drawing.Size(112, 20);
            this.txtbNumProd.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Nom Categorie :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Nom Fournisseur :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Quantité en stock :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nom Produit :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Numéro Produit :";
            // 
            // dgListCommandePassee
            // 
            this.dgListCommandePassee.AllowUserToAddRows = false;
            this.dgListCommandePassee.AllowUserToDeleteRows = false;
            this.dgListCommandePassee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListCommandePassee.Location = new System.Drawing.Point(70, 94);
            this.dgListCommandePassee.Name = "dgListCommandePassee";
            this.dgListCommandePassee.Size = new System.Drawing.Size(643, 102);
            this.dgListCommandePassee.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Listes des Commandes passées";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Consultation / Ajout / Modification / Suppression / Validation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "PASSER COMMANDE";
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(212, 78);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(51, 48);
            this.btnSuppr.TabIndex = 6;
            this.btnSuppr.Text = "Suppr.";
            this.btnSuppr.UseVisualStyleBackColor = true;
            // 
            // PasserCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 412);
            this.Controls.Add(this.btnGenPDF);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbNomCat);
            this.Controls.Add(this.cbNomFourn);
            this.Controls.Add(this.txtbQteStock);
            this.Controls.Add(this.txtbNomProd);
            this.Controls.Add(this.txtbNumProd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgListCommandePassee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PasserCommande";
            this.Text = "PasserCommande";
            this.Load += new System.EventHandler(this.PasserCommande_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListCommandePassee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ComboBox cbNomCat;
        private System.Windows.Forms.ComboBox cbNomFourn;
        private System.Windows.Forms.TextBox txtbQteStock;
        private System.Windows.Forms.TextBox txtbNomProd;
        private System.Windows.Forms.TextBox txtbNumProd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgListCommandePassee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}