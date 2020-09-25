using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Exo5
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

        public Article GetArticles(string nom)
        {
            return ListeArticles.Where(art => art.Nom.Equals(nom)).FirstOrDefault();
            
        }

        // retourne la quantite et le prix d'un article à partir de son nom

        public (double, int) GetPrixAndQuantite(string nom)
        {
            var res = ListeArticles
                       .Where(art => art.Nom.Equals(nom))
                       .Select(art => new { art.Prix, art.Quantite })
                       .FirstOrDefault();
            return (res.Prix, res.Quantite);
        }


    }
}
