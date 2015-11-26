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
    partial class Form2 : Form
    {
        Jour _jourCourant;
        public Form2(Jour J): base()
        {
            InitializeComponent();
            // Point P = dataGridView1.GetCellDisplayRectangle(0, 1, false).Location;
            _jourCourant = J;
            label1.Text = dataGridView1.GetCellDisplayRectangle(0, 0, true).Left.ToString();
            foreach(ActJour A in _jourCourant.ListAct)
            {
                AddActBtn((A.Min / 10) + 1, A.Heure + 1, A.Duree/10, A.Act.ToString());
            }
        }

        

        private void AddActBtn(int Col, int Ligne, int nbr, string texte)
        {
            int X = (dataGridView1.Size.Width * Col / 7);
            int Y = (dataGridView1.Size.Height * Ligne / dataGridView1.RowCount);
            Point P = new Point(X, Y);
            Size S = new Size((dataGridView1.Width * nbr / 7)+1, dataGridView1.Rows[0].Height + 2);
            Rectangle r = new Rectangle(P, S);

            Button B = new Button();
            B.Size = S;
            B.Location = P;
            B.Text = texte;
            dataGridView1.Controls.Add(B);
        }
    }
}
