using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;
using Persistance;
using MesErreurs;

namespace Presentation
{
    public partial class FCommercial : Form
    {
        public FCommercial()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FCommercial_Load(object sender, EventArgs e)
        {
            try
            {
                bool rep;
                // on connecte l'application à la base de données
                rep = OuvertureApplication.getOuverture();
                // si la connexion a réussie : on active les menus
                if (rep)
                {

                    interrogerToolStripMenuItem.Enabled = true;
                    gérerToolStripMenuItem.Enabled = true;

                    lb_connecte.Text = "Etat : en ligne";
                    lb_connecte.ForeColor = Color.DarkGreen;
                }
                // sinon on désactive les menus
                else
                {
                    interrogerToolStripMenuItem.Enabled = false;
                    gérerToolStripMenuItem.Enabled = false;

                    lb_connecte.Text = "Etat : hors ligne - erreur de connexion";
                    lb_connecte.ForeColor = Color.Red;
                }
            }
            catch (MonException excep)
            {
                MessageBox.Show(excep.MessageSysteme(), "Erreur de connexion");
                interrogerToolStripMenuItem.Enabled = false;
                gérerToolStripMenuItem.Enabled = false;
                lb_connecte.Text = excep.MessageSysteme();
                lb_connecte.ForeColor = Color.Red;
            }
        }

        private void ficheClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FClient fc = new FClient();
            fc.Show();
        }
    }
}
