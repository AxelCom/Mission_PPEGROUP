using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static commergnat_boutique.ClasseGestionFournisseur;
using static commergnat_boutique.GestionBoutique;
using static commergnat_boutique.GenPDF;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace commergnat_boutique
{
    public partial class GestionFournisseur : Form
    {
        int position = 0;
        public GestionFournisseur()
        {
            InitializeComponent();
        }
        private void GestionFournisseur_Load(object sender, EventArgs e)
        {
            dgListCli.DataSource = getLesFournisseurs();
            Rafraichir();
        }
        public void Rafraichir()
        {
            txtbNumCli.Text = dgListCli.Rows[position].Cells[0].Value.ToString();
            txtbNomCli.Text = dgListCli.Rows[position].Cells[1].Value.ToString();
            txtbVilleCli.Text = dgListCli.Rows[position].Cells[2].Value.ToString();
            txtbCodePostalCli.Text = dgListCli.Rows[position].Cells[3].Value.ToString();
            dgListCli.CurrentCell = dgListCli[0, position];
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            position = 0;
            Rafraichir();
        }

        private void btnPrece_Click(object sender, EventArgs e)
        {
            if (position > 0)
            {
                position = position - 1;
                Rafraichir();
            }
        }

        private void btnSuiv_Click(object sender, EventArgs e)
        {
            if (position < dgListCli.Rows.Count - 1)
            {
                position = position + 1;
                Rafraichir();
            }
        }

        private void btnDern_Click(object sender, EventArgs e)
        {
            position = dgListCli.Rows.Count - 1;
            Rafraichir();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (btnAjout.Text == "Ajout.")
            {
                txtbNumCli.Text = GenererClePrimaire("idFournisseur", "Fournisseur").ToString();
                txtbNomCli.Text = "";
                txtbVilleCli.Text = "";
                txtbCodePostalCli.Text = "";

                txtbNomCli.ReadOnly = false;
                txtbVilleCli.ReadOnly = false;
                txtbCodePostalCli.ReadOnly = false;
                btnModif.Enabled = false;
                btnSuppr.Enabled = false;
                btnAnnuler.Enabled = true;
                btnAjout.Text = "Valider!";
            }
            else
            {
                if (txtbNomCli.Text != "" | txtbVilleCli.Text != "" | txtbCodePostalCli.Text != "")
                {
                    int c = Convert.ToInt32(txtbNumCli.Text);
                    string z = txtbNomCli.Text;
                    string a = txtbVilleCli.Text;
                    int cp = Convert.ToInt32(txtbCodePostalCli.Text);
                    AjouterFournisseur(c, z, a, cp);
                    position = 0;
                    dgListCli.DataSource = getLesFournisseurs();
                    Rafraichir();
                    btnAjout.Text = "Ajout.";
                    txtbNomCli.ReadOnly = true;
                    txtbVilleCli.ReadOnly = true;
                    txtbCodePostalCli.ReadOnly = true;
                    txtbVilleCli.ReadOnly = true;
                    btnModif.Enabled = true;
                    btnSuppr.Enabled = true;
                    btnAnnuler.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas renseignés toutes les informations, veuillez rentrer toutes les informations !", "Alerte!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (btnModif.Text == "Modif.")
            {
                txtbNomCli.ReadOnly = false;
                txtbVilleCli.ReadOnly = false;
                txtbCodePostalCli.ReadOnly = false;
                txtbVilleCli.ReadOnly = false;
                btnAjout.Enabled = false;
                btnSuppr.Enabled = false;
                btnAnnuler.Enabled = true;
                btnModif.Text = "Valider!";
            }
            else
            {
                if (txtbNomCli.Text != "" | txtbVilleCli.Text != "" | txtbCodePostalCli.Text != "")
                {
                    int c = Convert.ToInt32(txtbNumCli.Text);
                    string z = txtbNomCli.Text;
                    string a = txtbVilleCli.Text;
                    int cp = Convert.ToInt32(txtbCodePostalCli.Text);
                    ModifierFournisseur(c, z, a, cp);
                    position = 0;
                    Rafraichir();
                    dgListCli.DataSource = getLesFournisseurs();
                    btnModif.Text = "Modif.";
                    txtbNomCli.ReadOnly = true;
                    txtbVilleCli.ReadOnly = true;
                    txtbCodePostalCli.ReadOnly = true;
                    txtbVilleCli.ReadOnly = true;
                    btnAjout.Enabled = true;
                    btnSuppr.Enabled = true;
                    btnAnnuler.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas renseignés toutes les informations, veuillez rentrer toutes les informations !", "Alerte!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            if (btnSuppr.Text == "Suppr.")
            {
                btnSuppr.Text = "Valider!";
                btnAjout.Enabled = false;
                btnModif.Enabled = false;
                btnAnnuler.Enabled = true;
            }
            else
            {
                int c = Convert.ToInt32(txtbNumCli.Text);
                try
                {
                    SupprimerInfoFournisseur("Fournisseur", c);

                    position = 0;
                    dgListCli.DataSource = getLesFournisseurs();
                    Rafraichir();
                    btnSuppr.Text = "Suppr.";
                    btnAjout.Enabled = true;
                    btnModif.Enabled = true;
                    btnAnnuler.Enabled = false;
                }
                catch (Exception)
                {
                    var rep = DialogResult;
                    rep = MessageBox.Show("Si vous supprimez ce Fournisseur vous supprimerez aussi le(s) produit(s) associé(s) a ce Fournisseur, êtes-vous sûr de vouloir continuer ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rep == DialogResult.Yes)
                    {
                        SupprimerInfoFournisseur("Produit", c);

                        SupprimerInfoFournisseur("Fournisseur", c);

                        position = 0;
                        dgListCli.DataSource = getLesFournisseurs();
                        Rafraichir();
                        btnSuppr.Text = "Suppr.";
                        btnAjout.Enabled = true;
                        btnModif.Enabled = true;
                        btnAnnuler.Enabled = false;
                    }
                    else
                    {
                        Rafraichir();
                        btnSuppr.Text = "Suppr.";
                        btnAjout.Enabled = true;
                        btnModif.Enabled = true;
                        btnAnnuler.Enabled = false;
                    }

                }
            }
        }

        private void dgListCli_Click(object sender, EventArgs e)
        {
            txtbNumCli.Text = dgListCli.CurrentRow.Cells[0].Value.ToString();
            txtbNomCli.Text = dgListCli.CurrentRow.Cells[1].Value.ToString();
            txtbVilleCli.Text = dgListCli.CurrentRow.Cells[2].Value.ToString();
            txtbCodePostalCli.Text = dgListCli.CurrentRow.Cells[3].Value.ToString();
            dgListCli.CurrentCell = dgListCli[0, dgListCli.CurrentRow.Index];
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtbNomCli.ReadOnly = true;
            txtbVilleCli.ReadOnly = true;
            txtbCodePostalCli.ReadOnly = true;
            txtbVilleCli.ReadOnly = true;

            btnAjout.Enabled = true;
            btnSuppr.Enabled = true;
            btnModif.Enabled = true;
            btnAjout.Text = "Ajout.";
            btnModif.Text = "Modif.";
            btnSuppr.Text = "Suppr.";
            btnAnnuler.Enabled = false;
            Rafraichir();
        }

        private void btnGenPDF_Click(object sender, EventArgs e)
        {
            PdfPTable tableau_info;
            tableau_info = new PdfPTable(4);
            tableau_info.AddCell("Id Fournisseur");
            tableau_info.AddCell("Nom Fournisseur");
            tableau_info.AddCell("Ville Fournisseur");
            tableau_info.AddCell("Code Postal Fournisseur");
            GenererPDFDepuisDataTable("Liste Fournisseurs", getLesFournisseurs(),tableau_info);
        } 
    }
}

