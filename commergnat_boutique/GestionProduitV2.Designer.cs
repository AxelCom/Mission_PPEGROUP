namespace commergnat_boutique
{
    partial class GestionProduitV2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CoBox_Filter = new System.Windows.Forms.ComboBox();
            this.TxBox_FilterValue = new System.Windows.Forms.TextBox();
            this.DGV_ListProduit = new System.Windows.Forms.DataGridView();
            this.DGV_ListProduit2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListProduit2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxBox_FilterValue);
            this.groupBox1.Controls.Add(this.CoBox_Filter);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtre";
            // 
            // CoBox_Filter
            // 
            this.CoBox_Filter.FormattingEnabled = true;
            this.CoBox_Filter.Location = new System.Drawing.Point(6, 19);
            this.CoBox_Filter.Name = "CoBox_Filter";
            this.CoBox_Filter.Size = new System.Drawing.Size(173, 21);
            this.CoBox_Filter.TabIndex = 0;
            // 
            // TxBox_FilterValue
            // 
            this.TxBox_FilterValue.Location = new System.Drawing.Point(7, 47);
            this.TxBox_FilterValue.Name = "TxBox_FilterValue";
            this.TxBox_FilterValue.Size = new System.Drawing.Size(172, 20);
            this.TxBox_FilterValue.TabIndex = 1;
            // 
            // DGV_ListProduit
            // 
            this.DGV_ListProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ListProduit.Location = new System.Drawing.Point(12, 95);
            this.DGV_ListProduit.Name = "DGV_ListProduit";
            this.DGV_ListProduit.Size = new System.Drawing.Size(240, 150);
            this.DGV_ListProduit.TabIndex = 1;
            // 
            // DGV_ListProduit2
            // 
            this.DGV_ListProduit2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ListProduit2.Location = new System.Drawing.Point(275, 95);
            this.DGV_ListProduit2.Name = "DGV_ListProduit2";
            this.DGV_ListProduit2.Size = new System.Drawing.Size(240, 150);
            this.DGV_ListProduit2.TabIndex = 2;
            // 
            // GestionProduitV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 508);
            this.Controls.Add(this.DGV_ListProduit2);
            this.Controls.Add(this.DGV_ListProduit);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionProduitV2";
            this.Text = "Gestion des produits";
            this.Load += new System.EventHandler(this.GestionProduitV2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListProduit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxBox_FilterValue;
        private System.Windows.Forms.ComboBox CoBox_Filter;
        private System.Windows.Forms.DataGridView DGV_ListProduit;
        private System.Windows.Forms.DataGridView DGV_ListProduit2;
    }
}