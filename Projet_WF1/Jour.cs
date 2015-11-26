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
        private XElement _calendrierXml;
        private XElement _jourXml = new XElement("Jour");
        private XElement _actXml = new XElement("Activité");
        private XElement _astroXml = new XElement("Astronaute");

        public Jour(int num,  XElement calendrierXml)
        {
            Num = num;
            _listAct = new List<ActJour>();
            _tabAct = new Activite[148];
            _tree = new TreeView();
            _tree.Nodes.Clear();
            _tree.BeginUpdate();
            for (int i= 0;i<=24;i++)
            {
                _tree.Nodes.Add(new TreeNode(i.ToString()));
                for(int a=0;a<=5;a++)
                {
                    //_tree.Nodes[i].Nodes.Add(a.ToString() + "0");
                    _tree.Nodes[i].Nodes.Add(new TreeNode(a.ToString() + "0"));

                }
            }
            _tree.EndUpdate();

            _calendrierXml = calendrierXml;
            _jourXml.SetAttributeValue("num", num);
            //_calendrierXml.Add(new XElement("Jour", new XAttribute("num", num.ToString())));
            _calendrierXml.Add(_jourXml);
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
