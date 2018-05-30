namespace FormABI_RH
{
    partial class frmAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
            this.lblBienvenue = new System.Windows.Forms.Label();
            this.btnGesRH = new System.Windows.Forms.Button();
            this.btnGesPro = new System.Windows.Forms.Button();
            this.btnGesCom = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenue.Location = new System.Drawing.Point(191, 90);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(416, 71);
            this.lblBienvenue.TabIndex = 0;
            this.lblBienvenue.Text = "Bienvenue sur l\'application \r\nActive Bretagne Informatique";
            this.lblBienvenue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGesRH
            // 
            this.btnGesRH.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGesRH.Location = new System.Drawing.Point(26, 350);
            this.btnGesRH.Name = "btnGesRH";
            this.btnGesRH.Size = new System.Drawing.Size(161, 73);
            this.btnGesRH.TabIndex = 1;
            this.btnGesRH.Text = "Gestion des Ressources Humaines";
            this.btnGesRH.UseVisualStyleBackColor = true;
            // 
            // btnGesPro
            // 
            this.btnGesPro.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGesPro.Location = new System.Drawing.Point(245, 350);
            this.btnGesPro.Name = "btnGesPro";
            this.btnGesPro.Size = new System.Drawing.Size(168, 73);
            this.btnGesPro.TabIndex = 2;
            this.btnGesPro.Text = "Gestion de Projets";
            this.btnGesPro.UseVisualStyleBackColor = true;
            // 
            // btnGesCom
            // 
            this.btnGesCom.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGesCom.Location = new System.Drawing.Point(472, 350);
            this.btnGesCom.Name = "btnGesCom";
            this.btnGesCom.Size = new System.Drawing.Size(168, 73);
            this.btnGesCom.TabIndex = 3;
            this.btnGesCom.Text = "Gestion Commerciale";
            this.btnGesCom.UseVisualStyleBackColor = true;
            this.btnGesCom.Click += new System.EventHandler(this.btnGesCom_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(688, 398);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(85, 25);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 149);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 445);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnGesCom);
            this.Controls.Add(this.btnGesPro);
            this.Controls.Add(this.btnGesRH);
            this.Controls.Add(this.lblBienvenue);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.Name = "frmAccueil";
            this.Text = "Accueil ABI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.Button btnGesRH;
        private System.Windows.Forms.Button btnGesPro;
        private System.Windows.Forms.Button btnGesCom;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

