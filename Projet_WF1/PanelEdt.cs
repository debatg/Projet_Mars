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
using System.Xml.Linq;

namespace Projet_WF1
{
    partial class PanelEdt : PanelCentral
    {
        private ActJour _actSelect;
        private int _heureSelect, _minSelect;
        private List<Button> _listBtn;
        private bool _btnSelec = false;
        private Astronaute AstroCourant = null;

        public PanelEdt( ) :base()
        {
            InitializeComponent();
            _listBtn = new List<Button>();
            
        }

        public void InitGrid()
        {
            InitializeComponent();
            
            dataGridView1.Refresh();
            listBox1.Items.Clear();
            foreach(Astronaute A in _list_Astro)
            {
                listBox1.Items.Add(A.NomAstronaute);
            }
            listBox1.SelectedIndex = 0;

            foreach (Astronaute Astr in _list_Astro)
            {
                if (Astr.NomAstronaute == listBox1.SelectedItem.ToString())
                    AstroCourant = Astr;
            }
            InitGrid(AstroCourant);


        }

        public void InitGrid(Astronaute Astro)
        {
            int index = listBox1.SelectedIndex;
            InitializeComponent();
            listBox1.Items.Clear();
            foreach (Astronaute A in _list_Astro)
            {
                listBox1.Items.Add(A.NomAstronaute);
            }
            listBox1.SelectedIndex = index;
            foreach (ActJour A in _jourCourant.ListAct)
            {
                if (A.ListA.Contains(Astro))
                {

                    string txt = A.Heure + "H" + A.Min + "-" + A.Act.ToString();
                    if (A.Heure == A.HeureFin)
                        AddActBtn((A.Min / 10) + 1, A.Heure + 1, A.Duree / 10, 1, txt, A.Act);
                    else if (A.Min == 0 && A.MinFin == 0)
                    {
                        AddActBtn((A.Min / 10) + 1, A.Heure + 1, 6, A.HeureFin - A.Heure, txt, A.Act);
                    }
                    else
                    {
                        if (A.MinFin == 0)
                        {
                            AddActBtn((A.Min / 10) + 1, A.Heure + 1, (60 - A.Min) / 10, 1, txt, A.Act);

                            AddActBtn(1, A.Heure + 2, 6, A.HeureFin - A.Heure - 1, txt, A.Act);
                        }
                        else if (A.Min == 0)
                        {
                            AddActBtn(1, A.Heure + 1, 6, A.HeureFin - A.Heure, txt, A.Act);

                            AddActBtn(1, A.HeureFin + 1, (A.MinFin / 10) + 1, 1, txt, A.Act);

                        }
                        else
                        {
                            if (A.HeureFin - A.Heure >= 2)
                            {
                                AddActBtn((A.Min / 10) + 1, A.Heure + 1, 6, 1, txt, A.Act);

                                AddActBtn(1, A.Heure + 2, 6, A.HeureFin - A.Heure - 1, txt, A.Act);

                            }
                            else
                            {
                                AddActBtn((A.Min / 10) + 1, A.Heure + 1, (60 - A.Min) / 10, 1, txt, A.Act);

                            }
                            AddActBtn(1, A.HeureFin + 1, A.MinFin / 10, 1, txt, A.Act);

                        }
                    }
                }
                else
                {
                    Debug.WriteLine("pas d'act");
                }

            }
            dataGridView1.Refresh();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Astronaute Astr in _list_Astro)
            {
                if (Astr.NomAstronaute == listBox1.SelectedItem.ToString())
                    AstroCourant = Astr;
            }
            InitGrid(AstroCourant);
        }

        private void AddActBtn(int Col, int Ligne, int nbr,int hauteur, string texte, Activite Act)
        {
            int X = (dataGridView1.Size.Width * Col / 7)+1;
            int Y = (dataGridView1.Size.Height * Ligne / dataGridView1.RowCount)+1;
            Point P = new Point(X, Y);
            Size S = new Size((dataGridView1.Width * nbr / 7) , (dataGridView1.Rows[0].Height*hauteur) + 2);
            Rectangle r = new Rectangle(P, S);

            Button B = new Button();
            B.FlatAppearance.BorderColor = ActColor(Act);
            B.BackColor = ActColor(Act);
            B.Font = new Font("Arial", 7, FontStyle.Regular);
            B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            B.FlatAppearance.BorderColor = Color.Black;
            B.Font = new Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            B.UseVisualStyleBackColor = true;
            B.Click+=new System.EventHandler(this.bttn_Act_Click);
            B.Size = S;
            B.Location = P;
            B.Text = texte;            
            dataGridView1.Controls.Add(B);
            _listBtn.Add(B);
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
            btnDescr.Enabled = true;
            _btnSelec = true;
        }

