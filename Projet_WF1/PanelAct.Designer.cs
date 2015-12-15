using System;
using System.Drawing;
using System.Windows.Forms;

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

            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textJour = new System.Windows.Forms.TextBox();
            this.textMin = new System.Windows.Forms.TextBox();
            this.btn_valid = new System.Windows.Forms.Button();
            this.textHeure = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureCroix = new System.Windows.Forms.PictureBox();
            this.labelCoord = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.labelAct = new System.Windows.Forms.Label();
            this.textBoxAct = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelAstro = new System.Windows.Forms.Label();
            this.textBoxHeureFin = new System.Windows.Forms.TextBox();
            this.textBoxMinfFin = new System.Windows.Forms.TextBox();
            this.labelHF = new System.Windows.Forms.Label();
            this.labelMF = new System.Windows.Forms.Label();
            this.richTextBoxDescript = new System.Windows.Forms.RichTextBox();
            this.labelDescipt = new System.Windows.Forms.Label();


            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCroix)).BeginInit();

            this.Controls.Add(this.textBoxAct);
            this.Controls.Add(this.labelAct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textJour);
            this.Controls.Add(this.textMin);
            this.Controls.Add(this.btn_valid);
            this.Controls.Add(this.textHeure);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelCoord);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.labelAstro);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelMF);
            this.Controls.Add(this.labelHF);
            this.Controls.Add(this.textBoxMinfFin);
            this.Controls.Add(this.textBoxHeureFin);
            this.Controls.Add(this.labelDescipt);
            this.Controls.Add(this.richTextBoxDescript);

            
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "heures";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Jour";
            // 
            // textJour
            // 
            this.textJour.Location = new System.Drawing.Point(243, 15);
            this.textJour.Name = "textJour";
            this.textJour.Size = new System.Drawing.Size(32, 20);
            this.textJour.TabIndex = 19;
            this.textJour.Text = "Jour";
            // 
            // textMin
            // 
            this.textMin.Location = new System.Drawing.Point(280, 43);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(24, 20);
            this.textMin.TabIndex = 18;
            this.textMin.Text = "Min";
            // 
            // btn_valid
            // 
            this.btn_valid.Location = new System.Drawing.Point(233, 387);
            this.btn_valid.Name = "btn_valid";
            this.btn_valid.Size = new System.Drawing.Size(75, 23);
            this.btn_valid.TabIndex = 17;
            this.btn_valid.Text = "Valider";
            this.btn_valid.UseVisualStyleBackColor = true;
            this.btn_valid.Click += new System.EventHandler(this.btn_valid_Click);
            // 
            // textHeure
            // 
            this.textHeure.Location = new System.Drawing.Point(213, 43);
            this.textHeure.Name = "textHeure";
            this.textHeure.Size = new System.Drawing.Size(24, 20);
            this.textHeure.TabIndex = 16;
            this.textHeure.Text = "H";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = Image.FromFile("images/nanedi valles.jpg");
            this.pictureBox1.Location = new System.Drawing.Point(371, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 410);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Controls.Add(pictureCroix);
            // 
            // pictureCroix
            // 
            this.pictureCroix.Image = Image.FromFile("images/cross106.png");
            this.pictureCroix.Location = new System.Drawing.Point(654, 144);
            this.pictureCroix.Name = "pictureCroix";
            this.pictureCroix.Size = new System.Drawing.Size(24, 24);
            this.pictureCroix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureCroix.TabIndex = 28;
            this.pictureCroix.TabStop = false;
            this.pictureCroix.Visible = false;
            this.pictureCroix.BackColor = Color.Transparent;
            // 
            // labelCoord
            // 
            this.labelCoord.AutoSize = true;
            this.labelCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoord.Location = new System.Drawing.Point(223, 172);
            this.labelCoord.Name = "labelCoord";
            this.labelCoord.Size = new System.Drawing.Size(81, 13);
            this.labelCoord.TabIndex = 29;
            this.labelCoord.Text = "Coordonnées";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(229, 191);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 13);
            this.labelX.TabIndex = 30;
            this.labelX.Text = "X";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(229, 218);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 13);
            this.labelY.TabIndex = 31;
            this.labelY.Text = "Y";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(259, 188);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(32, 20);
            this.textBoxX.TabIndex = 32;
            this.textBoxX.TextChanged += new System.EventHandler(this.textBoxCoord_TextChanged);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(259, 215);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(32, 20);
            this.textBoxY.TabIndex = 33;
            this.textBoxY.TextChanged += new System.EventHandler(this.textBoxCoord_TextChanged);

            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(180, 293);
            this.treeView1.TabIndex = 34;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // labelAct
            // 
            this.labelAct.AutoSize = true;
            this.labelAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAct.Location = new System.Drawing.Point(230, 113);
            this.labelAct.Name = "labelAct";
            this.labelAct.Size = new System.Drawing.Size(50, 13);
            this.labelAct.TabIndex = 35;
            this.labelAct.Text = "Activité";
            // 
            // textBoxAct
            // 
            this.textBoxAct.Location = new System.Drawing.Point(209, 129);
            this.textBoxAct.Name = "textBoxAct";
            this.textBoxAct.Size = new System.Drawing.Size(100, 20);
            this.textBoxAct.TabIndex = 36;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(213, 274);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 37;
            // 
            // labelAstro
            // 
            this.labelAstro.AutoSize = true;
            this.labelAstro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAstro.Location = new System.Drawing.Point(227, 258);
            this.labelAstro.Name = "labelAstro";
            this.labelAstro.Size = new System.Drawing.Size(74, 13);
            this.labelAstro.TabIndex = 38;
            this.labelAstro.Text = "Astronautes";
            // 
            // textBoxHeureFin
            // 
            this.textBoxHeureFin.Location = new System.Drawing.Point(210, 69);
            this.textBoxHeureFin.Name = "textBoxHeureFin";
            this.textBoxHeureFin.Size = new System.Drawing.Size(24, 20);
            this.textBoxHeureFin.TabIndex = 39;
            // 
            // textBoxMinfFin
            // 
            this.textBoxMinfFin.Location = new System.Drawing.Point(277, 74);
            this.textBoxMinfFin.Name = "textBoxMinfFin";
            this.textBoxMinfFin.Size = new System.Drawing.Size(29, 20);
            this.textBoxMinfFin.TabIndex = 40;
            // 
            // labelHF
            // 
            this.labelHF.AutoSize = true;
            this.labelHF.Location = new System.Drawing.Point(240, 75);
            this.labelHF.Name = "labelHF";
            this.labelHF.Size = new System.Drawing.Size(39, 13);
            this.labelHF.TabIndex = 41;
            this.labelHF.Text = "heures";
            // 
            // labelMF
            // 
            this.labelMF.AutoSize = true;
            this.labelMF.Location = new System.Drawing.Point(310, 80);
            this.labelMF.Name = "labelMF";
            this.labelMF.Size = new System.Drawing.Size(23, 13);
            this.labelMF.TabIndex = 42;
            this.labelMF.Text = "min";
            // 
            // richTextBoxDescript
            // 
            this.richTextBoxDescript.Location = new System.Drawing.Point(12, 441);
            this.richTextBoxDescript.Name = "richTextBoxDescript";
            this.richTextBoxDescript.Size = new System.Drawing.Size(577, 96);
            this.richTextBoxDescript.TabIndex = 43;
            this.richTextBoxDescript.Tag = "";
            this.richTextBoxDescript.Text = "";
            this.richTextBoxDescript.MaxLength=400;
            // 
            // labelDescipt
            // 
            this.labelDescipt.AutoSize = true;
            this.labelDescipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescipt.Location = new System.Drawing.Point(177, 425);
            this.labelDescipt.Name = "labelDescipt";
            this.labelDescipt.Size = new System.Drawing.Size(231, 13);
            this.labelDescipt.TabIndex = 44;
            this.labelDescipt.Text = "Description de l\'activité (400 mots Max)";


            foreach (Control C in Controls)
            {
                if (C is Button)
                {
                    var btn = C as Button;
                    btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
                    btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
            }

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCroix)).EndInit();
        }

        

        #endregion

        private System.Windows.Forms.TextBox textJour;
        private System.Windows.Forms.TextBox textMin;
        private System.Windows.Forms.Button btn_valid;
        private System.Windows.Forms.TextBox textHeure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDuree;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureCroix;
        private System.Windows.Forms.Label labelCoord;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label labelAct;
        private System.Windows.Forms.TextBox textBoxAct;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelAstro;
        private System.Windows.Forms.TextBox textBoxHeureFin;
        private System.Windows.Forms.TextBox textBoxMinfFin;
        private System.Windows.Forms.Label labelHF;
        private System.Windows.Forms.Label labelMF;
        private System.Windows.Forms.RichTextBox richTextBoxDescript;
        private System.Windows.Forms.Label labelDescipt;

    }
}
