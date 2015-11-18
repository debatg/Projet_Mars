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
    public partial class Form1 : Form
    {
        private int cent = 0, dix = 0, calend = 0;
        private List<Button> bttn_jour;
        private List<Jour> _list_Jour;
        private List<Activite> _list_Act;

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
                _list_Jour.Add(new Jour(i,treeView1));
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
                    label1.Text = J.Num.ToString();
                    label2.Text = J.ToString();
                    jourCourant = J;
                }              
            }
            tabControl1.SelectTab(1);
            treeView1 = jourCourant.Tree;  
            
        }

        private void btn_valid_Click(object sender, EventArgs e)
        {
            jourCourant.addAct(_list_Act[listBox1.SelectedIndex], int.Parse(textHeure.Text), int.Parse(textMin.Text));
            treeView1 = jourCourant.Tree;
            tabControl1.SelectTab(1);
            label2.Text = jourCourant.ToString();

        }

        private void bttn_modif_inser_Click(object sender, EventArgs e)
        {
            textJour.Text = jourCourant.Num.ToString();
            textHeure.Text = jourCourant.Tree.SelectedNode.Parent.Text;
            textMin.Text = jourCourant.Tree.SelectedNode.Text;
            tabControl1.SelectTab(2);
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
