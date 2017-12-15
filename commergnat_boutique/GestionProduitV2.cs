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
            CoBox_Filter.SelectedIndex = 0;
            CoBox_Filter2.SelectedIndex = 0;
        }

        public void Rafraichir()
        {

        //    txtbDateCom.Text = dataGridView1.Rows[position].Cells[1].Value.ToString();
        //    txtbNumCom.Text = dataGridView1.Rows[position].Cells[0].Value.ToString();
        //    cbNomCli.Text = dataGridView1.Rows[position].Cells[2].Value.ToString();
        //    dataGridView1.CurrentCell = dataGridView1[0, position];
        }

        private void CoBox_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CoBox_Filter.SelectedIndex == 0)
            {
                
                DGV_ListProduit2.DataSource = ClasseGestionProduit.getLesproduits("materiel");
            }

            if (CoBox_Filter.SelectedIndex == 1)
            {
                DGV_ListProduit2.Visible = true;
                DGV_ListProduit2.DataSource = ClasseGestionProduit.getLesproduits("service");
            }
        }
    }
}
