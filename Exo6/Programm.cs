using System;

namespace Exo6
{
    class Programm
    {
        static void Main(string[] args)
        {
            IArticleDAO dao = new ArticleDAO();
            

            Tuple<double, int>res =dao.GetPrixAndQuantiteTuple("mug");

            Console.WriteLine("Nom de l'article:Mug");
            Console.WriteLine($"Quantite:{res.Item1} Prix:{res.Item2}");

            
        }
    }
}
