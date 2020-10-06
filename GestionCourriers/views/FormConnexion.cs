using GestionCourriers.models;
using GestionCourriers.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCourriers
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            Password.Text = "Saisir le Password";
            Login.Text = "";
            Login.Focus();
        }


        //Déclaration de la fonction qui va exécuter la connexion
        public void Connexion()
        {
            FormConnexion PageConnexion = new FormConnexion();
            FormUser AcceuilAdmin = new FormUser();

            GestionnaireConnexion connect = new GestionnaireConnexion();

            if (connect.verifySecretaire(Login.Text, Password.Text) == false)
            {
                transitionErreur.ShowSync(Erreur);
                Erreur.Visible = true;

                Login.Text = "";
                if ((Password.Text == "") || (Password.Text == "Saisir le Password"))
                    Password.Text = "Saisir le Password";

                Password.Text = "";
                if ((Login.Text == "") || (Login.Text == "Saisir le Login"))
                    Login.Text = "Saisir le Login";
            }
            else
            {
                Secretaire curSecretaire = connect.OneSecretaire(Login.Text);
                transition.HideSync(PageConnexion);
                System.Windows.Forms.Form.ActiveForm.Visible = false;
                transition.ShowSync(AcceuilAdmin);
                AcceuilAdmin.Activate();

                AcceuilAdmin.NomUser.Text = curSecretaire.nomSecretaire;
                AcceuilAdmin.PrenomUser.Text = curSecretaire.prenomSecretaire;
                AcceuilAdmin.EmailUser.Text = curSecretaire.emailSecretaire;
                AcceuilAdmin.TelephoneUser.Text = curSecretaire.telSecretaire;

                //Remplisage des composants
                AcceuilAdmin.Taux.Value = (connect.countTotalEntrant() * 100) / connect.countTotalCourrier();

                AcceuilAdmin.EffectifC.Value = connect.countTotalCourrier();

                AcceuilAdmin.nbre.Text = connect.countTotalCourrier().ToString();


            }
        }


        private void Connecter_Click(object sender, EventArgs e)
        {
            Connexion();
        }

        private void Login_MouseClick(object sender, MouseEventArgs e)
        {
            /*Password.Text = "Saisir le Password";
            Login.Text = "";
            Login.Focus();*/
        }

        private void Login_Enter(object sender, EventArgs e)
        {
            Password.Text = "Saisir le Password";
            Login.Text = "";
            Login.Focus();
        }

        private void Password_MouseClick(object sender, MouseEventArgs e)
        {
            //Password.Text = "";
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            Password.Text = "";
        }
    }
}
