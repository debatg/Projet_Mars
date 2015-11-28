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
    partial class PanelEdt : Panel
    {

        private Jour _jourCourant;
        private Label _l;
        private ActJour _actSelect;
        private int _heureSelect, _minSelect;

        public PanelEdt(Jour J, Label L):base()
        {
            _l = L;
            _jourCourant = J;
            InitializeComponent();
            foreach (ActJour A in _jourCourant.ListAct)
            {
                AddActBtn((A.Min / 10) + 1, A.Heure + 1, A.Duree / 10, A.Heure+"H"+A.Min+"-"+A.Act.ToString());
            }
        }


        private void AddActBtn(int Col, int Ligne, int nbr, string texte)
        {
            int X = (dataGridView1.Size.Width * Col / 7);
            int Y = (dataGridView1.Size.Height * Ligne / dataGridView1.RowCount);
            Point P = new Point(X, Y);
            Size S = new Size((dataGridView1.Width * nbr / 7) + 1, dataGridView1.Rows[0].Height + 2);
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
                _l.Text = "";

                if (ch[0] == A.Heure.ToString() && ch[1] == A.Min.ToString())
                {
                    _actSelect = A;
                    _heureSelect = A.Heure;
                    _minSelect = A.Min;
                }               
                
            }
            AffichInfoAct();

        }

        private void AffichInfoAct()
        {
            string ch = "";
            ch += "Activité : " + _actSelect.Act.ToString()+"\n";
            ch += "Début : " + _actSelect.Heure.ToString() + "H" + _actSelect.Min.ToString()+"\n";
            ch += "Durée : " + _actSelect.Duree;
            _l.Text = ch;
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
            _heureSelect = int.Parse( dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Split('H')[0]);
            _minSelect = int.Parse(dataGridView1.Rows[0].Cells[e.ColumnIndex].Value.ToString().Split('H','-')[0]);

        }
    }
}
