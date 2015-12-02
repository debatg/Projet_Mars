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
        private PanelCalendrier panelCal;
        private PanelEdt panelEdt;
        private PanelAct panelAct;
        Point P;
        Size S;


        public Form1()
        {
            InitializeComponent();
            S = panel1.Size;
            P = panel1.Location;
            //panel1 = new PanelEdt(label1, panel1);
            panel1.Visible = false;
            
            panelCal = new PanelCalendrier(textBoxJour);
            panelEdt = new PanelEdt();
            panelAct = new PanelAct();
            //label2.Text = panelEdt.Size.ToString();

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
            }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelCal.Visible = true;
            panelEdt.Visible = false;
            panelAct.Visible = false;
        }

        private void buttonAct_Click(object sender, EventArgs e)
        {
            panelCal.Visible = false;
            panelEdt.Visible = false;
            panelAct.Visible = true;
        }

        private void buttonJour_Click(object sender, EventArgs e)
        {
            panelCal.setJourCourant(int.Parse(textBoxJour.Text));
        }

        public static void ChangeJour(int num)
        {
            //textBoxJour.Text = num.ToString();   
        }


    }
}