        private void bttn_modif_inser_Click(object sender, EventArgs e)
        {
            if (_btnSelec == true)
                Pa.InitText(_jourCourant.Num, HeureSelect, MinSelect, _actSelect);
            else if (dataGridView1.CurrentCell != null)
                Pa.InitText(_jourCourant.Num, HeureSelect, MinSelect);
            else
                MessErreur("Veuillez sélectionner un activité ou une heure");

            changePanel(3);
            
        }

        private void AffichInfoAct()
        {
            string ch = "";
            label1.Visible = true;
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
            label1.Visible = false;
            btnDescr.Enabled = false;
            _btnSelec = false;
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
            TB.Text = _jourCourant.Num.ToString();
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
            TB.Text = _jourCourant.Num.ToString();

            dataGridView1.Controls.Clear();
            InitGrid();            
        }

        private void bttn_Supprimer_Click(object sender, EventArgs e)
        {
            XNode nodeSup = null;
            var branche = from a in _docXml.Descendants("Jour")
                           select a;

            foreach (XElement el in branche)
            {
                if (el.FirstAttribute.Value.ToString() == _jourCourant.Num.ToString())
                {


                    var act = from a in el.Descendants("Activité")
                              select a;
                    foreach (XElement e2 in act)
                    {
                        if (e2.Element("Nom").Value == _actSelect.Act.Nom && int.Parse(e2.Element("Heure").Value) == _actSelect.Heure && int.Parse(e2.Element("Min").Value) == _actSelect.Min)
                        {
                            nodeSup = e2;
                        }
                    }
                }
            }
                nodeSup.Remove();
            SaveXml();
            _jourCourant.ListAct.Remove(_actSelect);
            InitGrid();
        }

        private void btnDescr_Click(object sender, EventArgs e)
        {
            XElement Xcr = null;
            var branches = from a in _docXml.Descendants("Jour")
                           select a;

            foreach (XElement elem in branches)
            {
                int num = int.Parse(elem.FirstAttribute.Value);
                if (num == _jourCourant.Num)
                {
                    var branchesDescr = from a in elem.Descendants("Activité")
                                   select a;
                    foreach(XElement Xdescript in branchesDescr)
                    {
                        int Hdebut = int.Parse(Xdescript.Element("Heure").Value);
                        int minDebut = int.Parse(Xdescript.Element("Min").Value);
                        if (Hdebut == _actSelect.Heure && minDebut == _actSelect.Min)
                            Xcr = Xdescript.Element("Descript");
                    }

                }
            }
            if (Xcr != null)
            {
                FormCompteRendu Fcr;
                if (_jourCourant.Num < _jourActu.Num)
                    Fcr = new FormCompteRendu(Xcr, true, this);
                else
                    Fcr = new FormCompteRendu(Xcr, false, this);

                Fcr.ShowDialog();
            }
            else
            {
                FormErreur FE = new FormErreur();
                FE.setMessage("Erreur dans le chargement du compte-rendu");
                FE.ShowDialog();
            }
        }

        private void buttonCR_Click(object sender, EventArgs e)
        {
            XElement Xcr = null;
            var branches = from a in _docXml.Descendants("Jour")
                           select a;

            foreach (XElement elem in branches)
            {
                int num = int.Parse(elem.FirstAttribute.Value);
                if (num == _jourCourant.Num)
                {
                    Xcr=elem.Element("Compte_rendu");
                    
                }
            }
            if (Xcr != null)
            {
                FormCompteRendu Fcr;
                if (_jourCourant.Num<_jourActu.Num)
                     Fcr= new FormCompteRendu(Xcr, true, this);
                else
                    Fcr = new FormCompteRendu(Xcr, false, this);

                Fcr.ShowDialog();
            }
            else
            {
                FormErreur FE = new FormErreur();
                FE.setMessage("Erreur dans le chargement du compte-rendu");
                FE.ShowDialog();
            }
        }
    }
}
