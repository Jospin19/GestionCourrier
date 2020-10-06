using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionCourriers.models;

namespace GestionCourriers.views
{
    public partial class CourrierUser : UserControl
    {
        public CourrierUser()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
            }

            //Remplissage du datagrid au moment du chargement de l'application
            chargerdgCourrier();
        }

        //Déclaration de la fonction qui va remplir le dg de tous les courriers
        public void chargerdgCourrier()
        {
            GestionnaireConnexion connect = new GestionnaireConnexion();
            List<Courrier> ficheC = connect.AllCourrier();

            dgCourrier.Rows.Clear();

            foreach (Courrier C in ficheC)
            {
                dgCourrier.Rows.Add(null, C.referenceCourrier, C.libelleCourrier, C.contenu, C.typeCourrier, C.nomExpediteur);
            }
        }

        //Déclaration de la fonction qui va actualiser la page
        public void Actualiser()
        {
            chargerdgCourrier();

            //On efface toutes les valeurs et on maque les panels

            //On masque les pannel
            transition.HideSync(panelAjoutCour);
            panelAjoutCour.Visible = false;

            transition.HideSync(modifCourrier);
            modifCourrier.Visible = false;

            transition.HideSync(panelExp);
            panelExp.Visible = false;


            //On efface toutes les présédentes valeurs
            searchCourrier.text = "Saisir une reference";

            //panelExp
            nomE.text = "Nom de l'expediteur";
            prenomExp.text = "Prenom de l'expediteur";
            telExp.text = "Telephone";

            //panelAjoutCour
            refCourrier.text = "Reference";
            libCourrier.text = "Libelle";
            txtType.selectedIndex = -1;
            contCourrier.text = "Contenu";
            

        }

        private void actualCourrier_Click(object sender, EventArgs e)
        {
            Actualiser();
        }


        //Déclaration de quelque variable
        string referenceC = "";
        string libelleC = "";
        string contenuC = "";
        string typeC = "";
        string expC = "";


        //Déclaration de la fonction qui va récupérer l'index de la valeur du sélectionée du Dropdown
        public int getIndex(string nomItem)
        {
            switch (nomItem)
            {
                case "Entrant":
                    return 0;
                case "Interne":
                    return 1;
                case "Sortant":
                    return 2;
                default:
                    return -1;
            }
        }
        private void dgCourrier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Affectation des valeurs du datagrid
            referenceC = dgCourrier.Rows[e.RowIndex].Cells[1].Value.ToString();

            //Affectation aux textbox
            Lib.Text = dgCourrier.Rows[e.RowIndex].Cells[2].Value.ToString();
            Cont.Text = dgCourrier.Rows[e.RowIndex].Cells[3].Value.ToString();

            txtType.selectedIndex = getIndex(dgCourrier.Rows[e.RowIndex].Cells[4].Value.ToString());

            Exp.Text = dgCourrier.Rows[e.RowIndex].Cells[5].Value.ToString();



            //Affectation à l'objet Courrier
            libelleC = dgCourrier.Rows[e.RowIndex].Cells[2].Value.ToString();
            contenuC = dgCourrier.Rows[e.RowIndex].Cells[3].Value.ToString();
            expC = dgCourrier.Rows[e.RowIndex].Cells[5].Value.ToString();
            

            //Rend visible
            Lib.Visible = true;
            Cont.Visible = true;
            Exp.Visible = true;

            transition.HideSync(panelAjoutCour);
            panelAjoutCour.Visible = false;

            transition.HideSync(panelExp);
            panelExp.Visible = false;

            transition.ShowSync(modifCourrier);
            modifCourrier.Visible = true;
            
        }


        //Déclaration de quelques variables
        string reference;
        string libelle;
        string contenu;
        string type;

        string nomExpe;
        string prenExpe;
        string telExpe;

        
        

        private void ajoutCourrier_Click(object sender, EventArgs e)
        {
            //On masque les pannel
            transition.HideSync(panelExp);
            panelExp.Visible = false;
            transition.HideSync(modifCourrier);
            modifCourrier.Visible = false;

            transition.ShowSync(panelAjoutCour);
            panelAjoutCour.Visible = true;
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            reference = refCourrier.text;
            libelle = libCourrier.text;

            contenu = contCourrier.text;

            //On masque les pannel
            transition.HideSync(panelAjoutCour);
            panelAjoutCour.Visible = false;
            transition.HideSync(modifCourrier);
            modifCourrier.Visible = false;

            //On affiche le pannel
            transition.ShowSync(panelExp);
            panelExp.Visible = true;
        }


        private void searchCourrier_Enter(object sender, EventArgs e)
        {
            searchCourrier.text = "";
        }

        private void SaveCour_Click(object sender, EventArgs e)
        {
            //On masque les pannel
            transition.HideSync(panelAjoutCour);
            panelAjoutCour.Visible = false;
            transition.HideSync(modifCourrier);
            modifCourrier.Visible = false;

            transition.HideSync(panelExp);
            panelExp.Visible = false;

            nomExpe = nomE.text;
            prenExpe = prenomExp.text;
            telExpe = telExp.text;

            //Création des objets à sauvegarder dans la bd
            Expediteur E = new Expediteur(nomExpe, prenExpe, telExpe);

            MessageBox.Show(txtType.Items[txtType.selectedIndex + 3]);

            Courrier C = new Courrier(reference, libelle, contenu, txtType.Items[txtType.selectedIndex + 3], nomExpe);

            //Déclarattion de la clase qui va sqauvegarder le courrier
            GestionnaireConnexion Connect = new GestionnaireConnexion();

            Connect.InsertCourrier(C, E);

            //On actualise le contenu
            Actualiser();
        }

        private void prenomExp_Enter(object sender, EventArgs e)
        {
            prenomExp.text = "";
        }

        private void telExp_Enter(object sender, EventArgs e)
        {
            telExp.text = "";
        }

        private void refCourrier_Enter(object sender, EventArgs e)
        {
            refCourrier.text = "";
        }

        private void libCourrier_Enter(object sender, EventArgs e)
        {
            libCourrier.text = "";
        }

        private void typeCour_Enter(object sender, EventArgs e)
        {
            txtType.selectedIndex = -1;
        }

        private void nomE_Enter(object sender, EventArgs e)
        {
            nomE.text = "";
        }

    
        private void contCourrier_Enter(object sender, EventArgs e)
        {
            contCourrier.text = "";
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            GestionnaireConnexion connect = new GestionnaireConnexion();
            List<Courrier> ficheC = connect.OneCourrier(searchCourrier.text);

            dgCourrier.Rows.Clear();

            foreach (Courrier C in ficheC)
            {
                dgCourrier.Rows.Add(null, C.referenceCourrier, C.libelleCourrier, C.contenu, C.typeCourrier, C.nomExpediteur);
            }
        }

    
        //Modification d'u courrier
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            GestionnaireConnexion Connect = new GestionnaireConnexion();
            
            Connect.ModifyCourrier(referenceC, Lib.Text, contenuC, txtType.Items[txtType.selectedIndex], Exp.Text);

            Actualiser();
        }


        //Suppression d'un courrier
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            GestionnaireConnexion Connect = new GestionnaireConnexion();

            Connect.DeleteCourrier(referenceC);

            Actualiser();
        }

        
    }
}
