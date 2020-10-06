using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCourriers.models
{
    public class Secretaire
    {
        //Déclaration des différentes attributs de la classe
        public string nomSecretaire;
        public string prenomSecretaire;
        public string emailSecretaire;
        public string telSecretaire;
        public string login;
        public string password;

        //Déclaration du constructeur
        public Secretaire(string nomSec, string prenomSec, string emailSec, string telSec, string loginSec, string passwdSec)
        {
            this.nomSecretaire = nomSec;
            this.prenomSecretaire = prenomSec;
            this.emailSecretaire = emailSec;
            this.telSecretaire = telSec;
            this.login = loginSec;
            this.password = passwdSec;
        }
    }
}
