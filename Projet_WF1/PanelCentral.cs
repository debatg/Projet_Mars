using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projet_WF1
{
    class PanelCentral:Panel
    {
        protected static XDocument _docXml;
        protected static XDocument _docActXml;
        protected static List<Jour> _list_Jour;
        protected static List<Activite> _list_Act;
        protected static List<Astronaute> _list_Astro;
        protected static XElement _jourXml = new XElement("Jour");
        protected static XElement _actXml = new XElement("Activité");
        protected static XElement _astroXml = new XElement("Astronaute");
        protected static XElement _calendrierXml = new XElement("Calendrier");
        protected static Jour _jourCourant = null, _jourActu = null;
        protected static Panel _panelCentre;
        protected static PanelAct pa;
        protected static PanelCalendrier pc;
        protected static PanelEdt pe;
        protected static PanelSearch ps;
        protected static PanelExplor pex;
        protected static TextBox TB;
        protected static FormErreur FE;
        protected static DateTime _dateActu, _premierJour;       


        public PanelCentral():base()
        {
        }

        public void SaveXml()
        {
            _docXml.Save("calendrier.xml");
        }

        protected void MessErreur(string txt)
        {
            FE.setMessage(txt);
            FE.ShowDialog();
        }

        protected void changePanel(int index)
        {
            if(index==1)
            {
                Pc.Visible = true;
                Pe.Visible = false;
                Pa.Visible = false;
                Ps.Visible = false;
                Pc.InitBtn();
            }
            else if(index==2)
            {
                Pc.Visible = false;
                Pe.Visible = true;
                Pa.Visible = false;
                Ps.Visible = false;
                Pe.InitGrid();
            }
            else if (index ==3)
            {
                Pc.Visible = false;
                Pe.Visible = false;
                Pa.Visible = true;
                Ps.Visible = false;
                
            }
            else
            {
                Pc.Visible = false;
                Pe.Visible = false;
                Pa.Visible = false;
                Ps.Visible = true;
            }
        }

        protected System.Drawing.Color ActColor(Activite Act)
        {
            System.Drawing.Color couleur;
            if (Act.Parents.Contains("Living"))
                couleur = System.Drawing.ColorTranslator.FromHtml("#2196F3");//
            else if (Act.Parents.Contains("Science"))
                couleur = System.Drawing.ColorTranslator.FromHtml("#FF9800");//
            else if (Act.Parents.Contains("Maintenance"))
                couleur = System.Drawing.ColorTranslator.FromHtml("#795548");//
            else if (Act.Parents.Contains("Communication"))
                couleur = System.Drawing.ColorTranslator.FromHtml("#F44336");//
            else if (Act.Parents.Contains("Repair"))
                couleur = System.Drawing.ColorTranslator.FromHtml("#FFEB3B");
            else
                couleur = System.Drawing.ColorTranslator.FromHtml("#4CAF50");//

            return couleur;
        } 

        public PanelEdt Pe
        {
            get
            {
                return pe;
            }

            set
            {
                pe = value;
            }
        }

        public PanelCalendrier Pc
        {
            get
            {
                return pc;
            }

            set
            {
                pc = value;
            }
        }

        public PanelAct Pa
        {
            get
            {
                return pa;
            }

            set
            {
                pa = value;
            }
        }

        public PanelSearch Ps
        {
            get
            {
                return ps;
            }

            set
            {
                ps = value;
            }
        }

        public PanelExplor Pex
        {
            get
            {
                return pex;
            }

            set
            {
                pex = value;
            }
        }
    }
}
