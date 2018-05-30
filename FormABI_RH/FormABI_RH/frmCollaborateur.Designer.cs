namespace FormABI_RH
{
    partial class frmCollabo
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
            this.gbxDonneesPerso = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.gbxDonneesABI = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lstStatut = new System.Windows.Forms.ListBox();
            this.lblStatut = new System.Windows.Forms.Label();
            this.lblDateSortie = new System.Windows.Forms.Label();
            this.lblDateEmbauche = new System.Windows.Forms.Label();
            this.gbxEtat = new System.Windows.Forms.GroupBox();
            this.rbtInactif = new System.Windows.Forms.RadioButton();
            this.rbtActif = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            this.gbxContrats = new System.Windows.Forms.GroupBox();
            this.gbxSalaires = new System.Windows.Forms.GroupBox();
            this.dgvContrats = new System.Windows.Forms.DataGridView();
            this.dgvSalaires = new System.Windows.Forms.DataGridView();
            this.gbxDonneesPerso.SuspendLayout();
            this.gbxDonneesABI.SuspendLayout();
            this.gbxEtat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxContrats.SuspendLayout();
            this.gbxSalaires.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaires)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDonneesPerso
            // 
            this.gbxDonneesPerso.Controls.Add(this.textBox3);
            this.gbxDonneesPerso.Controls.Add(this.textBox2);
            this.gbxDonneesPerso.Controls.Add(this.textBox1);
            this.gbxDonneesPerso.Controls.Add(this.lblPrenom);
            this.gbxDonneesPerso.Controls.Add(this.lblNom);
            this.gbxDonneesPerso.Controls.Add(this.lblMatricule);
            this.gbxDonneesPerso.Location = new System.Drawing.Point(24, 22);
            this.gbxDonneesPerso.Name = "gbxDonneesPerso";
            this.gbxDonneesPerso.Size = new System.Drawing.Size(584, 146);
            this.gbxDonneesPerso.TabIndex = 1;
            this.gbxDonneesPerso.TabStop = false;
            this.gbxDonneesPerso.Text = "Données personnelles";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(322, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(322, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(35, 100);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(35, 67);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(35, 34);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(50, 13);
            this.lblMatricule.TabIndex = 0;
            this.lblMatricule.Text = "Matricule";
            this.lblMatricule.Click += new System.EventHandler(this.lblMatricule_Click);
            // 
            // gbxDonneesABI
            // 
            this.gbxDonneesABI.Controls.Add(this.dateTimePicker2);
            this.gbxDonneesABI.Controls.Add(this.dateTimePicker1);
            this.gbxDonneesABI.Controls.Add(this.lstStatut);
            this.gbxDonneesABI.Controls.Add(this.lblStatut);
            this.gbxDonneesABI.Controls.Add(this.lblDateSortie);
            this.gbxDonneesABI.Controls.Add(this.lblDateEmbauche);
            this.gbxDonneesABI.Location = new System.Drawing.Point(24, 187);
            this.gbxDonneesABI.Name = "gbxDonneesABI";
            this.gbxDonneesABI.Size = new System.Drawing.Size(584, 145);
            this.gbxDonneesABI.TabIndex = 2;
            this.gbxDonneesABI.TabStop = false;
            this.gbxDonneesABI.Text = "Données ABI";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(142, 63);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // lstStatut
            // 
            this.lstStatut.FormattingEnabled = true;
            this.lstStatut.Location = new System.Drawing.Point(142, 101);
            this.lstStatut.Name = "lstStatut";
            this.lstStatut.Size = new System.Drawing.Size(322, 30);
            this.lstStatut.TabIndex = 3;
            this.lstStatut.SelectedIndexChanged += new System.EventHandler(this.lstStatut_SelectedIndexChanged);
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(35, 101);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(35, 13);
            this.lblStatut.TabIndex = 2;
            this.lblStatut.Text = "Statut";
            // 
            // lblDateSortie
            // 
            this.lblDateSortie.AutoSize = true;
            this.lblDateSortie.Location = new System.Drawing.Point(35, 69);
            this.lblDateSortie.Name = "lblDateSortie";
            this.lblDateSortie.Size = new System.Drawing.Size(73, 13);
            this.lblDateSortie.TabIndex = 1;
            this.lblDateSortie.Text = "Date de sortie";
            // 
            // lblDateEmbauche
            // 
            this.lblDateEmbauche.AutoSize = true;
            this.lblDateEmbauche.Location = new System.Drawing.Point(35, 37);
            this.lblDateEmbauche.Name = "lblDateEmbauche";
            this.lblDateEmbauche.Size = new System.Drawing.Size(91, 13);
            this.lblDateEmbauche.TabIndex = 0;
            this.lblDateEmbauche.Text = "Date d\'embauche";
            // 
            // gbxEtat
            // 
            this.gbxEtat.Controls.Add(this.rbtInactif);
            this.gbxEtat.Controls.Add(this.rbtActif);
            this.gbxEtat.Location = new System.Drawing.Point(624, 217);
            this.gbxEtat.Name = "gbxEtat";
            this.gbxEtat.Size = new System.Drawing.Size(163, 115);
            this.gbxEtat.TabIndex = 3;
            this.gbxEtat.TabStop = false;
            this.gbxEtat.Text = "Etat";
            // 
            // rbtInactif
            // 
            this.rbtInactif.AutoSize = true;
            this.rbtInactif.Location = new System.Drawing.Point(54, 71);
            this.rbtInactif.Name = "rbtInactif";
            this.rbtInactif.Size = new System.Drawing.Size(54, 17);
            this.rbtInactif.TabIndex = 1;
            this.rbtInactif.TabStop = true;
            this.rbtInactif.Text = "Inactif";
            this.rbtInactif.UseVisualStyleBackColor = true;
            // 
            // rbtActif
            // 
            this.rbtActif.AutoSize = true;
            this.rbtActif.Location = new System.Drawing.Point(54, 33);
            this.rbtActif.Name = "rbtActif";
            this.rbtActif.Size = new System.Drawing.Size(46, 17);
            this.rbtActif.TabIndex = 0;
            this.rbtActif.TabStop = true;
            this.rbtActif.Text = "Actif";
            this.rbtActif.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPhoto);
            this.groupBox1.Location = new System.Drawing.Point(624, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 180);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Photo";
            // 
            // txtPhoto
            // 
            this.txtPhoto.Location = new System.Drawing.Point(16, 24);
            this.txtPhoto.Multiline = true;
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.Size = new System.Drawing.Size(135, 142);
            this.txtPhoto.TabIndex = 0;
            // 
            // gbxContrats
            // 
            this.gbxContrats.Controls.Add(this.dgvContrats);
            this.gbxContrats.Location = new System.Drawing.Point(24, 349);
            this.gbxContrats.Name = "gbxContrats";
            this.gbxContrats.Size = new System.Drawing.Size(763, 150);
            this.gbxContrats.TabIndex = 5;
            this.gbxContrats.TabStop = false;
            this.gbxContrats.Text = "Liste des contrats";
            // 
            // gbxSalaires
            // 
            this.gbxSalaires.Controls.Add(this.dgvSalaires);
            this.gbxSalaires.Location = new System.Drawing.Point(24, 517);
            this.gbxSalaires.Name = "gbxSalaires";
            this.gbxSalaires.Size = new System.Drawing.Size(762, 154);
            this.gbxSalaires.TabIndex = 6;
            this.gbxSalaires.TabStop = false;
            this.gbxSalaires.Text = "Liste des salaires";
            // 
            // dgvContrats
            // 
            this.dgvContrats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContrats.Location = new System.Drawing.Point(25, 27);
            this.dgvContrats.Name = "dgvContrats";
            this.dgvContrats.Size = new System.Drawing.Size(697, 100);
            this.dgvContrats.TabIndex = 0;
            // 
            // dgvSalaires
            // 
            this.dgvSalaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaires.Location = new System.Drawing.Point(25, 32);
            this.dgvSalaires.Name = "dgvSalaires";
            this.dgvSalaires.Size = new System.Drawing.Size(697, 101);
            this.dgvSalaires.TabIndex = 0;
            // 
            // frmCollabo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 685);
            this.Controls.Add(this.gbxSalaires);
            this.Controls.Add(this.gbxContrats);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxEtat);
            this.Controls.Add(this.gbxDonneesABI);
            this.Controls.Add(this.gbxDonneesPerso);
            this.Name = "frmCollabo";
            this.Text = "Fiche Collaborateur";
            this.gbxDonneesPerso.ResumeLayout(false);
            this.gbxDonneesPerso.PerformLayout();
            this.gbxDonneesABI.ResumeLayout(false);
            this.gbxDonneesABI.PerformLayout();
            this.gbxEtat.ResumeLayout(false);
            this.gbxEtat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxContrats.ResumeLayout(false);
            this.gbxSalaires.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaires)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox txtPhoto;
        public System.Windows.Forms.GroupBox gbxDonneesPerso;
        public System.Windows.Forms.GroupBox gbxDonneesABI;
        public System.Windows.Forms.GroupBox gbxEtat;
        public System.Windows.Forms.RadioButton rbtInactif;
        public System.Windows.Forms.RadioButton rbtActif;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ListBox lstStatut;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.GroupBox gbxContrats;
        public System.Windows.Forms.DataGridView dgvContrats;
        public System.Windows.Forms.GroupBox gbxSalaires;
        public System.Windows.Forms.DataGridView dgvSalaires;
        public System.Windows.Forms.Label lblPrenom;
        public System.Windows.Forms.Label lblNom;
        public System.Windows.Forms.Label lblStatut;
        public System.Windows.Forms.Label lblDateSortie;
        public System.Windows.Forms.Label lblDateEmbauche;
        public System.Windows.Forms.Label lblMatricule;
    }
}