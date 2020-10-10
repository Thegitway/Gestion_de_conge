namespace congé
{
    partial class Modifier
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
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAffecterCon = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelJourCon = new System.Windows.Forms.Label();
            this.labelMatricule = new System.Windows.Forms.Label();
            this.labelDateE = new System.Windows.Forms.Label();
            this.labelCNSS = new System.Windows.Forms.Label();
            this.labelCIN = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxJourCon = new System.Windows.Forms.TextBox();
            this.textBoxMatricule = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxCNSS = new System.Windows.Forms.TextBox();
            this.textBoxCIN = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.buttonX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.Location = new System.Drawing.Point(719, 417);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(120, 40);
            this.buttonAnnuler.TabIndex = 41;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseCompatibleTextRendering = true;
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.AutoSize = true;
            this.buttonValider.BackColor = System.Drawing.Color.Coral;
            this.buttonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValider.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValider.Location = new System.Drawing.Point(492, 417);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(120, 40);
            this.buttonValider.TabIndex = 40;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseCompatibleTextRendering = true;
            this.buttonValider.UseVisualStyleBackColor = false;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonAffecterCon
            // 
            this.buttonAffecterCon.AutoSize = true;
            this.buttonAffecterCon.BackColor = System.Drawing.Color.Coral;
            this.buttonAffecterCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAffecterCon.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAffecterCon.Location = new System.Drawing.Point(907, 64);
            this.buttonAffecterCon.Name = "buttonAffecterCon";
            this.buttonAffecterCon.Size = new System.Drawing.Size(123, 41);
            this.buttonAffecterCon.TabIndex = 39;
            this.buttonAffecterCon.Text = "Congé";
            this.buttonAffecterCon.UseCompatibleTextRendering = true;
            this.buttonAffecterCon.UseVisualStyleBackColor = false;
            this.buttonAffecterCon.Click += new System.EventHandler(this.buttonAffecterCon_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.AutoSize = true;
            this.buttonSupprimer.BackColor = System.Drawing.Color.Salmon;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSupprimer.Location = new System.Drawing.Point(944, 417);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(120, 40);
            this.buttonSupprimer.TabIndex = 38;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseCompatibleTextRendering = true;
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.labelTitre.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTitre.Location = new System.Drawing.Point(470, 31);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(219, 43);
            this.labelTitre.TabIndex = 37;
            this.labelTitre.Text = "Information";
            // 
            // labelJourCon
            // 
            this.labelJourCon.AutoSize = true;
            this.labelJourCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.labelJourCon.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJourCon.Location = new System.Drawing.Point(338, 352);
            this.labelJourCon.Name = "labelJourCon";
            this.labelJourCon.Size = new System.Drawing.Size(228, 26);
            this.labelJourCon.TabIndex = 56;
            this.labelJourCon.Text = "Jours de congé / an";
            // 
            // labelMatricule
            // 
            this.labelMatricule.AutoSize = true;
            this.labelMatricule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.labelMatricule.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatricule.Location = new System.Drawing.Point(338, 320);
            this.labelMatricule.Name = "labelMatricule";
            this.labelMatricule.Size = new System.Drawing.Size(112, 26);
            this.labelMatricule.TabIndex = 55;
            this.labelMatricule.Text = "Matricule";
            // 
            // labelDateE
            // 
            this.labelDateE.AutoSize = true;
            this.labelDateE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.labelDateE.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateE.Location = new System.Drawing.Point(338, 284);
            this.labelDateE.Name = "labelDateE";
            this.labelDateE.Size = new System.Drawing.Size(208, 26);
            this.labelDateE.TabIndex = 54;
            this.labelDateE.Text = "Date d\'embauche";
            // 
            // labelCNSS
            // 
            this.labelCNSS.AutoSize = true;
            this.labelCNSS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.labelCNSS.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCNSS.Location = new System.Drawing.Point(328, 232);
            this.labelCNSS.Name = "labelCNSS";
            this.labelCNSS.Size = new System.Drawing.Size(67, 26);
            this.labelCNSS.TabIndex = 53;
            this.labelCNSS.Text = "CNSS";
            // 
            // labelCIN
            // 
            this.labelCIN.AutoSize = true;
            this.labelCIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.labelCIN.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCIN.Location = new System.Drawing.Point(328, 206);
            this.labelCIN.Name = "labelCIN";
            this.labelCIN.Size = new System.Drawing.Size(51, 26);
            this.labelCIN.TabIndex = 52;
            this.labelCIN.Text = "CIN";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.labelPrenom.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.Location = new System.Drawing.Point(328, 178);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(93, 26);
            this.labelPrenom.TabIndex = 51;
            this.labelPrenom.Text = "Prenom";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.labelNom.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(338, 138);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(63, 26);
            this.labelNom.TabIndex = 50;
            this.labelNom.Text = "Nom";
            // 
            // textBoxJourCon
            // 
            this.textBoxJourCon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxJourCon.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJourCon.Location = new System.Drawing.Point(537, 354);
            this.textBoxJourCon.MaxLength = 10;
            this.textBoxJourCon.MinimumSize = new System.Drawing.Size(200, 0);
            this.textBoxJourCon.Name = "textBoxJourCon";
            this.textBoxJourCon.Size = new System.Drawing.Size(449, 34);
            this.textBoxJourCon.TabIndex = 49;
            this.textBoxJourCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxJourCon_KeyPress);
            // 
            // textBoxMatricule
            // 
            this.textBoxMatricule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMatricule.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMatricule.Location = new System.Drawing.Point(526, 322);
            this.textBoxMatricule.MaxLength = 20;
            this.textBoxMatricule.MinimumSize = new System.Drawing.Size(200, 0);
            this.textBoxMatricule.Name = "textBoxMatricule";
            this.textBoxMatricule.Size = new System.Drawing.Size(449, 34);
            this.textBoxMatricule.TabIndex = 48;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDate.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.Location = new System.Drawing.Point(526, 284);
            this.dateTimePickerDate.MinimumSize = new System.Drawing.Size(200, 0);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(449, 27);
            this.dateTimePickerDate.TabIndex = 47;
            // 
            // textBoxCNSS
            // 
            this.textBoxCNSS.AcceptsReturn = true;
            this.textBoxCNSS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCNSS.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCNSS.Location = new System.Drawing.Point(526, 246);
            this.textBoxCNSS.MaxLength = 20;
            this.textBoxCNSS.MinimumSize = new System.Drawing.Size(200, 0);
            this.textBoxCNSS.Name = "textBoxCNSS";
            this.textBoxCNSS.Size = new System.Drawing.Size(449, 34);
            this.textBoxCNSS.TabIndex = 46;
            // 
            // textBoxCIN
            // 
            this.textBoxCIN.AcceptsReturn = true;
            this.textBoxCIN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCIN.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCIN.Location = new System.Drawing.Point(526, 206);
            this.textBoxCIN.MaxLength = 20;
            this.textBoxCIN.MinimumSize = new System.Drawing.Size(200, 0);
            this.textBoxCIN.Name = "textBoxCIN";
            this.textBoxCIN.Size = new System.Drawing.Size(449, 34);
            this.textBoxCIN.TabIndex = 45;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrenom.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenom.Location = new System.Drawing.Point(526, 172);
            this.textBoxPrenom.MaxLength = 20;
            this.textBoxPrenom.MinimumSize = new System.Drawing.Size(200, 0);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(449, 34);
            this.textBoxPrenom.TabIndex = 44;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNom.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(526, 132);
            this.textBoxNom.MaxLength = 20;
            this.textBoxNom.MinimumSize = new System.Drawing.Size(200, 0);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(449, 34);
            this.textBoxNom.TabIndex = 43;
            // 
            // buttonX
            // 
            this.buttonX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.buttonX.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX.Location = new System.Drawing.Point(1245, 31);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(30, 30);
            this.buttonX.TabIndex = 57;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = false;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // Modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 651);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.labelJourCon);
            this.Controls.Add(this.labelMatricule);
            this.Controls.Add(this.labelDateE);
            this.Controls.Add(this.labelCNSS);
            this.Controls.Add(this.labelCIN);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxJourCon);
            this.Controls.Add(this.textBoxMatricule);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.textBoxCNSS);
            this.Controls.Add(this.textBoxCIN);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.buttonAffecterCon);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.labelTitre);
            this.Name = "Modifier";
            this.Text = "Modifier";
            this.Load += new System.EventHandler(this.Modifier_Load);
            this.Shown += new System.EventHandler(this.Modifier_Shown);
            this.Resize += new System.EventHandler(this.Modifier_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAffecterCon;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelJourCon;
        private System.Windows.Forms.Label labelMatricule;
        private System.Windows.Forms.Label labelDateE;
        private System.Windows.Forms.Label labelCNSS;
        private System.Windows.Forms.Label labelCIN;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        public System.Windows.Forms.TextBox textBoxJourCon;
        public System.Windows.Forms.TextBox textBoxMatricule;
        public System.Windows.Forms.DateTimePicker dateTimePickerDate;
        public System.Windows.Forms.TextBox textBoxCNSS;
        public System.Windows.Forms.TextBox textBoxCIN;
        public System.Windows.Forms.TextBox textBoxPrenom;
        public System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button buttonX;
    }
}