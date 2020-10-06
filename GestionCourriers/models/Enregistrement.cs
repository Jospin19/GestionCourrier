using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCourriers.models
{
    public class Enregistrement
    {
        //Déclaration des différentes attributs de la classe
        public string referenceCourrier;
        public string libelleCourrier;
        public string typeCourrier;
        public string nomExpediteur;
        public string prenomExpediteur;


        //Déclaration du constructeur
        public Enregistrement(string refCour, string libCour, string typeCour, string nomExp, string prenomExp)
        {
            this.referenceCourrier = refCour;
            this.libelleCourrier = libCour;
            this.typeCourrier = typeCour;
            this.nomExpediteur = nomExp;
            this.prenomExpediteur = prenomExp;
        }
    }
}
