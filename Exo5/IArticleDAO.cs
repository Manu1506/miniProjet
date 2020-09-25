using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exo5
{
    public interface IArticleDAO
    {
       

        (double , int )GetPrixAndQuantite(string nom);


    }
}
