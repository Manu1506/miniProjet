using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;

namespace Fiche3
{
   internal class Program
    {

        private static bool Premier(int nb)
        {
            if (nb < 0)
                return Premier(-nb);
            else if (nb < 2 )
                return false;
            else
            {
                int sqrt_int = (int)Math.Sqrt(nb);
                for (int i = 2; i <= sqrt_int; i++)
                {
                    if (nb % i == 0)
                        return false;
                }

                return true;
            }

        }
        private static void Main(string[] args)
        {
            //Premier Exo
            List<int> ListNombresPremiers;
            List<int> ListNombresEntiers= new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var requete = from nbPremier in ListNombresEntiers
                          where Premier(nbPremier)
                          select nbPremier;
            int nbValeur = requete.Count();

            if (nbValeur == 0)
            {
                Console.WriteLine("Aucun nombre premier dans la liste");
            }
            else
            {
                ListNombresPremiers = requete.ToList();
                Console.WriteLine("Liste des nombres premiers:");
                foreach (int val in ListNombresPremiers)
                {
                    Console.WriteLine(val + " ");
                }

            }
            

            Console.ReadLine();
        }
    }
}
