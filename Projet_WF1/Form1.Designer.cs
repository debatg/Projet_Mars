namespace Projet_WF1
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel_calendrier = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownHaut = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownPetit = new System.Windows.Forms.NumericUpDown();
            this.btnExplor = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonJour = new System.Windows.Forms.Button();
            this.textBoxJour = new System.Windows.Forms.TextBox();
            this.labelJour = new System.Windows.Forms.Label();
            this.buttonAct = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHaut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPetit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // panel_calendrier
            // 
            this.panel_calendrier.Location = new System.Drawing.Point(0, 0);
            this.panel_calendrier.Name = "panel_calendrier";
            this.panel_calendrier.Size = new System.Drawing.Size(200, 100);
            this.panel_calendrier.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(175, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 548);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.numericUpDownHaut);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.numericUpDownPetit);
            this.panel2.Controls.Add(this.btnExplor);
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Controls.Add(this.labelSearch);
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Controls.Add(this.buttonJour);
            this.panel2.Controls.Add(this.textBoxJour);
            this.panel2.Controls.Add(this.labelJour);
            this.panel2.Controls.Add(this.buttonAct);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 548);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Jour";
            // 
            // numericUpDownHaut
            // 
            this.numericUpDownHaut.Location = new System.Drawing.Point(102, 390);
            this.numericUpDownHaut.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownHaut.Name = "numericUpDownHaut";
            this.numericUpDownHaut.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownHaut.TabIndex = 11;
            this.numericUpDownHaut.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "à";
            // 
            // numericUpDownPetit
            // 
            this.numericUpDownPetit.Location = new System.Drawing.Point(37, 390);
            this.numericUpDownPetit.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownPetit.Name = "numericUpDownPetit";
            this.numericUpDownPetit.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownPetit.TabIndex = 9;
            // 
            // btnExplor
            // 
            this.btnExplor.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnExplor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExplor.Location = new System.Drawing.Point(26, 508);
            this.btnExplor.Name = "btnExplor";
            this.btnExplor.Size = new System.Drawing.Size(108, 23);
            this.btnExplor.TabIndex = 8;
            this.btnExplor.Text = "Exploration";
            this.btnExplor.UseVisualStyleBackColor = true;
            this.btnExplor.Click += new System.EventHandler(this.btnExplor_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(44, 416);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Rechercher";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(17, 342);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(125, 13);
            this.labelSearch.TabIndex = 6;
            this.labelSearch.Text = "Recherche d\'activité";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(20, 358);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(122, 20);
            this.textBoxSearch.TabIndex = 5;
            // 
            // buttonJour
            // 
            this.buttonJour.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonJour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJour.Location = new System.Drawing.Point(26, 258);
            this.buttonJour.Name = "buttonJour";
            this.buttonJour.Size = new System.Drawing.Size(108, 23);
            this.buttonJour.TabIndex = 4;
            this.buttonJour.Text = "Aller à";
            this.buttonJour.UseVisualStyleBackColor = true;
            this.buttonJour.Click += new System.EventHandler(this.buttonJour_Click);
            // 
            // textBoxJour
            // 
            this.textBoxJour.Location = new System.Drawing.Point(54, 232);
            this.textBoxJour.Name = "textBoxJour";
            this.textBoxJour.Size = new System.Drawing.Size(54, 20);
            this.textBoxJour.TabIndex = 3;
            // 
            // labelJour
            // 
            this.labelJour.AutoSize = true;
            this.labelJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJour.Location = new System.Drawing.Point(17, 235);
            this.labelJour.Name = "labelJour";
            this.labelJour.Size = new System.Drawing.Size(31, 13);
            this.labelJour.TabIndex = 2;
            this.labelJour.Text = "Jour";
            // 
            // buttonAct
            // 
            this.buttonAct.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAct.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAct.Location = new System.Drawing.Point(26, 132);
            this.buttonAct.Name = "buttonAct";
            this.buttonAct.Size = new System.Drawing.Size(108, 53);
            this.buttonAct.TabIndex = 1;
            this.buttonAct.Text = "Ajouter une activité";
            this.buttonAct.UseVisualStyleBackColor = false;
            this.buttonAct.Click += new System.EventHandler(this.buttonAct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 17);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 572);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHaut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPetit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_calendrier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAct;
        private System.Windows.Forms.Button buttonJour;
        private System.Windows.Forms.TextBox textBoxJour = new System.Windows.Forms.TextBox();
        private System.Windows.Forms.Label labelJour;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnExplor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownHaut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownPetit;
        private System.Windows.Forms.Button button1;
    }
}

