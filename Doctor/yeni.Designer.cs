// ProLab3.DietExerciseRecommendationForm.designer.cs

namespace ProLab3
{
    partial class yeni
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPatientInfo = new System.Windows.Forms.Label();
            this.gbDiets = new System.Windows.Forms.GroupBox();
            this.lstAvailableDiets = new System.Windows.Forms.ListBox();
            this.rtbDietDetails = new System.Windows.Forms.RichTextBox();
            this.btnAddDiet = new System.Windows.Forms.Button();
            this.btnRemoveDiet = new System.Windows.Forms.Button();
            this.gbExercises = new System.Windows.Forms.GroupBox();
            this.lstAvailableExercises = new System.Windows.Forms.ListBox();
            this.rtbExerciseDetails = new System.Windows.Forms.RichTextBox();
            this.btnAddExercise = new System.Windows.Forms.Button();
            this.btnRemoveExercise = new System.Windows.Forms.Button();
            this.gbSelectedRecommendations = new System.Windows.Forms.GroupBox();
            this.lblSelectedDiets = new System.Windows.Forms.Label();
            this.lstSelectedDiets = new System.Windows.Forms.ListBox();
            this.lblSelectedExercises = new System.Windows.Forms.Label();
            this.lstSelectedExercises = new System.Windows.Forms.ListBox();
            this.btnSaveRecommendations = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.gbDiets.SuspendLayout();
            this.gbExercises.SuspendLayout();
            this.gbSelectedRecommendations.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblPatientInfo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(984, 80); // Adjusted for typical form width
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(361, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hasta Diyet ve Egzersiz Önerileri";
            // 
            // lblPatientInfo
            // 
            this.lblPatientInfo.AutoSize = true;
            this.lblPatientInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPatientInfo.ForeColor = System.Drawing.Color.White;
            this.lblPatientInfo.Location = new System.Drawing.Point(20, 45);
            this.lblPatientInfo.Name = "lblPatientInfo";
            this.lblPatientInfo.Size = new System.Drawing.Size(89, 19);
            this.lblPatientInfo.TabIndex = 1;
            this.lblPatientInfo.Text = "Patient Info"; // Placeholder, set in SetupForm
            // 
            // gbDiets
            // 
            this.gbDiets.BackColor = System.Drawing.Color.White;
            this.gbDiets.Controls.Add(this.lstAvailableDiets);
            this.gbDiets.Controls.Add(this.rtbDietDetails);
            this.gbDiets.Controls.Add(this.btnAddDiet);
            this.gbDiets.Controls.Add(this.btnRemoveDiet);
            this.gbDiets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbDiets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.gbDiets.Location = new System.Drawing.Point(20, 100);
            this.gbDiets.Name = "gbDiets";
            this.gbDiets.Size = new System.Drawing.Size(450, 280);
            this.gbDiets.TabIndex = 1;
            this.gbDiets.TabStop = false;
            this.gbDiets.Text = "Diyet Türleri";
            // 
            // lstAvailableDiets
            // 
            this.lstAvailableDiets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstAvailableDiets.FormattingEnabled = true;
            this.lstAvailableDiets.ItemHeight = 15;
            this.lstAvailableDiets.Location = new System.Drawing.Point(15, 30);
            this.lstAvailableDiets.Name = "lstAvailableDiets";
            this.lstAvailableDiets.Size = new System.Drawing.Size(200, 124); // Adjusted height for 120 + padding
            this.lstAvailableDiets.TabIndex = 0;
            this.lstAvailableDiets.SelectedIndexChanged += new System.EventHandler(this.LstAvailableDiets_SelectedIndexChanged);
            // 
            // rtbDietDetails
            // 
            this.rtbDietDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.rtbDietDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtbDietDetails.Location = new System.Drawing.Point(15, 160);
            this.rtbDietDetails.Name = "rtbDietDetails";
            this.rtbDietDetails.ReadOnly = true;
            this.rtbDietDetails.Size = new System.Drawing.Size(420, 80);
            this.rtbDietDetails.TabIndex = 1;
            this.rtbDietDetails.Text = "";
            // 
            // btnAddDiet
            // 
            this.btnAddDiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.btnAddDiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDiet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddDiet.ForeColor = System.Drawing.Color.White;
            this.btnAddDiet.Location = new System.Drawing.Point(230, 50);
            this.btnAddDiet.Name = "btnAddDiet";
            this.btnAddDiet.Size = new System.Drawing.Size(100, 35);
            this.btnAddDiet.TabIndex = 2;
            this.btnAddDiet.Text = "Diyet Ekle →";
            this.btnAddDiet.UseVisualStyleBackColor = false;
            this.btnAddDiet.Click += new System.EventHandler(this.BtnAddDiet_Click);
            // 
            // btnRemoveDiet
            // 
            this.btnRemoveDiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.btnRemoveDiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDiet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveDiet.ForeColor = System.Drawing.Color.White;
            this.btnRemoveDiet.Location = new System.Drawing.Point(230, 95);
            this.btnRemoveDiet.Name = "btnRemoveDiet";
            this.btnRemoveDiet.Size = new System.Drawing.Size(100, 35);
            this.btnRemoveDiet.TabIndex = 3;
            this.btnRemoveDiet.Text = "← Diyet Çıkar";
            this.btnRemoveDiet.UseVisualStyleBackColor = false;
            this.btnRemoveDiet.Click += new System.EventHandler(this.BtnRemoveDiet_Click);
            // 
            // gbExercises
            // 
            this.gbExercises.BackColor = System.Drawing.Color.White;
            this.gbExercises.Controls.Add(this.lstAvailableExercises);
            this.gbExercises.Controls.Add(this.rtbExerciseDetails);
            this.gbExercises.Controls.Add(this.btnAddExercise);
            this.gbExercises.Controls.Add(this.btnRemoveExercise);
            this.gbExercises.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbExercises.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.gbExercises.Location = new System.Drawing.Point(490, 100);
            this.gbExercises.Name = "gbExercises";
            this.gbExercises.Size = new System.Drawing.Size(450, 280);
            this.gbExercises.TabIndex = 2;
            this.gbExercises.TabStop = false;
            this.gbExercises.Text = "Egzersiz Türleri";
            // 
            // lstAvailableExercises
            // 
            this.lstAvailableExercises.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstAvailableExercises.FormattingEnabled = true;
            this.lstAvailableExercises.ItemHeight = 15;
            this.lstAvailableExercises.Location = new System.Drawing.Point(15, 30);
            this.lstAvailableExercises.Name = "lstAvailableExercises";
            this.lstAvailableExercises.Size = new System.Drawing.Size(200, 124); // Adjusted height
            this.lstAvailableExercises.TabIndex = 0;
            this.lstAvailableExercises.SelectedIndexChanged += new System.EventHandler(this.LstAvailableExercises_SelectedIndexChanged);
            // 
            // rtbExerciseDetails
            // 
            this.rtbExerciseDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.rtbExerciseDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtbExerciseDetails.Location = new System.Drawing.Point(15, 160);
            this.rtbExerciseDetails.Name = "rtbExerciseDetails";
            this.rtbExerciseDetails.ReadOnly = true;
            this.rtbExerciseDetails.Size = new System.Drawing.Size(420, 80);
            this.rtbExerciseDetails.TabIndex = 1;
            this.rtbExerciseDetails.Text = "";
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.btnAddExercise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExercise.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddExercise.ForeColor = System.Drawing.Color.White;
            this.btnAddExercise.Location = new System.Drawing.Point(230, 50);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(100, 35);
            this.btnAddExercise.TabIndex = 2;
            this.btnAddExercise.Text = "Egzersiz Ekle →";
            this.btnAddExercise.UseVisualStyleBackColor = false;
            this.btnAddExercise.Click += new System.EventHandler(this.BtnAddExercise_Click);
            // 
            // btnRemoveExercise
            // 
            this.btnRemoveExercise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.btnRemoveExercise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveExercise.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveExercise.ForeColor = System.Drawing.Color.White;
            this.btnRemoveExercise.Location = new System.Drawing.Point(230, 95);
            this.btnRemoveExercise.Name = "btnRemoveExercise";
            this.btnRemoveExercise.Size = new System.Drawing.Size(100, 35);
            this.btnRemoveExercise.TabIndex = 3;
            this.btnRemoveExercise.Text = "← Egzersiz Çıkar";
            this.btnRemoveExercise.UseVisualStyleBackColor = false;
            this.btnRemoveExercise.Click += new System.EventHandler(this.BtnRemoveExercise_Click);
            // 
            // gbSelectedRecommendations
            // 
            this.gbSelectedRecommendations.BackColor = System.Drawing.Color.White;
            this.gbSelectedRecommendations.Controls.Add(this.lblSelectedDiets);
            this.gbSelectedRecommendations.Controls.Add(this.lstSelectedDiets);
            this.gbSelectedRecommendations.Controls.Add(this.lblSelectedExercises);
            this.gbSelectedRecommendations.Controls.Add(this.lstSelectedExercises);
            this.gbSelectedRecommendations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbSelectedRecommendations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.gbSelectedRecommendations.Location = new System.Drawing.Point(20, 400);
            this.gbSelectedRecommendations.Name = "gbSelectedRecommendations";
            this.gbSelectedRecommendations.Size = new System.Drawing.Size(920, 200);
            this.gbSelectedRecommendations.TabIndex = 3;
            this.gbSelectedRecommendations.TabStop = false;
            this.gbSelectedRecommendations.Text = "Seçilen Öneriler";
            // 
            // lblSelectedDiets
            // 
            this.lblSelectedDiets.AutoSize = true;
            this.lblSelectedDiets.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectedDiets.Location = new System.Drawing.Point(15, 30);
            this.lblSelectedDiets.Name = "lblSelectedDiets";
            this.lblSelectedDiets.Size = new System.Drawing.Size(116, 19);
            this.lblSelectedDiets.TabIndex = 0;
            this.lblSelectedDiets.Text = "Seçilen Diyetler:";
            // 
            // lstSelectedDiets
            // 
            this.lstSelectedDiets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.lstSelectedDiets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstSelectedDiets.FormattingEnabled = true;
            this.lstSelectedDiets.ItemHeight = 15;
            this.lstSelectedDiets.Location = new System.Drawing.Point(15, 55);
            this.lstSelectedDiets.Name = "lstSelectedDiets";
            this.lstSelectedDiets.Size = new System.Drawing.Size(420, 124); // Adjusted height
            this.lstSelectedDiets.TabIndex = 1;
            // 
            // lblSelectedExercises
            // 
            this.lblSelectedExercises.AutoSize = true;
            this.lblSelectedExercises.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectedExercises.Location = new System.Drawing.Point(460, 30);
            this.lblSelectedExercises.Name = "lblSelectedExercises";
            this.lblSelectedExercises.Size = new System.Drawing.Size(139, 19);
            this.lblSelectedExercises.TabIndex = 2;
            this.lblSelectedExercises.Text = "Seçilen Egzersizler:";
            // 
            // lstSelectedExercises
            // 
            this.lstSelectedExercises.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.lstSelectedExercises.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstSelectedExercises.FormattingEnabled = true;
            this.lstSelectedExercises.ItemHeight = 15;
            this.lstSelectedExercises.Location = new System.Drawing.Point(460, 55);
            this.lstSelectedExercises.Name = "lstSelectedExercises";
            this.lstSelectedExercises.Size = new System.Drawing.Size(420, 124); // Adjusted height
            this.lstSelectedExercises.TabIndex = 3;
            // 
            // btnSaveRecommendations
            // 
            this.btnSaveRecommendations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnSaveRecommendations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveRecommendations.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveRecommendations.ForeColor = System.Drawing.Color.White;
            this.btnSaveRecommendations.Location = new System.Drawing.Point(720, 620);
            this.btnSaveRecommendations.Name = "btnSaveRecommendations";
            this.btnSaveRecommendations.Size = new System.Drawing.Size(120, 40);
            this.btnSaveRecommendations.TabIndex = 4;
            this.btnSaveRecommendations.Text = "Önerileri Kaydet";
            this.btnSaveRecommendations.UseVisualStyleBackColor = false;
            this.btnSaveRecommendations.Click += new System.EventHandler(this.BtnSaveRecommendations_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(860, 620);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // DietExerciseRecommendationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 681); // Adjusted client size based on Form Size and BorderStyle
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveRecommendations);
            this.Controls.Add(this.gbSelectedRecommendations);
            this.Controls.Add(this.gbExercises);
            this.Controls.Add(this.gbDiets);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DietExerciseRecommendationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diyet ve Egzersiz Önerileri";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.gbDiets.ResumeLayout(false);
            this.gbExercises.ResumeLayout(false);
            this.gbSelectedRecommendations.ResumeLayout(false);
            this.gbSelectedRecommendations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPatientInfo;
        private System.Windows.Forms.GroupBox gbDiets;
        private System.Windows.Forms.ListBox lstAvailableDiets;
        private System.Windows.Forms.RichTextBox rtbDietDetails;
        private System.Windows.Forms.Button btnAddDiet;
        private System.Windows.Forms.Button btnRemoveDiet;
        private System.Windows.Forms.GroupBox gbExercises;
        private System.Windows.Forms.ListBox lstAvailableExercises;
        private System.Windows.Forms.RichTextBox rtbExerciseDetails;
        private System.Windows.Forms.Button btnAddExercise;
        private System.Windows.Forms.Button btnRemoveExercise;
        private System.Windows.Forms.GroupBox gbSelectedRecommendations;
        private System.Windows.Forms.Label lblSelectedDiets; // Declared as field
        private System.Windows.Forms.ListBox lstSelectedDiets;
        private System.Windows.Forms.Label lblSelectedExercises; // Declared as field
        private System.Windows.Forms.ListBox lstSelectedExercises;
        private System.Windows.Forms.Button btnSaveRecommendations;
        private System.Windows.Forms.Button btnCancel;
    }
}