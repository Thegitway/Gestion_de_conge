namespace congé
{
    partial class SupprimerConge
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
            this.labelDateD = new System.Windows.Forms.Label();
            this.labelCIN = new System.Windows.Forms.Label();
            this.dateTimePickerDateDebut = new System.Windows.Forms.DateTimePicker();
            this.textBoxCIN = new System.Windows.Forms.TextBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.dateTimePickerDateFin = new System.Windows.Forms.DateTimePicker();
            this.buttonX = new System.Windows.Forms.Button();
            this.labelTitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDateD
            // 
            this.labelDateD.AutoSize = true;
            this.labelDateD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.labelDateD.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateD.Location = new System.Drawing.Point(132, 246);
            this.labelDateD.Name = "labelDateD";
            this.labelDateD.Size = new System.Drawing.Size(168, 26);
            this.labelDateD.TabIndex = 61;
            this.labelDateD.Text = "Date de debut";
            // 
            // labelCIN
            // 
            this.labelCIN.AutoSize = true;
            this.labelCIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.labelCIN.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCIN.Location = new System.Drawing.Point(132, 185);
            this.labelCIN.Name = "labelCIN";
            this.labelCIN.Size = new System.Drawing.Size(51, 26);
            this.labelCIN.TabIndex = 60;
            this.labelCIN.Text = "CIN";
            // 
            // dateTimePickerDateDebut
            // 
            this.dateTimePickerDateDebut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateDebut.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateDebut.Location = new System.Drawing.Point(501, 257);
            this.dateTimePickerDateDebut.MinimumSize = new System.Drawing.Size(200, 0);
            this.dateTimePickerDateDebut.Name = "dateTimePickerDateDebut";
            this.dateTimePickerDateDebut.Size = new System.Drawing.Size(637, 27);
            this.dateTimePickerDateDebut.TabIndex = 59;
            // 
            // textBoxCIN
            // 
            this.textBoxCIN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCIN.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCIN.Location = new System.Drawing.Point(501, 185);
            this.textBoxCIN.MaxLength = 20;
            this.textBoxCIN.MinimumSize = new System.Drawing.Size(200, 0);
            this.textBoxCIN.Name = "textBoxCIN";
            this.textBoxCIN.Size = new System.Drawing.Size(541, 34);
            this.textBoxCIN.TabIndex = 58;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.Location = new System.Drawing.Point(447, 349);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(120, 40);
            this.buttonAnnuler.TabIndex = 57;
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
            this.buttonValider.Location = new System.Drawing.Point(220, 349);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(120, 40);
            this.buttonValider.TabIndex = 56;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseCompatibleTextRendering = true;
            this.buttonValider.UseVisualStyleBackColor = false;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.AutoSize = true;
            this.buttonSupprimer.BackColor = System.Drawing.Color.Salmon;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSupprimer.Location = new System.Drawing.Point(672, 349);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(120, 40);
            this.buttonSupprimer.TabIndex = 55;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseCompatibleTextRendering = true;
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.labelDateFin.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFin.Location = new System.Drawing.Point(132, 290);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(133, 26);
            this.labelDateFin.TabIndex = 63;
            this.labelDateFin.Text = "Date de Fin";
            // 
            // dateTimePickerDateFin
            // 
            this.dateTimePickerDateFin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateFin.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateFin.Location = new System.Drawing.Point(501, 301);
            this.dateTimePickerDateFin.MinimumSize = new System.Drawing.Size(200, 0);
            this.dateTimePickerDateFin.Name = "dateTimePickerDateFin";
            this.dateTimePickerDateFin.Size = new System.Drawing.Size(637, 27);
            this.dateTimePickerDateFin.TabIndex = 62;
            // 
            // buttonX
            // 
            this.buttonX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.buttonX.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX.Location = new System.Drawing.Point(1195, 51);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(30, 30);
            this.buttonX.TabIndex = 64;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = false;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.labelTitre.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTitre.Location = new System.Drawing.Point(458, 51);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(344, 43);
            this.labelTitre.TabIndex = 65;
            this.labelTitre.Text = "Information congé";
            // 
            // SupprimerConge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 638);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.labelDateFin);
            this.Controls.Add(this.dateTimePickerDateFin);
            this.Controls.Add(this.labelDateD);
            this.Controls.Add(this.labelCIN);
            this.Controls.Add(this.dateTimePickerDateDebut);
            this.Controls.Add(this.textBoxCIN);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.buttonSupprimer);
            this.Name = "SupprimerConge";
            this.Text = "SupprimerConge";
            this.Load += new System.EventHandler(this.SupprimerConge_Load);
            this.Shown += new System.EventHandler(this.SupprimerConge_Shown);
            this.Resize += new System.EventHandler(this.SupprimerConge_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDateD;
        private System.Windows.Forms.Label labelCIN;
        public System.Windows.Forms.DateTimePicker dateTimePickerDateDebut;
        public System.Windows.Forms.TextBox textBoxCIN;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Label labelDateFin;
        public System.Windows.Forms.DateTimePicker dateTimePickerDateFin;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Label labelTitre;
    }
}