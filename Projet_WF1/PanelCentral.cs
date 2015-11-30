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
        protected static List<Jour> _list_Jour;
        protected XElement _jourXml = new XElement("Jour");
        protected XElement _actXml = new XElement("Activité");
        protected XElement _astroXml = new XElement("Astronaute");
        protected XElement _calendrierXml = new XElement("Calendrier");
        protected static Jour _jourCourant=null;
        protected Panel _panelCentre;
        protected static PanelAct pa;
        protected static PanelCalendrier pc;
        protected static PanelEdt pe;



        public PanelCentral():base()
        {
            _docXml = new XDocument(_calendrierXml);
            
            //InitXml();
        }
        private void InitXml(object sender, EventArgs e)
        {
            _docXml = new XDocument(_calendrierXml);
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
