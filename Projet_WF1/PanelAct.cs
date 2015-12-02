using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Projet_WF1
{
    partial class PanelAct : PanelCentral
    {
        //private Jour _jourCourant;
        //private XDocument _docXml;
        
        private Panel _panelPrec;
        XmlDocument xmlDocument;




        public PanelAct() :base()
        {
            InitializeComponent();
            listBox1.Items.Add("test");
            listBox1.Items.Add("test2");
            ChargeActXml();
        }

        private void ChargeActXml()
        {


            xmlDocument = new XmlDocument();

            xmlDocument.Load("Astro_Activites.xml");
            treeView1.Nodes.Clear();

            XmlRekursivImport(treeView1.Nodes, xmlDocument.DocumentElement.ChildNodes);
            foreach(TreeNode T in treeView1.Nodes)
            {
                if (T.Text != "ListActivity")
                    T.Remove();
            }
            treeView1.ExpandAll();
        }

        private void XmlRekursivImport(TreeNodeCollection elem, XmlNodeList xmlNodeList)
        {
            TreeNode treeNode;
            
            foreach (XmlNode myXmlNode in xmlNodeList)
            {
                Debug.WriteLine(xmlNodeList.Count);

                if (myXmlNode.ChildNodes.Count > 0)
                {
                    if (myXmlNode.Name != "Activity")
                    {
                        treeNode = new TreeNode(myXmlNode.Name);
                    }
                    else
                    {
                        treeNode = new TreeNode(myXmlNode.FirstChild.Value);
                        _list_Act.Add(new Activite(myXmlNode.FirstChild.Value));

                    }
                    elem.Add(treeNode);

                    XmlRekursivImport(treeNode.Nodes, myXmlNode.ChildNodes);
                }
                
                
            }
        }

        private void btn_valid_Click(object sender, EventArgs e)
        {
            foreach(Activite A in _list_Act)
            {
                if (A.Nom==textBoxAct.Text)
                {

                    _jourCourant.addAct(A, int.Parse(textHeure.Text), int.Parse(textMin.Text), int.Parse(textDuree.Text));

                    SaveXml();
                    changePanel(2);
                }
            }

        }

        public void InitText(int numJour, int heure, int min)
        {
            //var edt = panel1 as PanelEdt;
            textJour.Text = numJour.ToString();

            textHeure.Text = heure.ToString();
            textMin.Text = min.ToString();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var mouseEventArgs = e as MouseEventArgs;
            Point P = new Point(mouseEventArgs.X - pictureCroix.Size.Width / 2, mouseEventArgs.Y - pictureCroix.Size.Width / 2);
            pictureCroix.Location = P;
            pictureCroix.Visible = true;
            textBoxX.Text = (mouseEventArgs.X - 700 / 5).ToString();
            textBoxY.Text = ((1000 / 5)-mouseEventArgs.Y ).ToString();

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Nodes.Count==0)
            {
                textBoxAct.Text = e.Node.Text;
            }
        }

        private void textBoxCoord_TextChanged(object sender, EventArgs e)
        {
            if (textBoxX.Text != "" && textBoxY.Text != "")
            {
                Point P = new Point(int.Parse(textBoxX.Text) + (700 / 5) - pictureCroix.Size.Width / 2, -int.Parse(textBoxY.Text) + (1000 / 5) - pictureCroix.Size.Width / 2);
            pictureCroix.Location = P;
            pictureCroix.Visible = true; }
        }

        public Jour JourCourant
        {
            get
            {
                return _jourCourant;
            }

            set
            {
                _jourCourant = value;
            }
        }

        public Panel PanelPrec
        {
            get
            {
                return _panelPrec;
            }

            set
            {
                _panelPrec = value;
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
