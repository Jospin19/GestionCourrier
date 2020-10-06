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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
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

        //Déclaration des actions à effectuer lors du clic sur le bouton Menu Acceuil
        private void MenuAcceuil_Click(object sender, EventArgs e)
        {
            Separator.Width = MenuAcceuil.Width;
            Separator.Left = MenuAcceuil.Left;

            //Opérations de masquage

            //Menu du courrier--------Acceuil
            courrierUser2.Visible = false;

            //Menu Historique--------Acceuil
            enregistrementUser2.Visible = false;

            //Menu statistique--------Acceuil
            statistiqueUser2.Visible = false;

            Transition.ShowSync(acceuilUser2);
            acceuilUser2.Visible = true;
        }

        //Déclaration des actions à effectuer lors du clic sur le bouton Menu Courrier
        private void MenuCourriers_Click(object sender, EventArgs e)
        {
            Separator.Width = MenuCourriers.Width;
            Separator.Left = MenuCourriers.Left;

            //Opérations de masquage

            //Acceuil--------Menu courrier
            acceuilUser2.Visible = false;

            //Menu Historique--------Menu courrier
            enregistrementUser2.Visible = false;

            //menu statistique--------Menu courrier
            statistiqueUser2.Visible = false;

            Transition.ShowSync(courrierUser2);


            courrierUser2.Visible = true;

        }


        //Déclaration des actions à effectuer lors du clic sur le bouton Menu historique
        private void MenuHisto_Click(object sender, EventArgs e)
        {
            Separator.Width = MenuHisto.Width;
            Separator.Left = MenuHisto.Left;

            //Opérations de masquage

            //Acceuil--------Menu Historique
            acceuilUser2.Visible = false;

            //Menu Courrier--------Menu Historique
            courrierUser2.Visible = false;

            //Menu Statistique--------Menu Historique
            statistiqueUser2.Visible = false;

            Transition.ShowSync(MenuHisto);
            //On remplit le datagrid des lecteurs

            enregistrementUser2.Visible = true;
        }


        //Déclaration des actions à effectuer lors du clic sur le bouton Menu statistique
        private void MenuStat_Click(object sender, EventArgs e)
        {
            Separator.Width = MenuStat.Width;
            Separator.Left = MenuStat.Left;

            //Opérations de masquage

            //Acceuil--------GestionEmprunt
            acceuilUser2.Visible = false;

            //GestionLivre--------GestionEmprunt
            courrierUser2.Visible = false;

            //GestionLecteur--------GestionEmprunt
            enregistrementUser2.Visible = false;

            Transition.ShowSync(statistiqueUser2);
            //On remplit le datagrid des emprunts

            statistiqueUser2.Visible = true;
        }

    }
}
