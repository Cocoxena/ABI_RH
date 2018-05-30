namespace FormABI_RH
{
    partial class frmGrdSalaire
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
            this.lblListeSalaire = new System.Windows.Forms.Label();
            this.lblRechercheNom = new System.Windows.Forms.Label();
            this.txtRechNom = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnConsulter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.gbxRecherche = new System.Windows.Forms.GroupBox();
            this.lblQualification = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblListeSalaire
            // 
            this.lblListeSalaire.AutoSize = true;
            this.lblListeSalaire.Location = new System.Drawing.Point(22, 144);
            this.lblListeSalaire.Name = "lblListeSalaire";
            this.lblListeSalaire.Size = new System.Drawing.Size(93, 13);
            this.lblListeSalaire.TabIndex = 1;
            this.lblListeSalaire.Text = "Liste des salaires :";
            // 
            // lblRechercheNom
            // 
            this.lblRechercheNom.AutoSize = true;
            this.lblRechercheNom.Location = new System.Drawing.Point(36, 27);
            this.lblRechercheNom.Name = "lblRechercheNom";
            this.lblRechercheNom.Size = new System.Drawing.Size(133, 13);
            this.lblRechercheNom.TabIndex = 2;
            this.lblRechercheNom.Text = "par nom du collaborateur : ";
            // 
            // txtRechNom
            // 
            this.txtRechNom.Location = new System.Drawing.Point(175, 24);
            this.txtRechNom.Name = "txtRechNom";
            this.txtRechNom.Size = new System.Drawing.Size(339, 20);
            this.txtRechNom.TabIndex = 3;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(554, 61);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 4;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // btnConsulter
            // 
            this.btnConsulter.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulter.Location = new System.Drawing.Point(25, 389);
            this.btnConsulter.Name = "btnConsulter";
            this.btnConsulter.Size = new System.Drawing.Size(133, 46);
            this.btnConsulter.TabIndex = 5;
            this.btnConsulter.Text = "Consulter le salaire";
            this.btnConsulter.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(215, 389);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(133, 46);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "Modifier le salaire";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(689, 412);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // gbxRecherche
            // 
            this.gbxRecherche.Controls.Add(this.listBox1);
            this.gbxRecherche.Controls.Add(this.lblQualification);
            this.gbxRecherche.Controls.Add(this.lblRechercheNom);
            this.gbxRecherche.Controls.Add(this.txtRechNom);
            this.gbxRecherche.Controls.Add(this.btnRechercher);
            this.gbxRecherche.Location = new System.Drawing.Point(25, 26);
            this.gbxRecherche.Name = "gbxRecherche";
            this.gbxRecherche.Size = new System.Drawing.Size(646, 104);
            this.gbxRecherche.TabIndex = 8;
            this.gbxRecherche.TabStop = false;
            this.gbxRecherche.Text = "Recherche d\'un salaire";
            // 
            // lblQualification
            // 
            this.lblQualification.AutoSize = true;
            this.lblQualification.Location = new System.Drawing.Point(36, 66);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(90, 13);
            this.lblQualification.TabIndex = 5;
            this.lblQualification.Text = "par qualification : ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(175, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(339, 30);
            this.listBox1.TabIndex = 6;
            // 
            // frmGrdSalaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.gbxRecherche);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnConsulter);
            this.Controls.Add(this.lblListeSalaire);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmGrdSalaire";
            this.Text = "Liste des Salaires";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxRecherche.ResumeLayout(false);
            this.gbxRecherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblListeSalaire;
        private System.Windows.Forms.Label lblRechercheNom;
        private System.Windows.Forms.TextBox txtRechNom;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnConsulter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.GroupBox gbxRecherche;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblQualification;
    }
}