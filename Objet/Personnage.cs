using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objet
{
    class Personnage
    {
        //Ce sont les variables pour la classe
        int PersonnageID;
        string PersonnageNom;

        //Initalisation du personnage
        //Ce que l'on met sera enregistrer dans la classe
        public void SetPersonnage(int PersoID, string PersoName)
        {
            PersonnageID = PersoID;
            PersonnageNom = PersoName;
        }

        //On crée une méthode pour ressortir une variable
        public string GetPersonnageName()
        {
            return PersonnageNom;
        }
    }
}
