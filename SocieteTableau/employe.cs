using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteTableau
{
    class employe : personne
    {
        private float _salaire;
        public float Salaire   // salaire proprieté
        {
           // get { return _salaire; }
           // set { _salaire = value; }

            get => _salaire;
            set => _salaire = value;
        }

        public employe(string nom, string prenom, int age, float salaire):base(nom,prenom)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
            Salaire = salaire;
        }

        public override string ToString()
        {
            return this.Nom + " " + this.Prenom + " " + this.Age + " " + this.Salaire;
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
            Console.WriteLine("Salaire :" + Salaire);
        }

        


    }
}
