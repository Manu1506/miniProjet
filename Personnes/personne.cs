using System;
using System.Collections.Generic;
using System.Text;

namespace Personnes
{
    class personne
    {
           //déclaration des attributs de la classe
        private string Nom;
        private string Prenom;
        private int Age;
        private static int nbPersonnes;

        static personne()
        {
            nbPersonnes = 0;
        }

       //Constructeur
        public personne(string Nom ,string Prenom, int Age)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Age = Age;
            nbPersonnes++;
        }

        //Methode pour afficher les informations de la personne
        public void Afficher()
        {
            Console.WriteLine("[Affichage des informations sur la personne]");
            Console.WriteLine("Nom de la personne : " + Nom);
            Console.WriteLine("Prenom de la personne : " + Prenom);
            Console.WriteLine("Age de la personne : " + Age);
           
        }

        public int Combien()
        {
            return nbPersonnes;
        }

    }
}
