using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteEnumeration.ListeChainee
{
    
        public class Element
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
                Objet = objet;

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
                set => _nbElements = value;

            }

        public object getIndex(int index)// indexeur
        {
            if (index >= this.NbElements)
            {
                index = this.NbElements - 1;
            }

            Element actuel = this.Debut;

            for (int i = 0; i < index; i++)
            {
                actuel = actuel.Suivant;
            }

            return actuel.Objet;

        }


            public  Liste() // constructeur liste
            {
                Debut = null;
                NbElements = 0;

            }

            public void InsererDebut(Object objet)
            {
                Element ajouterElem = new Element(objet);

                ajouterElem.Suivant = Debut;
                Debut = ajouterElem;
                NbElements++;

            }

            public void InsererFin(Object objet)
            {
                if (Debut == null)
                {
                    Debut = new Element(objet);
                    Debut.Suivant = null;
                }
                else
                {
                    Element actuel = Debut;
                    while (actuel.Suivant != null)
                    {
                        actuel = actuel.Suivant;
                    }
                    Element ajouterElemFin = new Element(objet);
                    actuel.Suivant = ajouterElemFin;
                    NbElements++;
                }


            }

            public void Lister()
            {
                if (Debut == null)
                {
                    Console.WriteLine("La liste est vide");
                }
                else
                {
                    Element actuel = Debut;
                    while (actuel != null)
                    {
                        Console.WriteLine(actuel.Objet.ToString());
                        actuel = actuel.Suivant;
                    }
                }

            }

           

            public void Vider()
            {
                Element actuel = Debut;
                if (actuel != null)
                {
                    actuel = null;
                }
                Debut = null;
                NbElements = 0;
                Console.WriteLine("La liste est vidé  ");


            }

        }

    
}
