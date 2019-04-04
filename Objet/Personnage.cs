using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objet
{
    class Personnage
    {

        //Variables gérée avec get, set
        public int PersonnageForce { get; private set; }
        public int PersonnageIntelligence { get; private set; }
        public int PersonnageVie { get; private set; }
        public int PersonnageDefense { get; private set; }
        public string PersonnageNom { get; private set; }
        public Arme PersonnageArme { get; private set; }

        //Initalisation du personnage, ce que l'on crée dans le main sera enregistré dans l'objet
        public void CreationPersonnage(int PersoForce, int intelligence, int PersoVie, int PersoDef, string PersoName, Arme arme)
        {
            PersonnageForce = PersoForce;
            PersonnageIntelligence = intelligence;
            PersonnageVie = PersoVie;
            PersonnageDefense = PersoDef;
            PersonnageNom = PersoName;
            PersonnageArme = arme;
        }

        //On crée une fonction qui va chercher des variables et la fonction
        public void AttaquePersonnage(Personnage personne)
        {
            Console.WriteLine(this.PersonnageNom + " attaque " + personne.PersonnageNom + " avec : " + this.PersonnageArme.RetourNomArme());
            Console.WriteLine(this.PersonnageNom + " fait " + ((this.PersonnageForce * this.PersonnageArme.RetourDegatsArme()) - personne.PersonnageDefense) + " pts de dégâts !");
            personne.PersonnageVie += personne.PersonnageDefense - (this.PersonnageForce * this.PersonnageArme.RetourDegatsArme());
            Console.WriteLine(personne.PersonnageNom + " passe à " + personne.PersonnageVie + " PDV");
        }

        public void AttaqueMagique(Personnage personne)
        {
            Console.WriteLine(this.PersonnageNom + " attaque " + personne.PersonnageNom + " avec : " + this.PersonnageArme.RetourNomArme());
            Console.WriteLine(this.PersonnageNom + " fait " + ((this.PersonnageIntelligence * this.PersonnageArme.RetourDegatsArme()) - personne.PersonnageDefense) + " pts de dégâts !");
            personne.PersonnageVie += personne.PersonnageDefense - (this.PersonnageIntelligence * this.PersonnageArme.RetourDegatsArme());
            Console.WriteLine(personne.PersonnageNom + " passe à " + personne.PersonnageVie + " PDV");
        }
    }

    class Arme
    {
        public int ArmeDegats { get; private set; }
        private string ArmeNom { get; set; }

        public void CreationArme(int Arme, string Nom)
        {
            ArmeDegats = Arme;
            ArmeNom = Nom;
        }

        //Ici la création de cette fonction est obligatoire car
        //notre variable est en private et donc le get aussi, ce
        //qui fait qu'elle n'est pas atteignable en dehors de la classe
        public string RetourNomArme()
        {
            return ArmeNom;
        }

        //Par contre ici, la fonction n'est pas obligatoire !
        //En effet, le get en public, on peut donc reprendre la
        //fonction en dehors de la classe
        public int RetourDegatsArme()
        {
            return ArmeDegats;
        }
    }
}
