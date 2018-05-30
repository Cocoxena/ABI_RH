namespace FormABI_RH
{
    partial class frmAvenant
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
            this.gbxDetailsAvenant = new System.Windows.Forms.GroupBox();
            this.lblNumAvenant = new System.Windows.Forms.Label();
            this.lblDateDebutAven = new System.Windows.Forms.Label();
            this.lblDateFinAv = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.gbxDetailsAvenant.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDetailsAvenant
            // 
            this.gbxDetailsAvenant.Controls.Add(this.textBox2);
            this.gbxDetailsAvenant.Controls.Add(this.dateTimePicker2);
            this.gbxDetailsAvenant.Controls.Add(this.dateTimePicker1);
            this.gbxDetailsAvenant.Controls.Add(this.textBox1);
            this.gbxDetailsAvenant.Controls.Add(this.label4);
            this.gbxDetailsAvenant.Controls.Add(this.lblDateFinAv);
            this.gbxDetailsAvenant.Controls.Add(this.lblDateDebutAven);
            this.gbxDetailsAvenant.Controls.Add(this.lblNumAvenant);
            this.gbxDetailsAvenant.Location = new System.Drawing.Point(23, 34);
            this.gbxDetailsAvenant.Name = "gbxDetailsAvenant";
            this.gbxDetailsAvenant.Size = new System.Drawing.Size(419, 253);
            this.gbxDetailsAvenant.TabIndex = 0;
            this.gbxDetailsAvenant.TabStop = false;
            this.gbxDetailsAvenant.Text = "Détails de l\'avenant";
            // 
            // lblNumAvenant
            // 
            this.lblNumAvenant.AutoSize = true;
            this.lblNumAvenant.Location = new System.Drawing.Point(31, 51);
            this.lblNumAvenant.Name = "lblNumAvenant";
            this.lblNumAvenant.Size = new System.Drawing.Size(94, 13);
            this.lblNumAvenant.TabIndex = 0;
            this.lblNumAvenant.Text = "Numéro d\'avenant";
            // 
            // lblDateDebutAven
            // 
            this.lblDateDebutAven.AutoSize = true;
            this.lblDateDebutAven.Location = new System.Drawing.Point(29, 107);
            this.lblDateDebutAven.Name = "lblDateDebutAven";
            this.lblDateDebutAven.Size = new System.Drawing.Size(136, 13);
            this.lblDateDebutAven.TabIndex = 1;
            this.lblDateDebutAven.Text = "Date de début de l\'avenant";
            // 
            // lblDateFinAv
            // 
            this.lblDateFinAv.AutoSize = true;
            this.lblDateFinAv.Location = new System.Drawing.Point(29, 157);
            this.lblDateFinAv.Name = "lblDateFinAv";
            this.lblDateFinAv.Size = new System.Drawing.Size(120, 13);
            this.lblDateFinAv.TabIndex = 2;
            this.lblDateFinAv.Text = "Date de fin de l\'avenant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Motif";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(191, 155);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(170, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 7;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(23, 302);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(175, 32);
            this.btnEnregistrer.TabIndex = 1;
            this.btnEnregistrer.Text = "Enregistrer l\'avenant";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(367, 308);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // frmAvenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 346);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.gbxDetailsAvenant);
            this.Name = "frmAvenant";
            this.Text = "frmAvenant";
            this.gbxDetailsAvenant.ResumeLayout(false);
            this.gbxDetailsAvenant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gbxDetailsAvenant;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblDateFinAv;
        public System.Windows.Forms.Label lblDateDebutAven;
        public System.Windows.Forms.Label lblNumAvenant;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnQuitter;
    }
}