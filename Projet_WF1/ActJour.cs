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
        private int _heure, _min, _duree, _heureFin, _minFin;
        //private int DateTime _debut, _fin;
        public ActJour(Activite A, int heure, int min, int duree)
        {
            _act = A;
            _heure = heure;
            _min = min;
            _duree = duree;
            _heureFin = _heure + (_min + _duree) / 60;
            _minFin= (_min + _duree) % 60;
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

        public int HeureFin
        {
            get
            {
                return _heureFin;
            }

            set
            {
                _heureFin = value;
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

        public int MinFin
        {
            get
            {
                return _minFin;
            }

            set
            {
                _minFin = value;
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
