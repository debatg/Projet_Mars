using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_WF1
{
    partial class PanelExplor : PanelCentral
    {
        private List<PictureBox> Lpb = new List<PictureBox>();
        private List<string> ListInfo = new List<string>();

        public PanelExplor()
        {
            InitializeComponent();
        }

        public void InitMap()
        {
            Graphics g = pictureBox1.CreateGraphics();
            int i = 0;
            foreach(Jour J in _list_Jour)
            {
                foreach(ActJour A in J.ListAct)
                {

                    if (A.Ext)
                    {
                        PictureBox PB = new PictureBox();
                        PB.Size = new System.Drawing.Size(20, 20);
                        PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                        Point P = new Point(A.X+700 / 5, (1000 / 5) -A.Y);
                        PB.Location = P;
                        PB.Click += new System.EventHandler(this.PB_Click);
                        PB.Name = i.ToString();
                        PB.Image = ActImage(A, J);
                        PB.BackColor= Color.Transparent;
                        PB.Visible = true;
                        Lpb.Add(PB);
                        labelInfo.Text = P.ToString();
                        ListInfo.Add(InfoAct(A, J));
                        pictureBox1.Controls.Add(PB);
                        i++;                        
                    }
                }
            }
        }

        private string InfoAct(ActJour A, Jour J)
        {
            string ch = "";
            ch += "Activité : " + A.Act.Nom+"\n";
            ch += "Jour : " + J.Num + "\n";
            ch += "Heure début : " + A.Heure + "H" + A.Min + "min\n";
            ch += "Heure fin : " + A.HeureFin + "H" + A.MinFin + "min";
            return ch;
        }

        private void PB_Click(object sender, EventArgs e)
        {
            var picture = sender as PictureBox;
            int index = Lpb.IndexOf(picture);
            labelInfo.Text = ListInfo[index];

        }


        private Image ActImage(ActJour A, Jour J)
        {
            string ch = "ok";
            foreach(string s in A.Act.Parents)
            {
                ch += s + "//";
            }
            Debug.WriteLine(ch);
            if(J.Num<_jourActu.Num)
            {
                if (A.Act.Parents.Contains("Living"))
                    return Image.FromFile("images/filledBleu.png");
                else if (A.Act.Parents.Contains("Science"))
                    return Image.FromFile("images/filledOrange.png");
                else if (A.Act.Parents.Contains("Maintenance"))
                    return Image.FromFile("images/filledMarron.png");
                else if (A.Act.Parents.Contains("Communication"))
                    return Image.FromFile("images/filledRouge.png");
                else if (A.Act.Parents.Contains("Repair"))
                    return Image.FromFile("images/filledJaune.png");
                else
                    return Image.FromFile("images/filledVert.png");
            }
            else
            {
                if (A.Act.Parents.Contains("Living"))
                    return Image.FromFile("images/shapeBleu.png");
                else if (A.Act.Parents.Contains("Science"))
                    return Image.FromFile("images/shapeOrange.png");
                else if (A.Act.Parents.Contains("Maintenance"))
                    return Image.FromFile("images/shapeMarron.png");
                else if (A.Act.Parents.Contains("Communication"))
                    return Image.FromFile("images/shapeRouge.png");
                else if (A.Act.Parents.Contains("Repair"))
                    return Image.FromFile("images/shapeJaune.png");
                else
                    return Image.FromFile("images/shapeVert.png");
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
