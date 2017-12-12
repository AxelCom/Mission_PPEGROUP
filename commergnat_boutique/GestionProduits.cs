using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static commergnat_boutique.ClasseGestionProduit;
using static commergnat_boutique.ClasseGestionFournisseur;
using static commergnat_boutique.GestionBoutique;
using static commergnat_boutique.GenPDF;
using iTextSharp.text.pdf;

namespace commergnat_boutique
{
    public partial class GestionProduits : Form
    {
        int position = 0;
        public GestionProduits()
        {
            InitializeComponent();
        }
        public void Rafraichir()
        {
            txtbNumProd.Text = dgListProd.Rows[position].Cells[0].Value.ToString();
            txtbNomProd.Text = dgListProd.Rows[position].Cells[1].Value.ToString();
            txtbPrixProd.Text = dgListProd.Rows[position].Cells[2].Value.ToString();
            txtbQteStock.Text = dgListProd.Rows[position].Cells[3].Value.ToString();
            cbNomFourn.Text = dgListProd.Rows[position].Cells[4].Value.ToString();
            cbNomCat.Text = dgListProd.Rows[position].Cells[5].Value.ToString();
            dgListProd.CurrentCell = dgListProd[0, position];
        }

        private void GestionProduits_Load(object sender, EventArgs e)
        {
            dgListProd.DataSource = getLesProduitsAvecNom();
            cbNomFourn.DataSource = getLesFournisseurs();
            cbNomFourn.DisplayMember = "nomFournisseur";
            cbNomFourn.ValueMember = "idFournisseur";
            cbNomCat.DataSource = getLesCategories();
            cbNomCat.DisplayMember = "libelleCategorie";
            cbNomCat.ValueMember = "idCategorie";
            dgListProd.Columns[0].HeaderText = "N° Produit";
            dgListProd.Columns[1].HeaderText = "Nom Produit";
            dgListProd.Columns[2].HeaderText = "Prix Produit";
            dgListProd.Columns[3].HeaderText = "Quantité en Stock";
            dgListProd.Columns[4].HeaderText = "Fournisseur";
            dgListProd.Columns[5].HeaderText = "Categorie";
            Rafraichir();
        }
        private void btnPrem_Click(object sender, EventArgs e)
        {
            position = 0;
            Rafraichir();
        }

        private void btnDern_Click(object sender, EventArgs e)
        {
            position = dgListProd.Rows.Count - 1;
            Rafraichir();
        }

        private void btnPrec_Click(object sender, EventArgs e)
        {
            if (position > 0)
            {
                position = position - 1;
                Rafraichir();
            }
        }

        private void btnSuiv_Click(object sender, EventArgs e)
        {
            if (position < dgListProd.Rows.Count - 1)
            {
                position = position + 1;
                Rafraichir();
            }
        }

