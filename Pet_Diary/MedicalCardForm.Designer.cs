namespace Pet_Diary
{
    partial class MedicalCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalCardForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnWeight = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnVaccination = new System.Windows.Forms.Button();
            this.btnDiagnosis = new System.Windows.Forms.Button();
            this.btnTreatment = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Медицинская карта";
            // 
            // btnWeight
            // 
            this.btnWeight.Location = new System.Drawing.Point(84, 32);
            this.btnWeight.Name = "btnWeight";
            this.btnWeight.Size = new System.Drawing.Size(76, 28);
            this.btnWeight.TabIndex = 2;
            this.btnWeight.Text = "Вес";
            this.btnWeight.UseVisualStyleBackColor = true;
            this.btnWeight.Click += new System.EventHandler(this.btnWeight_Click);
            // 
            // btnFood
            // 
            this.btnFood.Location = new System.Drawing.Point(84, 66);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(76, 28);
            this.btnFood.TabIndex = 3;
            this.btnFood.Text = "Питание";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnVaccination
            // 
            this.btnVaccination.Location = new System.Drawing.Point(84, 100);
            this.btnVaccination.Name = "btnVaccination";
            this.btnVaccination.Size = new System.Drawing.Size(76, 28);
            this.btnVaccination.TabIndex = 4;
            this.btnVaccination.Text = "Вакцинация";
            this.btnVaccination.UseVisualStyleBackColor = true;
            // 
            // btnDiagnosis
            // 
            this.btnDiagnosis.Location = new System.Drawing.Point(84, 134);
            this.btnDiagnosis.Name = "btnDiagnosis";
            this.btnDiagnosis.Size = new System.Drawing.Size(76, 28);
            this.btnDiagnosis.TabIndex = 5;
            this.btnDiagnosis.Text = "Диагноз";
            this.btnDiagnosis.UseVisualStyleBackColor = true;
            // 
            // btnTreatment
            // 
            this.btnTreatment.Location = new System.Drawing.Point(84, 168);
            this.btnTreatment.Name = "btnTreatment";
            this.btnTreatment.Size = new System.Drawing.Size(76, 28);
            this.btnTreatment.TabIndex = 6;
            this.btnTreatment.Text = "Лечение";
            this.btnTreatment.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(84, 214);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MedicalCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 254);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTreatment);
            this.Controls.Add(this.btnDiagnosis);
            this.Controls.Add(this.btnVaccination);
            this.Controls.Add(this.btnFood);
            this.Controls.Add(this.btnWeight);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MedicalCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicalCardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWeight;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnVaccination;
        private System.Windows.Forms.Button btnDiagnosis;
        private System.Windows.Forms.Button btnTreatment;
        private System.Windows.Forms.Button btnClose;
    }
}