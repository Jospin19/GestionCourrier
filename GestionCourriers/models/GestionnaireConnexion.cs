using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCourriers.models
{
    public class GestionnaireConnexion
    {
        //Déclaration des attributs
        private MySqlConnection connecteur;

        String message_erreur;
        int nbreCmde;


        //Déclaration des méthodes

        //Déclaration du constructeur
        public GestionnaireConnexion()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            string connectionString;
            connectionString = "Server=127.0.0.1;Database=courrier_bd;Uid=root;Pwd=;SslMode=none";

            connecteur = new MySqlConnection(connectionString);
        }

        //Déclaration de la méthode qui va ouvrir une connexion
        private bool Open()
        {
            try
            {
                connecteur.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }


        //Déclaration de la méthode qui va fermer la connexion
        public bool Close()
        {
            try
            {
                connecteur.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }



        /**
         * Déclration des méthodes de gestion des sécrétaires
         * */

        //Déclaration de la méthode qui  va renvoyer la liste de tous les sécrétaires
        public List<Secretaire> AllSecretaire()
        {
            List<Secretaire> ListeSec = new List<Secretaire>();

            //Déclarationde la requête à exécuter
            string requete = "select * from secretaires ORDER BY nom_sec, prenom_sec ASC";

            //Ouverture de connecteur
            if (this.Open() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(requete, connecteur);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    ListeSec.Add(new Secretaire(dataReader.GetString("nom_sec"), dataReader.GetString("nom_sec"), dataReader.GetString("email_sec"), dataReader.GetString("tel"), dataReader.GetString("login"), dataReader.GetString("password")));
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.Close();

                //return list to be displayed
                return ListeSec;
            }
            else
            {
                return null;
            }
        }

        //Déclaration de la fonction qui va rechercher un/ une sécrétaire
        public Secretaire OneSecretaire(string loginSec)
        {
            Secretaire newSecretaire = null;

            //Déclarationde la requête à exécuter
            string requete = "select * from secretaires where (login = '" + loginSec + "')";

            //Ouverture de connecteur
            if (this.Open() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(requete, connecteur);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                if (dataReader.Read())
                {
                    newSecretaire = new Secretaire(dataReader.GetString("nom_sec"), dataReader.GetString("nom_sec"), dataReader.GetString("email_sec"), dataReader.GetString("tel"), dataReader.GetString("login"), dataReader.GetString("password"));
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.Close();

                //return list to be displayed
                return newSecretaire;
            }
            else
            {
                return null;
            }
        }

        //Déclaration de la focntionn qui va permettre de vérifier si une/une sécrétaire existe
        public bool verifySecretaire(string loginSec, string passwdSec)
        {
            GestionnaireConnexion connect = new GestionnaireConnexion();
            List<Secretaire> ListeSec = connect.AllSecretaire();
            bool reponse = false;

            foreach (Secretaire S in ListeSec)
            {
                if ((S.login == loginSec) && (S.password == passwdSec))
                    reponse = true;
            }
            return reponse;
        }

        //Déclaration de la méthode qui va modifier un/sécrétaire
        public void ModifySecretaire(Secretaire S, string login, string password)
        {
            string requete = "update secretaires set login = '" + login + "', passsword = '" + password + "' where  nom_sec = '" + S.nomSecretaire + "'and prenom_sec = '" + S.prenomSecretaire + "'";

            //Open connection
            if (this.Open() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = requete;
                //Assign the connection using Connection
                cmd.Connection = connecteur;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.Close();
            }
        }




        /**
         * Déclration des méthodes de gestion des expéditeurs
         * */

        //Déclaration de la méthode qui  va renvoyer la liste de tous les expéditeurs
        public List<Expediteur> AllExpediteur()
        {
            List<Expediteur> ListeExpediteur = new List<Expediteur>();

            //Déclarationde la requête à exécuter
            string requete = "select * from expediteurs ORDER BY id_exp";

            //Ouverture de connecteur
            if (this.Open() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(requete, connecteur);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    ListeExpediteur.Add(new Expediteur(dataReader.GetString("nom_exp"), dataReader.GetString("prenom_exp"), dataReader.GetString("tel_exp")));
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.Close();

                //return list to be displayed
                return ListeExpediteur;
            }
            else
            {
                return null;
            }
        }


        //Déclaration de la fonction qui va rechercher un expéditeur
        public List<Expediteur> OneExpediteur(string nomExp, string prenomExp)
        {
            List<Expediteur> ListeExpediteur = new List<Expediteur>();

            //Déclarationde la requête à exécuter
            string requete = "select * from expediteurs where (nom_exp = '" + nomExp + "' AND prenom_exp = '" + prenomExp + "')";

            //Ouverture de connecteur
            if (this.Open() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(requete, connecteur);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                if (dataReader.Read())
                {
                    ListeExpediteur.Add(new Expediteur(dataReader.GetString("nom_exp"), dataReader.GetString("prenom_exp"), dataReader.GetString("tel_exp")));
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.Close();

                //return list to be displayed
                return ListeExpediteur;
            }
            else
            {
                return null;
            }
        }

        //Déclaration de la méthode qui va ajouter un expéditeur
        public void insertExpediteur(Expediteur E)
        {
            string requete = "insert into expediteurs (nom_exp, prenom_exp, tel_exp)" +
                                   "values('" + E.nomExpediteur + "', '" + E.prenomExpediteur + "', '" + E.telExpediteur + "')";

            //open connection
            if (this.Open() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(requete, connecteur);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.Close();
            }
        }


        //Déclaration de la méthode qui va modifier un expéditeur
        public void ModifyExpediteur(Expediteur E, string refC)
        {
            //Récupération de l'ID de l'expéditeà supprimer
            int idCour = this.idCour(refC);

            string requete = "update expediteurs set nom_exp = '" + E.nomExpediteur + "', prenom_exp = '" + E.prenomExpediteur + "', tel_exp = '" + E.telExpediteur + "', email_exp = '" +  "' where  id_exp = '" + idCour + "'";

            //Open connection
            if (this.Open() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = requete;
                //Assign the connection using Connection
                cmd.Connection = connecteur;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.Close();
            }
        }

        //Déclaration de la méthode qui va modifier un expéditeur
        public void ModifyNomExpediteur(string nomE, string refC)
        {
            //Récupération de l'ID de l'expéditeà supprimer
            int idCour = this.idCour(refC);

            string requete = "update expediteurs set nom_exp = '" + nomE + "' where  id_exp = '" + idCour + "'";

            //Open connection
            if (this.Open() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = requete;
                //Assign the connection using Connection
                cmd.Connection = connecteur;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.Close();
            }
        }


        //Déclaration de la méthode qui va supprimer un expéditeur
        public void DeleteExpediteur(string refCour)
        {
            int idCour = this.idCour(refCour);

            string requete = "delete from expediteurs where id_exp = '" + idCour + "'";

            if (this.Open() == true)
            {
                MySqlCommand cmd = new MySqlCommand(requete, connecteur);
                cmd.ExecuteNonQuery();
                this.Close();
            }
        }


        /**
         * Déclration des méthodes de gestion des courriers
         * */

        //Déclaration de la méthode qui  va renvoyer la liste de tous les courriers
        public List<Courrier> AllCourrier()
        {
            List<Courrier> ListeCourrier = new List<Courrier>();

            //Déclarationde la requête à exécuter
            string requete = "select * from courriers, expediteurs where courriers.id_cour = expediteurs.id_exp";

            //Ouverture de connecteur
            if (this.Open() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(requete, connecteur);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    ListeCourrier.Add(new Courrier(dataReader.GetString("reference_cour"), dataReader.GetString("libelle_cour"), dataReader.GetString("contenu"), dataReader.GetString("type_cour"), dataReader.GetString("nom_exp")));
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.Close();

                //return list to be displayed
                return ListeCourrier;
            }
            else
            {
                return null;
            }
        }

        //Déclaration de la fonction qui va recupérer l'ID d'un courrier
        public int idCour(string refCour)
        {
            int idCour = 0;

            //Déclarationde la requête à exécuter
            string requete = "select id_cour from courriers where (reference_cour = '" + refCour + "')";

            //Ouverture de connecteur
            if (this.Open() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(requete, connecteur);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                if (dataReader.Read())
                {
                    idCour = dataReader.GetInt32("id_cour");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.Close();

                //return list to be displayed
                return idCour;
            }
            else
            {
                return idCour;
            }
        }


        //Déclration de la fonction qui va ajouter du courrier
        public void InsertCourrier(Courrier C, Expediteur E)
        {

            //Insertion de l'expéditeur
            insertExpediteur(E);

            string requete = "insert into courriers (reference_cour, libelle_cour, contenu, type_cour)" +
                                   "values('" + C.referenceCourrier + "', '" + C.libelleCourrier + "', '" + C.contenu + "', '" + C.typeCourrier + "')";


            //open connection
            if (this.Open() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(requete, connecteur);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.Close();
            }
        }


        //Déclaration de la méthode qui va supprimer un Courrier
        public void DeleteCourrier(string refCour)
        {
            //Récupération de l'ID du courrier en focntion de sa référence
            int idCour = this.idCour(refCour);

            //Suppression de l'expéditeur
            this.DeleteExpediteur(refCour);

            //Requête de suppression du courrier
            string requete = "delete from courriers where id_cour = '" + idCour + "'";

            if (this.Open() == true)
            {
                MySqlCommand cmd = new MySqlCommand(requete, connecteur);
                cmd.ExecuteNonQuery();
                this.Close();
            }
        }

        //Déclaration de la méthode qui va modifier un/sécrétaire
        public void ModifyCourrier(string refC, string libC, string contC, string typeC, string nomEx)
        {
            //Modification du nom de l'expéditeur
            this.ModifyNomExpediteur(nomEx, refC);

            int idCour = this.idCour(refC);

            string requete = "update courriers set libelle_cour = '" + libC + "'," + " contenu = '" + contC + "'," + " type_cour = '" + typeC + "'" + "where  id_cour = '" + idCour + "'";

            //Open connection
            if (this.Open() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = requete;
                //Assign the connection using Connection
                cmd.Connection = connecteur;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.Close();
            }
        }

        //Déclaration de la fonction qui va rechercher un courrier
        public List<Courrier> OneCourrier(string refCour)
        {
            List<Courrier> ListeCourrier = new List<Courrier>();

            //Déclarationde la requête à exécuter
            string requete = "select * from courriers, expediteurs where (reference_cour = '" + refCour +  "')";

            //Ouverture de connecteur
            if (this.Open() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(requete, connecteur);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                if (dataReader.Read())
                {
                    ListeCourrier.Add(new Courrier(dataReader.GetString("reference_cour"), dataReader.GetString("libelle_cour"), dataReader.GetString("contenu"), dataReader.GetString("type_cour"), dataReader.GetString("nom_exp")));
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.Close();

                //return list to be displayed
                return ListeCourrier;
            }
            else
            {
                return null;
            }
        }

        /**
         * Déclration des méthodes de gestion des enregistrement
         * */

        //Déclaration de la méthode qui  va renvoyer la l'historique des enregistrements de courier
        public List<Enregistrement> AllEnregistrement()
        {
            List<Enregistrement> ListeEnr = new List<Enregistrement>();

            //Déclarationde la requête à exécuter
            string requete = "SELECT reference_cour, libelle_cour, type_cour, nom_exp, prenom_exp FROM courriers, expediteurs where id_cour = id_exp;";

            //Ouverture de connecteur
            if (this.Open() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(requete, connecteur);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    ListeEnr.Add(new Enregistrement(dataReader.GetString("reference_cour"), dataReader.GetString("libelle_cour"), dataReader.GetString("type_cour"), dataReader.GetString("nom_exp"), dataReader.GetString("prenom_exp")));
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.Close();

                //return list to be displayed
                return ListeEnr;
            }
            else
            {
                return null;
            }
        }


        /**
         * Méthode de gestion de l'aspect statistique
         **/

        //Déclaration de la méthode qui compte le nombre de courriers présents dans la BD
         public int countTotalCourrier()
        {
            int nbreCour = 0;

            //Déclarationde la requête à exécuter
            string requete = "SELECT COUNT(id_cour) as nbreCourrier FROM courriers";

            //Ouverture de connecteur
            if (this.Open() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(requete, connecteur);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                if (dataReader.Read())
                {
                    nbreCour = dataReader.GetInt32("nbreCourrier");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.Close();

                //return list to be displayed
                return nbreCour;
            }
            else
            {
                return nbreCour;
            }
        }

        //Déclaration de la méthode qui compte le nombre de courriers de type entrants présents dans la BD
        public int countTotalEntrant()
        {
            string typeC = "Entrant";
            int nbreCour = 0;

            //Déclarationde la requête à exécuter
            string requete = "SELECT COUNT(id_cour) AS nbreCourrier FROM courriers WHERE (type_cour = '" + typeC + "')";

            //Ouverture de connecteur
            if (this.Open() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(requete, connecteur);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                if (dataReader.Read())
                {
                    nbreCour = dataReader.GetInt32("nbreCourrier");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.Close();

                //return list to be displayed
                return nbreCour;
            }
            else
            {
                return nbreCour;
            }
        }


        //Déclaration de la méthode qui compte le nombre de courriers de type interne présents dans la BD
        public int countTotalInterne()
        {
            string typeC = "Interne";
            int nbreCour = 0;

            //Déclarationde la requête à exécuter
            string requete = "SELECT COUNT(id_cour) AS nbreCourrier FROM courriers WHERE (type_cour = '" + typeC + "')";

            //Ouverture de connecteur
            if (this.Open() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(requete, connecteur);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                if (dataReader.Read())
                {
                    nbreCour = dataReader.GetInt32("nbreCourrier");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.Close();

                //return list to be displayed
                return nbreCour;
            }
            else
            {
                return nbreCour;
            }
        }

        //Déclaration de la méthode qui compte le nombre de courriers de type interne présents dans la BD
        public int countTotalSortant()
        {
            string typeC = "Sortant";
            int nbreCour = 0;

            //Déclarationde la requête à exécuter
            string requete = "SELECT COUNT(id_cour) AS nbreCourrier FROM courriers WHERE (type_cour = '" + typeC + "')";

            //Ouverture de connecteur
            if (this.Open() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(requete, connecteur);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                if (dataReader.Read())
                {
                    nbreCour = dataReader.GetInt32("nbreCourrier");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.Close();

                //return list to be displayed
                return nbreCour;
            }
            else
            {
                return nbreCour;
            }
        }


    }
}
