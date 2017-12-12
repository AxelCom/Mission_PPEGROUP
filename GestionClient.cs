using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static commergnat_boutique.ClasseGestionClient;
using static commergnat_boutique.GenPDF;

namespace commergnat_boutique
{
    public partial class GestionClient : Form
    {
        int position = 0;
        public GestionClient()
        {
            InitializeComponent();
        }

        private void GestionClient_Load(object sender, EventArgs e)
        {
            dgListCli.DataSource = ClasseGestionClient.getLesClients();
            Rafraichir();
        }
        public void Rafraichir()
        {
            txtbNumCli.Text = dgListCli.Rows[position].Cells[0].Value.ToString();
            txtbNomCli.Text = dgListCli.Rows[position].Cells[1].Value.ToString();
            txtbPrenomCli.Text = dgListCli.Rows[position].Cells[2].Value.ToString();
            txtbAdrCli.Text = dgListCli.Rows[position].Cells[3].Value.ToString();
            txtbCodePostalCli.Text = dgListCli.Rows[position].Cells[4].Value.ToString();
            txtbVilleCli.Text = dgListCli.Rows[position].Cells[5].Value.ToString();
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
                txtbNumCli.Text = Convert.ToString(GestionBoutique.GenererClePrimaire("idClient","CLient"));
                txtbNomCli.Text = "";
                txtbPrenomCli.Text = "";
                txtbAdrCli.Text = "";
                txtbCodePostalCli.Text = "";
                txtbVilleCli.Text = "";

                txtbNomCli.ReadOnly = false;
                txtbPrenomCli.ReadOnly = false;
                txtbAdrCli.ReadOnly = false;
                txtbCodePostalCli.ReadOnly = false;
                txtbVilleCli.ReadOnly = false;
                btnModif.Enabled = false;
                btnSuppr.Enabled = false;
                btnAnnuler.Enabled = true;
                btnAjout.Text = "Valider!";
            }
            else
            {
                if (txtbNomCli.Text != "" | txtbPrenomCli.Text != "" | txtbAdrCli.Text != "" | txtbCodePostalCli.Text != "" | txtbVilleCli.Text != "")
                {
                    int c = Convert.ToInt32(txtbNumCli.Text);
                    string p = txtbPrenomCli.Text;
                    string z = txtbNomCli.Text;
                    string a = txtbAdrCli.Text;
                    int cp = Convert.ToInt32(txtbCodePostalCli.Text);
                    string v = txtbVilleCli.Text;
                    AjouterClient(c, z, p, a, cp, v);
                    position = 0;
                    dgListCli.DataSource = getLesClients();
                    Rafraichir();
                    btnAjout.Text = "Ajout.";
                    txtbNomCli.ReadOnly = true;
                    txtbPrenomCli.ReadOnly = true;
                    txtbAdrCli.ReadOnly = true;
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
                txtbPrenomCli.ReadOnly = false;
                txtbAdrCli.ReadOnly = false;
                txtbCodePostalCli.ReadOnly = false;
                txtbVilleCli.ReadOnly = false;
                btnAjout.Enabled = false;
                btnSuppr.Enabled = false;
                btnAnnuler.Enabled = true;
                btnModif.Text = "Valider!";
        }
            else
            {
                if (txtbNomCli.Text != "" | txtbPrenomCli.Text != "" | txtbAdrCli.Text != "" | txtbCodePostalCli.Text != "" | txtbVilleCli.Text != "")
                {
                    int c = Convert.ToInt32(txtbNumCli.Text);
                    string p = txtbPrenomCli.Text;
                    string z = txtbNomCli.Text;
                    string a = txtbAdrCli.Text;
                    int cp = Convert.ToInt32(txtbCodePostalCli.Text);
                    string v = txtbVilleCli.Text;
                    ModifierClient(c, z, p, a, cp, v);
                    position = 0;
                    dgListCli.DataSource = getLesClients();
                    Rafraichir();
                    btnModif.Text = "Modif.";
                    txtbNomCli.ReadOnly = true;
                    txtbPrenomCli.ReadOnly = true;
                    txtbAdrCli.ReadOnly = true;
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
                    SupprimerInfoClient("Client",c);
                    position = 0;
                    dgListCli.DataSource = getLesClients();
                    Rafraichir();
                    btnSuppr.Text = "Suppr.";
                    btnAjout.Enabled = true;
                    btnModif.Enabled = true;
                    btnAnnuler.Enabled = false;
                }
                catch (Exception)
                {
                    var rep = DialogResult;
                    rep = MessageBox.Show("Si vous supprimez ce Client vous supprimerez aussi la(les) commande(s) associé(s) a ce client, êtes-vous sûr de vouloir continuer ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rep == DialogResult.Yes)
                    {
                        SupprimerInfoClient("Commande", c);
                        SupprimerInfoClient("Client", c);

                        position = 0;
                        dgListCli.DataSource = getLesClients();
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
            txtbPrenomCli.Text = dgListCli.CurrentRow.Cells[2].Value.ToString();
            txtbAdrCli.Text = dgListCli.CurrentRow.Cells[3].Value.ToString();
            txtbCodePostalCli.Text = dgListCli.CurrentRow.Cells[4].Value.ToString();
            txtbVilleCli.Text = dgListCli.CurrentRow.Cells[5].Value.ToString();
            dgListCli.CurrentCell = dgListCli[0, dgListCli.CurrentRow.Index];
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtbNomCli.ReadOnly = true;
            txtbPrenomCli.ReadOnly = true;
            txtbAdrCli.ReadOnly = true;
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

        private void btnGenererPDF_Click(object sender, EventArgs e)
        {
            PdfPTable tableau_info;
            tableau_info = new PdfPTable(6);
            tableau_info.AddCell("Id Client");
            tableau_info.AddCell("Nom CLient");
            tableau_info.AddCell("Prenom Client");
            tableau_info.AddCell("Adresse Client");
            tableau_info.AddCell("Code Postal Client");
            tableau_info.AddCell("Ville Client");

            GenererPDFDepuisDataTable("Liste Clients", getLesClients(),tableau_info);
        }
    }
}
