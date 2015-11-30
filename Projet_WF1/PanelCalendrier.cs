using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_WF1
{
    partial class PanelCalendrier : PanelCentral
    {
        private int cent = 0, dix = 0, calend = 1;
        private List<Button> bttn_jour;
        
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
            int i = 1;
            foreach (Button B in panel_calendrier.Controls)
            {
                bttn_jour.Add(B);
            }
            while (i <= 500)
            {
                _list_Jour.Add(new Jour(i, _calendrierXml));
                i++;
            }
            i = 0;
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

        /*private void InitEdt()
        {
            Size S = panel1.Size;
            Point P = panel1.Location;
            panel1 = new PanelEdt(label2, this);
            panel1.Location = P;
            panel1.Size = S;
            tabControl1.SelectTab(1);
            tabControl1.SelectedTab.Controls.Add(panel1);
            tabControl1.SelectedTab.Controls.SetChildIndex(panel1, 0);
        }*/




        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
