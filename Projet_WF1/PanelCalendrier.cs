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
using System.Xml.Linq;

namespace Projet_WF1
{
    partial class PanelCalendrier : PanelCentral
    {
        private int cent = 0, dix = 0, calend = 1;
        private List<Button> bttn_jour;
        Label la = new Label();

        //private Jour jourCourant = null;
        public event EventHandler _eventEdt=null;


        public PanelCalendrier(Panel panelcentre):base()
        {
            InitializeComponent();
            _panelCentre = panelcentre;
            /*Size S = panelcentre.Size;
            Point P = panelcentre.Location;
            _panelCentre.Location = P;
            _panelCentre.Size = S;*/

            bttn_jour = new List<Button>();
            _list_Jour = new List<Jour>();

            _list_Act = new List<Activite>();
            _list_Act.Add(new Activite("test"));
            _list_Act.Add(new Activite("test2"));


            InitXml();

            foreach (Button B in panel_calendrier.Controls)
            {
                bttn_jour.Add(B);
            }
            
           int i = 0;
            foreach (Button B in bttn_jour)
            {

                foreach (Jour J in _list_Jour)
                {
                    if (J.Num.ToString() == (calend + i).ToString())
                        B.Text = J.Num.ToString();
                }

                i++;
            }
            Debug.WriteLine("a");
            SaveXml();
        }

        private void bt_cent_Click(object sender, EventArgs e)
        {
            var bttn = sender as Button;
            cent = int.Parse(bttn.Name.Split('_')[1]) - 1;
            // if(bttn.Name.Split('_')(5))
        }

        private void bt_dix_Click(object sender, EventArgs e)
        {
            var bttn = sender as Button;
            dix = int.Parse(bttn.Name.Split('_')[1]);
            calend = cent + dix;
            int i = 0;
            foreach (Button B in bttn_jour)
            {

                foreach (Jour J in _list_Jour)
                {
                    if (J.Num.ToString() == (calend + i).ToString())
                        B.Text = J.Num.ToString();
                }

                i++;
            }

        }

        private void bttn_Jour_Click(object sender, EventArgs e)
        {
            var bttn = sender as Button;
            foreach (Jour J in _list_Jour)
            {
                if (J.Num == int.Parse(bttn.Text))
                {
                    
                    _jourCourant = J;
                }
            }
            changePanel(2);

            //this._eventEdt(this, new EventArgs());

        }
        
        private void InitXml()
        {
            string[] tabFiles;
            string chemin;
            bool present = false;
            chemin = Directory.GetCurrentDirectory();
            tabFiles = Directory.GetFiles(chemin, "*.xml");
            
            la.Location = new Point(100, 100);
            la.Text = "";
            la.Visible = true;
            this.Controls.Add(la);
            foreach (string X in tabFiles)
            {
                if (Path.GetFileName(X) == "calendrier.xml")
                    present = true;
            }
            if (present)
            {
                _docXml = XDocument.Load("calendrier.xml");
                la.Text += "ok";
                ChargeXml();
            }
            else
            {
                _docXml = new XDocument(_calendrierXml);
                int i = 1;

                while (i <= 500)
                {
                    _list_Jour.Add(new Jour(i, _docXml));
                    i++;
                }
            }
        }

        private void ChargeXml()
        {
            var branches = from a in _docXml.Descendants("Jour")
                          select a;
            int aaa = 0;

            foreach (XElement e in branches)
            {
                aaa++;
                List<ActJour> listAJ = new List<ActJour>();
                int num = int.Parse(e.FirstAttribute.Value);
                //la.Text =e.FirstAttribute.Value;
                var act = from a in e.Descendants("Activité")
                          select a;
                foreach (XElement e2 in act)
                {
                    string name = e2.Element("Nom").Value;
                    int heure = int.Parse(e2.Element("Heure").Value);
                    int min = int.Parse(e2.Element("Min").Value);
                    int duree= int.Parse(e2.Element("Duree").Value);
                    Activite Act=null;

                    foreach (Activite A in _list_Act)
                    {
                        if (A.Nom == name)
                            Act = A;
                    }
                    listAJ.Add(new ActJour(Act, heure, min, duree));

                }
                _list_Jour.Add(new Jour(num, _docXml, listAJ));
                Debug.WriteLine("ooookkkk" + num);

            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
