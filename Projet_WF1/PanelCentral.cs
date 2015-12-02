using System;
using System.Collections.Generic;
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
        protected static XElement _jourXml = new XElement("Jour");
        protected static XElement _actXml = new XElement("Activité");
        protected static XElement _astroXml = new XElement("Astronaute");
        protected static XElement _calendrierXml = new XElement("Calendrier");
        protected static Jour _jourCourant = null;
        protected static Panel _panelCentre;
        protected static PanelAct pa;
        protected static PanelCalendrier pc;
        protected static PanelEdt pe;
        protected static TextBox TB;



        public PanelCentral():base()
        {
        }

        public void SaveXml()
        {
            _docXml.Save("calendrier.xml");
        }

        protected void changePanel(int index)
        {
            if(index==1)
            {
                Pc.Visible = true;
                Pe.Visible = false;
                Pa.Visible = false;
            }
            else if(index==2)
            {
                Pc.Visible = false;
                Pe.Visible = true;
                Pa.Visible = false;
                Pe.InitGrid();
            }
            else
            {
                Pc.Visible = false;
                Pe.Visible = false;
                Pa.Visible = true;
            }
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

        
    }
}
