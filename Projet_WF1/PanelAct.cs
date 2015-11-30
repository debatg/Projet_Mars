﻿using System;
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
    partial class PanelAct : PanelCentral
    {
        //private Jour _jourCourant;
        //private XDocument _docXml;
        private List<Activite> _list_Act;
        private Panel _panelPrec;



        public PanelAct() :base()
        {
            InitializeComponent();
            
            //_docXml = docXml;
            _list_Act = new List<Activite>();
            _list_Act.Add(new Activite("test"));
            listBox1.Items.Add("test");
            listBox1.Items.Add("test2");
            _list_Act.Add(new Activite("test2"));
        }

        private void btn_valid_Click(object sender, EventArgs e)
        {
            _jourCourant.addAct(_list_Act[listBox1.SelectedIndex], int.Parse(textHeure.Text), int.Parse(textMin.Text), int.Parse(textDuree.Text));
            //tabControl1.SelectTab(1);
            _docXml.Save(Directory.GetCurrentDirectory() + "/calendrier.xml");
            //InitEdt();
            changePanel(2);

        }

        public void InitText(int numJour, int heure, int min)
        {
            //var edt = panel1 as PanelEdt;
            textJour.Text = numJour.ToString();

            textHeure.Text = heure.ToString();
            textMin.Text = min.ToString();
            
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