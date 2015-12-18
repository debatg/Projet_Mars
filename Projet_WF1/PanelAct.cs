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
        private XmlDocument xmlDocument;
        private List<string> LP = new List<string>();
        private bool _modif;
        private ActJour _ActPrec = null;
        private string _heurePrec, _minPrec;

        public PanelAct() :base()
        {
            InitializeComponent();
            _list_Astro = new List<Astronaute>();
            //ChargeActXml();
        }

        public void ChargeActXml()
        {
            xmlDocument = new XmlDocument();
            string date = "";
            xmlDocument.Load("Astro_Activites.xml");
            treeView1.Nodes.Clear();

            XmlRekursivImport(treeView1.Nodes, xmlDocument.DocumentElement.ChildNodes);
            TreeNode LT=null ;
            foreach(TreeNode T in treeView1.Nodes)
            {
                if (T.Text == "ListActivity")
                    LT=T;
            }
            treeView1.Nodes.Clear();
           
                treeView1.Nodes.Add(LT);
            
          
            foreach(XmlNode X in xmlDocument.DocumentElement.ChildNodes)
            {
                if (X.Name == "ListAstronaute")
                {
                    foreach (XmlNode Xastro in X.ChildNodes)
                    {
                        Debug.WriteLine(Xastro.Name + "//" + Xastro.FirstChild.Value);
                        _list_Astro.Add(new Astronaute(Xastro.FirstChild.Value));
                        listBox1.Items.Add(Xastro.FirstChild.Value);
                    }
                }
                if (X.Name == "DateDebut")
                {
                    date = X.FirstChild.Value;
                }
            }
            _premierJour = DateTime.ParseExact(date, "yyyy-MM-dd HH:mm:ss,fff",
                                       System.Globalization.CultureInfo.InvariantCulture);
            _dateActu = DateTime.Now;
          
            treeView1.ExpandAll();
        }

        private void XmlRekursivImport(TreeNodeCollection elem, XmlNodeList xmlNodeList)
        {
            TreeNode treeNode;

            foreach (XmlNode myXmlNode in xmlNodeList)
            {
                if (myXmlNode.ChildNodes.Count > 0)
                {
                    if (myXmlNode.Name !="Activity")
                    {
                        treeNode = new TreeNode(myXmlNode.Name);
                        if (myXmlNode.ParentNode.Name != "Exploration")
                            LP = new List<string>();
                        LP.Add(myXmlNode.Name);
                        Debug.WriteLine("Name : " + myXmlNode.Name);
                    }
                    else
                    {
                        treeNode = new TreeNode(myXmlNode.FirstChild.Value);
                        _list_Act.Add(new Activite(myXmlNode.FirstChild.Value, LP));
                        string ch = "";
                        foreach(string s in LP)
                        {
                            ch += s + "+++++";
                        }
                        Debug.WriteLine(ch);                        
                    }
                    elem.Add(treeNode);

                    XmlRekursivImport(treeNode.Nodes, myXmlNode.ChildNodes);
                }
                
                
            }
        }

        private void btn_valid_Click(object sender, EventArgs e)
        {
            Activite Act = null;
            Debug.WriteLine(listBox1.SelectedItem.ToString());
            XElement Xprec = null;
            if (_modif == true)
            {
                foreach(XElement XE in _docXml.Descendants("Activité"))
                {
                    if (XE.Element("Heure").Value == _heurePrec && XE.Element("Min").Value == _minPrec)
                        Xprec = XE;
                }
            }
            foreach(Jour J in _list_Jour)
            {
                if (int.Parse(textJour.Text) >= 1 && int.Parse(textJour.Text) <= 500)
                {
                    if(textJour.Text==J.Num.ToString())
                        _jourCourant = J;

                }
                else
                    MessErreur("Vous n'avez pas entré un jour valide");

            }
            foreach (Activite A in _list_Act)
            {

                if (A.Nom==textBoxAct.Text)
                {
                    try
                    {
                        Act = A;
                        int heure = int.Parse(textHeure.Text);
                        int min= int.Parse(textMin.Text);
                        int heureFin= int.Parse(textBoxHeureFin.Text);
                        int minFin= int.Parse(textBoxMinfFin.Text);

                        List<Astronaute> LA = new List<Astronaute>();
                        bool erreur = false;
                        if (min < 0 || minFin < 0||min>=60||minFin>=60||min%10!=0||minFin%10!=0)
                        {
                            MessErreur("Une des heures entrées est invalide.");
                            erreur = true;
                        }
                        else if((heure==24||heureFin==24)&&(min>=40||minFin>40))
                        {
                            MessErreur("Une des heures entrées est invalide.");
                            erreur = true;
                        }
                        foreach (ActJour AJ in _jourCourant.ListAct)
                        {
                            if ((AJ.Heure < heureFin && AJ.HeureFin > heureFin) || (AJ.Heure < heure && AJ.HeureFin > heure))
                            {
                                MessErreur("Il y a déjà une activité dans cette période");
                                erreur = true;
                            }
                            else if((AJ.Heure==heureFin&&AJ.Min<minFin)|| (AJ.Heure == heure && AJ.Min <= min))
                            {
                                MessErreur("Il y a déjà une activité dans cette période");
                                erreur = true;                            
                            }
                            else if ((AJ.HeureFin == heure && AJ.MinFin > min) )
                            {
                                MessErreur("Il y a déjà une activité dans cette période");
                                erreur = true;
                            }
                            else if (AJ.Heure>heure&&AJ.HeureFin<heureFin)
                            {
                                MessErreur("Il y a déjà une activité dans cette période");
                                erreur = true;
                            }
                        }
                        if (erreur==false)
                        {
                            foreach (Astronaute Astr in _list_Astro)
                            {
                                if (Astr.NomAstronaute == listBox1.SelectedItem.ToString())
                                    LA.Add(Astr);
                            }
                            Debug.WriteLine(_modif.ToString());
                            if (_modif == false)
                            {
                                _jourCourant.addAct(A, LA, int.Parse(textHeure.Text), int.Parse(textMin.Text), int.Parse(textBoxHeureFin.Text), int.Parse(textBoxMinfFin.Text),
                                int.Parse(textBoxX.Text), int.Parse(textBoxY.Text), richTextBoxDescript.Text);
                            }
                            else
                            {
                                _jourCourant.ModifAct(A, LA, int.Parse(textHeure.Text), int.Parse(textMin.Text), int.Parse(textBoxHeureFin.Text), int.Parse(textBoxMinfFin.Text),
                                int.Parse(textBoxX.Text), int.Parse(textBoxY.Text), richTextBoxDescript.Text, _ActPrec);
                            }
                            SaveXml();
                            changePanel(2);
                            return;
                        }
                    }
                    catch (Exception)
                    {
                        MessErreur("Les informations entrées ne sont pas valides");

                    }
                }
            }
            if (Act == null)
                MessErreur("Vous n'avez pas sélectionné d'activité");

        }

        public void InitText()
        {
            foreach(TextBox T in this.Controls)
            {
                T.ResetText();
            }
            _modif = false;
            textJour.ReadOnly = false;
        }

        public void InitText(int numJour, int heure, int min)
        {
            foreach (Control T in this.Controls)
            {
                if(T is TextBox)
                    T.ResetText();
            }
            textJour.Text = numJour.ToString();
            textJour.ReadOnly = false;
            textHeure.Text = heure.ToString();
            textMin.Text = min.ToString();
            richTextBoxDescript.Text = "";
            _modif = false;
        }

        public void InitText(int numJour, int heure, int min, ActJour A)
        {
            foreach (Control T in this.Controls)
            {
                if (T is TextBox|| T is RichTextBox)
                    T.ResetText();
            }
            textJour.Text = numJour.ToString();
            textJour.ReadOnly = true;
            textHeure.Text = heure.ToString();
            textMin.Text = min.ToString();
            textBoxAct.Text = A.Act.Nom;
            textBoxX.Text = A.X.ToString();
            textBoxY.Text = A.Y.ToString();
            richTextBoxDescript.Text = A.Descript;
            if(A.ListA.Count>0)
                listBox1.SelectedItem = A.ListA[0];
            _ActPrec = A;
            _modif = true;
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
