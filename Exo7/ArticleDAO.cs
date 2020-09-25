using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Exo7
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

  

        // retourne l'article ayant la quantite min ,quantite max et le prix moyen

        public string GetInformationArticle()
        {
            StringBuilder res = new StringBuilder();
            res.AppendLine("Information sur l'article");
            res.AppendLine("Quantite moyenne des articles:" + ListeArticles.Average(art=>art.Quantite));
            res.AppendLine("Quantite minimale:" + ListeArticles.Min(art=>art.Quantite));
            res.AppendLine("Quantite maximale:" + ListeArticles.Max(art=>art.Quantite));
            return res.ToString();
        }


    }
}
