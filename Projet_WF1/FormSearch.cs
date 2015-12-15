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
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            var CB = sender as CheckBox;

            if(CB.Name=="Activité")
            {
                checkBoxCR.CheckState = CheckState.Unchecked;
                checkBoxDescr.CheckState = CheckState.Unchecked;
            }
            else if (CB.Name=="Description d'activité")
            {
                checkBoxAct.CheckState = CheckState.Unchecked;
                checkBoxCR.CheckState = CheckState.Unchecked;

            }
            else
            {
                checkBoxAct.CheckState = CheckState.Unchecked;
                checkBoxDescr.CheckState = CheckState.Unchecked;

            }
        }
    }
}
