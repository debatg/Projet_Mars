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
    public partial class FormErreur : Form
    {
        public FormErreur()
        {
            InitializeComponent();
        }

        public void setMessage(string txt)
        {
            labelMessage.Text = txt;
        }
    }
}
