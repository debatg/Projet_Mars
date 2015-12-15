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
    partial class FormCompteRendu : Form
    {
        private XElement _docX;
        private bool _passe;
        private PanelCentral _parent;

        public FormCompteRendu(XElement docX, bool passe, PanelCentral parent): base()
        {
            InitializeComponent();
            _docX = docX;
            _passe = passe;
            _parent = parent;
            richTextBox1.Text = _docX.Value;
            if (_passe == true)
            {
                richTextBox1.ReadOnly = true;
                buttonEnre.Enabled = false;
            }
            else
            {
                richTextBox1.ReadOnly = false;
                buttonEnre.Enabled = true;
            }
            richTextBox1.MaxLength = 1000;
        }


        private void buttonEnre_Click(object sender, EventArgs e)
        {
            var a = this.Parent as PanelCentral;
            _docX.Value = richTextBox1.Text;
            _parent.SaveXml();
            //_docX.Save("calendrier.xml");
        }
    }
}
