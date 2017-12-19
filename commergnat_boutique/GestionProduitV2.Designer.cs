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
            this.CoBox_Filter2 = new System.Windows.Forms.ComboBox();
            this.CoBox_Filter = new System.Windows.Forms.ComboBox();
            this.DGV_ListProduit = new System.Windows.Forms.DataGridView();
            this.DGV_ListProduit2 = new System.Windows.Forms.DataGridView();
            this.RcTxBoxDescription = new System.Windows.Forms.RichTextBox();
            this.RcTxBoxProduit2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListProduit2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CoBox_Filter2);
            this.groupBox1.Controls.Add(this.CoBox_Filter);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(385, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtre";
            // 
            // CoBox_Filter2
            // 
            this.CoBox_Filter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBox_Filter2.FormattingEnabled = true;
            this.CoBox_Filter2.Items.AddRange(new object[] {
            "Tous",
            "Simple",
            "Complexe"});
            this.CoBox_Filter2.Location = new System.Drawing.Point(196, 23);
            this.CoBox_Filter2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoBox_Filter2.Name = "CoBox_Filter2";
            this.CoBox_Filter2.Size = new System.Drawing.Size(179, 24);
            this.CoBox_Filter2.TabIndex = 1;
            this.CoBox_Filter2.SelectedIndexChanged += new System.EventHandler(this.CoBox_Filter2_SelectedIndexChanged);
            // 
            // CoBox_Filter
            // 
            this.CoBox_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBox_Filter.FormattingEnabled = true;
            this.CoBox_Filter.Items.AddRange(new object[] {
            "Tous les produits",
            "Matériel",
            "Service"});
            this.CoBox_Filter.Location = new System.Drawing.Point(8, 23);
            this.CoBox_Filter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoBox_Filter.Name = "CoBox_Filter";
            this.CoBox_Filter.Size = new System.Drawing.Size(179, 24);
            this.CoBox_Filter.TabIndex = 0;
            this.CoBox_Filter.SelectedIndexChanged += new System.EventHandler(this.CoBox_Filter_SelectedIndexChanged);
            // 
            // DGV_ListProduit
            // 
            this.DGV_ListProduit.AllowUserToAddRows = false;
            this.DGV_ListProduit.AllowUserToDeleteRows = false;
            this.DGV_ListProduit.AllowUserToResizeColumns = false;
            this.DGV_ListProduit.AllowUserToResizeRows = false;
            this.DGV_ListProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ListProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ListProduit.Location = new System.Drawing.Point(16, 87);
            this.DGV_ListProduit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_ListProduit.Name = "DGV_ListProduit";
            this.DGV_ListProduit.ReadOnly = true;
            this.DGV_ListProduit.RowHeadersVisible = false;
            this.DGV_ListProduit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ListProduit.Size = new System.Drawing.Size(685, 308);
            this.DGV_ListProduit.TabIndex = 1;
            this.DGV_ListProduit.SelectionChanged += new System.EventHandler(this.DGV_ListProduit_SelectionChanged);
            // 
            // DGV_ListProduit2
            // 
            this.DGV_ListProduit2.AllowUserToAddRows = false;
            this.DGV_ListProduit2.AllowUserToDeleteRows = false;
            this.DGV_ListProduit2.AllowUserToOrderColumns = true;
            this.DGV_ListProduit2.AllowUserToResizeColumns = false;
            this.DGV_ListProduit2.AllowUserToResizeRows = false;
            this.DGV_ListProduit2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ListProduit2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ListProduit2.Location = new System.Drawing.Point(709, 87);
            this.DGV_ListProduit2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_ListProduit2.Name = "DGV_ListProduit2";
            this.DGV_ListProduit2.ReadOnly = true;
            this.DGV_ListProduit2.RowHeadersVisible = false;
            this.DGV_ListProduit2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ListProduit2.Size = new System.Drawing.Size(379, 308);
            this.DGV_ListProduit2.TabIndex = 2;
            this.DGV_ListProduit2.Visible = false;
            this.DGV_ListProduit2.SelectionChanged += new System.EventHandler(this.DGV_ListProduit2_SelectionChanged);
            // 
            // RcTxBoxDescription
            // 
            this.RcTxBoxDescription.Location = new System.Drawing.Point(17, 402);
            this.RcTxBoxDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RcTxBoxDescription.Name = "RcTxBoxDescription";
            this.RcTxBoxDescription.Size = new System.Drawing.Size(683, 74);
            this.RcTxBoxDescription.TabIndex = 3;
            this.RcTxBoxDescription.Text = "";
            // 
            // RcTxBoxProduit2
            // 
            this.RcTxBoxProduit2.Location = new System.Drawing.Point(709, 402);
            this.RcTxBoxProduit2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RcTxBoxProduit2.Name = "RcTxBoxProduit2";
            this.RcTxBoxProduit2.Size = new System.Drawing.Size(377, 74);
            this.RcTxBoxProduit2.TabIndex = 4;
            this.RcTxBoxProduit2.Text = "";
            this.RcTxBoxProduit2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(989, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Afficher CA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GestionProduitV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RcTxBoxProduit2);
            this.Controls.Add(this.RcTxBoxDescription);
            this.Controls.Add(this.DGV_ListProduit2);
            this.Controls.Add(this.DGV_ListProduit);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GestionProduitV2";
            this.Text = "Gestion des produits";
            this.Load += new System.EventHandler(this.GestionProduitV2_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListProduit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CoBox_Filter;
        private System.Windows.Forms.DataGridView DGV_ListProduit;
        private System.Windows.Forms.DataGridView DGV_ListProduit2;
        private System.Windows.Forms.ComboBox CoBox_Filter2;
        private System.Windows.Forms.RichTextBox RcTxBoxDescription;
        private System.Windows.Forms.RichTextBox RcTxBoxProduit2;
        private System.Windows.Forms.Button button1;
    }
}