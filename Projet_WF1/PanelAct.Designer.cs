namespace Projet_WF1
{
    partial class PanelAct
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

            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textDuree = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textJour = new System.Windows.Forms.TextBox();
            this.textMin = new System.Windows.Forms.TextBox();
            this.btn_valid = new System.Windows.Forms.Button();
            this.textHeure = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();


            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textDuree);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textJour);
            this.Controls.Add(this.textMin);
            this.Controls.Add(this.btn_valid);
            this.Controls.Add(this.textHeure);
            this.Controls.Add(this.listBox1);


            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Durée";
            // 
            // textDuree
            // 
            this.textDuree.Location = new System.Drawing.Point(282, 269);
            this.textDuree.Name = "textDuree";
            this.textDuree.Size = new System.Drawing.Size(27, 20);
            this.textDuree.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "heures";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Jour";
            // 
            // textJour
            // 
            this.textJour.Location = new System.Drawing.Point(273, 218);
            this.textJour.Name = "textJour";
            this.textJour.Size = new System.Drawing.Size(32, 20);
            this.textJour.TabIndex = 19;
            this.textJour.Text = "Jour";
            // 
            // textMin
            // 
            this.textMin.Location = new System.Drawing.Point(310, 246);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(24, 20);
            this.textMin.TabIndex = 18;
            this.textMin.Text = "Min";
            // 
            // btn_valid
            // 
            this.btn_valid.Location = new System.Drawing.Point(259, 295);
            this.btn_valid.Name = "btn_valid";
            this.btn_valid.Size = new System.Drawing.Size(75, 23);
            this.btn_valid.TabIndex = 17;
            this.btn_valid.Text = "Valider";
            this.btn_valid.UseVisualStyleBackColor = true;
            this.btn_valid.Click += new System.EventHandler(this.btn_valid_Click);
            // 
            // textHeure
            // 
            this.textHeure.Location = new System.Drawing.Point(243, 246);
            this.textHeure.Name = "textHeure";
            this.textHeure.Size = new System.Drawing.Size(24, 20);
            this.textHeure.TabIndex = 16;
            this.textHeure.Text = "H";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(243, 108);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(106, 95);
            this.listBox1.TabIndex = 15;
        }

        #endregion

        private System.Windows.Forms.TextBox textJour;
        private System.Windows.Forms.TextBox textMin;
        private System.Windows.Forms.Button btn_valid;
        private System.Windows.Forms.TextBox textHeure;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDuree;


    }
}
