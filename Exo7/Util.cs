using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Exo7
{
    static class Util
    {
        public static List<Article> GetArticles()
        {
            List<Article> liste = new List<Article>()
            {
                new Article("baguette", 0.50, 1),
                new Article("mug", 2, 3),
                new Article("gel", 1.23, 40),
                new Article("pouf", 150, 5),
                new Article("masques", 12, 20),
                
                
            };
            return liste;

        }
       
         
        
    }
}

        
        
    

