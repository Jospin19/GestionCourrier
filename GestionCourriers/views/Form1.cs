using GestionCourrier.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCourrier
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void CloseFormCon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        


        //Méthode qui s'exécute lorsque le Login a le focus
        private void Login_MouseClick(object sender, MouseEventArgs e)
        {
            Login.Text = "";
            if ((Password.Text == "") || (Password.Text == "Saisir le Password"))
                Password.Text = "Saisir le Password";
        }

        //Méthode qui s'exécute lorsque le Password a le focus
        private void Password_MouseClick(object sender, MouseEventArgs e)
        {
            Password.Text = "";
            if ((Login.Text == "") || (Login.Text == "Saisir le Login"))
                Login.Text = "Saisir le Login";
        }

        private void Connecter_Click(object sender, EventArgs e)
        {
            FormConnexion PageConnexion = new FormConnexion();
            FormAdmin AcceuilAdmin = new FormAdmin();

            GestionnaireConnexion connect = new GestionnaireConnexion();

            if (connect.verifySecretaire(Login.Text) == false)
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

            }
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            Password.Text = "Saisir le Password";
            Login.Text = "Saisir le Login";
            Login.Focus();
        }
    }
}
