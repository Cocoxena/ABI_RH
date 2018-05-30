namespace FormABI_RH
{
    partial class frmGesRH
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
            this.lblGesRH = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.gbxGesColl = new System.Windows.Forms.GroupBox();
            this.gbxGesCont = new System.Windows.Forms.GroupBox();
            this.gbxGesCarr = new System.Windows.Forms.GroupBox();
            this.lblChoix1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnValider1 = new System.Windows.Forms.Button();
            this.lblChoix2 = new System.Windows.Forms.Label();
            this.lblChoix3 = new System.Windows.Forms.Label();
            this.btnValider2 = new System.Windows.Forms.Button();
            this.btnValider3 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.gbxGesColl.SuspendLayout();
            this.gbxGesCont.SuspendLayout();
            this.gbxGesCarr.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGesRH
            // 
            this.lblGesRH.AutoSize = true;
            this.lblGesRH.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGesRH.Location = new System.Drawing.Point(197, 35);
            this.lblGesRH.Name = "lblGesRH";
            this.lblGesRH.Size = new System.Drawing.Size(390, 58);
            this.lblGesRH.TabIndex = 1;
            this.lblGesRH.Text = "Gestion des Ressources Humaines \r\nABI";
            this.lblGesRH.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGesRH.Click += new System.EventHandler(this.lblGesRH_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(766, 569);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // gbxGesColl
            // 
            this.gbxGesColl.Controls.Add(this.btnValider1);
            this.gbxGesColl.Controls.Add(this.listBox1);
            this.gbxGesColl.Controls.Add(this.lblChoix1);
            this.gbxGesColl.Location = new System.Drawing.Point(33, 133);
            this.gbxGesColl.Name = "gbxGesColl";
            this.gbxGesColl.Size = new System.Drawing.Size(651, 145);
            this.gbxGesColl.TabIndex = 3;
            this.gbxGesColl.TabStop = false;
            this.gbxGesColl.Text = "Gestion des collaborateurs";
            // 
            // gbxGesCont
            // 
            this.gbxGesCont.Controls.Add(this.listBox2);
            this.gbxGesCont.Controls.Add(this.btnValider2);
            this.gbxGesCont.Controls.Add(this.lblChoix2);
            this.gbxGesCont.Location = new System.Drawing.Point(33, 296);
            this.gbxGesCont.Name = "gbxGesCont";
            this.gbxGesCont.Size = new System.Drawing.Size(652, 139);
            this.gbxGesCont.TabIndex = 4;
            this.gbxGesCont.TabStop = false;
            this.gbxGesCont.Text = "Gestion des contrats";
            // 
            // gbxGesCarr
            // 
            this.gbxGesCarr.Controls.Add(this.listBox3);
            this.gbxGesCarr.Controls.Add(this.btnValider3);
            this.gbxGesCarr.Controls.Add(this.lblChoix3);
            this.gbxGesCarr.Location = new System.Drawing.Point(33, 459);
            this.gbxGesCarr.Name = "gbxGesCarr";
            this.gbxGesCarr.Size = new System.Drawing.Size(651, 133);
            this.gbxGesCarr.TabIndex = 5;
            this.gbxGesCarr.TabStop = false;
            this.gbxGesCarr.Text = "Gestion des carrières";
            // 
            // lblChoix1
            // 
            this.lblChoix1.AutoSize = true;
            this.lblChoix1.Location = new System.Drawing.Point(25, 40);
            this.lblChoix1.Name = "lblChoix1";
            this.lblChoix1.Size = new System.Drawing.Size(121, 13);
            this.lblChoix1.TabIndex = 0;
            this.lblChoix1.Text = "Veuillez faire votre choix";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(169, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(377, 82);
            this.listBox1.TabIndex = 1;
            // 
            // btnValider1
            // 
            this.btnValider1.Location = new System.Drawing.Point(563, 99);
            this.btnValider1.Name = "btnValider1";
            this.btnValider1.Size = new System.Drawing.Size(75, 23);
            this.btnValider1.TabIndex = 2;
            this.btnValider1.Text = "Valider";
            this.btnValider1.UseVisualStyleBackColor = true;
            // 
            // lblChoix2
            // 
            this.lblChoix2.AutoSize = true;
            this.lblChoix2.Location = new System.Drawing.Point(25, 34);
            this.lblChoix2.Name = "lblChoix2";
            this.lblChoix2.Size = new System.Drawing.Size(121, 13);
            this.lblChoix2.TabIndex = 0;
            this.lblChoix2.Text = "Veuillez faire votre choix";
            // 
            // lblChoix3
            // 
            this.lblChoix3.AutoSize = true;
            this.lblChoix3.Location = new System.Drawing.Point(25, 35);
            this.lblChoix3.Name = "lblChoix3";
            this.lblChoix3.Size = new System.Drawing.Size(121, 13);
            this.lblChoix3.TabIndex = 0;
            this.lblChoix3.Text = "Veuillez faire votre choix";
            // 
            // btnValider2
            // 
            this.btnValider2.Location = new System.Drawing.Point(563, 93);
            this.btnValider2.Name = "btnValider2";
            this.btnValider2.Size = new System.Drawing.Size(75, 23);
            this.btnValider2.TabIndex = 1;
            this.btnValider2.Text = "Valider";
            this.btnValider2.UseVisualStyleBackColor = true;
            // 
            // btnValider3
            // 
            this.btnValider3.Location = new System.Drawing.Point(563, 88);
            this.btnValider3.Name = "btnValider3";
            this.btnValider3.Size = new System.Drawing.Size(75, 23);
            this.btnValider3.TabIndex = 1;
            this.btnValider3.Text = "Valider";
            this.btnValider3.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(169, 34);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(377, 82);
            this.listBox2.TabIndex = 2;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(169, 29);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(377, 82);
            this.listBox3.TabIndex = 2;
            // 
            // frmGesRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 604);
            this.Controls.Add(this.gbxGesCarr);
            this.Controls.Add(this.gbxGesCont);
            this.Controls.Add(this.gbxGesColl);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lblGesRH);
            this.Name = "frmGesRH";
            this.Text = "Gestion Ressources Humaines";
            this.gbxGesColl.ResumeLayout(false);
            this.gbxGesColl.PerformLayout();
            this.gbxGesCont.ResumeLayout(false);
            this.gbxGesCont.PerformLayout();
            this.gbxGesCarr.ResumeLayout(false);
            this.gbxGesCarr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGesRH;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.GroupBox gbxGesColl;
        private System.Windows.Forms.Button btnValider1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblChoix1;
        private System.Windows.Forms.GroupBox gbxGesCont;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnValider2;
        private System.Windows.Forms.Label lblChoix2;
        private System.Windows.Forms.GroupBox gbxGesCarr;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnValider3;
        private System.Windows.Forms.Label lblChoix3;
    }
}