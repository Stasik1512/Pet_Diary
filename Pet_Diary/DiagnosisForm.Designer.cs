namespace Pet_Diary
{
    partial class DiagnosisForm
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
            this.tbDiagnosisComment = new System.Windows.Forms.TextBox();
            this.lblLastDiagnosisName = new System.Windows.Forms.Label();
            this.dtpDiagnosisDate = new System.Windows.Forms.DateTimePicker();
            this.lblNextVaccinationDate = new System.Windows.Forms.Label();
            this.lblLastFoodType = new System.Windows.Forms.Label();
            this.labelDiagnosisForm = new System.Windows.Forms.Label();
            this.dgvDiagnosis = new System.Windows.Forms.DataGridView();
            this.lblLastDiagnosisDate = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            this.tbDiagnosis = new System.Windows.Forms.TextBox();
            this.lblNextDiagnosisName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosis)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDiagnosisComment
            // 
            this.tbDiagnosisComment.Location = new System.Drawing.Point(155, 233);
            this.tbDiagnosisComment.Name = "tbDiagnosisComment";
            this.tbDiagnosisComment.Size = new System.Drawing.Size(272, 20);
            this.tbDiagnosisComment.TabIndex = 50;
            // 
            // lblLastDiagnosisName
            // 
            this.lblLastDiagnosisName.AutoSize = true;
            this.lblLastDiagnosisName.Location = new System.Drawing.Point(14, 29);
            this.lblLastDiagnosisName.Name = "lblLastDiagnosisName";
            this.lblLastDiagnosisName.Size = new System.Drawing.Size(60, 13);
            this.lblLastDiagnosisName.TabIndex = 49;
            this.lblLastDiagnosisName.Text = "Название:";
            // 
            // dtpDiagnosisDate
            // 
            this.dtpDiagnosisDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDiagnosisDate.Location = new System.Drawing.Point(155, 206);
            this.dtpDiagnosisDate.Name = "dtpDiagnosisDate";
            this.dtpDiagnosisDate.Size = new System.Drawing.Size(272, 20);
            this.dtpDiagnosisDate.TabIndex = 48;
            // 
            // lblNextVaccinationDate
            // 
            this.lblNextVaccinationDate.AutoSize = true;
            this.lblNextVaccinationDate.Location = new System.Drawing.Point(18, 210);
            this.lblNextVaccinationDate.Name = "lblNextVaccinationDate";
            this.lblNextVaccinationDate.Size = new System.Drawing.Size(99, 13);
            this.lblNextVaccinationDate.TabIndex = 47;
            this.lblNextVaccinationDate.Text = "Дата вакцинации:";
            // 
            // lblLastFoodType
            // 
            this.lblLastFoodType.AutoSize = true;
            this.lblLastFoodType.Location = new System.Drawing.Point(13, 47);
            this.lblLastFoodType.Name = "lblLastFoodType";
            this.lblLastFoodType.Size = new System.Drawing.Size(0, 13);
            this.lblLastFoodType.TabIndex = 46;
            // 
            // labelDiagnosisForm
            // 
            this.labelDiagnosisForm.AutoSize = true;
            this.labelDiagnosisForm.Location = new System.Drawing.Point(176, 7);
            this.labelDiagnosisForm.Name = "labelDiagnosisForm";
            this.labelDiagnosisForm.Size = new System.Drawing.Size(51, 13);
            this.labelDiagnosisForm.TabIndex = 45;
            this.labelDiagnosisForm.Text = "Диагноз";
            // 
            // dgvDiagnosis
            // 
            this.dgvDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnosis.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDiagnosis.Location = new System.Drawing.Point(17, 66);
            this.dgvDiagnosis.Name = "dgvDiagnosis";
            this.dgvDiagnosis.Size = new System.Drawing.Size(409, 106);
            this.dgvDiagnosis.TabIndex = 44;
            // 
            // lblLastDiagnosisDate
            // 
            this.lblLastDiagnosisDate.AutoSize = true;
            this.lblLastDiagnosisDate.Location = new System.Drawing.Point(14, 50);
            this.lblLastDiagnosisDate.Name = "lblLastDiagnosisDate";
            this.lblLastDiagnosisDate.Size = new System.Drawing.Size(36, 13);
            this.lblLastDiagnosisDate.TabIndex = 43;
            this.lblLastDiagnosisDate.Text = "Дата:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(351, 259);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "Назад";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(269, 259);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(17, 237);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(132, 13);
            this.lblComment.TabIndex = 40;
            this.lblComment.Text = "Следующая вакцинация:";
            // 
            // tbDiagnosis
            // 
            this.tbDiagnosis.Location = new System.Drawing.Point(155, 178);
            this.tbDiagnosis.Name = "tbDiagnosis";
            this.tbDiagnosis.Size = new System.Drawing.Size(272, 20);
            this.tbDiagnosis.TabIndex = 39;
            // 
            // lblNextDiagnosisName
            // 
            this.lblNextDiagnosisName.AutoSize = true;
            this.lblNextDiagnosisName.Location = new System.Drawing.Point(15, 181);
            this.lblNextDiagnosisName.Name = "lblNextDiagnosisName";
            this.lblNextDiagnosisName.Size = new System.Drawing.Size(51, 13);
            this.lblNextDiagnosisName.TabIndex = 38;
            this.lblNextDiagnosisName.Text = "Диагноз";
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 294);
            this.Controls.Add(this.tbDiagnosisComment);
            this.Controls.Add(this.lblLastDiagnosisName);
            this.Controls.Add(this.dtpDiagnosisDate);
            this.Controls.Add(this.lblNextVaccinationDate);
            this.Controls.Add(this.lblLastFoodType);
            this.Controls.Add(this.labelDiagnosisForm);
            this.Controls.Add(this.dgvDiagnosis);
            this.Controls.Add(this.lblLastDiagnosisDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.tbDiagnosis);
            this.Controls.Add(this.lblNextDiagnosisName);
            this.Name = "DiagnosisForm";
            this.Text = "DiagnosisForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDiagnosisComment;
        private System.Windows.Forms.Label lblLastDiagnosisName;
        private System.Windows.Forms.DateTimePicker dtpDiagnosisDate;
        private System.Windows.Forms.Label lblNextVaccinationDate;
        private System.Windows.Forms.Label lblLastFoodType;
        private System.Windows.Forms.Label labelDiagnosisForm;
        private System.Windows.Forms.DataGridView dgvDiagnosis;
        private System.Windows.Forms.Label lblLastDiagnosisDate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox tbDiagnosis;
        private System.Windows.Forms.Label lblNextDiagnosisName;
    }
}