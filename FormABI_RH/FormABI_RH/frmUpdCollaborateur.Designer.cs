namespace FormABI_RH
{
    partial class frmUpdCollaborateur
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
            this.btnModifContrat = new System.Windows.Forms.Button();
            this.btnModifSalaire = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.lblAutres = new System.Windows.Forms.Label();
            this.gbxDonneesPerso.SuspendLayout();
            this.gbxDonneesABI.SuspendLayout();
            this.gbxEtat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModifContrat
            // 
            this.btnModifContrat.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifContrat.Location = new System.Drawing.Point(24, 689);
            this.btnModifContrat.Name = "btnModifContrat";
            this.btnModifContrat.Size = new System.Drawing.Size(147, 36);
            this.btnModifContrat.TabIndex = 5;
            this.btnModifContrat.Text = "Modifier le contrat";
            this.btnModifContrat.UseVisualStyleBackColor = true;
            // 
            // btnModifSalaire
            // 
            this.btnModifSalaire.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifSalaire.Location = new System.Drawing.Point(219, 689);
            this.btnModifSalaire.Name = "btnModifSalaire";
            this.btnModifSalaire.Size = new System.Drawing.Size(147, 36);
            this.btnModifSalaire.TabIndex = 6;
            this.btnModifSalaire.Text = "Modifier le salaire";
            this.btnModifSalaire.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(700, 702);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(411, 681);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(187, 44);
            this.btnEnregistrer.TabIndex = 8;
            this.btnEnregistrer.Text = "Enregistrer les modifications";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // lblAutres
            // 
            this.lblAutres.AutoSize = true;
            this.lblAutres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutres.Location = new System.Drawing.Point(37, 511);
            this.lblAutres.Name = "lblAutres";
            this.lblAutres.Size = new System.Drawing.Size(206, 16);
            this.lblAutres.TabIndex = 9;
            this.lblAutres.Text = "Autres modifications éventuelles :";
            // 
            // frmUpdCollaborateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(795, 729);
            this.Controls.Add(this.lblAutres);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnModifSalaire);
            this.Controls.Add(this.btnModifContrat);
            this.Name = "frmUpdCollaborateur";
            this.Controls.SetChildIndex(this.gbxContrats, 0);
            this.Controls.SetChildIndex(this.gbxSalaires, 0);
            this.Controls.SetChildIndex(this.gbxDonneesPerso, 0);
            this.Controls.SetChildIndex(this.gbxDonneesABI, 0);
            this.Controls.SetChildIndex(this.gbxEtat, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnModifContrat, 0);
            this.Controls.SetChildIndex(this.btnModifSalaire, 0);
            this.Controls.SetChildIndex(this.btnQuitter, 0);
            this.Controls.SetChildIndex(this.btnEnregistrer, 0);
            this.Controls.SetChildIndex(this.lblAutres, 0);
            this.gbxDonneesPerso.ResumeLayout(false);
            this.gbxDonneesPerso.PerformLayout();
            this.gbxDonneesABI.ResumeLayout(false);
            this.gbxDonneesABI.PerformLayout();
            this.gbxEtat.ResumeLayout(false);
            this.gbxEtat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifContrat;
        private System.Windows.Forms.Button btnModifSalaire;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label lblAutres;
    }
}
