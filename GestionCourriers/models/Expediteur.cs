using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCourriers.models
{
    public class Expediteur
    {
        //Déclaration des différenets attributs de la classe
        public string nomExpediteur;
        public string prenomExpediteur;
        public string telExpediteur;

        //Déclaration du constructeur
        public Expediteur(string nomExp, string prenomExp, string telExp)
        {
            this.nomExpediteur = nomExp;
            this.prenomExpediteur = prenomExp;
            this.telExpediteur = telExp;
        }
    }
}
