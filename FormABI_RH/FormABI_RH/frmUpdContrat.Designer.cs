namespace FormABI_RH
{
    partial class frmUpdContrat
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
            this.btnValider = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbxContrat.SuspendLayout();
            this.grpDonnOpti.SuspendLayout();
            this.gbxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(33, 733);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(213, 36);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Enregistrer les modifications";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(627, 741);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(273, 733);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Créer un avenant";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmUpdContrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(723, 776);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnValider);
            this.Name = "frmUpdContrat";
            this.Text = "Modification du Contrat";
            this.Controls.SetChildIndex(this.gbxAvenant, 0);
            this.Controls.SetChildIndex(this.gbxContrat, 0);
            this.Controls.SetChildIndex(this.grpDonnOpti, 0);
            this.Controls.SetChildIndex(this.btnValider, 0);
            this.Controls.SetChildIndex(this.btnQuitter, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.gbxContrat.ResumeLayout(false);
            this.gbxContrat.PerformLayout();
            this.grpDonnOpti.ResumeLayout(false);
            this.grpDonnOpti.PerformLayout();
            this.gbxOptions.ResumeLayout(false);
            this.gbxOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnQuitter;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnValider;
    }
}
