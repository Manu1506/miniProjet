using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Exo6
{
    internal class ArticleDAO : IArticleDAO
    {
        public List<Article> ListeArticles { get; }

        public ArticleDAO()
        {
            ListeArticles = Util.GetArticles();
        }

        public ArticleDAO(List<Article> listeArticles)
       {
            ListeArticles = listeArticles;
        }

       

        // retourne un tuple quantite et le prix d'un article à partir de son nom

        public Tuple<double, int> GetPrixAndQuantiteTuple(string nom)
        {
           Tuple <double,int> res = ListeArticles
                       .Where(art => art.Nom.Equals(nom))
                       .Select(art => new Tuple<double,int> (art.Prix, art.Quantite ))
                       .FirstOrDefault();
            return (res);
        }


    }
}
