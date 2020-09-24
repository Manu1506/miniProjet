using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteTableau
{
    class chef :employe
    {
        private string _service;
        public string Service   // service proprieté
        {

            get => _service;
            set => _service = value;
        }

        public chef(string nom, string prenom, int age, float salaire,string service) : base(nom, prenom,age,salaire)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
            Salaire = salaire;
            Service = service;
        }

        public override string ToString()
        {
            return this.Nom + " " + this.Prenom + " " + this.Age + " " + this.Salaire + " " + this.Service;
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
        }
    }
}
