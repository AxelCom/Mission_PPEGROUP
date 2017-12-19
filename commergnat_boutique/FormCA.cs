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
    public partial class FormCA : Form
    {
        public FormCA()
        {
            InitializeComponent();
        }

        private void FormCA_Load(object sender, EventArgs e)
        {
            foreach (DataRow uneDonnee in ClasseGestionProduit.getLesProduitsCA().Rows)
            {
                chart1.Series["Chiffre d'affaire"].Points.AddXY(uneDonnee[1], uneDonnee[4]);
            }
        }
    }
}
