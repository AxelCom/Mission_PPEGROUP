using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static commergnat_boutique.ClasseGestionCommande;
using static commergnat_boutique.GestionBoutique;

namespace commergnat_boutique
{
    public partial class GestionCommande : Form
    {
        int position = 0;
        public GestionCommande()
        {
            InitializeComponent();
        }

        private void GestionCommande_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getLesCommandesAvecNomCli();
            dataGridView1.Columns[0].HeaderText = "N° Commande";
            dataGridView1.Columns[1].HeaderText = "Date Commande";
            dataGridView1.Columns[2].HeaderText = "Nom Client";
            dataGridView1.Columns[3].Visible = false;
            cbNomCli.DataSource = ClasseGestionClient.getLesClients();
            cbNomCli.DisplayMember = "nomClient";
            cbNomCli.ValueMember = "idClient";
            
            Rafraichir();
        }
        public void Rafraichir()
        {
            
            txtbDateCom.Text = dataGridView1.Rows[position].Cells[1].Value.ToString();
            txtbNumCom.Text = dataGridView1.Rows[position].Cells[0].Value.ToString();
            cbNomCli.Text = dataGridView1.Rows[position].Cells[2].Value.ToString();
            dataGridView1.CurrentCell = dataGridView1[0, position];
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            string pos = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            position = Convert.ToInt32(pos);
            position = position - 1;
            Rafraichir();

            txtbDateCom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtbNumCom.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbNomCli.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dataGridView1.CurrentCell = dataGridView1[0, dataGridView1.CurrentRow.Index];
        }

        private void btnPrem_Click(object sender, EventArgs e)
        {
            position = 0;
            Rafraichir();
        }

        private void btnDern_Click(object sender, EventArgs e)
        {
            position = dataGridView1.Rows.Count - 1;
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
            if (position < dataGridView1.Rows.Count - 1)
            {
                position = position + 1;
                Rafraichir();
            }
        }
        private void btnModif_Click(object sender, EventArgs e)
        {
            if (btnModif.Text == "Modif.")
            {
                txtbDateCom.ReadOnly = false;
                cbNomCli.Enabled = true;
                btnAjout.Enabled = false;
                btnSuppr.Enabled = false;
                btnAnnuler.Enabled = true;

                btnModif.Text = "Valider!";
            }
            else
            {
                if (txtbDateCom.Text != "")
                {
                    int c;
                    string l;
                    int z;
                    c = Convert.ToInt32(txtbNumCom.Text);
                    l = txtbDateCom.Text;
                    z = Convert.ToInt32(cbNomCli.SelectedValue);
                    ModifierCommande(c, l, z);
                    position = 0;
                    dataGridView1.DataSource = getLesCommandesAvecNomCli();
                    Rafraichir();
                    btnModif.Text = "Modif.";
                    txtbDateCom.ReadOnly = true;
                    btnAjout.Enabled = true;
                    btnSuppr.Enabled = true;
                    btnAnnuler.Enabled = false;
                    cbNomCli.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Renseigner la Date SVP...!", "Alerte!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (btnAjout.Text == "Ajout.")
            {
                txtbNumCom.Text = Convert.ToString(GenererClePrimaire("idCommande", "Commande"));
                txtbDateCom.Text = "";
                txtbDateCom.ReadOnly = false;
                cbNomCli.Enabled = true;
                btnSuppr.Enabled = false;
                btnModif.Enabled = false;
                btnAnnuler.Enabled = true;
                btnAjout.Text = "Valider!";
            }
            else
            {
                if (txtbDateCom.Text != "")
                {
                    int c = Convert.ToInt32(txtbNumCom.Text);
                    string l = txtbDateCom.Text;
                    int z = Convert.ToInt32(cbNomCli.SelectedValue);

                    AjouterCommande(c, l, z);
                    position = 0;
                    dataGridView1.DataSource = getLesCommandesAvecNomCli();
                    Rafraichir();
                    btnAjout.Text = "Ajout.";
                    txtbDateCom.ReadOnly = true;
                    cbNomCli.Enabled = false;
                    btnModif.Enabled = true;
                    btnSuppr.Enabled = true;
                    btnAnnuler.Enabled = false;

                    ClasseGestionCommande.idCommande = c;

                    GestionLigneComande FrmGestLigneCommande = new GestionLigneComande();
                    FrmGestLigneCommande.MdiParent = accueil.ActiveForm;
                    FrmGestLigneCommande.StartPosition = FormStartPosition.CenterScreen;
                    FrmGestLigneCommande.Show();

                }
                else
                {
                    MessageBox.Show("Renseigner la Date SVP...!", "Alerte!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                int c = Convert.ToInt32(txtbNumCom.Text);
                try
                {
                    SupprimerInfoCommande("Commande", c);

                    position = 0;
                    dataGridView1.DataSource = getLesCommandesAvecNomCli();
                    Rafraichir();
                    btnSuppr.Text = "Supp.";
                    btnAjout.Enabled = true;
                    btnModif.Enabled = true;
                    btnAnnuler.Enabled = false;
                }
               catch (Exception)
                {
                    var rep = DialogResult;
                    rep = MessageBox.Show("Si vous supprimez cette commande vous supprimerez aussi le suivi de commande associé a cette commande, êtes-vous sûr de vouloir continuer ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rep == DialogResult.Yes)
                    {
                        SupprimerInfoCommande("Lignedecommande",c);

                        SupprimerInfoCommande("Commande", c);
  
                        position = 0;
                        dataGridView1.DataSource = getLesCommandesAvecNomCli();
                        Rafraichir();
                        btnSuppr.Text = "Supp.";
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

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtbNumCom.ReadOnly = true;
            txtbDateCom.ReadOnly = true;
            cbNomCli.Enabled = false;

            btnAjout.Enabled = true;
            btnSuppr.Enabled = true;
            btnModif.Enabled = true;
            btnAjout.Text = "Ajout.";
            btnModif.Text = "Modif.";
            btnSuppr.Text = "Supp.";
            btnAnnuler.Enabled = false;
            Rafraichir();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            ClasseGestionCommande.idCommande = Convert.ToInt32(txtbNumCom.Text);

            GestionLigneComande FrmGestLigneCommande = new GestionLigneComande();
            FrmGestLigneCommande.MdiParent = accueil.ActiveForm;
            FrmGestLigneCommande.StartPosition = FormStartPosition.CenterScreen;
            FrmGestLigneCommande.Show();
        }

        private void txtRecCli_TextChanged(object sender, EventArgs e)
        {
           dataGridView1.DataSource = getCommandeByClient(txtRecCli.Text);
        }
    }
    }
