namespace Pet_Diary
{
    partial class VaccinationForm
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
            this.lblNextVaccinationDate = new System.Windows.Forms.Label();
            this.lblLastFoodType = new System.Windows.Forms.Label();
            this.labelFoodPet = new System.Windows.Forms.Label();
            this.dgvVaccination = new System.Windows.Forms.DataGridView();
            this.lblLastVaccinationDate = new System.Windows.Forms.Label();
            this.lblLastVaccination = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpNextVaccinationDate = new System.Windows.Forms.DateTimePicker();
            this.lblNextVaccination = new System.Windows.Forms.Label();
            this.tbVaccineName = new System.Windows.Forms.TextBox();
            this.lblNextVaccinetionName = new System.Windows.Forms.Label();
            this.dtpVaccinationDate = new System.Windows.Forms.DateTimePicker();
            this.lblLastVaccineName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccination)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNextVaccinationDate
            // 
            this.lblNextVaccinationDate.AutoSize = true;
            this.lblNextVaccinationDate.Location = new System.Drawing.Point(12, 234);
            this.lblNextVaccinationDate.Name = "lblNextVaccinationDate";
            this.lblNextVaccinationDate.Size = new System.Drawing.Size(99, 13);
            this.lblNextVaccinationDate.TabIndex = 34;
            this.lblNextVaccinationDate.Text = "Дата вакцинации:";
            // 
            // lblLastFoodType
            // 
            this.lblLastFoodType.AutoSize = true;
            this.lblLastFoodType.Location = new System.Drawing.Point(8, 53);
            this.lblLastFoodType.Name = "lblLastFoodType";
            this.lblLastFoodType.Size = new System.Drawing.Size(0, 13);
            this.lblLastFoodType.TabIndex = 33;
            // 
            // labelFoodPet
            // 
            this.labelFoodPet.AutoSize = true;
            this.labelFoodPet.Location = new System.Drawing.Point(171, 13);
            this.labelFoodPet.Name = "labelFoodPet";
            this.labelFoodPet.Size = new System.Drawing.Size(68, 13);
            this.labelFoodPet.TabIndex = 32;
            this.labelFoodPet.Text = "Вакцинация";
            // 
            // dgvVaccination
            // 
            this.dgvVaccination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaccination.GridColor = System.Drawing.SystemColors.Control;
            this.dgvVaccination.Location = new System.Drawing.Point(11, 90);
            this.dgvVaccination.Name = "dgvVaccination";
            this.dgvVaccination.Size = new System.Drawing.Size(409, 106);
            this.dgvVaccination.TabIndex = 31;
            // 
            // lblLastVaccinationDate
            // 
            this.lblLastVaccinationDate.AutoSize = true;
            this.lblLastVaccinationDate.Location = new System.Drawing.Point(8, 74);
            this.lblLastVaccinationDate.Name = "lblLastVaccinationDate";
            this.lblLastVaccinationDate.Size = new System.Drawing.Size(36, 13);
            this.lblLastVaccinationDate.TabIndex = 30;
            this.lblLastVaccinationDate.Text = "Дата:";
            // 
            // lblLastVaccination
            // 
            this.lblLastVaccination.AutoSize = true;
            this.lblLastVaccination.Location = new System.Drawing.Point(8, 34);
            this.lblLastVaccination.Name = "lblLastVaccination";
            this.lblLastVaccination.Size = new System.Drawing.Size(132, 13);
            this.lblLastVaccination.TabIndex = 29;
            this.lblLastVaccination.Text = "Последняя вакцинация: ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(345, 283);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Назад";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(263, 283);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpNextVaccinationDate
            // 
            this.dtpNextVaccinationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNextVaccinationDate.Location = new System.Drawing.Point(149, 257);
            this.dtpNextVaccinationDate.Name = "dtpNextVaccinationDate";
            this.dtpNextVaccinationDate.Size = new System.Drawing.Size(272, 20);
            this.dtpNextVaccinationDate.TabIndex = 26;
            // 
            // lblNextVaccination
            // 
            this.lblNextVaccination.AutoSize = true;
            this.lblNextVaccination.Location = new System.Drawing.Point(11, 261);
            this.lblNextVaccination.Name = "lblNextVaccination";
            this.lblNextVaccination.Size = new System.Drawing.Size(132, 13);
            this.lblNextVaccination.TabIndex = 25;
            this.lblNextVaccination.Text = "Следующая вакцинация:";
            // 
            // tbVaccineName
            // 
            this.tbVaccineName.Location = new System.Drawing.Point(149, 202);
            this.tbVaccineName.Name = "tbVaccineName";
            this.tbVaccineName.Size = new System.Drawing.Size(272, 20);
            this.tbVaccineName.TabIndex = 24;
            // 
            // lblNextVaccinetionName
            // 
            this.lblNextVaccinetionName.AutoSize = true;
            this.lblNextVaccinetionName.Location = new System.Drawing.Point(9, 205);
            this.lblNextVaccinetionName.Name = "lblNextVaccinetionName";
            this.lblNextVaccinetionName.Size = new System.Drawing.Size(104, 13);
            this.lblNextVaccinetionName.TabIndex = 23;
            this.lblNextVaccinetionName.Text = "Название вакцины";
            // 
            // dtpVaccinationDate
            // 
            this.dtpVaccinationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVaccinationDate.Location = new System.Drawing.Point(149, 230);
            this.dtpVaccinationDate.Name = "dtpVaccinationDate";
            this.dtpVaccinationDate.Size = new System.Drawing.Size(272, 20);
            this.dtpVaccinationDate.TabIndex = 35;
            // 
            // lblLastVaccineName
            // 
            this.lblLastVaccineName.AutoSize = true;
            this.lblLastVaccineName.Location = new System.Drawing.Point(8, 53);
            this.lblLastVaccineName.Name = "lblLastVaccineName";
            this.lblLastVaccineName.Size = new System.Drawing.Size(60, 13);
            this.lblLastVaccineName.TabIndex = 36;
            this.lblLastVaccineName.Text = "Название:";
            // 
            // VaccinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 326);
            this.Controls.Add(this.lblLastVaccineName);
            this.Controls.Add(this.dtpVaccinationDate);
            this.Controls.Add(this.lblNextVaccinationDate);
            this.Controls.Add(this.lblLastFoodType);
            this.Controls.Add(this.labelFoodPet);
            this.Controls.Add(this.dgvVaccination);
            this.Controls.Add(this.lblLastVaccinationDate);
            this.Controls.Add(this.lblLastVaccination);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpNextVaccinationDate);
            this.Controls.Add(this.lblNextVaccination);
            this.Controls.Add(this.tbVaccineName);
            this.Controls.Add(this.lblNextVaccinetionName);
            this.Name = "VaccinationForm";
            this.Text = "VaccinationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNextVaccinationDate;
        private System.Windows.Forms.Label lblLastFoodType;
        private System.Windows.Forms.Label labelFoodPet;
        private System.Windows.Forms.DataGridView dgvVaccination;
        private System.Windows.Forms.Label lblLastVaccinationDate;
        private System.Windows.Forms.Label lblLastVaccination;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpNextVaccinationDate;
        private System.Windows.Forms.Label lblNextVaccination;
        private System.Windows.Forms.TextBox tbVaccineName;
        private System.Windows.Forms.Label lblNextVaccinetionName;
        private System.Windows.Forms.DateTimePicker dtpVaccinationDate;
        private System.Windows.Forms.Label lblLastVaccineName;
    }
}