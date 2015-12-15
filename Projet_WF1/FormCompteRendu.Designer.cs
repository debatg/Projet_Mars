namespace Projet_WF1
{
    partial class FormCompteRendu
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
            this.labelCompteRendu = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonEnre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCompteRendu
            // 
            this.labelCompteRendu.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCompteRendu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompteRendu.Location = new System.Drawing.Point(0, 0);
            this.labelCompteRendu.Name = "labelCompteRendu";
            this.labelCompteRendu.Size = new System.Drawing.Size(556, 18);
            this.labelCompteRendu.TabIndex = 0;
            this.labelCompteRendu.Text = "Compte rendu";
            this.labelCompteRendu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(532, 209);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // buttonEnre
            // 
            this.buttonEnre.Location = new System.Drawing.Point(236, 236);
            this.buttonEnre.Name = "buttonEnre";
            this.buttonEnre.Size = new System.Drawing.Size(75, 23);
            this.buttonEnre.TabIndex = 2;
            this.buttonEnre.Text = "Enregistrer";
            this.buttonEnre.UseVisualStyleBackColor = true;
            this.buttonEnre.Click += new System.EventHandler(this.buttonEnre_Click);
            // 
            // FormCompteRendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 266);
            this.Controls.Add(this.buttonEnre);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelCompteRendu);
            this.Name = "FormCompteRendu";
            this.Text = "FormCompteRendu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCompteRendu;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonEnre;
    }
}