using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteListe
{
    class ListeChaine
    {
        class Element
        {
            private Object _objet;
            public Object Objet  // objet proprieté
            {

                get => _objet;
                set => _objet = value;
            }

            private Element _suivant;
            public Element Suivant  // suivant proprieté
            {

                get => _suivant;
                set => _suivant = value;
            }

            public Element(Object objet) // constructeur element
            {

            }

        }

        public class Liste 
        {
            private Element _debut;
            public Element Debut
            {
                get => _debut;
                set => _debut = value;
            }


            private int _nbElements;
            public int NbElements  // nbElements proprieté
            {

                get => _nbElements;
             
            }

            public Liste() // constructeur liste
            {
                Debut = null;
                _nbElements = 0;

            }

        }

    }
}
