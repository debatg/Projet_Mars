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
        private List<Astronaute> _listA;
        private int _heure, _min, _duree, _heureFin, _minFin;
        private int _x, _y;
        private bool _ext;
        private string _descript;
         
        /*public ActJour(Activite A, List<Astronaute> LA , int heure, int min, int duree, int x , int y)
        {
            _act = A;
            _heure = heure;
            _min = min;
            _duree = duree;
            _listA = LA;
            _heureFin = _heure + (_min + _duree) / 60;
            _minFin= (_min + _duree) % 60;
            _x = x;
            _y=y;
            if (_x != 0 || _y != 0)
                _ext = true;
            else
                _ext = false;
        }*/

        public ActJour(Activite A, List<Astronaute> LA, int heure, int min, int heure_fin, int min_fin , int x, int y, string descript)
        {
            _act = A;
            _heure = heure;
            _min = min;
            _duree = ((heure_fin - heure) * 60) + (min_fin - min);
            _listA = LA;
            _heureFin = heure_fin;
            _minFin = min_fin;
            _x = x;
            _y = y;
            _descript = descript;
            if (_x != 0 || _y != 0)
                _ext = true;
            else
                _ext = false;
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

        public Activite Act
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

        public bool Ext
        {
            get
            {
                return _ext;
            }

            set
            {
                _ext = value;
            }
        }

        public int X
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }

        public List<Astronaute> ListA
        {
            get
            {
                return _listA;
            }

            set
            {
                _listA = value;
            }
        }

        public string Descript
        {
            get
            {
                return _descript;
            }

            set
            {
                _descript = value;
            }
        }
    }
}
