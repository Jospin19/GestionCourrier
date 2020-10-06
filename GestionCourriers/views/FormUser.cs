using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCourriers.views
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        //Méthode qui va permettre de fermer la fenêtre de l'application
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Méthode qui va permettre de réduire la fenêtre 
        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //Méthode qui va permettre de se déconnecter
        private void LogOut_Click(object sender, EventArgs e)
        {

        }

        //Méthode qui va permettre d'afficher un manuel d'aide pour l'application
        private void Help_Click(object sender, EventArgs e)
        {

        }


        /*
        //Déclaration des actions à effectuer lors du clic sur le bouton Menu Acceuil
        private void MenuAcceuil_Click(object sender, EventArgs e)
        {
            Separator.Width = MenuAcceuil.Width;
            Separator.Left = MenuAcceuil.Left;

            //Opérations de masquage

            //Menu du courrier--------Acceuil
            courrierUser3.Visible = false;

            //Menu Historique--------Acceuil
            enregistrementUser3.Visible = false;

            //Menu statistique--------Acceuil
            statistiqueUser3.Visible = false;

            Transition.ShowSync(homeUser3);
            homeUser3.Visible = true;
        }

        //Déclaration des actions à effectuer lors du clic sur le bouton Menu Courrier
        private void MenuCourriers_Click(object sender, EventArgs e)
        {
            Separator.Width = MenuCourriers.Width;
            Separator.Left = MenuCourriers.Left;

            //Opérations de masquage

            //Acceuil--------Menu courrier
            homeUser3.Visible = false;

            //Menu Historique--------Menu courrier
            enregistrementUser3.Visible = false;

            //menu statistique--------Menu courrier
            statistiqueUser3.Visible = false;

            Transition.ShowSync(courrierUser3);
            
            courrierUser3.Visible = true;

        }


        //Déclaration des actions à effectuer lors du clic sur le bouton Menu historique
        private void MenuHisto_Click(object sender, EventArgs e)
        {
            Separator.Width = MenuHisto.Width;
            Separator.Left = MenuHisto.Left;

            //Opérations de masquage

            //Acceuil--------Menu Historique
            homeUser3.Visible = false;

            //Menu Courrier--------Menu Historique
            courrierUser3.Visible = false;

            //Menu Statistique--------Menu Historique
            statistiqueUser3.Visible = false;

            Transition.ShowSync(enregistrementUser3);
            //On remplit le datagrid des lecteurs

            enregistrementUser3.Visible = true;
        }


        //Déclaration des actions à effectuer lors du clic sur le bouton Menu statistique
        private void MenuStat_Click(object sender, EventArgs e)
        {
            Separator.Width = MenuStat.Width;
            Separator.Left = MenuStat.Left;

            //Opérations de masquage

            //Acceuil--------GestionEmprunt
            homeUser3.Visible = false;

            //GestionLivre--------GestionEmprunt
            courrierUser3.Visible = false;

            //GestionLecteur--------GestionEmprunt
            enregistrementUser3.Visible = false;

            Transition.ShowSync(statistiqueUser3);
            //On remplit le datagrid des emprunts

            statistiqueUser3.Visible = true;
        }

    */

        //Répétition des fonctions précédentes suite à un bug
        private void MenuAcceuil_Click(object sender, EventArgs e)
        {
            Separator.Width = MenuAcceuil.Width;
            Separator.Left = MenuAcceuil.Left;

            //Opérations de masquage

            //Menu du courrier--------Acceuil
            courrierUser3.Visible = false;

            //Menu Historique--------Acceuil
            enregistrementUser3.Visible = false;

            //Menu statistique--------Acceuil
            statistiqueUser3.Visible = false;

            Transition.ShowSync(homeUser3);
            homeUser3.Visible = true;
        }

        private void MenuCourriers_Click(object sender, EventArgs e)
        {
            Separator.Width = MenuCourriers.Width;
            Separator.Left = MenuCourriers.Left;

            //Opérations de masquage

            //Acceuil--------Menu courrier
            homeUser3.Visible = false;

            //Menu Historique--------Menu courrier
            enregistrementUser3.Visible = false;

            //menu statistique--------Menu courrier
            statistiqueUser3.Visible = false;

            Transition.ShowSync(courrierUser3);

            courrierUser3.Visible = true;
        }

        private void MenuHisto_Click(object sender, EventArgs e)
        {
            Separator.Width = MenuHisto.Width;
            Separator.Left = MenuHisto.Left;

            //Opérations de masquage

            //Acceuil--------Menu Historique
            homeUser3.Visible = false;

            //Menu Courrier--------Menu Historique
            courrierUser3.Visible = false;

            //Menu Statistique--------Menu Historique
            statistiqueUser3.Visible = false;

            Transition.ShowSync(enregistrementUser3);
            //On remplit le datagrid des lecteurs

            enregistrementUser3.Visible = true;
        }

        private void MenuStat_Click(object sender, EventArgs e)
        {
            Separator.Width = MenuStat.Width;
            Separator.Left = MenuStat.Left;

            //Opérations de masquage

            //Acceuil--------GestionEmprunt
            homeUser3.Visible = false;

            //GestionLivre--------GestionEmprunt
            courrierUser3.Visible = false;

            //GestionLecteur--------GestionEmprunt
            enregistrementUser3.Visible = false;

            Transition.ShowSync(statistiqueUser3);
            //On remplit le datagrid des emprunts

            statistiqueUser3.Visible = true;
        }
    }
}
