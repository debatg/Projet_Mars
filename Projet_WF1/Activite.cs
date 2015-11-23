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

        public Activite(string nom, List<Astronaute>LA, Point pos, bool exte):this(nom)
        {
            
        }
        public Activite(string nom)
        {
            Nom = nom;
        }

        public override string ToString()
        {
            return Nom;
        }

        
    }
}
