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
        private PanelCalendrier panelCal;
        private PanelEdt panelEdt;
        private PanelAct panelAct;
        private PanelSearch panelSearch;
        private PanelExplor panelExplor;
        private Point P;
        private Size S;


        public Form1()
        {
            InitializeComponent();
            S = panel1.Size;
            P = panel1.Location;
            panel1.Visible = false;
            
            //Initialisation des différents panels utilisés
            panelCal = new PanelCalendrier(textBoxJour);
            panelEdt = new PanelEdt();
            panelAct = new PanelAct();
            panelSearch = new PanelSearch();
            panelExplor = new PanelExplor();
            panelExplor = new PanelExplor();

            //Affectation d'un copie 
            panelAct.Pe = panelEdt;
            panelAct.Pc = panelCal;
            panelAct.Pa = panelAct;
            panelAct.Ps = panelSearch;
            panelAct.Pex = panelExplor;

            //Chargement des deux fichiers Xml
            panelAct.ChargeActXml();
            panelCal.InitXml();

            //Affichage du calendrier + Init tailles et position des panels
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

            panelSearch.Visible = false;
            panelSearch.Location = P;
            panelSearch.Size = S;
            this.Controls.Add(panelSearch);

            panelExplor.Visible = false;
            panelExplor.Location = P;
            panelExplor.Size = S;
            this.Controls.Add(panelExplor);
        }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        /*===========================================================
         * public void pictureBox1_Click
         * Role : Affiche le panel de calendrier
         * ==========================================================*/
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelCal.Visible = true;
            panelEdt.Visible = false;
            panelAct.Visible = false;
            panelExplor.Visible = false;
        }

        /*===========================================================
         * public void buttonSearch_Click
         * Paramètre d'entrée : Effectue la recherche suivant le texte et la tranche de jour entréé
         * puis affiche le panel de recherche
         * ==========================================================*/
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (numericUpDownPetit.Value <= numericUpDownHaut.Value)
                panelSearch.SearchAct(textBoxSearch.Text, (int)numericUpDownPetit.Value, (int)numericUpDownHaut.Value,1);
            else
                MessErreur("Le premier jour doit être inférieur ou égal au second.");
        }

        /*===========================================================
         * public void buttonAct_Click
         * Role : Affiche le panel d'activité
         * ==========================================================*/
        private void buttonAct_Click(object sender, EventArgs e)
        {
            panelCal.Visible = false;
            panelEdt.Visible = false;
            panelAct.Visible = true;
            panelExplor.Visible = false;
            panelSearch.Visible = false;

        }

        /*===========================================================
         * public void btnExplorer_Click
         * Role : Affiche le panel d'exploration
         * ==========================================================*/
        private void btnExplor_Click(object sender, EventArgs e)
        {
            panelCal.Visible = false;
            panelEdt.Visible = false;
            panelAct.Visible = false;
            panelSearch.Visible = false;
            panelExplor.Visible = true;
            panelExplor.InitMap();
        }

        /*===========================================================
         * public void buttonJour_Click
         * Paramètre d'entrée : 
         * Role : Attirbue le jour courant, et affiche son emploi du temps
         * ==========================================================*/
        private void buttonJour_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBoxJour.Text) >= 1 && int.Parse(textBoxJour.Text) <= 500)
                    panelCal.setJourCourant(int.Parse(textBoxJour.Text));
                else
                    throw new Exception();

            }
            catch (Exception)
            {
                FormErreur FE = new FormErreur();
                FE.setMessage("Jour entré non valide");
                FE.ShowDialog();
            }
        }

        public static void MessErreur(string texte)
        {
            FormErreur FE = new FormErreur();
            FE.setMessage(texte);
            FE.ShowDialog();
        }


    }
}
