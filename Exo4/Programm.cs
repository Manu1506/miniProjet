using System;

namespace Exo4
{
    class Programm
    {
        static void Main(string[] args)
        {
            IArticleDAO dao = new ArticleDAO();
            Article article= dao.GetArticles("mug");
            Article article2 = dao.GetArticles("gel");

            Console.WriteLine("Liste des articles");
            article.Afficher();
            article2.Afficher();

            
        }
    }
}
