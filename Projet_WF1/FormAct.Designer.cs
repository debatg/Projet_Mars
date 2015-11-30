using System;

namespace Projet_WF1
{
    partial class FormAct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAct));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureCroix = new System.Windows.Forms.PictureBox();
            this.labelCoord = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCroix)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Durée";
            // 
            // textDuree
            // 
            this.textDuree.Location = new System.Drawing.Point(168, 206);
            this.textDuree.Name = "textDuree";
            this.textDuree.Size = new System.Drawing.Size(27, 20);
            this.textDuree.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "heures";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Jour";
            // 
            // textJour
            // 
            this.textJour.Location = new System.Drawing.Point(159, 155);
            this.textJour.Name = "textJour";
            this.textJour.Size = new System.Drawing.Size(32, 20);
            this.textJour.TabIndex = 19;
            this.textJour.Text = "Jour";
            // 
            // textMin
            // 
            this.textMin.Location = new System.Drawing.Point(196, 183);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(24, 20);
            this.textMin.TabIndex = 18;
            this.textMin.Text = "Min";
            // 
            // btn_valid
            // 
            this.btn_valid.Location = new System.Drawing.Point(145, 232);
            this.btn_valid.Name = "btn_valid";
            this.btn_valid.Size = new System.Drawing.Size(75, 23);
            this.btn_valid.TabIndex = 17;
            this.btn_valid.Text = "Valider";
            this.btn_valid.UseVisualStyleBackColor = true;
            this.btn_valid.Click += new System.EventHandler(this.btn_valid_Click);
            // 
            // textHeure
            // 
            this.textHeure.Location = new System.Drawing.Point(129, 183);
            this.textHeure.Name = "textHeure";
            this.textHeure.Size = new System.Drawing.Size(24, 20);
            this.textHeure.TabIndex = 16;
            this.textHeure.Text = "H";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(129, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(106, 95);
            this.listBox1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(335, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 410);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureCroix
            // 
            this.pictureCroix.Location = new System.Drawing.Point(654, 144);
            this.pictureCroix.Name = "pictureCroix";
            this.pictureCroix.Size = new System.Drawing.Size(24, 24);
            this.pictureCroix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureCroix.TabIndex = 28;
            this.pictureCroix.TabStop = false;
            // 
            // labelCoord
            // 
            this.labelCoord.AutoSize = true;
            this.labelCoord.Location = new System.Drawing.Point(142, 277);
            this.labelCoord.Name = "labelCoord";
            this.labelCoord.Size = new System.Drawing.Size(70, 13);
            this.labelCoord.TabIndex = 29;
            this.labelCoord.Text = "Coordonnées";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(129, 305);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 13);
            this.labelX.TabIndex = 30;
            this.labelX.Text = "X";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(129, 332);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 13);
            this.labelY.TabIndex = 31;
            this.labelY.Text = "Y";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(159, 302);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(32, 20);
            this.textBoxX.TabIndex = 32;
            this.textBoxX.TextChanged += new System.EventHandler(this.textBoxX_TextChanged);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(159, 329);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(32, 20);
            this.textBoxY.TabIndex = 33;
            // 
            // FormAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 694);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelCoord);
            this.Controls.Add(this.pictureCroix);
            this.Controls.Add(this.pictureBox1);
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
            this.Name = "FormAct";
            this.Text = "FormAct";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCroix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_valid_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureCroix;
        private System.Windows.Forms.Label labelCoord;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
    }
}