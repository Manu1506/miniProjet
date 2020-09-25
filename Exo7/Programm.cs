using System;

namespace Exo7
{
    class Programm
    {
        static void Main(string[] args)
        {
            IArticleDAO dao = new ArticleDAO();

            Console.WriteLine(dao.GetInformationArticle());

          

            
        }
    }
}
