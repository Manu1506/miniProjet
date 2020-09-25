using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Exo4
{
    static class Util
    {
        public static List<Article> GetArticles()
        {
            List<Article> liste = new List<Article>()
            {
                new Article("baguette", "bbb000", 1),
                new Article("mug", "oooaaa", 3),
                new Article("gel", "ggg00", 40),
                new Article("pouf", "pfff", 5),
                new Article("masques", "mmmqqq", 20),
                
                
            };
            return liste;

        }
       
         
        
    }
}

        
        
    

