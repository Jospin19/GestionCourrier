using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCourriers.models
{
    public class Courrier
    {
        //Déclaration des différentes attributs de la classe
        public string referenceCourrier;
        public string libelleCourrier;
        public string contenu;
        public string typeCourrier;
        public string nomExpediteur;

        //Déclaration du constructeur
        public Courrier(string refCour, string libCour, string contCour, string typeCour, string nomExp)
        {
            this.referenceCourrier = refCour;
            this.libelleCourrier = libCour;
            this.contenu = contCour;
            this.typeCourrier = typeCour;
            this.nomExpediteur = nomExp;
        }
    }
}
