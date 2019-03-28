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
            //On crée le personnage
            Personnage test = new Personnage();

            //On initialise ces valeurs
            test.SetPersonnage(1, "BlackJack");
            //On écrit son nom dans la console
            Console.WriteLine(test.GetPersonnageName());

            //Pour que la console ne se ferme pas directement
            Console.Write("Press Enter to leave : ");
            Console.Read();

        }
    }
}
