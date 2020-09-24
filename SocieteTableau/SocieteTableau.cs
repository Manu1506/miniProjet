using System;

namespace SocieteTableau
{
    class SocieteTableau
    {
       
        static void Main(string[] args)
        {
            // incrémentation de l'age de l'employé
            //employe employe1 = new employe("aude", "abel", 30, 2000);
            //Console.WriteLine("Age incrementé:" + employe1.operator++());
            

            //declaration du tableau avec creation des instances
            personne[] tabPersonne= new personne[8];

          

            tabPersonne[0] = new employe("lebon", "james", 37, 12000);
            tabPersonne[1] = new employe("west", "russel", 30, 2500);
            tabPersonne[2] = new employe("harden", "james", 30, 600);
            tabPersonne[3] = new employe("kwahi", "leonard", 27, 9000);
            tabPersonne[4] = new employe("batum", "nicolas", 22, 2000);

            

            tabPersonne[5] = new chef("man", "marie", 20, 3000, "commercial");
            tabPersonne[6]= new chef("Atalia", "bernadette", 25, 5000, "comptable");

            tabPersonne[7] = new directeur("george", "paul", 30, 15000, "budget", "orange");

            //Affichage d'un tableau avec la boucle for
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(tabPersonne[i]);
            }

            //affichage du tableau avec la boucle foreach
            Console.BackgroundColor = ConsoleColor.Red;
                foreach(employe e in tabPersonne)
            {
                Console.WriteLine(e);
            }

        }
    }
}
