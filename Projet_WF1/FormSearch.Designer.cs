namespace Projet_WF1
{
    partial class FormSearch
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.checkBoxAct = new System.Windows.Forms.CheckBox();
            this.checkBoxDescr = new System.Windows.Forms.CheckBox();
            this.checkBoxCR = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
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
            this.checkBoxAct.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxAct.Location = new System.Drawing.Point(157, 26);
            this.checkBoxAct.Name = "checkBoxAct";
            this.checkBoxAct.Size = new System.Drawing.Size(46, 31);
            this.checkBoxAct.TabIndex = 1;
            this.checkBoxAct.Text = "Activité";
            this.checkBoxAct.UseVisualStyleBackColor = true;
            this.checkBoxAct.Click += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxDescr
            // 
            this.checkBoxDescr.AutoSize = true;
            this.checkBoxDescr.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxDescr.Location = new System.Drawing.Point(234, 26);
            this.checkBoxDescr.Name = "checkBoxDescr";
            this.checkBoxDescr.Size = new System.Drawing.Size(107, 31);
            this.checkBoxDescr.TabIndex = 2;
            this.checkBoxDescr.Text = "Descripton d\'activité";
            this.checkBoxDescr.UseVisualStyleBackColor = true;
            this.checkBoxDescr.Click += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxCR
            // 
            this.checkBoxCR.AutoSize = true;
            this.checkBoxCR.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCR.Location = new System.Drawing.Point(363, 26);
            this.checkBoxCR.Name = "checkBoxCR";
            this.checkBoxCR.Size = new System.Drawing.Size(77, 28);
            this.checkBoxCR.TabIndex = 3;
            this.checkBoxCR.Text = "Compte-rendu";
            this.checkBoxCR.UseVisualStyleBackColor = true;
            this.checkBoxCR.Click += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 422);
            this.Controls.Add(this.checkBoxCR);
            this.Controls.Add(this.checkBoxDescr);
            this.Controls.Add(this.checkBoxAct);
            this.Controls.Add(this.treeView1);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckBox checkBoxAct;
        private System.Windows.Forms.CheckBox checkBoxDescr;
        private System.Windows.Forms.CheckBox checkBoxCR;
    }
}