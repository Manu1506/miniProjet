using System;
using System.Collections.Generic;

using System.Text;

namespace Exo7
{
    public class Article
    {
        //proprietés

        public string Nom { get; set; }
        public double Prix { get; set; }
        
        public int Quantite { get; set; }

        

        // constructeur

        public Article(string nom , double prix , int quantite)
        {
            Nom = nom;
            Prix = prix;
            Quantite = quantite;
          
        }

        public Article(string nom)
        {
            Nom = nom;
        }


        public void Afficher()
        {
            
            
            Console.WriteLine("Prix : " + Prix);
            Console.WriteLine("Quantité  : " + Quantite);
            Console.WriteLine(Environment.NewLine);
        }


    }
}
