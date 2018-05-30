namespace FormABI_RH
{
    partial class frmSalaire
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
            this.gbxIDSalaire = new System.Windows.Forms.GroupBox();
            this.txtIDSalaireInit = new System.Windows.Forms.TextBox();
            this.lblIDSalaireInit = new System.Windows.Forms.Label();
            this.lblDatSalInit = new System.Windows.Forms.Label();
            this.lblIdSalaire = new System.Windows.Forms.Label();
            this.lblSalaireInitial = new System.Windows.Forms.Label();
            this.lblDateAugment = new System.Windows.Forms.Label();
            this.lblSalaireAugment = new System.Windows.Forms.Label();
            this.txtSalaireInit = new System.Windows.Forms.TextBox();
            this.txtAugmentation = new System.Windows.Forms.TextBox();
            this.gbxDetails = new System.Windows.Forms.GroupBox();
            this.dtpDateSalInit = new System.Windows.Forms.DateTimePicker();
            this.dtpAugmentation = new System.Windows.Forms.DateTimePicker();
            this.lblPourcentage = new System.Windows.Forms.Label();
            this.txtPourcentage = new System.Windows.Forms.TextBox();
            this.gbxIDSalaire.SuspendLayout();
            this.gbxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxIDSalaire
            // 
            this.gbxIDSalaire.Controls.Add(this.txtIDSalaireInit);
            this.gbxIDSalaire.Controls.Add(this.lblIDSalaireInit);
            this.gbxIDSalaire.Controls.Add(this.lblIdSalaire);
            this.gbxIDSalaire.Location = new System.Drawing.Point(45, 31);
            this.gbxIDSalaire.Name = "gbxIDSalaire";
            this.gbxIDSalaire.Size = new System.Drawing.Size(415, 78);
            this.gbxIDSalaire.TabIndex = 0;
            this.gbxIDSalaire.TabStop = false;
            this.gbxIDSalaire.Text = "Identifiant du Salaire";
            // 
            // txtIDSalaireInit
            // 
            this.txtIDSalaireInit.Location = new System.Drawing.Point(241, 37);
            this.txtIDSalaireInit.Name = "txtIDSalaireInit";
            this.txtIDSalaireInit.Size = new System.Drawing.Size(145, 20);
            this.txtIDSalaireInit.TabIndex = 6;
            // 
            // lblIDSalaireInit
            // 
            this.lblIDSalaireInit.AutoSize = true;
            this.lblIDSalaireInit.Location = new System.Drawing.Point(44, 40);
            this.lblIDSalaireInit.Name = "lblIDSalaireInit";
            this.lblIDSalaireInit.Size = new System.Drawing.Size(94, 13);
            this.lblIDSalaireInit.TabIndex = 5;
            this.lblIDSalaireInit.Text = "ID du Salaire initial";
            // 
            // lblDatSalInit
            // 
            this.lblDatSalInit.AutoSize = true;
            this.lblDatSalInit.Location = new System.Drawing.Point(37, 36);
            this.lblDatSalInit.Name = "lblDatSalInit";
            this.lblDatSalInit.Size = new System.Drawing.Size(106, 13);
            this.lblDatSalInit.TabIndex = 1;
            this.lblDatSalInit.Text = "Date du Salaire initial";
            // 
            // lblIdSalaire
            // 
            this.lblIdSalaire.AutoSize = true;
            this.lblIdSalaire.Location = new System.Drawing.Point(44, 40);
            this.lblIdSalaire.Name = "lblIdSalaire";
            this.lblIdSalaire.Size = new System.Drawing.Size(10, 13);
            this.lblIdSalaire.TabIndex = 0;
            this.lblIdSalaire.Text = " ";
            // 
            // lblSalaireInitial
            // 
            this.lblSalaireInitial.AutoSize = true;
            this.lblSalaireInitial.Location = new System.Drawing.Point(37, 74);
            this.lblSalaireInitial.Name = "lblSalaireInitial";
            this.lblSalaireInitial.Size = new System.Drawing.Size(137, 13);
            this.lblSalaireInitial.TabIndex = 2;
            this.lblSalaireInitial.Text = "Montant du Salaire initial (€)";
            // 
            // lblDateAugment
            // 
            this.lblDateAugment.AutoSize = true;
            this.lblDateAugment.Location = new System.Drawing.Point(37, 115);
            this.lblDateAugment.Name = "lblDateAugment";
            this.lblDateAugment.Size = new System.Drawing.Size(117, 13);
            this.lblDateAugment.TabIndex = 3;
            this.lblDateAugment.Text = "Date de l\'Augmentation";
            // 
            // lblSalaireAugment
            // 
            this.lblSalaireAugment.AutoSize = true;
            this.lblSalaireAugment.Location = new System.Drawing.Point(37, 202);
            this.lblSalaireAugment.Name = "lblSalaireAugment";
            this.lblSalaireAugment.Size = new System.Drawing.Size(187, 13);
            this.lblSalaireAugment.TabIndex = 4;
            this.lblSalaireAugment.Text = "Montant du Salaire Final Augmenté (€)";
            // 
            // txtSalaireInit
            // 
            this.txtSalaireInit.Location = new System.Drawing.Point(241, 67);
            this.txtSalaireInit.Name = "txtSalaireInit";
            this.txtSalaireInit.Size = new System.Drawing.Size(145, 20);
            this.txtSalaireInit.TabIndex = 8;
            // 
            // txtAugmentation
            // 
            this.txtAugmentation.Location = new System.Drawing.Point(241, 195);
            this.txtAugmentation.Name = "txtAugmentation";
            this.txtAugmentation.Size = new System.Drawing.Size(145, 20);
            this.txtAugmentation.TabIndex = 10;
            // 
            // gbxDetails
            // 
            this.gbxDetails.Controls.Add(this.txtPourcentage);
            this.gbxDetails.Controls.Add(this.lblPourcentage);
            this.gbxDetails.Controls.Add(this.dtpAugmentation);
            this.gbxDetails.Controls.Add(this.dtpDateSalInit);
            this.gbxDetails.Controls.Add(this.txtAugmentation);
            this.gbxDetails.Controls.Add(this.lblSalaireInitial);
            this.gbxDetails.Controls.Add(this.lblDatSalInit);
            this.gbxDetails.Controls.Add(this.txtSalaireInit);
            this.gbxDetails.Controls.Add(this.lblDateAugment);
            this.gbxDetails.Controls.Add(this.lblSalaireAugment);
            this.gbxDetails.Location = new System.Drawing.Point(45, 127);
            this.gbxDetails.Name = "gbxDetails";
            this.gbxDetails.Size = new System.Drawing.Size(415, 238);
            this.gbxDetails.TabIndex = 1;
            this.gbxDetails.TabStop = false;
            this.gbxDetails.Text = "Détails";
            // 
            // dtpDateSalInit
            // 
            this.dtpDateSalInit.Location = new System.Drawing.Point(241, 29);
            this.dtpDateSalInit.Name = "dtpDateSalInit";
            this.dtpDateSalInit.Size = new System.Drawing.Size(145, 20);
            this.dtpDateSalInit.TabIndex = 11;
            // 
            // dtpAugmentation
            // 
            this.dtpAugmentation.Location = new System.Drawing.Point(241, 108);
            this.dtpAugmentation.Name = "dtpAugmentation";
            this.dtpAugmentation.Size = new System.Drawing.Size(145, 20);
            this.dtpAugmentation.TabIndex = 12;
            // 
            // lblPourcentage
            // 
            this.lblPourcentage.AutoSize = true;
            this.lblPourcentage.Location = new System.Drawing.Point(37, 158);
            this.lblPourcentage.Name = "lblPourcentage";
            this.lblPourcentage.Size = new System.Drawing.Size(143, 13);
            this.lblPourcentage.TabIndex = 13;
            this.lblPourcentage.Text = "Pourcentage d\'augmentation";
            // 
            // txtPourcentage
            // 
            this.txtPourcentage.Location = new System.Drawing.Point(241, 151);
            this.txtPourcentage.Name = "txtPourcentage";
            this.txtPourcentage.Size = new System.Drawing.Size(145, 20);
            this.txtPourcentage.TabIndex = 14;
            // 
            // frmSalaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 396);
            this.Controls.Add(this.gbxDetails);
            this.Controls.Add(this.gbxIDSalaire);
            this.Name = "frmSalaire";
            this.Text = "frmSalaire";
            this.gbxIDSalaire.ResumeLayout(false);
            this.gbxIDSalaire.PerformLayout();
            this.gbxDetails.ResumeLayout(false);
            this.gbxDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblIdSalaire;
        public System.Windows.Forms.TextBox txtAugmentation;
        public System.Windows.Forms.TextBox txtSalaireInit;
        public System.Windows.Forms.GroupBox gbxDetails;
        public System.Windows.Forms.GroupBox gbxIDSalaire;
        public System.Windows.Forms.TextBox txtIDSalaireInit;
        public System.Windows.Forms.Label lblDatSalInit;
        public System.Windows.Forms.DateTimePicker dtpDateSalInit;
        public System.Windows.Forms.Label lblSalaireInitial;
        public System.Windows.Forms.DateTimePicker dtpAugmentation;
        public System.Windows.Forms.Label lblDateAugment;
        public System.Windows.Forms.Label lblSalaireAugment;
        public System.Windows.Forms.TextBox txtPourcentage;
        public System.Windows.Forms.Label lblPourcentage;
        public System.Windows.Forms.Label lblIDSalaireInit;
    }
}