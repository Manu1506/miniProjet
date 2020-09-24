using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteTableau
{
    class directeur : chef
    {
        private string _societe;
        public string Societe   // service proprieté
        {

            get => _societe;
            set => _societe = value;
        }

        public directeur(string nom, string prenom, int age, float salaire, string service , string societe) : base(nom, prenom, age, salaire,societe)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
            Salaire = salaire;
            Service = service;
            Societe = societe;
        }

        public override string ToString()
        {
            return this.Nom + " " + this.Prenom + " " + this.Age + " " + this.Salaire + " " + this.Service + this.Societe;
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
            Console.WriteLine("Service :" + Service);
            Console.WriteLine("Societe :" + Societe);
        }
    }
}
