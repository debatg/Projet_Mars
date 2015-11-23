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
        private int cent = 0, dix = 0, calend = 0;
        private string chemin;
        private List<Button> bttn_jour;
        private List<Jour> _list_Jour;
        private List<Activite> _list_Act;
        private XDocument _docXml;
        private XElement _jourXml = new XElement("Jour");
        private XElement _actXml = new XElement("Activité");
        private XElement _astroXml = new XElement("Astronaute");
        private XElement _calendrierXml = new XElement("Calendrier");

        private Jour jourCourant = null;
        private Form2 F2;
        public Form1()
        {
            InitializeComponent();

            bttn_jour = new List<Button>();
            _list_Jour = new List<Jour>();
            _list_Act = new List<Activite>();

            _list_Act.Add(new Activite("test"));
            listBox1.Items.Add("test");
            listBox1.Items.Add("test2");
            _list_Act.Add(new Activite("test2"));
            

            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            int i = 1;
            foreach (Button B in panel_calendrier.Controls)
            {
                bttn_jour.Add(B);
            }
            while(i<=500)
            {
                _list_Jour.Add(new Jour(i, _calendrierXml));
                i++;
            }
            _docXml = new XDocument(_calendrierXml);

            

            

        }

        private void InitEdt()
        {
            List<PictureBox> LP = new List<PictureBox>();

            for (int i = 1; i<= 25; i++)
            {
                
                PictureBox P = new PictureBox();
                P.BackColor = Color.FromName("GradientInactiveCaption");
                P.Margin= new System.Windows.Forms.Padding(0);
                P.Dock = DockStyle.Fill;
                tableLayoutPanel1.Controls.Add(P,0,i);
                LP.Add(P);
                Label textAffich = new Label();
                textAffich.Visible = true;
                textAffich.Text = (i-1).ToString() + "H";
                textAffich.Location = new Point((P.Location.X / 2) + tableLayoutPanel1.Location.X+3, P.Location.Y + tableLayoutPanel1.Location.Y);
                textAffich.BackColor = Color.FromName("GradientInactiveCaption");
                textAffich.Size = new Size(textAffich.Size.Width/2, textAffich.Size.Height / 2);
                tabControl1.SelectTab(1);
                tabControl1.SelectedTab.Controls.Add(textAffich);
                tabControl1.SelectedTab.Controls.SetChildIndex(tableLayoutPanel1, 100);
                tabControl1.SelectedTab.Controls.SetChildIndex(textAffich, 0);      

            }
            for (int i = 1; i <= 6; i++)
            {
                PictureBox P = new PictureBox();
                P.BackColor = Color.FromName("GradientInactiveCaption");
                P.Margin = new System.Windows.Forms.Padding(0);
                P.Dock = DockStyle.Fill;
                tableLayoutPanel1.Controls.Add(P, i, 0);
                LP.Add(P);
                Label textAffich = new Label();
                textAffich.Visible = true;
                textAffich.Text = ((i - 1)*10).ToString() +"-"+(i*10).ToString()+ " min";
                textAffich.Location = new Point((P.Location.X) + tableLayoutPanel1.Location.X + 3, P.Location.Y + tableLayoutPanel1.Location.Y);
                textAffich.BackColor = Color.FromName("GradientInactiveCaption");
                textAffich.Size = new Size((tableLayoutPanel1.Size.Width/7)-10, (tableLayoutPanel1.Size.Height/25)-2);
                tabControl1.SelectTab(1);
                tabControl1.SelectedTab.Controls.Add(textAffich);
                tabControl1.SelectedTab.Controls.SetChildIndex(tableLayoutPanel1, 100);
                tabControl1.SelectedTab.Controls.SetChildIndex(textAffich, 0);
            }
        }

        private void MajEdt()
        {
            int indexTab = 0;
            List<PictureBox> LP = new List<PictureBox>();
            Activite actPrec = null;
            Label textAffich = new Label();
            foreach (Activite A in jourCourant.TabAct)
            {
                if (A != null||actPrec!=null)
                {

                    
                        PictureBox P = new PictureBox();
                        P.BackColor = Color.FromName("LimeGreen");
                        P.Margin = new System.Windows.Forms.Padding(0);
                        P.Dock = DockStyle.Fill;
                        int heure = indexTab / 6;
                        int min = indexTab % 6;
                        tableLayoutPanel1.Controls.Add(P, min + 1, heure + 1);
                    

                    if (actPrec == null)
                    {
                        textAffich = new Label();
                        textAffich.Visible = true;
                        textAffich.Text = A.ToString();
                        LP.Add(P);
                    }
                    else if (actPrec == A)
                    {
                        LP.Add(P);
                    }
                    else
                    {
                        textAffich.Location = new Point(((((LP[LP.Count - 1].Location.X) + (LP[0].Location.X))/2) + tableLayoutPanel1.Location.X + 3),
                            ((LP[0].Location.Y) + tableLayoutPanel1.Location.Y));
                        textAffich.BackColor = Color.FromName("LimeGreen");
                        textAffich.Size = new Size((tableLayoutPanel1.Size.Width / 7) - 10, (tableLayoutPanel1.Size.Height / 25) - 2);
                        tabControl1.SelectTab(1);
                        tabControl1.SelectedTab.Controls.Add(textAffich);
                        tabControl1.SelectedTab.Controls.SetChildIndex(tableLayoutPanel1, 100);
                        tabControl1.SelectedTab.Controls.SetChildIndex(textAffich, 0);
                        label2.Text = textAffich.Location.ToString();
                        LP.Clear();
                        LP.Add(P);
                    }
                }
                actPrec = A;
                indexTab++;
                
            }
        }

        private void InitXml()
        {
            _docXml = new XDocument(_calendrierXml);
        }

        private void bttn_Jour_Click(object sender, EventArgs e)
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
            /*treeView1 = jourCourant.Tree;
            if (jourCourant.Tree == treeView1) ;
                //label2.Text = "ok";
            treeView1.Show();
            tabControl1.SelectTab(1);
            //TreeView T = jourCourant.Tree;
            treeView1.Refresh();*/
            InitEdt();
            MajEdt();
            
        }        

        private void btn_valid_Click(object sender, EventArgs e)
        {
            jourCourant.addAct(_list_Act[listBox1.SelectedIndex], int.Parse(textHeure.Text), int.Parse(textMin.Text), int.Parse(textDuree.Text));
            //treeView1 = jourCourant.Tree;
            tabControl1.SelectTab(1);
            //label2.Text = Directory.GetCurrentDirectory();
            _docXml.Save(Directory.GetCurrentDirectory()+"/calendrier.xml");
            //InitEdt();
            MajEdt();

        }

        private void bttn_modif_inser_Click(object sender, EventArgs e)
        {
            textJour.Text = jourCourant.Num.ToString();
           /* textHeure.Text = jourCourant.Tree.SelectedNode.Parent.Text;
            textMin.Text = jourCourant.Tree.SelectedNode.Text;*/
            tabControl1.SelectTab(2);
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            int num_Jour= jourCourant.Num;
            foreach(Jour J in _list_Jour)
            {
                if (J.Num == num_Jour - 1)
                {
                    jourCourant = J;
                }

            }
            /*TreeView T = jourCourant.Tree;
            label2.Text = jourCourant.ToString();
            treeView1 = T;*/
            //treeView1.Refresh();

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
            //label2.Text = jourCourant.ToString();
            /*TreeView T = jourCourant.Tree;
            treeView1 = T;*/
           // treeView1.Refresh();
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void bt_cent_Click(object sender, EventArgs e)
        {
            var bttn = sender as Button;
            cent= int.Parse(bttn.Name.Split('_')[1])-1;
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

                foreach(Jour J in _list_Jour)
                {
                    if (J.Num.ToString() == (calend + i).ToString())
                        B.Text = J.Num.ToString();
                }
                
                i++;
            }
           
        }
    }
}
