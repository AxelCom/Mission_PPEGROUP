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
    public partial class accueil : Form
    {
        public accueil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics graphicsObj;

            graphicsObj = this.CreateGraphics();

            Pen myPen = new Pen(System.Drawing.Color.Red, 5);

            graphicsObj.DrawLine(myPen, 20, 20, 200, 20);
        }

        private void gestionDesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionCommande FrmGestCommande = new GestionCommande();
            FrmGestCommande.MdiParent = this;
            FrmGestCommande.StartPosition = FormStartPosition.CenterScreen;
            FrmGestCommande.Show();
        }

        private void listeDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionClient FrmGestClient = new GestionClient();
            FrmGestClient.MdiParent = this;
            FrmGestClient.StartPosition = FormStartPosition.CenterScreen;
            FrmGestClient.Show();
        }

        private void listeDesFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionFournisseur FrmGestFournisseur = new GestionFournisseur();
            FrmGestFournisseur.MdiParent = this;
            FrmGestFournisseur.StartPosition = FormStartPosition.CenterScreen;
            FrmGestFournisseur.Show();
        }

        private void listeDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionProduits FrmGestProduit = new GestionProduits();
            FrmGestProduit.MdiParent = this;
            FrmGestProduit.StartPosition = FormStartPosition.CenterScreen;
            FrmGestProduit.Show();
        }

        private void accueil_Load(object sender, EventArgs e)
        {
            GestionBoutique.seConnecter("paulsalban","sa59s");
        }

        private void réapprovisionnementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasserCommande FrmPasserCommande = new PasserCommande();
            FrmPasserCommande.MdiParent = this;
            FrmPasserCommande.StartPosition = FormStartPosition.CenterScreen;
            FrmPasserCommande.Show();
        }
    }
}
