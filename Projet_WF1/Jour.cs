using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projet_WF1
{
    class Jour
    {
        private List<ActJour> _listAct;
        private int _num;
        private Activite[] _tabAct;
        private TreeView _tree;
        private static XDocument _calendrierXml=null;
        private XElement _jourXml;
        private XElement _actXml ;
        private XElement _astroXml = new XElement("Astronaute");

        public Jour(int num, XDocument calendrierXml, List<ActJour> LA)
        {
            Num = num;
            _listAct = LA;
            if (_calendrierXml == null)
                _calendrierXml = calendrierXml;
            var jour = from a in calendrierXml.Descendants("Jour")
                       select a;
            foreach (XElement e in jour)
            {
                if (e.FirstAttribute.Value == num.ToString())
                    _jourXml = e;
            }
        }

        public Jour(int num, XDocument calendrierXml):this(num, calendrierXml, new List<ActJour>())
        {
            _jourXml = new XElement("Jour", new XAttribute("num", num.ToString()));
            _calendrierXml.Element("Calendrier").Add(_jourXml);
        }

        public int Num
        {
            get
            {
                return _num;
            }

            set
            {
                _num = value;
            }
        }

        public TreeView Tree
        {
            get
            {
                return _tree;
            }

            set
            {
                _tree = value;
            }
        }

        public Activite[] TabAct
        {
            get
            {
                return _tabAct;
            }

            set
            {
                _tabAct = value;
            }
        }

        public List<ActJour> ListAct
        {
            get
            {
                return _listAct;
            }

            set
            {
                _listAct = value;
            }
        }

        public void addAct(Activite A, int heure, int min, int duree)
        {
            _listAct.Add(new ActJour(A, heure, min, duree));
            _actXml = new XElement("Activité", new XElement("Nom", A.Nom), new XElement("Heure", heure), new XElement("Min", min), new XElement("Duree", duree));
            _jourXml.Add(_actXml);            
        }

        

        public override string ToString()
        {
            string ch = Num.ToString();
            /*foreach(Activite A in _listAct)
            {
                ch += "\n"+A.Nom;
            }*/
            return ch;
        }
    }
}
