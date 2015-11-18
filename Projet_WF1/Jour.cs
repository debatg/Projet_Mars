using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_WF1
{
    class Jour
    {
        private List<Activite> _listAct;
        private int _num;
        private Activite[] _tabAct;
        private TreeView _tree;

        public Jour(int num, TreeView tree)
        {
            Num = num;
            _listAct = new List<Activite>();
            _tabAct = new Activite[148];
            _tree = tree;
            _tree.Nodes.Clear();
            _tree.BeginUpdate();
            for (int i= 0;i<=24;i++)
            {
                _tree.Nodes.Add(i.ToString());
                for(int a=0;a<=5;a++)
                {
                    _tree.Nodes[i].Nodes.Add(a.ToString() + "0");
                }
            }
            _tree.EndUpdate();

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

        public void addAct(Activite A, int heure, int min)
        {
            _listAct.Add(A);
            _tree.BeginUpdate();
            foreach(TreeNode T in _tree.Nodes[heure].Nodes)
            {
                if (T.Text == min.ToString())
                {
                    T.Text += "   "+A.ToString();
                }
                    
            }
            _tree.EndUpdate();
        }

        public override string ToString()
        {
            string ch = Num.ToString();
            foreach(Activite A in _listAct)
            {
                ch += "\n"+A.Nom;
            }
            return ch;
        }
    }
}
