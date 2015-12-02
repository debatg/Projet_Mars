using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_WF1
{
    class Astronaute
    {

        private List<Activite> _listAct;
        //Attributs de la classe Astronaute
        private string _nomAstronaute;



        //private List<Activite> _listAct;
        //Constructeur
        public Astronaute(string nomAstronaute)
        {
            _nomAstronaute = nomAstronaute;
        }

        //Accesseurs de la classe Astronaute
        public string NomAstronaute
        {
            get
            {
                return _nomAstronaute;
            }

            set
            {
                _nomAstronaute = value;
            }
        }

        //Ajout d'un astrononaute
        public void AjoutAstronaute(string nomAstronaute)
        {
            System.Xml.XmlDocument AstroActivites = new System.Xml.XmlDocument();
            AstroActivites.LoadXml("Astro_Activites.xml");

        }

    }
}
