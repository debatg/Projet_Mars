using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projet_WF1
{
    public partial class Form1 : Form
    {
        private int cent = 0, dix = 0, calend = 1;
        private string chemin;
        /*private List<Button> bttn_jour;
        private List<Jour> _list_Jour;
        private List<Activite> _list_Act;*/
        /*private XDocument _docXml;
        private XElement _jourXml = new XElement("Jour");
        private XElement _actXml = new XElement("Activité");
        private XElement _astroXml = new XElement("Astronaute");
        private XElement _calendrierXml = new XElement("Calendrier");*/
        private PanelCalendrier panelCal;
        private PanelEdt panelEdt;
        private PanelAct panelAct;
        Point P;
        Size S;

        private Jour jourCourant = null;


        public Form1()
        {
            InitializeComponent();
            S = panel1.Size;
            P = panel1.Location;
            //panel1 = new PanelEdt(label1, panel1);
            panel1.Visible = false;
            
            panelCal = new PanelCalendrier(panel1);
            panelEdt = new PanelEdt();
            panelAct = new PanelAct();
            label2.Text = panelEdt.Size.ToString();

            panelAct.Pe = panelEdt;
            panelAct.Pc = panelCal;
            panelAct.Pa = panelAct;

            //var panelCal =panel1 as PanelCalendrier;
            panelCal.Visible = true;
            panelCal.Location = P;
            panelCal.Size = S;            
            this.Controls.Add(panelCal);

            panelEdt.Visible = false;
            panelEdt.Location = P;
            panelEdt.Size = S;
            this.Controls.Add(panelEdt);

            panelAct.Visible = false;
            panelAct.Location = P;
            panelAct.Size = S;
            this.Controls.Add(panelAct);

           
            //panelCal._eventEdt += new EventHandler(page2);
        }

        

        /*private void InitXml(object sender, EventArgs e)
        {
            _docXml = new XDocument(_calendrierXml);
        }*/

       /* private void bttn_Jour_Click(object sender, EventArgs e)
        {
            var bttn = sender as Button;
            foreach (Jour J in _list_Jour)
            {
                if (J.Num == int.Parse(bttn.Text))
                {
                    label1.Text = J.Num.ToString();
                    //label2.Text = J.ToString();
                    jourCourant = J;
                }              
            }
            InitEdt();
        }  */      

        /*private void InitEdt()
        {

            Size S = panel1.Size;
            Point P = panel1.Location;
            panel1 = new PanelEdt(label2,this);
            panel1.Location = P;
            panel1.Size = S;
            tabControl1.SelectTab(1);
            tabControl1.SelectedTab.Controls.Add(panel1);
            tabControl1.SelectedTab.Controls.SetChildIndex(panel1, 0);
        }*/

        /*private void btn_valid_Click(object sender, EventArgs e)
        {
            jourCourant.addAct(_list_Act[listBox1.SelectedIndex], int.Parse(textHeure.Text), int.Parse(textMin.Text), int.Parse(textDuree.Text));
            tabControl1.SelectTab(1);
            _docXml.Save(Directory.GetCurrentDirectory()+"/calendrier.xml");
            InitEdt();

        }*/

       /* private void bttn_modif_inser_Click(object sender, EventArgs e)
        {
            var edt = panel1 as PanelEdt;
            textJour.Text = jourCourant.Num.ToString();

            textHeure.Text = edt.HeureSelect.ToString();
            textMin.Text = edt.MinSelect.ToString();
            tabControl1.SelectTab(2);
        }*/

       /* private void btn_Previous_Click(object sender, EventArgs e)
        {
            int num_Jour= jourCourant.Num;
            foreach(Jour J in _list_Jour)
            {
                if (J.Num == num_Jour - 1)
                {
                    jourCourant = J;
                }

            }

        }

        private void bttn_Next_Click(object sender, EventArgs e)
        {
            int num_Jour = jourCourant.Num;
            int a = 0;
            foreach (Jour J in _list_Jour)
            {
                if (J.Num == num_Jour + 1)
                {
                    jourCourant = J;
                }


            }
        }*/

        /*private void bt_cent_Click(object sender, EventArgs e)
        {
            var bttn = sender as Button;
            cent= int.Parse(bttn.Name.Split('_')[1])-1;
            // if(bttn.Name.Split('_')(5))
        }*/

        /*private void bt_dix_Click(object sender, EventArgs e)
        {
            var bttn = sender as Button;            
            dix = int.Parse(bttn.Name.Split('_')[1]);
            calend = cent + dix;
            int i = 0;
            foreach (Button B in bttn_jour)
            {

                foreach(Jour J in _list_Jour)
                {
                    if (J.Num.ToString() == (calend + i).ToString())
                        B.Text = J.Num.ToString();
                }
                
                i++;
            }
           
        }*/
    }
}
