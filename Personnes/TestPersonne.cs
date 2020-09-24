using System;
using System.Runtime.CompilerServices;

namespace Personnes
{
    class Program
    {
        static void Main(string[] args)
        {
            personne personne1 = new personne("BELOBO", "Marie", 21);
            personne personne2 = new personne("BEl", "Marie", 21);

            personne personne3 = new personne("BELOBO", "Marie", 21);
            personne personne4 = new personne("BEl", "Marie", 21);


            Console.WriteLine("Nombre de personne:" + personne1.Combien());
            Console.ReadLine();

        }

      
    }
}
