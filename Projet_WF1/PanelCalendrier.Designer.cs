using System.Collections.Generic;
using System.Windows.Forms;

namespace Projet_WF1
{
    partial class PanelCalendrier
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

            this.panel_calendrier = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_51_60 = new System.Windows.Forms.Button();
            this.bt_61_70 = new System.Windows.Forms.Button();
            this.bt_71_80 = new System.Windows.Forms.Button();
            this.bt_81_90 = new System.Windows.Forms.Button();
            this.bt_91_100 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_1_10 = new System.Windows.Forms.Button();
            this.bt_11_20 = new System.Windows.Forms.Button();
            this.bt_21_30 = new System.Windows.Forms.Button();
            this.bt_31_40 = new System.Windows.Forms.Button();
            this.bt_41_50 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_1_100 = new System.Windows.Forms.Button();
            this.bt_101_200 = new System.Windows.Forms.Button();
            this.bt_201_300 = new System.Windows.Forms.Button();
            this.bt_301_400 = new System.Windows.Forms.Button();
            this.bt_401_500 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.panel_calendrier.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            bttn_jour = new List<Button>();
            btn_cent = new List<Button>();
            btn_dix = new List<Button>();

            this.Controls.Add(flowLayoutPanel1);
            this.Controls.Add(flowLayoutPanel2);
            this.Controls.Add(flowLayoutPanel3);
            this.Controls.Add(panel_calendrier);



            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.bt_51_60);
            this.flowLayoutPanel3.Controls.Add(this.bt_61_70);
            this.flowLayoutPanel3.Controls.Add(this.bt_71_80);
            this.flowLayoutPanel3.Controls.Add(this.bt_81_90);
            this.flowLayoutPanel3.Controls.Add(this.bt_91_100);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 79);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(659, 29);
            this.flowLayoutPanel3.TabIndex = 13;

            // 
            // bt_51_60
            // 
            this.bt_51_60.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_51_60.Location = new System.Drawing.Point(3, 3);
            this.bt_51_60.Name = "bt_51_60";
            this.bt_51_60.Size = new System.Drawing.Size(125, 23);
            this.bt_51_60.TabIndex = 5;
            this.bt_51_60.Text = "51 - 60";
            this.bt_51_60.UseVisualStyleBackColor = false;
            this.bt_51_60.Click += new System.EventHandler(this.bt_dix_Click);
            // 
            // bt_61_70
            // 
            this.bt_61_70.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_61_70.Location = new System.Drawing.Point(134, 3);
            this.bt_61_70.Name = "bt_61_70";
            this.bt_61_70.Size = new System.Drawing.Size(125, 23);
            this.bt_61_70.TabIndex = 6;
            this.bt_61_70.Text = "61 - 70";
            this.bt_61_70.UseVisualStyleBackColor = false;
            this.bt_61_70.Click += new System.EventHandler(this.bt_dix_Click);
            // 
            // bt_71_80
            // 
            this.bt_71_80.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_71_80.Location = new System.Drawing.Point(265, 3);
            this.bt_71_80.Name = "bt_71_80";
            this.bt_71_80.Size = new System.Drawing.Size(125, 23);
            this.bt_71_80.TabIndex = 7;
            this.bt_71_80.Text = "71 - 80";
            this.bt_71_80.UseVisualStyleBackColor = false;
            this.bt_71_80.Click += new System.EventHandler(this.bt_dix_Click);
            // 
            // bt_81_90
            // 
            this.bt_81_90.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_81_90.Location = new System.Drawing.Point(396, 3);
            this.bt_81_90.Name = "bt_81_90";
            this.bt_81_90.Size = new System.Drawing.Size(125, 23);
            this.bt_81_90.TabIndex = 8;
            this.bt_81_90.Text = "81 - 90";
            this.bt_81_90.UseVisualStyleBackColor = false;
            this.bt_81_90.Click += new System.EventHandler(this.bt_dix_Click);
            // 
            // bt_91_100
            // 
            this.bt_91_100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_91_100.Location = new System.Drawing.Point(527, 3);
            this.bt_91_100.Name = "bt_91_100";
            this.bt_91_100.Size = new System.Drawing.Size(125, 23);
            this.bt_91_100.TabIndex = 9;
            this.bt_91_100.Text = "91 - 100";
            this.bt_91_100.UseVisualStyleBackColor = false;
            this.bt_91_100.Click += new System.EventHandler(this.bt_dix_Click);

            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.bt_1_10);
            this.flowLayoutPanel2.Controls.Add(this.bt_11_20);
            this.flowLayoutPanel2.Controls.Add(this.bt_21_30);
            this.flowLayoutPanel2.Controls.Add(this.bt_31_40);
            this.flowLayoutPanel2.Controls.Add(this.bt_41_50);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(659, 29);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // bt_1_10
            // 
            this.bt_1_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_1_10.Location = new System.Drawing.Point(3, 3);
            this.bt_1_10.Name = "bt_1_10";
            this.bt_1_10.Size = new System.Drawing.Size(125, 23);
            this.bt_1_10.TabIndex = 0;
            this.bt_1_10.Text = "1 - 10";
            this.bt_1_10.UseVisualStyleBackColor = false;
            this.bt_1_10.Click += new System.EventHandler(this.bt_dix_Click);
            // 
            // bt_11_20
            // 
            this.bt_11_20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_11_20.Location = new System.Drawing.Point(134, 3);
            this.bt_11_20.Name = "bt_11_20";
            this.bt_11_20.Size = new System.Drawing.Size(125, 23);
            this.bt_11_20.TabIndex = 1;
            this.bt_11_20.Text = "11 - 20";
            this.bt_11_20.UseVisualStyleBackColor = false;
            this.bt_11_20.Click += new System.EventHandler(this.bt_dix_Click);
            // 
            // bt_21_30
            // 
            this.bt_21_30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_21_30.Location = new System.Drawing.Point(265, 3);
            this.bt_21_30.Name = "bt_21_30";
            this.bt_21_30.Size = new System.Drawing.Size(125, 23);
            this.bt_21_30.TabIndex = 2;
            this.bt_21_30.Text = "21 - 30";
            this.bt_21_30.UseVisualStyleBackColor = false;
            this.bt_21_30.Click += new System.EventHandler(this.bt_dix_Click);
            // 
            // bt_31_40
            // 
            this.bt_31_40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_31_40.Location = new System.Drawing.Point(396, 3);
            this.bt_31_40.Name = "bt_31_40";
            this.bt_31_40.Size = new System.Drawing.Size(125, 23);
            this.bt_31_40.TabIndex = 3;
            this.bt_31_40.Text = "31 - 40";
            this.bt_31_40.UseVisualStyleBackColor = false;
            this.bt_31_40.Click += new System.EventHandler(this.bt_dix_Click);
            // 
            // bt_41_50
            // 
            this.bt_41_50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_41_50.Location = new System.Drawing.Point(527, 3);
            this.bt_41_50.Name = "bt_41_50";
            this.bt_41_50.Size = new System.Drawing.Size(125, 23);
            this.bt_41_50.TabIndex = 4;
            this.bt_41_50.Text = "41 - 50";
            this.bt_41_50.UseVisualStyleBackColor = false;
            this.bt_41_50.Click += new System.EventHandler(this.bt_dix_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bt_1_100);
            this.flowLayoutPanel1.Controls.Add(this.bt_101_200);
            this.flowLayoutPanel1.Controls.Add(this.bt_201_300);
            this.flowLayoutPanel1.Controls.Add(this.bt_301_400);
            this.flowLayoutPanel1.Controls.Add(this.bt_401_500);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(659, 46);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // bt_1_100
            // 
            this.bt_1_100.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_1_100.Location = new System.Drawing.Point(3, 3);
            this.bt_1_100.Name = "bt_1_100";
            this.bt_1_100.Size = new System.Drawing.Size(125, 41);
            this.bt_1_100.TabIndex = 0;
            this.bt_1_100.Text = "1 - 100";
            this.bt_1_100.UseVisualStyleBackColor = false;
            this.bt_1_100.Click += new System.EventHandler(this.bt_cent_Click);
            
            // 
            // bt_101_200
            // 
            this.bt_101_200.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_101_200.Location = new System.Drawing.Point(134, 3);
            this.bt_101_200.Name = "bt_101_200";
            this.bt_101_200.Size = new System.Drawing.Size(125, 41);
            this.bt_101_200.TabIndex = 1;
            this.bt_101_200.Text = "101 - 200";
            this.bt_101_200.UseVisualStyleBackColor = false;
            this.bt_101_200.Click += new System.EventHandler(this.bt_cent_Click);
            // 
            // bt_201_300
            // 
            this.bt_201_300.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_201_300.Location = new System.Drawing.Point(265, 3);
            this.bt_201_300.Name = "bt_201_300";
            this.bt_201_300.Size = new System.Drawing.Size(125, 41);
            this.bt_201_300.TabIndex = 2;
            this.bt_201_300.Text = "201 - 300";
            this.bt_201_300.UseVisualStyleBackColor = false;
            this.bt_201_300.Click += new System.EventHandler(this.bt_cent_Click);
            // 
            // bt_301_400
            // 
            this.bt_301_400.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_301_400.Location = new System.Drawing.Point(396, 3);
            this.bt_301_400.Name = "bt_301_400";
            this.bt_301_400.Size = new System.Drawing.Size(125, 41);
            this.bt_301_400.TabIndex = 3;
            this.bt_301_400.Text = "301 - 400";
            this.bt_301_400.UseVisualStyleBackColor = false;
            this.bt_301_400.Click += new System.EventHandler(this.bt_cent_Click);
            // 
            // bt_401_500
            // 
            
            this.bt_401_500.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_401_500.Location = new System.Drawing.Point(527, 3);
            this.bt_401_500.Name = "bt_401_500";
            this.bt_401_500.Size = new System.Drawing.Size(125, 41);
            this.bt_401_500.TabIndex = 4;
            this.bt_401_500.Text = "401 - 500";
            this.bt_401_500.UseVisualStyleBackColor = false;
            this.bt_401_500.Click += new System.EventHandler(this.bt_cent_Click);
            // 
            // panel_calendrier
            // 
            this.panel_calendrier.Controls.Add(this.button10);
            this.panel_calendrier.Controls.Add(this.button9);
            this.panel_calendrier.Controls.Add(this.button8);
            this.panel_calendrier.Controls.Add(this.button7);
            this.panel_calendrier.Controls.Add(this.button6);
            this.panel_calendrier.Controls.Add(this.button5);
            this.panel_calendrier.Controls.Add(this.button4);
            this.panel_calendrier.Controls.Add(this.button3);
            this.panel_calendrier.Controls.Add(this.button2);
            this.panel_calendrier.Controls.Add(this.button1);
            this.panel_calendrier.Location = new System.Drawing.Point(0, 133);
            this.panel_calendrier.Name = "panel_calendrier";
            this.panel_calendrier.Size = new System.Drawing.Size(659, 344);
            this.panel_calendrier.TabIndex = 7;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 42);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(125, 115);
            this.button10.TabIndex = 9;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.bttn_Jour_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(137, 42);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(125, 115);
            this.button9.TabIndex = 8;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.bttn_Jour_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(268, 42);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 115);
            this.button8.TabIndex = 7;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.bttn_Jour_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(399, 42);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 115);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.bttn_Jour_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(530, 42);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 115);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.bttn_Jour_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 181);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 115);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.bttn_Jour_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(137, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 115);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.bttn_Jour_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 115);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.bttn_Jour_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 115);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.bttn_Jour_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 115);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bttn_Jour_Click);

            this.btn_dix.Add(bt_11_20);
            this.btn_dix.Add(bt_21_30);
            this.btn_dix.Add(bt_1_10);
            this.btn_dix.Add(bt_31_40);
            this.btn_dix.Add(bt_41_50);
            this.btn_dix.Add(bt_51_60);
            this.btn_dix.Add(bt_61_70);
            this.btn_dix.Add(bt_71_80);
            this.btn_dix.Add(bt_81_90);
            this.btn_dix.Add(bt_91_100);

            this.btn_cent.Add(bt_1_100);
            this.btn_cent.Add(bt_101_200);
            this.btn_cent.Add(bt_201_300);
            this.btn_cent.Add(bt_301_400);
            this.btn_cent.Add(bt_401_500);

            this.ResumeLayout(false);
            this.Visible=true;
            this.panel_calendrier.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion
        private System.Windows.Forms.Panel panel_calendrier;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_1_100;
        private System.Windows.Forms.Button bt_101_200;
        private System.Windows.Forms.Button bt_201_300;
        private System.Windows.Forms.Button bt_301_400;
        private System.Windows.Forms.Button bt_401_500;
        private System.Windows.Forms.Button bt_1_10;
        private System.Windows.Forms.Button bt_11_20;
        private System.Windows.Forms.Button bt_21_30;
        private System.Windows.Forms.Button bt_31_40;
        private System.Windows.Forms.Button bt_41_50;
        private System.Windows.Forms.Button bt_51_60;
        private System.Windows.Forms.Button bt_61_70;
        private System.Windows.Forms.Button bt_71_80;
        private System.Windows.Forms.Button bt_81_90;
        private System.Windows.Forms.Button bt_91_100;
        private System.Windows.Forms.TabPage btn_Next;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private List<Button> bttn_jour, btn_dix, btn_cent;

    }
}
