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
    public partial class EnregistrementUser : UserControl
    {
        public EnregistrementUser()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
            }

            //On charge le datagrid au demarrage de l'application
            chargerdgEnr();
        }

        //Déclaration de la fonction qui va remplir le dg des enregistrement pour l'historique
        public void chargerdgEnr()
        {
            GestionnaireConnexion connect = new GestionnaireConnexion();
            List<Enregistrement> ficheE = connect.AllEnregistrement();

            dgEnr.Rows.Clear();

            foreach (Enregistrement E in ficheE)
            {
                dgEnr.Rows.Add(null, E.referenceCourrier, E.libelleCourrier, E.typeCourrier, E.nomExpediteur, E.prenomExpediteur);
            }
        }

        private void actualCourrier_Click(object sender, EventArgs e)
        {
            chargerdgEnr();
        }
    }
}
