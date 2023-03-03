namespace NewProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            BtEffacer = new Button();
            BtAjouter = new Button();
            Rb20 = new RadioButton();
            Rb7 = new RadioButton();
            label3 = new Label();
            TbQte = new TextBox();
            TbPrix = new TextBox();
            TbDes = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Desingiation = new Label();
            Lv = new ListView();
            LvDesigiation = new ColumnHeader();
            LvPU = new ColumnHeader();
            LvQte = new ColumnHeader();
            LvMHT = new ColumnHeader();
            LvMTVA = new ColumnHeader();
            LvTTC = new ColumnHeader();
            BtSupprimer = new Button();
            BtModifier = new Button();
            BtQuitter = new Button();
            TbNET = new TextBox();
            TbTTVA = new TextBox();
            TbTHT = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtEffacer);
            groupBox1.Controls.Add(BtAjouter);
            groupBox1.Controls.Add(Rb20);
            groupBox1.Controls.Add(Rb7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TbQte);
            groupBox1.Controls.Add(TbPrix);
            groupBox1.Controls.Add(TbDes);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Desingiation);
            groupBox1.Location = new Point(22, 16);
            groupBox1.Margin = new Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 1, 2, 1);
            groupBox1.Size = new Size(877, 137);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Article";
            // 
            // BtEffacer
            // 
            BtEffacer.Location = new Point(574, 83);
            BtEffacer.Name = "BtEffacer";
            BtEffacer.Size = new Size(100, 22);
            BtEffacer.TabIndex = 10;
            BtEffacer.Text = "Effacer";
            BtEffacer.UseVisualStyleBackColor = true;
            BtEffacer.Click += BtEffacer_Click;
            // 
            // BtAjouter
            // 
            BtAjouter.BackColor = SystemColors.ButtonHighlight;
            BtAjouter.FlatAppearance.BorderColor = Color.Green;
            BtAjouter.FlatAppearance.MouseDownBackColor = Color.GreenYellow;
            BtAjouter.FlatAppearance.MouseOverBackColor = Color.Green;
            BtAjouter.ForeColor = Color.Black;
            BtAjouter.Location = new Point(468, 82);
            BtAjouter.Name = "BtAjouter";
            BtAjouter.Size = new Size(100, 22);
            BtAjouter.TabIndex = 9;
            BtAjouter.Text = "Ajouter";
            BtAjouter.UseVisualStyleBackColor = false;
            BtAjouter.Click += BtAjouter_Click;
            // 
            // Rb20
            // 
            Rb20.AutoSize = true;
            Rb20.Location = new Point(623, 31);
            Rb20.Margin = new Padding(3, 2, 3, 2);
            Rb20.Name = "Rb20";
            Rb20.Size = new Size(47, 19);
            Rb20.TabIndex = 8;
            Rb20.TabStop = true;
            Rb20.Text = "20%";
            Rb20.UseVisualStyleBackColor = true;
            // 
            // Rb7
            // 
            Rb7.AutoSize = true;
            Rb7.Location = new Point(507, 32);
            Rb7.Margin = new Padding(3, 2, 3, 2);
            Rb7.Name = "Rb7";
            Rb7.Size = new Size(41, 19);
            Rb7.TabIndex = 7;
            Rb7.TabStop = true;
            Rb7.Text = "7%";
            Rb7.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(432, 33);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.MaximumSize = new Size(150, 20);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 6;
            label3.Text = "TVA";
            // 
            // TbQte
            // 
            TbQte.BackColor = Color.LavenderBlush;
            TbQte.Location = new Point(142, 83);
            TbQte.Name = "TbQte";
            TbQte.Size = new Size(169, 23);
            TbQte.TabIndex = 5;
            // 
            // TbPrix
            // 
            TbPrix.BackColor = Color.LavenderBlush;
            TbPrix.Location = new Point(142, 56);
            TbPrix.Name = "TbPrix";
            TbPrix.Size = new Size(169, 23);
            TbPrix.TabIndex = 4;
            // 
            // TbDes
            // 
            TbDes.BackColor = Color.LavenderBlush;
            TbDes.ForeColor = SystemColors.WindowText;
            TbDes.Location = new Point(142, 30);
            TbDes.Name = "TbDes";
            TbDes.Size = new Size(169, 23);
            TbDes.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(32, 86);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.MaximumSize = new Size(150, 20);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Quantite";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(32, 59);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.MaximumSize = new Size(150, 20);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Prix untaire HT";
            // 
            // Desingiation
            // 
            Desingiation.AutoSize = true;
            Desingiation.ForeColor = Color.Black;
            Desingiation.Location = new Point(32, 33);
            Desingiation.Margin = new Padding(2, 0, 2, 0);
            Desingiation.MaximumSize = new Size(150, 20);
            Desingiation.Name = "Desingiation";
            Desingiation.Size = new Size(66, 15);
            Desingiation.TabIndex = 0;
            Desingiation.Text = "Desigiation";
            // 
            // Lv
            // 
            Lv.BackColor = Color.LavenderBlush;
            Lv.Columns.AddRange(new ColumnHeader[] { LvDesigiation, LvPU, LvQte, LvMHT, LvMTVA, LvTTC });
            Lv.GridLines = true;
            Lv.Location = new Point(22, 157);
            Lv.Name = "Lv";
            Lv.Size = new Size(877, 198);
            Lv.TabIndex = 1;
            Lv.TileSize = new Size(200, 30);
            Lv.UseCompatibleStateImageBehavior = false;
            Lv.View = View.Details;
            // 
            // LvDesigiation
            // 
            LvDesigiation.Text = "Desigiation";
            LvDesigiation.Width = 350;
            // 
            // LvPU
            // 
            LvPU.Text = "Prix Unitaire";
            LvPU.Width = 250;
            // 
            // LvQte
            // 
            LvQte.Text = "Quantite";
            LvQte.Width = 200;
            // 
            // LvMHT
            // 
            LvMHT.Text = "Montant HT";
            LvMHT.Width = 250;
            // 
            // LvMTVA
            // 
            LvMTVA.Text = "MTVA";
            LvMTVA.Width = 250;
            // 
            // LvTTC
            // 
            LvTTC.Text = "TTC";
            LvTTC.Width = 270;
            // 
            // BtSupprimer
            // 
            BtSupprimer.Location = new Point(164, 371);
            BtSupprimer.Name = "BtSupprimer";
            BtSupprimer.Size = new Size(100, 30);
            BtSupprimer.TabIndex = 11;
            BtSupprimer.Text = "Supprimer";
            BtSupprimer.UseVisualStyleBackColor = true;
            BtSupprimer.Click += BtSupprimer_Click;
            // 
            // BtModifier
            // 
            BtModifier.Location = new Point(417, 371);
            BtModifier.Name = "BtModifier";
            BtModifier.Size = new Size(100, 30);
            BtModifier.TabIndex = 12;
            BtModifier.Text = "Modifier";
            BtModifier.UseVisualStyleBackColor = true;
            BtModifier.Click += BtModifier_Click;
            // 
            // BtQuitter
            // 
            BtQuitter.Location = new Point(665, 371);
            BtQuitter.Name = "BtQuitter";
            BtQuitter.Size = new Size(100, 30);
            BtQuitter.TabIndex = 13;
            BtQuitter.Text = "Quitter";
            BtQuitter.UseVisualStyleBackColor = true;
            BtQuitter.Click += BtQuitter_Click;
            // 
            // TbNET
            // 
            TbNET.Location = new Point(164, 477);
            TbNET.Name = "TbNET";
            TbNET.Size = new Size(190, 23);
            TbNET.TabIndex = 16;
            TbNET.Text = "0,00";
            // 
            // TbTTVA
            // 
            TbTTVA.Location = new Point(164, 450);
            TbTTVA.Name = "TbTTVA";
            TbTTVA.Size = new Size(190, 23);
            TbTTVA.TabIndex = 15;
            TbTTVA.Text = "0,00";
            // 
            // TbTHT
            // 
            TbTHT.Location = new Point(164, 424);
            TbTHT.Name = "TbTHT";
            TbTHT.Size = new Size(190, 23);
            TbTHT.TabIndex = 14;
            TbTHT.Text = "0,00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(21, 480);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.MaximumSize = new Size(150, 20);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 13;
            label4.Text = "Net à payer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(21, 453);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.MaximumSize = new Size(150, 20);
            label5.Name = "label5";
            label5.Size = new Size(138, 15);
            label5.TabIndex = 12;
            label5.Text = "Total des Montants (TVA)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(21, 427);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.MaximumSize = new Size(150, 20);
            label6.Name = "label6";
            label6.Size = new Size(133, 15);
            label6.TabIndex = 11;
            label6.Text = "Total des Montants (HT)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(920, 516);
            Controls.Add(TbNET);
            Controls.Add(BtQuitter);
            Controls.Add(TbTTVA);
            Controls.Add(BtModifier);
            Controls.Add(TbTHT);
            Controls.Add(label4);
            Controls.Add(BtSupprimer);
            Controls.Add(label5);
            Controls.Add(Lv);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label Desingiation;
        private Label label2;
        private Label label1;
        private Button BtAjouter;
        private RadioButton Rb20;
        private RadioButton Rb7;
        private Label label3;
        private TextBox TbQte;
        private TextBox TbPrix;
        private TextBox TbDes;
        private ListView Lv;
        private Button BtSupprimer;
        private Button BtModifier;
        private Button BtQuitter;
        private Button BtEffacer;
        private TextBox TbNET;
        private TextBox TbTTVA;
        private TextBox TbTHT;
        private Label label4;
        private Label label5;
        private Label label6;
        private ColumnHeader LvDesigiation;
        private ColumnHeader LvPU;
        private ColumnHeader LvQte;
        private ColumnHeader LvMHT;
        private ColumnHeader LvMTVA;
        private ColumnHeader LvTTC;
    }
}