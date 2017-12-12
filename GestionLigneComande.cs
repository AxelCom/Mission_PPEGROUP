using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static commergnat_boutique.GenPDF;
using static commergnat_boutique.ClasseGestionCommande;
using static commergnat_boutique.ClasseGestionProduit;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;

namespace commergnat_boutique
{
    public partial class GestionLigneComande : Form
    {
        int position = 0;
        public GestionLigneComande()
        {
            InitializeComponent();
        }

        private void GestionLigneComande_Load(object sender, EventArgs e)
        {
            lblDetCom.Text = lblDetCom.Text + idCommande;
            dgListCli.DataSource = getLignesDeCommandesAvecNom();
            comboBox1.DataSource = getLesProduitsAvecNom();
            comboBox1.DisplayMember = "libelleProduit";
            comboBox1.ValueMember = "idProduit";
            Rafraichir();
            if (VerificationLigneDeCommande() == false)
            {
                btnModif.Enabled = false;
                btnSuppr.Enabled = false;
            }
        }
        public void Rafraichir()
        {
            txtbNumCom.Text = idCommande.ToString();
            if (VerificationLigneDeCommande() == false)
            {
                btnModif.Enabled = false;
                btnSuppr.Enabled = false;
                comboBox1.Text = "";
                txtbVilleCli.Text = "";
            }
            else
            {
                comboBox1.Text = dgListCli.Rows[position].Cells[1].Value.ToString();
                txtbVilleCli.Text = dgListCli.Rows[position].Cells[2].Value.ToString();
                dgListCli.CurrentCell = dgListCli[1, position];
            }
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

        private void dgListCli_Click(object sender, EventArgs e)
        {
            dgListCli.CurrentCell = dgListCli[1, dgListCli.CurrentRow.Index];
            txtbNumCom.Text = idCommande.ToString();
            comboBox1.Text = dgListCli.CurrentRow.Cells[1].Value.ToString();
            txtbVilleCli.Text = dgListCli.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (btnAjout.Text == "Ajout.")
            {

                btnAnnuler.Enabled = true;
                btnSuppr.Enabled = false;
                btnModif.Enabled = false;

                comboBox1.Enabled = true;
                comboBox1.Text = "";
                txtbVilleCli.Text = "";
                txtbVilleCli.ReadOnly = false;
                btnAjout.Text = "Valider!";
            }
            else
            {
                int c = Convert.ToInt32(txtbNumCom.Text);
                string l = comboBox1.SelectedValue.ToString();
                int z = Convert.ToInt32(txtbVilleCli.Text);


                AjouterLigneCommande(c, l, z);
                position = 0;
                dgListCli.DataSource = getLignesDeCommandesAvecNom();
                Rafraichir();
                btnAjout.Text = "Ajout.";
                comboBox1.Enabled = false;
                txtbVilleCli.ReadOnly = true;

                btnAnnuler.Enabled = false;
                btnSuppr.Enabled = true;
                btnModif.Enabled = true;
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (btnModif.Text == "Modif.")
            {
                btnAjout.Enabled = false;
                btnAnnuler.Enabled = true;
                btnSuppr.Enabled = false;
                txtbVilleCli.ReadOnly = false;
                btnModif.Text = "Valider!";
            }
            else
            {
                int c;
                string l;
                int z;
                c = Convert.ToInt32(txtbNumCom.Text);
                l = comboBox1.SelectedValue.ToString();
                z = Convert.ToInt32(txtbVilleCli.Text);
                ModifierLigneCommande(c, l, z);
                position = 0;
                dgListCli.DataSource = getLignesDeCommandesAvecNom();
                Rafraichir();
                btnModif.Text = "Modif.";
                txtbVilleCli.ReadOnly = true;

                btnSuppr.Enabled = true;
                btnAnnuler.Enabled = false;
                btnAjout.Enabled = true;
            }
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            if (btnSuppr.Text == "Supp.")
            {
                btnAjout.Enabled = false;
                btnModif.Enabled = false;
                btnAnnuler.Enabled = true;

                btnSuppr.Text = "Valider!";
            }
            else
            {
                btnAjout.Enabled = true;
                btnModif.Enabled = true;
                btnAnnuler.Enabled = false;

                int c = Convert.ToInt32(txtbNumCom.Text);

                SupprimerInfoCommande("lignedecommande", c);

                position = 0;
                dgListCli.DataSource = getLignesDeCommandesAvecNom();
                Rafraichir();
                btnSuppr.Text = "Supp.";
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtbNumCom.ReadOnly = true;
            txtbVilleCli.ReadOnly = true;
            comboBox1.Enabled = false;

            btnAjout.Enabled = true;
            btnSuppr.Enabled = true;
            btnModif.Enabled = true;
            btnAjout.Text = "Ajout.";
            btnModif.Text = "Modif.";
            btnSuppr.Text = "Supp.";
            btnAnnuler.Enabled = false;
            Rafraichir();
        }

        private void GestionLigneComande_Enter(object sender, EventArgs e)
        {
            Rafraichir();
        }
        private void btnGenPDF_Click(object sender, EventArgs e)
        {
            GenererFactureCommande("Facture Commande", getLignesDeCommandesAvecNom());
        }
        private static void GenererFactureCommande(string titre, DataTable lesdonnees)
        {
            Document Doc = new Document();
            PdfPTable tableau_entete;
            PdfPTable tableau_ligne;
            PdfPTable tableau_numCommande;

            PdfPCell cellule = new PdfPCell();

            try
            {
                PdfWriter.GetInstance(Doc, new System.IO.FileStream("d:/fichier.pdf", System.IO.FileMode.Create));

                Doc.Open();

                tableau_entete = new PdfPTable(1);

                cellule.Colspan = 0;

                tableau_entete.AddCell(titre);
                Doc.Add(tableau_entete);

                tableau_numCommande = new PdfPTable(2);
                tableau_numCommande.AddCell("Numéro Commande");
                tableau_numCommande.AddCell(lesdonnees.Rows[0].ItemArray[0].ToString());
                tableau_numCommande.SpacingBefore = 10;
                Doc.Add(tableau_numCommande);

                PdfPTable tableau_info;
                tableau_info = new PdfPTable(2);
                tableau_info.AddCell("Produit");
                tableau_info.AddCell("Quantité");
                tableau_info.SpacingBefore = 10;

                Doc.Add(tableau_info);

                tableau_ligne = new PdfPTable(2);
                tableau_ligne.SpacingBefore = 10;
                int nblignes;
                int nbcolonnes;
                nblignes = lesdonnees.Rows.Count;
                nbcolonnes = lesdonnees.Columns.Count - 1;
                cellule.Colspan = 5;

                int i, j;
                for (i = 0; i < nblignes; i++)
                {
                    for (j = 0; j < nbcolonnes; j++)
                    {
                        tableau_ligne.AddCell(lesdonnees.Rows[i].ItemArray[j+1].ToString());
                    }
                    
                }
                Doc.Add(tableau_ligne);
            }
            catch (Exception e)
            {
                MessageBox.Show(" Erreur sur le fichier Pdf " + e.Message);
            }
            Doc.Close();
            Process.Start("d:/fichier.pdf");
        }
    }
}