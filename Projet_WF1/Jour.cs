using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private bool _ext;
        private string _CR;

        public Jour(int num, XDocument calendrierXml, List<ActJour> LA, string CR)
        {
            Num = num;
            _ext = false;
            _listAct = LA;
            _CR = CR;
            if (_calendrierXml == null)
                _calendrierXml = calendrierXml;
            var jour = from a in calendrierXml.Descendants("Jour")
                       select a;
            foreach (XElement e in jour)
            {
                if (e.FirstAttribute.Value == num.ToString())
                    _jourXml = e;
            }
            foreach(ActJour J in _listAct)
            {
                if (J.Ext == true)
                    _ext = true;
            }
        }

        public Jour(int num, XDocument calendrierXml):this(num, calendrierXml, new List<ActJour>(), "")
        {
            _jourXml = new XElement("Jour", new XAttribute("num", num.ToString()), new XElement("Compte_rendu"));
            _calendrierXml.Element("Calendrier").Add(_jourXml);
            _ext = false;
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

        public string CR
        {
            get
            {
                return _CR;
            }

            set
            {
                _CR = value;
            }
        }

        public void addAct(Activite A, List<Astronaute> LA,int heure, int min, int heureFin, int minFin, int x, int y, string descript)
        {
            _listAct.Add(new ActJour(A, LA, heure, min, heureFin, minFin, x, y, descript));
            _actXml = new XElement("Activité", new XElement("Nom", A.Nom), new XElement("Heure", heure),
                new XElement("Min", min), new XElement("HeureFin", heureFin), new XElement("MinFin", minFin), new XElement("PosX", x),new XElement("PosY", y), new XElement("Descript", descript), new XElement("ListAstronautes"));
            foreach(Astronaute Astro in LA)
            {
                _actXml.Element("ListAstronautes").Add(new XElement("Astronaute", Astro.NomAstronaute));
            }
            _jourXml.Add(_actXml);

            if (x != 0 || y != 0)
                _ext = true;   
        }

        public void ModifAct(Activite A, List<Astronaute> LA, int heure, int min, int heureFin, int minFin, int x, int y, string descript, ActJour AJ)
        {
            XElement Xprec = null;
            foreach (XElement XE in _jourXml.Descendants("Activité"))
            {
                if (XE.Element("Heure").Value == AJ.Heure.ToString() && XE.Element("Min").Value == AJ.Min.ToString())
                    Xprec = XE;
            }
            Xprec.Remove();
            _listAct.Remove(AJ);
            addAct(A, LA, heure, min, heureFin, minFin, x, y, descript);


        }



        public override string ToString()
        {
            string ch = Num.ToString();
            return ch;
        }
    }
}
