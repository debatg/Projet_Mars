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
        Label la = new Label();

        //private Jour jourCourant = null;
        public event EventHandler _eventEdt=null;


        public PanelCalendrier(TextBox T):base()
        {
            InitializeComponent();
            
            TB = T;
            FE = new FormErreur();

            
            _list_Jour = new List<Jour>();
            
            _list_Act = new List<Activite>();
            
            

        }

        private void InitBtnColor(int val, Button B)
        {
            if (val==1)
            {
                B.BackColor = Color.SkyBlue;
                B.FlatAppearance.BorderColor = Color.CadetBlue;
            }
            else if (val==2)
            {
                B.BackColor = Color.LightSlateGray;
                B.FlatAppearance.BorderColor = Color.LightGray;
            }
            else
            {
                B.BackColor = Color.LimeGreen;
                B.FlatAppearance.BorderColor = Color.LawnGreen;
            }
        }

        private void InitBtnCent()
        {
            foreach (Button B in btn_cent)
            {
                int min = int.Parse(B.Name.Split('_')[1]);
                int max = min + 99;
                B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                if (_jourActu.Num >= min && _jourActu.Num <= max)
                {
                    InitBtnColor(1,B);
                }
                else if (_jourActu.Num >= max)
                {
                    InitBtnColor(2, B);

                }
                else
                {
                    InitBtnColor(3, B);

                }
            }
        }

        public void InitBtn()
        {
            int i = 0;
            foreach (Button B in bttn_jour)
            {

                foreach (Jour J in _list_Jour)
                {
                    if (J.Num.ToString() == (calend + i).ToString())
                    {
                        B.Text = J.Num.ToString();
                        B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        if (J.Num < _jourActu.Num)
                        {
                            InitBtnColor(2, B);


                        }
                        else if (J.Num > _jourActu.Num)
                        {
                            InitBtnColor(3, B);


                        }
                        else
                        {
                            InitBtnColor(1, B);


                        }
                        if (J.Ext == true)
                        {
                            B.BackgroundImage = Image.FromFile("images/universe3.png");
                            B.BackgroundImageLayout = ImageLayout.Zoom;
                        }
                        else
                        {
                            B.BackgroundImage = null;
                        }
                    }
                }

                i++;
            }
        }

        private void InitBtnDix()
        {
            int min = cent + 1;
            int max = min + 99;
            foreach (Button B in btn_dix)
            {
                if (_jourActu.Num >= min && _jourActu.Num <= max)
                {
                    int mindix = int.Parse(B.Name.Split('_')[1]) + cent;
                    int maxdix = mindix + 9;
                    Debug.WriteLine(mindix + "//" + maxdix);
                    if (_jourActu.Num >= mindix && _jourActu.Num <= maxdix)
                    {
                        InitBtnColor(1, B);

                    }
                    else if (_jourActu.Num >= maxdix)
                    {
                        InitBtnColor(2, B);

                    }
                    else
                    {
                        InitBtnColor(3, B);

                    }
                }
                else if (_jourActu.Num >= max)
                {
                    InitBtnColor(2, B);

                }
                else
                {
                    InitBtnColor(3, B);

                }
            }
        }

        private void bt_cent_Click(object sender, EventArgs e)
        {
            var bttn = sender as Button;
            cent = int.Parse(bttn.Name.Split('_')[1]) - 1;
            InitBtnDix();
        }

        private void bt_dix_Click(object sender, EventArgs e)
        {
            var bttn = sender as Button;
            dix = int.Parse(bttn.Name.Split('_')[1]);
            calend = cent + dix;
            InitBtn();    

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
            TB.Text = _jourCourant.Num.ToString();
            changePanel(2);
        }
        
        public void InitXml()
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
                ChargeEdtXml();
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
            _docActXml = XDocument.Load("Astro_Activites.xml");

            foreach (Button B in panel_calendrier.Controls)
            {
                bttn_jour.Add(B);
            }
            Debug.WriteLine("eeeee//" + (int)(_dateActu - _premierJour).Minutes / 1480);

            foreach (Jour J in _list_Jour)
            {
                if (J.Num == (int)(_dateActu - _premierJour).TotalMinutes / 1480)
                    _jourActu = J;
            }

            InitBtn();
            InitBtnCent();
            InitBtnDix();
            SaveXml();
        }        

        private void ChargeEdtXml()
        {
            var branches = from a in _docXml.Descendants("Jour")
                          select a;
            List<Astronaute> listAstro = new List<Astronaute>();
            foreach (XElement e in branches)
            {
                List<ActJour> listAJ = new List<ActJour>();
                int num = int.Parse(e.FirstAttribute.Value);
                string CR = e.Element("Compte_rendu").Value;
                //la.Text =e.FirstAttribute.Value;
                var act = from a in e.Descendants("Activité")
                          select a;
                foreach (XElement e2 in act)
                {
                    listAstro.Clear();
                    string name = e2.Element("Nom").Value;
                    int heure = int.Parse(e2.Element("Heure").Value);
                    int min = int.Parse(e2.Element("Min").Value);
                    int heureFin= int.Parse(e2.Element("HeureFin").Value);
                    int minFin = int.Parse(e2.Element("MinFin").Value);
                    int x = int.Parse(e2.Element("PosX").Value);
                    int y = int.Parse(e2.Element("PosY").Value);
                    string descript = e2.Element("Descript").Value;

                    Activite Act =null;

                    foreach (Activite A in _list_Act)
                    {
                        if (A.Nom == name)
                            Act = A;
                    }

                    var XlistAstr = from a in e2.Descendants("ListAstronaute")
                                   select a;
                    foreach (XElement astr in XlistAstr)
                    {
                        foreach(Astronaute A in _list_Astro)
                        {
                            if (A.NomAstronaute == astr.Element("Astronaute").Value)
                                listAstro.Add(A);
                        }
                    }
                    listAJ.Add(new ActJour(Act, listAstro, heure, min, heureFin, minFin,x ,y, descript));

                }
                _list_Jour.Add(new Jour(num, _docXml, listAJ, CR));
            }
        }

        public void setJourCourant(int num)
        {
                foreach (Jour J in _list_Jour)
                {
                    if (J.Num == num)
                    {

                        _jourCourant = J;
                        changePanel(2);
                    }
                }
                
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
