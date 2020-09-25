using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Exo4
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

        //retourne les informations sur l'article à partir de son nom
        public Article GetArticles(string nom)
        {
            return ListeArticles.Where(art => art.Nom.Equals(nom)).FirstOrDefault();
            
        }

     
       
    }
}
