using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objet
{
    class Program
    {
        static void Main(string[] args)
        {
            //On crée les personnages et les armes
            Personnage nain = new Personnage();
            Personnage elf = new Personnage();
            Arme baton = new Arme();
            Arme marteau = new Arme();

            //On initialise ces valeurs
            nain.CreationPersonnage(20, 8, 1000, 50, "BlackJack", marteau);
            elf.CreationPersonnage(5, 30, 800, 30, "Isgandar", baton);
            baton.CreationArme(25, "Baton magique");
            marteau.CreationArme(20, "Marteau lourd");

            //On "attaque" un personnage
            nain.AttaquePersonnage(elf);
            elf.AttaqueMagique(nain);

            //Pour que la console ne se ferme pas directement
            Console.Write("\n");
            Console.Write("Press Enter to leave : ");
            Console.Read();

        }
    }
}
