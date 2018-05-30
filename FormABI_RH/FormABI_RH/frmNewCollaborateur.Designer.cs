namespace FormABI_RH
{
    partial class frmNewCollaborateur
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCréerSalaire = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblAlert = new System.Windows.Forms.Label();
            this.gbxDonneesPerso.SuspendLayout();
            this.gbxDonneesABI.SuspendLayout();
            this.gbxEtat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxContrats.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxContrats
            // 
            this.gbxContrats.Controls.Add(this.lblAlert);
            this.gbxContrats.Controls.SetChildIndex(this.lblAlert, 0);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 677);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Créer le contrat";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCréerSalaire
            // 
            this.btnCréerSalaire.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCréerSalaire.Location = new System.Drawing.Point(228, 677);
            this.btnCréerSalaire.Name = "btnCréerSalaire";
            this.btnCréerSalaire.Size = new System.Drawing.Size(147, 36);
            this.btnCréerSalaire.TabIndex = 6;
            this.btnCréerSalaire.Text = "Créer le salaire";
            this.btnCréerSalaire.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(711, 690);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.ForeColor = System.Drawing.Color.Red;
            this.lblAlert.Location = new System.Drawing.Point(79, 65);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(438, 13);
            this.lblAlert.TabIndex = 8;
            this.lblAlert.Text = "Attention, si vous créez un collaborateur, vous devez lui créer un contrat !!!";
            // 
            // frmNewCollaborateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(803, 720);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnCréerSalaire);
            this.Controls.Add(this.button1);
            this.Name = "frmNewCollaborateur";
            this.Text = "Nouveau Collaborateur";
            this.Controls.SetChildIndex(this.gbxContrats, 0);
            this.Controls.SetChildIndex(this.gbxSalaires, 0);
            this.Controls.SetChildIndex(this.gbxDonneesPerso, 0);
            this.Controls.SetChildIndex(this.gbxDonneesABI, 0);
            this.Controls.SetChildIndex(this.gbxEtat, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btnCréerSalaire, 0);
            this.Controls.SetChildIndex(this.btnQuitter, 0);
            this.gbxDonneesPerso.ResumeLayout(false);
            this.gbxDonneesPerso.PerformLayout();
            this.gbxDonneesABI.ResumeLayout(false);
            this.gbxDonneesABI.PerformLayout();
            this.gbxEtat.ResumeLayout(false);
            this.gbxEtat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxContrats.ResumeLayout(false);
            this.gbxContrats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCréerSalaire;
        private System.Windows.Forms.Button btnQuitter;
        public System.Windows.Forms.Label lblAlert;
    }
}
