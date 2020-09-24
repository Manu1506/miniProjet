using System;
using SocieteEnumeration.ListeChainee;
using SocieteTableau;

namespace SocieteEnumeration
{
    class GererSocieteEnumeration
    {
        static void Main(string[] args)
        {
            var employe1 = new employe("lebon", "james", 37, 12000);
            var employe2 = new employe("west", "russel", 30, 2500);
            var employe3 = new employe("harden", "james", 30, 600);
            var employe4 = new employe("kwahi", "leonard", 27, 9000);
            var employe5 = new employe("batum", "nicolas", 22, 2000);



            var chef1 = new chef("man", "marie", 20, 3000, "commercial");
            var chef2 = new chef("Atalia", "bernadette", 25, 5000, "comptable");

            var directeur = new directeur("george", "paul", 30, 15000, "budget", "orange");

            //Declaration de la liste
            var Liste = new Liste();
            Liste.InsererDebut(employe1);
            Liste.InsererDebut(employe2);
            Liste.InsererDebut(employe3);
            Liste.InsererDebut(employe4);
            Liste.InsererDebut(employe5);
            Liste.InsererDebut(chef1);
            Liste.InsererDebut(chef2);
            Liste.InsererDebut(directeur);


            Console.WriteLine(" -- [Affichage de la liste] --");// affichage de la liste
            Liste.Lister();

            var ListeEnumeration = new ListeEnumeration(Liste);

          

            while (ListeEnumeration.MoveNext())
            {
                Console.WriteLine(ListeEnumeration.Current().ToString());
                Console.WriteLine(Environment.NewLine);

            }


        }
    }
}
