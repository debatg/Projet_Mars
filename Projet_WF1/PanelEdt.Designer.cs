using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Projet_WF1
{
    partial class PanelEdt : PanelCentral
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelEdt));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bttn_Supprimer = new System.Windows.Forms.Button();
            this.bttn_modif_inser = new System.Windows.Forms.Button();
            this.LB = new List<Button>();
            this.btn_Previous = new System.Windows.Forms.PictureBox();
            this.btn_Next = new System.Windows.Forms.PictureBox();

            this.Controls.Add(dataGridView1);
            this.Controls.Add(label1);
            this.Controls.Add(this.bttn_modif_inser);
            this.Controls.Add(this.bttn_Supprimer);
            this.Controls.Add(btn_Next);
            this.Controls.Add(btn_Previous);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Previous)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Next)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(586, 470);
            this.dataGridView1.ScrollBars = ScrollBars.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowCount = 26;
            this.dataGridView1.ColumnCount = 7;
            this.dataGridView1.AutoResizeColumnHeadersHeight();
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = (dataGridView1.Height) / 26;
            }
            for (int i = 1; i < 26; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = ((i - 1).ToString() + "H");
            }
            for (int i = 1; i < 7; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = ((i - 1).ToString() + "0-" + i.ToString() + "0Min");
            }
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.AutoResizeRowHeadersWidth(System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // bttn_Supprimer
            // 
            this.bttn_Supprimer.Location = new System.Drawing.Point(592, 260);
            this.bttn_Supprimer.Name = "bttn_Supprimer";
            this.bttn_Supprimer.Size = new System.Drawing.Size(92, 23);
            this.bttn_Supprimer.TabIndex = 16;
            this.bttn_Supprimer.Text = "Supprimer";
            this.bttn_Supprimer.UseVisualStyleBackColor = true;
            // 
            // bttn_modif_inser
            // 
            this.bttn_modif_inser.Location = new System.Drawing.Point(592, 217);
            this.bttn_modif_inser.Name = "bttn_modif_inser";
            this.bttn_modif_inser.Size = new System.Drawing.Size(92, 23);
            this.bttn_modif_inser.TabIndex = 15;
            this.bttn_modif_inser.Text = "Modifier/Insérer";
            this.bttn_modif_inser.UseVisualStyleBackColor = true;
            this.bttn_modif_inser.Click += new System.EventHandler(this.bttn_modif_inser_Click);
            // 
            // btn_Previous
            // 
            //this.btn_Previous.Image = ((System.Drawing.Image)(resources.GetObject("btn_Previous.Image")));
            this.btn_Previous.Image = Image.FromFile("images/arrowhead7.png");

            this.btn_Previous.Location = new System.Drawing.Point(166, 476);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(50, 50);
            this.btn_Previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Previous.TabIndex = 18;
            this.btn_Previous.TabStop = false;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Next
            // 
            //this.btn_Next.Image = ((System.Drawing.Image)(resources.GetObject("btn_Next.Image")));
            this.btn_Next.Image = Image.FromFile("images/right-arrow26.png");
            this.btn_Next.Location = new System.Drawing.Point(287, 476);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(50, 50);
            this.btn_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Next.TabIndex = 19;
            this.btn_Next.TabStop = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // Form2
            // 
            this.Location = new Point(114, 8);
            //this.Size = new Size(589, 422);
            this.Visible = true;
            /*this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();*/
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Previous)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Next)).EndInit();

        }
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttn_Supprimer;
        private System.Windows.Forms.Button bttn_modif_inser;
        private List<Button> LB;
        private PictureBox btn_Previous;
        private PictureBox btn_Next;

        #endregion
    }
}
