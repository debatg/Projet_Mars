using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Projet_WF1
{
    class Activite
    {
        private string _nom;
        private List<string> _parents;

        public Activite(string nom, List<Astronaute>LA, List<string> parents):this(nom, parents)
        {
            
        }
        public Activite(string nom, List<string> parents)
        {
            Nom = nom;
            _parents = parents;
        }

        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }

        public List<string> Parents
        {
            get
            {
                return _parents;
            }

            set
            {
                _parents = value;
            }
        }

        public override string ToString()
        {
            return Nom;
        }

        
    }
}
