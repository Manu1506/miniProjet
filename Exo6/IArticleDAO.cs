using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exo6
{
    public interface IArticleDAO
    {
       

            Tuple<double, int>GetPrixAndQuantiteTuple(string nom);
             


    }
}
