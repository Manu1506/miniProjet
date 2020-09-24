using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace SocieteTableau
{
    class personne
    {
        private int c;
        private string _nom;
        public string Nom    // proprieté du nom
        {
            get => _nom;
            set => _nom = value;

        }
        private string _prenom;
        public string Prenom    // proprieté du prenom
        {
            get => _prenom;
            set => _prenom = value;

        }
        private int _age;
        public int Age   // age proprieté
        {
            get => _age;
            set => _age = value;
        }



        public personne(string Nom, string Prenom)
        {

            _nom = Nom;
            _prenom = Prenom;


        }

        public personne(string Nom, string Prenom, int Age)
        {

            _nom = Nom;
            _prenom = Prenom;
            _age = Age;

        }

        public override string ToString()
        {
            return this.Nom + " " + this.Prenom + " " + this.Age;
        }

        public void Afficher()
        {
            Console.WriteLine("Nom :" + Nom);
            Console.WriteLine("Prenom :" + Prenom);
            if (Age != 0)
            {
                Console.WriteLine("Age : " + Age);
            }
            else
            {
                Console.WriteLine("Erreur, l'age n'existe pas");
            }
        }

        public static int operator ++(int c)
        {
            return c = c + 1;
        }
    }
}
