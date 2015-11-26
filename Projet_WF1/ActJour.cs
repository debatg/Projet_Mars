using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_WF1
{
    class ActJour
    {
        private Activite _act;
        private int _heure, _min, _duree;
        public ActJour(Activite A, int heure, int min, int duree)
        {
            _act = A;
            _heure = heure;
            _min = min;
            _duree = duree;
        }

        public int Duree
        {
            get
            {
                return _duree;
            }

            set
            {
                _duree = value;
            }
        }

        public int Heure
        {
            get
            {
                return _heure;
            }

            set
            {
                _heure = value;
            }
        }

        public int Min
        {
            get
            {
                return _min;
            }

            set
            {
                _min = value;
            }
        }

        internal Activite Act
        {
            get
            {
                return _act;
            }

            set
            {
                _act = value;
            }
        }
    }
}
