using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;


namespace Exo3
{
    class Exo3
    {
        private static void Main(string[] args)
        {
            //Premier Exo

            List<int> ListNombresEntiers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 155, 13, 20, 45 };

            List<int> ListNombresDivisibles = ListNombresEntiers.
                      Where(valeur => valeur % 5 == 0)
                      .ToList();

            Console.WriteLine("Liste des nombres divisbles par 5:");
            foreach (int val in ListNombresDivisibles)
            {
                Console.WriteLine(val + " ");
            }




            Console.ReadLine();
        }
    }
}
