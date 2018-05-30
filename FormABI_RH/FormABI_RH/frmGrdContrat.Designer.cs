namespace FormABI_RH
{
    partial class frmGrdContrat
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNomColl = new System.Windows.Forms.TextBox();
            this.txtNumCont = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lblRechNom = new System.Windows.Forms.Label();
            this.lblRechNum = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblListeContrat = new System.Windows.Forms.Label();
            this.btnModifContrat = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnConsulter = new System.Windows.Forms.Button();
            this.btnCréerContrat = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNomColl);
            this.groupBox2.Controls.Add(this.txtNumCont);
            this.groupBox2.Controls.Add(this.btnRechercher);
            this.groupBox2.Controls.Add(this.lblRechNom);
            this.groupBox2.Controls.Add(this.lblRechNum);
            this.groupBox2.Location = new System.Drawing.Point(34, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 103);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche d\'un contrat";
            // 
            // txtNomColl
            // 
            this.txtNomColl.Location = new System.Drawing.Point(180, 64);
            this.txtNomColl.Name = "txtNomColl";
            this.txtNomColl.Size = new System.Drawing.Size(323, 20);
            this.txtNomColl.TabIndex = 4;
            // 
            // txtNumCont
            // 
            this.txtNumCont.Location = new System.Drawing.Point(180, 26);
            this.txtNumCont.Name = "txtNumCont";
            this.txtNumCont.Size = new System.Drawing.Size(323, 20);
            this.txtNumCont.TabIndex = 3;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(618, 62);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 2;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // lblRechNom
            // 
            this.lblRechNom.AutoSize = true;
            this.lblRechNom.Location = new System.Drawing.Point(39, 67);
            this.lblRechNom.Name = "lblRechNom";
            this.lblRechNom.Size = new System.Drawing.Size(130, 13);
            this.lblRechNom.TabIndex = 1;
            this.lblRechNom.Text = "par nom du collaborateur :";
            // 
            // lblRechNum
            // 
            this.lblRechNum.AutoSize = true;
            this.lblRechNum.Location = new System.Drawing.Point(39, 29);
            this.lblRechNum.Name = "lblRechNum";
            this.lblRechNum.Size = new System.Drawing.Size(117, 13);
            this.lblRechNum.TabIndex = 0;
            this.lblRechNum.Text = "par numéro de contrat :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(710, 171);
            this.dataGridView1.TabIndex = 10;
            // 
            // lblListeContrat
            // 
            this.lblListeContrat.AutoSize = true;
            this.lblListeContrat.Location = new System.Drawing.Point(31, 148);
            this.lblListeContrat.Name = "lblListeContrat";
            this.lblListeContrat.Size = new System.Drawing.Size(96, 13);
            this.lblListeContrat.TabIndex = 11;
            this.lblListeContrat.Text = "Liste des contrats :";
            // 
            // btnModifContrat
            // 
            this.btnModifContrat.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifContrat.Location = new System.Drawing.Point(385, 361);
            this.btnModifContrat.Name = "btnModifContrat";
            this.btnModifContrat.Size = new System.Drawing.Size(152, 46);
            this.btnModifContrat.TabIndex = 12;
            this.btnModifContrat.Text = "Modifier le contrat";
            this.btnModifContrat.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(752, 384);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 13;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(592, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 46);
            this.button2.TabIndex = 14;
            this.button2.Text = "Clôturer le contrat";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnConsulter
            // 
            this.btnConsulter.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulter.Location = new System.Drawing.Point(210, 361);
            this.btnConsulter.Name = "btnConsulter";
            this.btnConsulter.Size = new System.Drawing.Size(152, 46);
            this.btnConsulter.TabIndex = 15;
            this.btnConsulter.Text = "Consulter le contrat";
            this.btnConsulter.UseVisualStyleBackColor = true;
            // 
            // btnCréerContrat
            // 
            this.btnCréerContrat.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCréerContrat.Location = new System.Drawing.Point(34, 362);
            this.btnCréerContrat.Name = "btnCréerContrat";
            this.btnCréerContrat.Size = new System.Drawing.Size(152, 46);
            this.btnCréerContrat.TabIndex = 16;
            this.btnCréerContrat.Text = "Créer un nouveau contrat";
            this.btnCréerContrat.UseVisualStyleBackColor = true;
            // 
            // frmGrdContrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 416);
            this.Controls.Add(this.btnCréerContrat);
            this.Controls.Add(this.btnConsulter);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnModifContrat);
            this.Controls.Add(this.lblListeContrat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmGrdContrat";
            this.Text = "Liste des Contrats";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRechNom;
        private System.Windows.Forms.Label lblRechNum;
        private System.Windows.Forms.TextBox txtNomColl;
        private System.Windows.Forms.TextBox txtNumCont;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblListeContrat;
        private System.Windows.Forms.Button btnModifContrat;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnConsulter;
        private System.Windows.Forms.Button btnCréerContrat;
    }
}