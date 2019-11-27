namespace rallyeLecture
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_reper = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_annee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_niveau = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_integ = new System.Windows.Forms.Button();
            this.clb_fichcsv = new System.Windows.Forms.CheckedListBox();
            this.rd_aleatoire = new System.Windows.Forms.RadioButton();
            this.rd_Construit = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Répertoire des fichiers :";
            // 
            // cb_reper
            // 
            this.cb_reper.FormattingEnabled = true;
            this.cb_reper.Location = new System.Drawing.Point(136, 27);
            this.cb_reper.Name = "cb_reper";
            this.cb_reper.Size = new System.Drawing.Size(254, 21);
            this.cb_reper.TabIndex = 1;
            this.cb_reper.SelectedIndexChanged += new System.EventHandler(this.cb_reper_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "fichier csv à intégrer :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Année scolaire :";
            // 
            // tb_annee
            // 
            this.tb_annee.Location = new System.Drawing.Point(136, 177);
            this.tb_annee.Name = "tb_annee";
            this.tb_annee.Size = new System.Drawing.Size(254, 20);
            this.tb_annee.TabIndex = 5;
            this.tb_annee.Text = "0";
            this.tb_annee.TextChanged += new System.EventHandler(this.tb_annee_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Niveau :";
            // 
            // cb_niveau
            // 
            this.cb_niveau.FormattingEnabled = true;
            this.cb_niveau.Location = new System.Drawing.Point(136, 208);
            this.cb_niveau.Name = "cb_niveau";
            this.cb_niveau.Size = new System.Drawing.Size(254, 21);
            this.cb_niveau.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mot de Passe :";
            // 
            // btn_integ
            // 
            this.btn_integ.Location = new System.Drawing.Point(136, 296);
            this.btn_integ.Name = "btn_integ";
            this.btn_integ.Size = new System.Drawing.Size(155, 23);
            this.btn_integ.TabIndex = 11;
            this.btn_integ.Text = "Lancer l\'intégration";
            this.btn_integ.UseVisualStyleBackColor = true;
            this.btn_integ.Click += new System.EventHandler(this.btn_integ_Click);
            // 
            // clb_fichcsv
            // 
            this.clb_fichcsv.FormattingEnabled = true;
            this.clb_fichcsv.Location = new System.Drawing.Point(136, 63);
            this.clb_fichcsv.Name = "clb_fichcsv";
            this.clb_fichcsv.Size = new System.Drawing.Size(254, 94);
            this.clb_fichcsv.TabIndex = 12;
            // 
            // rd_aleatoire
            // 
            this.rd_aleatoire.AutoSize = true;
            this.rd_aleatoire.Location = new System.Drawing.Point(136, 244);
            this.rd_aleatoire.Name = "rd_aleatoire";
            this.rd_aleatoire.Size = new System.Drawing.Size(66, 17);
            this.rd_aleatoire.TabIndex = 13;
            this.rd_aleatoire.TabStop = true;
            this.rd_aleatoire.Text = "Aleatoire";
            this.rd_aleatoire.UseVisualStyleBackColor = true;
            this.rd_aleatoire.CheckedChanged += new System.EventHandler(this.rd_aleatoire_CheckedChanged);
            // 
            // rd_Construit
            // 
            this.rd_Construit.AutoSize = true;
            this.rd_Construit.Location = new System.Drawing.Point(250, 244);
            this.rd_Construit.Name = "rd_Construit";
            this.rd_Construit.Size = new System.Drawing.Size(66, 17);
            this.rd_Construit.TabIndex = 14;
            this.rd_Construit.TabStop = true;
            this.rd_Construit.Text = "Construit";
            this.rd_Construit.UseVisualStyleBackColor = true;
            this.rd_Construit.CheckedChanged += new System.EventHandler(this.rd_Construit_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 341);
            this.Controls.Add(this.rd_Construit);
            this.Controls.Add(this.rd_aleatoire);
            this.Controls.Add(this.clb_fichcsv);
            this.Controls.Add(this.btn_integ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_niveau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_annee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_reper);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Alimentation de la base de données :  Nouvelle classe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_reper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_annee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_niveau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_integ;
        private System.Windows.Forms.CheckedListBox clb_fichcsv;
        private System.Windows.Forms.RadioButton rd_aleatoire;
        private System.Windows.Forms.RadioButton rd_Construit;
    }
}

