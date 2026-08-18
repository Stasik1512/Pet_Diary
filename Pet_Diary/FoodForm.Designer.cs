namespace Pet_Diary
{
    partial class FoodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodForm));
            this.labelFoodPet = new System.Windows.Forms.Label();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.lblLastFoodDate = new System.Windows.Forms.Label();
            this.lblLastFood = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpFoodDate = new System.Windows.Forms.DateTimePicker();
            this.labelWeightDate = new System.Windows.Forms.Label();
            this.tbFoodBrand = new System.Windows.Forms.TextBox();
            this.labelFoodBrand = new System.Windows.Forms.Label();
            this.lblLastFoodType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFoodType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFoodPet
            // 
            this.labelFoodPet.AutoSize = true;
            this.labelFoodPet.Location = new System.Drawing.Point(171, 7);
            this.labelFoodPet.Name = "labelFoodPet";
            this.labelFoodPet.Size = new System.Drawing.Size(99, 13);
            this.labelFoodPet.TabIndex = 19;
            this.labelFoodPet.Text = "Питание питомца:";
            // 
            // dgvFood
            // 
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.GridColor = System.Drawing.SystemColors.Control;
            this.dgvFood.Location = new System.Drawing.Point(12, 82);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.Size = new System.Drawing.Size(409, 101);
            this.dgvFood.TabIndex = 18;
            // 
            // lblLastFoodDate
            // 
            this.lblLastFoodDate.AutoSize = true;
            this.lblLastFoodDate.Location = new System.Drawing.Point(9, 66);
            this.lblLastFoodDate.Name = "lblLastFoodDate";
            this.lblLastFoodDate.Size = new System.Drawing.Size(53, 13);
            this.lblLastFoodDate.TabIndex = 17;
            this.lblLastFoodDate.Text = "Записан:";
            // 
            // lblLastFood
            // 
            this.lblLastFood.AutoSize = true;
            this.lblLastFood.Location = new System.Drawing.Point(8, 28);
            this.lblLastFood.Name = "lblLastFood";
            this.lblLastFood.Size = new System.Drawing.Size(95, 13);
            this.lblLastFood.TabIndex = 16;
            this.lblLastFood.Text = "Последний корм:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(345, 277);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Назад";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(263, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpFoodDate
            // 
            this.dtpFoodDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFoodDate.Location = new System.Drawing.Point(117, 251);
            this.dtpFoodDate.Name = "dtpFoodDate";
            this.dtpFoodDate.Size = new System.Drawing.Size(304, 20);
            this.dtpFoodDate.TabIndex = 13;
            // 
            // labelWeightDate
            // 
            this.labelWeightDate.AutoSize = true;
            this.labelWeightDate.Location = new System.Drawing.Point(11, 255);
            this.labelWeightDate.Name = "labelWeightDate";
            this.labelWeightDate.Size = new System.Drawing.Size(36, 13);
            this.labelWeightDate.TabIndex = 12;
            this.labelWeightDate.Text = "Дата:";
            // 
            // tbFoodBrand
            // 
            this.tbFoodBrand.Location = new System.Drawing.Point(117, 196);
            this.tbFoodBrand.Name = "tbFoodBrand";
            this.tbFoodBrand.Size = new System.Drawing.Size(304, 20);
            this.tbFoodBrand.TabIndex = 11;
            // 
            // labelFoodBrand
            // 
            this.labelFoodBrand.AutoSize = true;
            this.labelFoodBrand.Location = new System.Drawing.Point(9, 199);
            this.labelFoodBrand.Name = "labelFoodBrand";
            this.labelFoodBrand.Size = new System.Drawing.Size(44, 13);
            this.labelFoodBrand.TabIndex = 10;
            this.labelFoodBrand.Text = "Фирма";
            // 
            // lblLastFoodType
            // 
            this.lblLastFoodType.AutoSize = true;
            this.lblLastFoodType.Location = new System.Drawing.Point(8, 47);
            this.lblLastFoodType.Name = "lblLastFoodType";
            this.lblLastFoodType.Size = new System.Drawing.Size(64, 13);
            this.lblLastFoodType.TabIndex = 20;
            this.lblLastFoodType.Text = "Тип корма:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Тип:";
            // 
            // cbFoodType
            // 
            this.cbFoodType.FormattingEnabled = true;
            this.cbFoodType.Items.AddRange(new object[] {
            "Сухой",
            "Влажный"});
            this.cbFoodType.Location = new System.Drawing.Point(117, 224);
            this.cbFoodType.Name = "cbFoodType";
            this.cbFoodType.Size = new System.Drawing.Size(304, 21);
            this.cbFoodType.TabIndex = 22;
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 322);
            this.Controls.Add(this.cbFoodType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLastFoodType);
            this.Controls.Add(this.labelFoodPet);
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.lblLastFoodDate);
            this.Controls.Add(this.lblLastFood);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpFoodDate);
            this.Controls.Add(this.labelWeightDate);
            this.Controls.Add(this.tbFoodBrand);
            this.Controls.Add(this.labelFoodBrand);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FoodForm";
            this.Text = "FoodForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFoodPet;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Label lblLastFoodDate;
        private System.Windows.Forms.Label lblLastFood;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpFoodDate;
        private System.Windows.Forms.Label labelWeightDate;
        private System.Windows.Forms.TextBox tbFoodBrand;
        private System.Windows.Forms.Label labelFoodBrand;
        private System.Windows.Forms.Label lblLastFoodType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFoodType;
    }
}