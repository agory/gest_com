using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Persistance;
using Utilitaires;
using MesErreurs;
using MySql.Data.MySqlClient;


namespace Metier
{
    public class Clientel
    {
        //Definition des attributs

        private String noClient;
        private String societe;
        private String nomCl;
        private String prenomCl;
        private String adresseCl;
        private String villeCl;
        private String codePostCl;


        //Definition des properties

        public String Societe
        {
            get { return societe; }
            set { societe = value; }
        }

        public String NomCl
        {
            get { return nomCl; }
            set { nomCl = value; }
        }

        public String PrenomCl
        {
            get { return prenomCl; }
            set { prenomCl = value; }
        }

        public String AdresseCl
        {
            get { return adresseCl; }
            set { adresseCl = value; }
        }

        public String VilleCl
        {
            get { return villeCl; }
            set { villeCl = value; }
        }

        public String CodePostCl
        {
            get { return codePostCl; }
            set { codePostCl = value; }
        }


        //Constructeurs

        public Clientel()
        {
            noClient = "";
            societe = "";
            nomCl = "";
            prenomCl = "";
            adresseCl = "";
            villeCl = "";
            codePostCl = "";
        }

        public Clientel(string no, string soc, string nom, string prenom, string adresse, string ville, String codePostal)
        {
            noClient = no;
            societe = soc;
            nomCl = nom;
            prenomCl = prenom;
            adresseCl = adresse;
            villeCl = ville;
            codePostCl = codePostal;
        }


        //Traitement de la classe Clientel

        /// <summary>
        /// Lire un utilisateur sur son ID
        /// </summary>
        /// <param name="id_utilisateur">N° de l'utilisateur à lire</param>


        public List<String> LectureNoClient()
        {
            List<String> mesNumeros = new List<String>();
            DataTable dt;
            sErreurs er = new sErreurs("Erreur sur lecture du client.", "Utilisateur.lectureClient()");
            try
            {

                String mysql = "SELECT DISTINCT NO_CLIENT FROM CLIENTEL ORDER BY NO_CLIENT";
                dt = DbInterface.Lecture(mysql, er);

                foreach (DataRow dataRow in dt.Rows)
                {
                    mesNumeros.Add((dataRow[0]).ToString());
                }

                return mesNumeros;
            }
            catch (MySqlException e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }

        public Clientel RechercheUnClient(String numCli)
        {

            String mysql;
            DataTable dt;
            sErreurs er = new sErreurs("Erreur sur recherche d'un client.", "Client.rechercherClient()");
            try
            {

                mysql = "SELECT SOCIETE, NOM_CL, PRENOM_CL,";
                mysql += "ADRESSE_CL, VILLE_CL, CODE_POST_CL ";
                mysql += "FROM CLIENTEL WHERE NO_CLIENT=':numero'";
                // On se protège de l’injection sql
                mysql = mysql.Replace(":numero", numCli);

                // On appelle la couche Persistance

                dt = DbInterface.Lecture(mysql, er);

                if (dt.IsInitialized)
                {
                    DataRow dataRow = dt.Rows[0];
                    this.noClient = numCli;
                    this.nomCl = dataRow[1].ToString();
                    this.societe = dataRow[0].ToString();
                    this.prenomCl = dataRow[2].ToString();
                    this.adresseCl = dataRow[3].ToString();
                    this.villeCl = dataRow[4].ToString();
                    this.codePostCl = dataRow[5].ToString();

                    return this;
                }
                else
                    return null;
            }
            catch (MySqlException e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }

    }
}
