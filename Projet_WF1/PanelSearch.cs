using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_WF1
{
    partial class PanelSearch : PanelCentral
    {
        private string _nom;
        private int _jour1, _jour2;
        public PanelSearch()
        {
            InitializeComponent();
        }

        public void SearchAct(string nomAct, int jour1, int jour2, int val)
        {
            treeView1.Nodes.Clear();
            _nom = nomAct;
            _jour1 = jour1;
            _jour2 = jour2;
            
            AffichInfo(nomAct, jour1, jour2, val);
           changePanel(4);
        }

        private void AffichInfo(string nomAct, int jour1, int jour2, int val)
        {
            int i = 0;

            foreach (Jour J in _list_Jour)
            {
                if (J.Num >= jour1 && J.Num <= jour2)
                {
                    foreach (ActJour A in J.ListAct)
                    {

                        if (val==1&&(A.Act.Nom == nomAct || A.Act.Parents.Contains(nomAct)))
                        {
                            i++;
                            List<TreeNode> listTree = new List<TreeNode>();
                            listTree.Add(new TreeNode("Début : " + A.Heure.ToString() + "H" + A.Min.ToString()));
                            listTree.Add(new TreeNode("Fin : " + A.HeureFin.ToString() + "H" + A.MinFin.ToString()));
                            TreeNode T = new TreeNode(J.Num.ToString(), listTree.ToArray());
                            treeView1.Nodes.Add(T);
                        }
                        else if (val==2&&(A.Descript.Contains(nomAct)))
                        {
                            i++;
                            List<TreeNode> listTree = new List<TreeNode>();
                            listTree.Add(new TreeNode("Début : " + A.Heure.ToString() + "H" + A.Min.ToString()));
                            listTree.Add(new TreeNode("Fin : " + A.HeureFin.ToString() + "H" + A.MinFin.ToString()));
                            TreeNode T = new TreeNode(J.Num.ToString(), listTree.ToArray());
                            treeView1.Nodes.Add(T);
                        }
                    }
                    if (val == 3 && J.CR.Contains(nomAct))
                    {
                        i++;
                        List<TreeNode> listTree = new List<TreeNode>();
                        listTree.Add(new TreeNode("Jour : " + J.Num.ToString()));
                        listTree.Add(new TreeNode("Compte-rendu : " + J.CR.ToString() ));
                        TreeNode T = new TreeNode(J.Num.ToString(), listTree.ToArray());
                        treeView1.Nodes.Add(T);

                    }
                }
            }
            if (treeView1.Nodes.Count == 0)
                treeView1.Nodes.Add(new TreeNode("Aucun résultat trouvé pour la recherche effectuée."));
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            var CB = sender as CheckBox;

                foreach (Control C in Controls)
                {
                    if (C is CheckBox)
                    {
                        var check = C as CheckBox;
                        //Debug.WriteLine(check.Checked);
                        if (check.Checked == true)
                            check.Checked = false;

                    }
                }
                if (CB.Name == checkBoxAct.Name)
                {
                    checkBoxAct.Checked = true;
                    SearchAct(_nom, _jour1, _jour2, 1);
                }
                else if (CB.Name == checkBoxDescr.Name)
                {
                    checkBoxDescr.Checked = true;
                SearchAct(_nom, _jour1, _jour2, 2);
                }
            else
                {
                    checkBoxCR.Checked = true;
                SearchAct(_nom, _jour1, _jour2, 3);
                }

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
