using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace websprincipal
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void AltaDeDireccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altadedirecciones ad = new altadedirecciones();
            ad.Show();
        }

        private void ModificaciónDeDireccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultadedirecciones cd = new consultadedirecciones();
            cd.Show();
        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
