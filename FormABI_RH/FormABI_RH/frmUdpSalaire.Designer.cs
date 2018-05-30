namespace FormABI_RH
{
    partial class frmUdpSalaire
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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbxDetails.SuspendLayout();
            this.gbxIDSalaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDetails
            // 
            this.gbxDetails.Location = new System.Drawing.Point(45, 150);
            this.gbxDetails.Size = new System.Drawing.Size(427, 231);
            // 
            // gbxIDSalaire
            // 
            this.gbxIDSalaire.Size = new System.Drawing.Size(427, 94);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(397, 416);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(45, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Enregistrer les modifications";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmUdpSalaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(494, 451);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnQuitter);
            this.Name = "frmUdpSalaire";
            this.Text = "Modifications du salaire";
            this.Controls.SetChildIndex(this.gbxIDSalaire, 0);
            this.Controls.SetChildIndex(this.gbxDetails, 0);
            this.Controls.SetChildIndex(this.btnQuitter, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.gbxDetails.ResumeLayout(false);
            this.gbxDetails.PerformLayout();
            this.gbxIDSalaire.ResumeLayout(false);
            this.gbxIDSalaire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button button2;
    }
}
