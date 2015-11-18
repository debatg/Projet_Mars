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
    public partial class Form2 : Form
    {
        private List<Button> Lt = new List<Button>();
        public Form2()
        {
            InitializeComponent();
            int i = 0;
            while (i < 100)
            {
                Button btn = new Button();
                btn.Height = 20;
                btn.Width = 20;
                flowLayoutPanel1.Controls.Add(btn);
                i++;
            }

        }

      

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
