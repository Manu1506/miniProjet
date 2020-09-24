using SocieteTableau;
using System;

namespace SocieteListe
{
    class SocieteListe
    {
        class gererSocieteListe
        {

            static void Main(string[] args)
            {
                var employe1 = new employe("lebon", "james", 37, 12000);
                var employe2 = new employe("west", "russel", 30, 2500);
                var employe3= new employe("harden", "james", 30, 600);
                var employe4 = new employe("kwahi", "leonard", 27, 9000);
                var employe5 = new employe("batum", "nicolas", 22, 2000);



                var chef1 = new chef("man", "marie", 20, 3000, "commercial");
                var chef2= new chef("Atalia", "bernadette", 25, 5000, "comptable");

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

                Console.WriteLine("-- Vider Liste --");// vider la liste
                Liste.Vider();

                Liste.InsererFin(employe1);
                Liste.InsererFin(employe2);
                Liste.InsererFin(employe3);
                Liste.InsererFin(employe4);
                Liste.InsererFin(employe5);
                Liste.InsererFin(chef1);
                Liste.InsererFin(chef2);
                Liste.InsererFin(directeur);

                Console.WriteLine("-- Insertion en fin de liste --");
                Liste.Lister();
                Liste.Lister();

                Console.WriteLine(" -- [Affiche avec l'indexeur] --");
                Console.WriteLine(Liste.getIndex(5).ToString());

            }
        }
    }
    
 }   
    

    
       


