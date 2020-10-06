using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCourriers.models
{
    public class Expedition
    {
        //Déclaration des différentes attributs de la classe
        public int idCourrier;
        public int idExpediteur;
        public DateTime dateExpedition;


        //Déclaration du constructeur
        public Expedition(int idCour, int idExp, DateTime dateExp)
        {
            this.idCourrier = idCour;
            this.idExpediteur = idExp;
            this.dateExpedition = dateExp;
        }
    }
}