        private void dgListProd_Click(object sender, EventArgs e)
        {
            dgListProd.CurrentCell = dgListProd[0, dgListProd.CurrentRow.Index];
            txtbNumProd.Text = dgListProd.CurrentRow.Cells[0].Value.ToString();
            txtbNomProd.Text = dgListProd.CurrentRow.Cells[1].Value.ToString();
            txtbPrixProd.Text = dgListProd.CurrentRow.Cells[2].Value.ToString();
            txtbQteStock.Text = dgListProd.CurrentRow.Cells[3].Value.ToString();
            cbNomFourn.Text = dgListProd.CurrentRow.Cells[4].Value.ToString();
            cbNomCat.Text = dgListProd.CurrentRow.Cells[5].Value.ToString();  
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (btnModif.Text == "Modif.")
            {
                txtbNomProd.ReadOnly = false;
                txtbPrixProd.ReadOnly = false;
                txtbQteStock.ReadOnly = false;

                cbNomFourn.Enabled = true;
                cbNomCat.Enabled = true;
                btnAjout.Enabled = false;
                btnSuppr.Enabled = false;
                btnAnnuler.Enabled = true;

                btnModif.Text = "Valider!";
            }
            else
            {
                if (txtbNomProd.Text != "" | txtbPrixProd.Text != "" | txtbQteStock.Text != "")
                {
                    int k;
                    string no;
                    int p;
                    int q;
                    int f;
                    int g;
                    k = Convert.ToInt32(txtbNumProd.Text);
                    no = txtbNomProd.Text;
                    p = Convert.ToInt32(txtbPrixProd.Text);
                    q = Convert.ToInt32(txtbQteStock.Text);
                    f = Convert.ToInt32(cbNomFourn.SelectedValue);
                    g = Convert.ToInt32(cbNomCat.SelectedValue);


                    ModifierProduit(k, no, p, q, f, g);
                    position = 0;
                    dgListProd.DataSource = getLesProduitsAvecNom();
                    Rafraichir();
                    btnModif.Text = "Modif.";
                    txtbNomProd.ReadOnly = true;
                    txtbPrixProd.ReadOnly = true;
                    txtbQteStock.ReadOnly = true;

                    cbNomCat.Enabled = false;
                    cbNomFourn.Enabled = false;
                    btnAjout.Enabled = true;
                    btnSuppr.Enabled = true;
                    btnAnnuler.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Renseigner la Date SVP...!", "Alerte!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtbNomProd.ReadOnly = true;
            txtbPrixProd.ReadOnly = true;
            txtbQteStock.ReadOnly = true;
            cbNomFourn.Enabled = false;
            cbNomCat.Enabled = false;

            btnAjout.Enabled = true;
            btnSuppr.Enabled = true;
            btnModif.Enabled = true;
            btnAjout.Text = "Ajout.";
            btnModif.Text = "Modif.";
            btnSuppr.Text = "Suppr.";
            btnAnnuler.Enabled = false;
            Rafraichir();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (btnAjout.Text == "Ajout.")
            {
                txtbNumProd.Text = GenererClePrimaire("idProduit", "Produit").ToString();
                txtbNomProd.Text = "";
                txtbPrixProd.Text = "";
                txtbQteStock.Text = "";

                txtbNomProd.ReadOnly = false;
                txtbPrixProd.ReadOnly = false;
                txtbQteStock.ReadOnly = false;

                cbNomCat.Enabled = true;
                cbNomFourn.Enabled = true;
                btnSuppr.Enabled = false;
                btnModif.Enabled = false;
                btnAnnuler.Enabled = true;
                btnAjout.Text = "Valider!";
            }
            else
            {
                if (txtbNomProd.Text != "" | txtbPrixProd.Text != "" | txtbQteStock.Text != "" )
                {
                    int k;
                    string no;
                    int p;
                    int q;
                    int f;
                    int g;
                    k = Convert.ToInt32(txtbNumProd.Text);
                    no = txtbNomProd.Text;
                    p = Convert.ToInt32(txtbPrixProd.Text);
                    q = Convert.ToInt32(txtbQteStock.Text);
                    f = Convert.ToInt32(cbNomFourn.SelectedValue);
                    g = Convert.ToInt32(cbNomCat.SelectedValue);

                    AjouterProduit(k, no, p, q, f, g);
                    position = 0;
                    dgListProd.DataSource = getLesProduitsAvecNom();
                    Rafraichir();
                    btnAjout.Text = "Ajout.";
                    txtbNomProd.ReadOnly = true;
                    txtbPrixProd.ReadOnly = true;
                    txtbQteStock.ReadOnly = true;

                    cbNomCat.Enabled = false;
                    cbNomFourn.Enabled = false;
                    
                    btnModif.Enabled = true;
                    btnSuppr.Enabled = true;
                    btnAnnuler.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Renseigner la Date SVP...!", "Alerte!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            if (btnSuppr.Text == "Suppr.")
            {
                btnAjout.Enabled = false;
                btnModif.Enabled = false;
                btnAnnuler.Enabled = true;

                btnSuppr.Text = "Valider!";
            }
            else
            {
                int c = Convert.ToInt32(txtbNumProd.Text);
                SupprimerProduit("Produit", c);
                position = 0;
                dgListProd.DataSource = getLesProduitsAvecNom();
                Rafraichir();
                btnSuppr.Text = "Supp.";
                btnAjout.Enabled = true;
                btnModif.Enabled = true;
                btnAnnuler.Enabled = false;
            }
        }

        private void btnGenPDF_Click(object sender, EventArgs e)
        {
            PdfPTable tableau_info;
            tableau_info = new PdfPTable(6);
            tableau_info.AddCell("Id Produit");
            tableau_info.AddCell("Libelle Produit");
            tableau_info.AddCell("Prix HT Produit");
            tableau_info.AddCell("Quantité Stock Produit");
            tableau_info.AddCell("Fournisseur Produit");
            tableau_info.AddCell("Catégorie Produit");
            GenererPDFDepuisDataTable(" Liste Produits", getLesProduitsAvecNom(), tableau_info);
        }
    }
}
