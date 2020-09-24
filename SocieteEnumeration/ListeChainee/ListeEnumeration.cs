using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SocieteEnumeration.ListeChainee
{
    class ListeEnumeration : IEnumerator<Liste>
    {
        private Liste _liste;
        public Liste Liste  // liste proprieté
        {

            get => _liste;
            set => _liste = value;
        }

        private int _indiceCourant;
        public int IndiceCourant // liste proprieté
        {

            get => _indiceCourant;
            set => _indiceCourant = value;
        }

        object IEnumerator.Current => throw new NotImplementedException();

        Liste IEnumerator<Liste>.Current => throw new NotImplementedException();

        public ListeEnumeration(Liste liste) // constructeur listeenumeration
        {
            Liste = liste;
        }

        public object Current()
        {
            return IndiceCourant;
          
        }


        public bool MoveNext()
        {
            _indiceCourant++;
            if (_indiceCourant > Liste.NbElements )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Reset()
        {
            IndiceCourant = 0;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
