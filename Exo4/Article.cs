using System;
using System.Collections.Generic;

using System.Text;

namespace Exo4
{
    public class Article
    {
        //proprietés

        public string Nom { get; set; }
        public string Reference { get; set; }
        
        public int Quantite { get; set; }

        

        // constructeur

        public Article(string nom , string reference , int quantite)
        {
            Nom = nom;
            Reference = reference;
            Quantite = quantite;
          
        }

        public Article(string nom)
        {
            Nom = nom;
        }


        public void Afficher()
        {
            
            Console.WriteLine("Nom  : " + Nom);
            Console.WriteLine("Reference: " + Reference);
            Console.WriteLine("Quantité  : " + Quantite);
            Console.WriteLine(Environment.NewLine);
        }


    }
}
