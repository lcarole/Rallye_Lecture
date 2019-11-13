namespace WindowsFormsApp1
{
    partial class FNvlclasse
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.cBR = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.clb = new System.Windows.Forms.CheckedListBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.CBaléatoire = new System.Windows.Forms.CheckBox();
            this.CBconstruit = new System.Windows.Forms.CheckBox();
            this.btnLancer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(37, 40);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(113, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "répertoire des fichiers :";
            // 
            // cBR
            // 
            this.cBR.FormattingEnabled = true;
            this.cBR.Location = new System.Drawing.Point(157, 40);
            this.cBR.Name = "cBR";
            this.cBR.Size = new System.Drawing.Size(287, 21);
            this.cBR.TabIndex = 1;
            this.cBR.SelectedIndexChanged += new System.EventHandler(this.cBR_SelectedIndexChanged);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(37, 83);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(111, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "fichier csv à intégrer : ";
            // 
            // clb
            // 
            this.clb.FormattingEnabled = true;
            this.clb.Location = new System.Drawing.Point(154, 83);
            this.clb.Name = "clb";
            this.clb.Size = new System.Drawing.Size(290, 109);
            this.clb.TabIndex = 3;
            this.clb.SelectedIndexChanged += new System.EventHandler(this.clb_SelectedIndexChanged);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(37, 222);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(82, 13);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "année scolaire :";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(40, 265);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(39, 13);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "niveau";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(40, 312);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(70, 13);
            this.lbl5.TabIndex = 8;
            this.lbl5.Text = "mot de passe";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(154, 256);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // CBaléatoire
            // 
            this.CBaléatoire.AutoSize = true;
            this.CBaléatoire.Location = new System.Drawing.Point(154, 312);
            this.CBaléatoire.Name = "CBaléatoire";
            this.CBaléatoire.Size = new System.Drawing.Size(66, 17);
            this.CBaléatoire.TabIndex = 11;
            this.CBaléatoire.Text = "aléatoire";
            this.CBaléatoire.UseVisualStyleBackColor = true;
            // 
            // CBconstruit
            // 
            this.CBconstruit.AutoSize = true;
            this.CBconstruit.Location = new System.Drawing.Point(280, 312);
            this.CBconstruit.Name = "CBconstruit";
            this.CBconstruit.Size = new System.Drawing.Size(66, 17);
            this.CBconstruit.TabIndex = 12;
            this.CBconstruit.Text = "construit";
            this.CBconstruit.UseVisualStyleBackColor = true;
            // 
            // btnLancer
            // 
            this.btnLancer.Location = new System.Drawing.Point(154, 357);
            this.btnLancer.Name = "btnLancer";
            this.btnLancer.Size = new System.Drawing.Size(138, 33);
            this.btnLancer.TabIndex = 13;
            this.btnLancer.Text = "Lancer l\'intéragration";
            this.btnLancer.UseVisualStyleBackColor = true;
            // 
            // FNvlclasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(479, 384);
            this.Controls.Add(this.btnLancer);
            this.Controls.Add(this.CBconstruit);
            this.Controls.Add(this.CBaléatoire);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.clb);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.cBR);
            this.Controls.Add(this.lbl1);
            this.Name = "FNvlclasse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox cBR;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.CheckedListBox clb;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox CBaléatoire;
        private System.Windows.Forms.CheckBox CBconstruit;
        private System.Windows.Forms.Button btnLancer;
    }
}

