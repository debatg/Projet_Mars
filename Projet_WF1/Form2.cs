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
        public Form2()
        {
            InitializeComponent();
            // Point P = dataGridView1.GetCellDisplayRectangle(0, 1, false).Location;
            int X = (dataGridView1.Size.Width * 2 / 7);
            int Y=(dataGridView1.Size.Height * 3 / dataGridView1.RowCount);
            Point P = new Point(1, 1);
            // Size S = new Size(dataGridView1.Rows[1].Cells[1].Size.Width , dataGridView1.Rows[1].Cells[1].Size.Height);
            Size S = new Size(dataGridView1.Width*3/7, dataGridView1.Rows[0].Height+1);
            Rectangle r = new Rectangle(P, S);
            
            Button B = new Button();
                B.Size = S;
            B.Location = P;
            //Panel r = new Panel();
            dataGridView1.Controls.Add(B);
            //r.Location = P;
            //r.Size = S;
            //r.Controls.Add(new Button());
            //dataGridView1.Visible = false;
            ButtonRenderer.DrawButton(this.CreateGraphics(), r, "test", new Font("Arial", 10, FontStyle.Regular), true, System.Windows.Forms.VisualStyles.PushButtonState.Pressed);
            label1.Text = dataGridView1.GetCellDisplayRectangle(0, 0, true).Left.ToString();
        }
    }
}
