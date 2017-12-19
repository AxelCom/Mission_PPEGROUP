using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace commergnat_boutique
{
    public partial class GestionProduitV2 : Form
    {
        public GestionProduitV2()
        {
            InitializeComponent();
        }

        private void GestionProduitV2_Load(object sender, EventArgs e)
        {
            
            DGV_ListProduit.DataSource = ClasseGestionProduit.getLesProduits();
            CoBox_Filter2.Enabled = false;
            CoBox_Filter.SelectedIndex = 0;
            CoBox_Filter2.SelectedIndex = 0;                      
        }

        private void CoBox_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CoBox_Filter.SelectedIndex == 0)
            {
                DGV_ListProduit.DataSource = ClasseGestionProduit.getLesproduits("");
                CoBox_Filter2.Enabled = false;
                DGV_ListProduit2.Visible = false;
                RcTxBoxProduit2.Visible = false;
            } else if (CoBox_Filter.SelectedIndex == 1) {                           
                DGV_ListProduit.DataSource = ClasseGestionProduit.getLesproduits("materiel");
                CoBox_Filter2.Enabled = true;               
            } else if (CoBox_Filter.SelectedIndex == 2) {                
                DGV_ListProduit.DataSource = ClasseGestionProduit.getLesproduits("service");
                CoBox_Filter2.Enabled = false;
                DGV_ListProduit2.Visible = false;
                RcTxBoxProduit2.Visible = false;
            }
        }

        private void CoBox_Filter2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CoBox_Filter2.SelectedIndex == 0 && CoBox_Filter2.Enabled == true) {
                DGV_ListProduit.DataSource = ClasseGestionProduit.getLesproduits("materiel");
                RcTxBoxProduit2.Visible = false;
            } else if (CoBox_Filter2.SelectedIndex == 1) {
                DGV_ListProduit.DataSource = ClasseGestionProduit.getLesproduits("simple");
                RcTxBoxProduit2.Visible = false;
            } else if (CoBox_Filter2.SelectedIndex == 2) {
                DGV_ListProduit.DataSource = ClasseGestionProduit.getLesproduits("complexe");
                DGV_ListProduit2.Visible = true;
                RcTxBoxProduit2.Visible = true;
            }
        }

        private void DGV_ListProduit_SelectionChanged(object sender, EventArgs e)
        {
            if (CoBox_Filter2.SelectedIndex == 2)
            {
                DGV_ListProduit2.DataSource = ClasseGestionProduit.getLesProduits(Convert.ToInt16(DGV_ListProduit.CurrentRow.Cells[0].Value));
            }
            RcTxBoxDescription.Text = ClasseGestionProduit.getDescriptionProduit(Convert.ToInt16(DGV_ListProduit.CurrentRow.Cells[0].Value));
        }

        private void DGV_ListProduit2_SelectionChanged(object sender, EventArgs e)
        {
            RcTxBoxProduit2.Text = ClasseGestionProduit.getDescriptionProduit(Convert.ToInt16(DGV_ListProduit2.CurrentRow.Cells[0].Value));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormCA().Show();
        }
    }
}
