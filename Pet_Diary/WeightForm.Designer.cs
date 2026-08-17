namespace Pet_Diary
{
    partial class WeightForm
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
            this.labelWeight = new System.Windows.Forms.Label();
            this.tbWieght = new System.Windows.Forms.TextBox();
            this.labelWeightDate = new System.Windows.Forms.Label();
            this.dtpWeightDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(18, 16);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(46, 13);
            this.labelWeight.TabIndex = 0;
            this.labelWeight.Text = "Вес (кг)";
            // 
            // tbWieght
            // 
            this.tbWieght.Location = new System.Drawing.Point(120, 12);
            this.tbWieght.Name = "tbWieght";
            this.tbWieght.Size = new System.Drawing.Size(200, 20);
            this.tbWieght.TabIndex = 1;
            // 
            // labelWeightDate
            // 
            this.labelWeightDate.AutoSize = true;
            this.labelWeightDate.Location = new System.Drawing.Point(18, 51);
            this.labelWeightDate.Name = "labelWeightDate";
            this.labelWeightDate.Size = new System.Drawing.Size(36, 13);
            this.labelWeightDate.TabIndex = 2;
            this.labelWeightDate.Text = "Дата:";
            // 
            // dtpWeightDate
            // 
            this.dtpWeightDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWeightDate.Location = new System.Drawing.Point(120, 47);
            this.dtpWeightDate.Name = "dtpWeightDate";
            this.dtpWeightDate.Size = new System.Drawing.Size(200, 20);
            this.dtpWeightDate.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(162, 78);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(244, 78);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Назад";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // WeightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 114);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpWeightDate);
            this.Controls.Add(this.labelWeightDate);
            this.Controls.Add(this.tbWieght);
            this.Controls.Add(this.labelWeight);
            this.Name = "WeightForm";
            this.Text = "WeightForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox tbWieght;
        private System.Windows.Forms.Label labelWeightDate;
        private System.Windows.Forms.DateTimePicker dtpWeightDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}