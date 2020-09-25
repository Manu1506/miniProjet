using System;

namespace Exo5
{
    class Programm
    {
        static void Main(string[] args)
        {
            IArticleDAO dao = new ArticleDAO();
            

            (double prix, int quantite)=dao.GetPrixAndQuantite("mug");

            Console.WriteLine("Nom de l'article:Mug");
            Console.WriteLine($"Quantite:{quantite} Prix:{prix}");

            
        }
    }
}
