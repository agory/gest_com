using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilitaires;
using Metier;
using MesErreurs;


namespace Presentation
{
    public partial class FClient : Form
    {
        public FClient()
        {
            InitializeComponent();
            List<String> mesNumeros;
            try
            {
                Clientel unClient = new Clientel();
                //mesnumeros = unclient.lecturenoclient();
                //foreach (string item in mesnumeros)
                //{
                //    cb_client.items.add(item);
                //}


                // Lecture à partir d’un data source 
                cb_Client.DataSource = unClient.LectureNoClient();

            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }
        }


        private void cb_Client_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_Fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_Interroger_Click_1(object sender, EventArgs e)
        {
            string numCli;
            Clientel unClient = new Clientel();
            Clientel unClientCherche;

            try
            {
                numCli = cb_Client.Text;
                unClientCherche = unClient.RechercheUnClient(numCli);
                lb_Nom.Text = "Nom : " + unClientCherche.NomCl;
                lb_Prenom.Text = "Prénom : " + unClientCherche.PrenomCl;
                lb_Societe.Text = "Societe : " + unClientCherche.Societe;
                lb_Adresse.Text = "Adresse : " + unClientCherche.AdresseCl;
                lb_Ville.Text = "Ville : " + unClientCherche.VilleCl;
                lb_Cp.Text = "Code Postal :" + unClientCherche.CodePostCl;

            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
