using System.Windows.Forms;

namespace Projet_WF1
{
    partial class PanelSearch :PanelCentral
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
            components = new System.ComponentModel.Container();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.checkBoxAct = new System.Windows.Forms.CheckBox();
            this.checkBoxDescr = new System.Windows.Forms.CheckBox();
            this.checkBoxCR = new System.Windows.Forms.CheckBox();

            this.Controls.Add(treeView1);
            this.Controls.Add(this.checkBoxCR);
            this.Controls.Add(this.checkBoxDescr);
            this.Controls.Add(this.checkBoxAct);

            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(157, 64);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(294, 396);
            this.treeView1.TabIndex = 0;
            // 
            // checkBoxAct
            // 
            this.checkBoxAct.AutoSize = true;
            this.checkBoxAct.Location = new System.Drawing.Point(157, 26);
            this.checkBoxAct.Name = "checkBoxAct";
            this.checkBoxAct.Size = new System.Drawing.Size(61, 17);
            this.checkBoxAct.TabIndex = 1;
            this.checkBoxAct.Text = "Activité";
            this.checkBoxAct.UseVisualStyleBackColor = true;
            this.checkBoxAct.Click += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxDescr
            // 
            this.checkBoxDescr.AutoSize = true;
            this.checkBoxDescr.Location = new System.Drawing.Point(234, 26);
            this.checkBoxDescr.Name = "checkBoxDescr";
            this.checkBoxDescr.Size = new System.Drawing.Size(122, 17);
            this.checkBoxDescr.TabIndex = 2;
            this.checkBoxDescr.Text = "Descripton d\'activité";
            this.checkBoxDescr.UseVisualStyleBackColor = true;
            this.checkBoxDescr.Click += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxCR
            // 
            this.checkBoxCR.AutoSize = true;
            this.checkBoxCR.Location = new System.Drawing.Point(363, 26);
            this.checkBoxCR.Name = "checkBoxCR";
            this.checkBoxCR.Size = new System.Drawing.Size(92, 17);
            this.checkBoxCR.TabIndex = 3;
            this.checkBoxCR.Text = "Compte-rendu";
            this.checkBoxCR.UseVisualStyleBackColor = true;
            this.checkBoxCR.Click += new System.EventHandler(this.checkBox_CheckedChanged);


            foreach (Control C in Controls)
            {
                if (C is CheckBox)
                {
                    var CB = C as CheckBox;
                    CB.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
                    CB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
            }
            
        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckBox checkBoxAct;
        private System.Windows.Forms.CheckBox checkBoxDescr;
        private System.Windows.Forms.CheckBox checkBoxCR;

    }
}
