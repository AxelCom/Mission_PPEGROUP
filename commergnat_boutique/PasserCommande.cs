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
    public partial class PasserCommande : Form
    {
        public PasserCommande()
        {
            InitializeComponent();
        }

        private void PasserCommande_Load(object sender, EventArgs e)
        {
           // dgListCommandePassee.DataSource = ClassePasserCommande.getLesCommandesPassees();
        }
    }
}
