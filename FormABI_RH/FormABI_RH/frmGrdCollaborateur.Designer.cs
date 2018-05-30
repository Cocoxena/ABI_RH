namespace FormABI_RH
{
    partial class frmGrdCollaborateur
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblSelectionColl = new System.Windows.Forms.Label();
            this.btnDesactiver = new System.Windows.Forms.Button();
            this.btnAjouterColl = new System.Windows.Forms.Button();
            this.btnConsulter = new System.Windows.Forms.Button();
            this.gbxRecherche = new System.Windows.Forms.GroupBox();
            this.lblRechNom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstQualification = new System.Windows.Forms.ListBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 228);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(378, 410);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(152, 46);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier la fiche \r\ndu collaborateur";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(804, 433);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // lblSelectionColl
            // 
            this.lblSelectionColl.AutoSize = true;
            this.lblSelectionColl.Location = new System.Drawing.Point(24, 140);
            this.lblSelectionColl.Name = "lblSelectionColl";
            this.lblSelectionColl.Size = new System.Drawing.Size(124, 13);
            this.lblSelectionColl.TabIndex = 3;
            this.lblSelectionColl.Text = "Liste des collaborateurs :";
            // 
            // btnDesactiver
            // 
            this.btnDesactiver.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactiver.Location = new System.Drawing.Point(629, 410);
            this.btnDesactiver.Name = "btnDesactiver";
            this.btnDesactiver.Size = new System.Drawing.Size(152, 46);
            this.btnDesactiver.TabIndex = 4;
            this.btnDesactiver.Text = "Désactiver le collaborateur";
            this.btnDesactiver.UseVisualStyleBackColor = true;
            // 
            // btnAjouterColl
            // 
            this.btnAjouterColl.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterColl.Location = new System.Drawing.Point(27, 410);
            this.btnAjouterColl.Name = "btnAjouterColl";
            this.btnAjouterColl.Size = new System.Drawing.Size(152, 46);
            this.btnAjouterColl.TabIndex = 5;
            this.btnAjouterColl.Text = "Ajouter un collaborateur";
            this.btnAjouterColl.UseVisualStyleBackColor = true;
            // 
            // btnConsulter
            // 
            this.btnConsulter.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulter.Location = new System.Drawing.Point(202, 410);
            this.btnConsulter.Name = "btnConsulter";
            this.btnConsulter.Size = new System.Drawing.Size(152, 46);
            this.btnConsulter.TabIndex = 6;
            this.btnConsulter.Text = "Consulter la fiche  du collaborateur";
            this.btnConsulter.UseVisualStyleBackColor = true;
            // 
            // gbxRecherche
            // 
            this.gbxRecherche.Controls.Add(this.btnRechercher);
            this.gbxRecherche.Controls.Add(this.lstQualification);
            this.gbxRecherche.Controls.Add(this.textBox1);
            this.gbxRecherche.Controls.Add(this.label2);
            this.gbxRecherche.Controls.Add(this.lblRechNom);
            this.gbxRecherche.Location = new System.Drawing.Point(27, 20);
            this.gbxRecherche.Name = "gbxRecherche";
            this.gbxRecherche.Size = new System.Drawing.Size(754, 99);
            this.gbxRecherche.TabIndex = 7;
            this.gbxRecherche.TabStop = false;
            this.gbxRecherche.Text = "Recherche d\'un collaborateur";
            // 
            // lblRechNom
            // 
            this.lblRechNom.AutoSize = true;
            this.lblRechNom.Location = new System.Drawing.Point(35, 32);
            this.lblRechNom.Name = "lblRechNom";
            this.lblRechNom.Size = new System.Drawing.Size(133, 13);
            this.lblRechNom.TabIndex = 0;
            this.lblRechNom.Text = "par nom du collaborateur : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "par qualification : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lstQualification
            // 
            this.lstQualification.FormattingEnabled = true;
            this.lstQualification.Location = new System.Drawing.Point(187, 67);
            this.lstQualification.Name = "lstQualification";
            this.lstQualification.Size = new System.Drawing.Size(316, 30);
            this.lstQualification.TabIndex = 3;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(653, 67);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(86, 23);
            this.btnRechercher.TabIndex = 4;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // frmGrdCollaborateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 474);
            this.Controls.Add(this.gbxRecherche);
            this.Controls.Add(this.btnConsulter);
            this.Controls.Add(this.btnAjouterColl);
            this.Controls.Add(this.btnDesactiver);
            this.Controls.Add(this.lblSelectionColl);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmGrdCollaborateur";
            this.Text = "Liste des Collaborateurs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxRecherche.ResumeLayout(false);
            this.gbxRecherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblSelectionColl;
        private System.Windows.Forms.Button btnDesactiver;
        private System.Windows.Forms.Button btnAjouterColl;
        private System.Windows.Forms.Button btnConsulter;
        private System.Windows.Forms.GroupBox gbxRecherche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRechNom;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.ListBox lstQualification;
    }
}