using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projet_WF1
{
    partial class PanelEdt : PanelCentral
    {

        //private Jour _jourCourant;
        private Label _l;
        private ActJour _actSelect;
        private int _heureSelect, _minSelect;
        private Panel _panelPrec;
        //private XDocument _docXml;


        public PanelEdt( ) :base()
        {
            //_jourCourant = J;
            
            InitializeComponent();
            
           /* _panelActivite.JourCourant = _jourCourant;
            _panelActivite.PanelPrec = this;*/
        }

        public void InitGrid()
        {
            foreach (ActJour A in _jourCourant.ListAct)
            {
                string txt = A.Heure + "H" + A.Min + "-" + A.Act.ToString();
                if (A.Heure == A.HeureFin)
                    AddActBtn((A.Min / 10) + 1, A.Heure + 1, A.Duree / 10, 1, txt);
                else if (A.Min == 0 && A.MinFin == 0)
                {
                    AddActBtn((A.Min / 10) + 1, A.Heure + 1, 6, A.HeureFin - A.Heure, txt);
                }
                else
                {
                    //AddActBtn((A.Min / 10) + 1, A.Heure + 1, (60-A.Min)/10, 1, txt);
                    if(A.MinFin==0)
                    {
                        AddActBtn( 1, A.Heure + 2, 6, A.HeureFin - A.Heure-1, txt);
                    }
                    else
                    {
                        if(A.HeureFin-A.Heure>=2)
                        {
                            AddActBtn(1, A.Heure + 1, 6, A.HeureFin - A.Heure , txt);

                        }
                        AddActBtn(1, A.HeureFin + 1, A.MinFin/10,  1, txt);

                    }
                }

            }
        }

        private void AddActBtn(int Col, int Ligne, int nbr,int hauteur, string texte)
        {
            int X = (dataGridView1.Size.Width * Col / 7);
            int Y = (dataGridView1.Size.Height * Ligne / dataGridView1.RowCount);
            Point P = new Point(X, Y);
            Size S = new Size((dataGridView1.Width * nbr / 7) + 1, (dataGridView1.Rows[0].Height*hauteur) + 2);
            Rectangle r = new Rectangle(P, S);

            Button B = new Button();
            B.Click+=new System.EventHandler(this.bttn_Act_Click);
            B.Size = S;
            B.Location = P;
            B.Text = texte;            
            dataGridView1.Controls.Add(B);
            //dataGridView1.Controls.SetChildIndex(B, 100);
        }

        private void bttn_Act_Click(object sender, EventArgs e)
        {
            var bttn = sender as Button;
            
            foreach (ActJour A in _jourCourant.ListAct)
            {
                string[] ch = bttn.Text.Split('H', '-');
                label1.Text = "";

                if (ch[0] == A.Heure.ToString() && ch[1] == A.Min.ToString())
                {
                    _actSelect = A;
                    _heureSelect = A.Heure;
                    _minSelect = A.Min;
                }               
                
            }
            AffichInfoAct();

        }

        private void bttn_modif_inser_Click(object sender, EventArgs e)
        {
            Pa.InitText(_jourCourant.Num, HeureSelect, MinSelect);
            changePanel(3);
            
        }

        private void AffichInfoAct()
        {
            string ch = "";
            ch += "Activité : " + _actSelect.Act.ToString()+"\n";
            ch += "Début : " + _actSelect.Heure.ToString() + "H" + _actSelect.Min.ToString()+"\n";
            ch += "Durée : " + _actSelect.Duree+"\n";
            ch += "Heure Fin : " + _actSelect.HeureFin+"\n";
            ch += "Min Fin : " + _actSelect.MinFin + "\n";

            label1.Text = ch;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public int HeureSelect
        {
            get
            {
                return _heureSelect;
            }

            set
            {
                _heureSelect = value;
            }
        }

        public int MinSelect
        {
            get
            {
                return _minSelect;
            }

            set
            {
                _minSelect = value;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           /* _heureSelect = int.Parse( dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Split('H')[0]);
            _minSelect = int.Parse(dataGridView1.Rows[0].Cells[e.ColumnIndex].Value.ToString().Split('H','-')[0]);
            */
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0|| dataGridView1.CurrentCell.RowIndex==0)
                dataGridView1.CurrentCell.Selected = false;
            else
            {
                _heureSelect = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString().Split('H')[0]);
                _minSelect = int.Parse(dataGridView1.Rows[0].Cells[dataGridView1.CurrentCell.ColumnIndex].Value.ToString().Split('H', '-')[0]);
            }

        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            Jour test=null;
            foreach(Jour J in _list_Jour)
            {
                if(J.Num==_jourCourant.Num-1)
                {
                    test = J;
                    //return;
                }
            }
            _jourCourant = test;
            dataGridView1.Controls.Clear();
            InitGrid();

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            Jour test = null;
            foreach (Jour J in _list_Jour)
            {
                if (J.Num == _jourCourant.Num + 1)
                {
                    test = J;
                    //return;
                }
            }
            _jourCourant = test;
            dataGridView1.Controls.Clear();
            InitGrid();            
        }
    }
}
