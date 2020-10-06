using GestionCourriers.models;
using GestionCourriers.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCourriers.views
{
    public partial class StatistiqueUser : UserControl
    {
        public StatistiqueUser()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
            }
            GestionnaireConnexion connect = new GestionnaireConnexion();

            nbreC.Text = connect.countTotalCourrier().ToString();

            //Affichage des diférentes charts
            renderChart1();



        }

        private void renderCharts_Tick(object sender, EventArgs e)
        {
            renderCharts.Stop();

            //Délai pour actualiser
            renderChart1();
        }

        //
        void renderChart1()
        {
            

        }

    }
}
