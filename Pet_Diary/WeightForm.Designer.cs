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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeightForm));
            this.labelWeight = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.labelWeightDate = new System.Windows.Forms.Label();
            this.dtpWeightDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLastWeight = new System.Windows.Forms.Label();
            this.lblLastWeightDate = new System.Windows.Forms.Label();
            this.dgvWeight = new System.Windows.Forms.DataGridView();
            this.labelWeightPet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(13, 201);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(46, 13);
            this.labelWeight.TabIndex = 0;
            this.labelWeight.Text = "Вес (кг)";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(121, 198);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(304, 20);
            this.tbWeight.TabIndex = 1;
            // 
            // labelWeightDate
            // 
            this.labelWeightDate.AutoSize = true;
            this.labelWeightDate.Location = new System.Drawing.Point(13, 230);
            this.labelWeightDate.Name = "labelWeightDate";
            this.labelWeightDate.Size = new System.Drawing.Size(36, 13);
            this.labelWeightDate.TabIndex = 2;
            this.labelWeightDate.Text = "Дата:";
            // 
            // dtpWeightDate
            // 
            this.dtpWeightDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWeightDate.Location = new System.Drawing.Point(121, 224);
            this.dtpWeightDate.Name = "dtpWeightDate";
            this.dtpWeightDate.Size = new System.Drawing.Size(304, 20);
            this.dtpWeightDate.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(267, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(349, 256);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Назад";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLastWeight
            // 
            this.lblLastWeight.AutoSize = true;
            this.lblLastWeight.Location = new System.Drawing.Point(13, 26);
            this.lblLastWeight.Name = "lblLastWeight";
            this.lblLastWeight.Size = new System.Drawing.Size(87, 13);
            this.lblLastWeight.TabIndex = 6;
            this.lblLastWeight.Text = "Последний вес:";
            // 
            // lblLastWeightDate
            // 
            this.lblLastWeightDate.AutoSize = true;
            this.lblLastWeightDate.Location = new System.Drawing.Point(13, 55);
            this.lblLastWeightDate.Name = "lblLastWeightDate";
            this.lblLastWeightDate.Size = new System.Drawing.Size(56, 13);
            this.lblLastWeightDate.TabIndex = 7;
            this.lblLastWeightDate.Text = "Измерен:";
            // 
            // dgvWeight
            // 
            this.dgvWeight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeight.Location = new System.Drawing.Point(16, 84);
            this.dgvWeight.Name = "dgvWeight";
            this.dgvWeight.Size = new System.Drawing.Size(409, 101);
            this.dgvWeight.TabIndex = 8;
            // 
            // labelWeightPet
            // 
            this.labelWeightPet.AutoSize = true;
            this.labelWeightPet.Location = new System.Drawing.Point(175, 9);
            this.labelWeightPet.Name = "labelWeightPet";
            this.labelWeightPet.Size = new System.Drawing.Size(75, 13);
            this.labelWeightPet.TabIndex = 9;
            this.labelWeightPet.Text = "Вес питомца:";
            // 
            // WeightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 294);
            this.Controls.Add(this.labelWeightPet);
            this.Controls.Add(this.dgvWeight);
            this.Controls.Add(this.lblLastWeightDate);
            this.Controls.Add(this.lblLastWeight);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpWeightDate);
            this.Controls.Add(this.labelWeightDate);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.labelWeight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeightForm";
            this.Text = "   ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label labelWeightDate;
        private System.Windows.Forms.DateTimePicker dtpWeightDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLastWeight;
        private System.Windows.Forms.Label lblLastWeightDate;
        private System.Windows.Forms.DataGridView dgvWeight;
        private System.Windows.Forms.Label labelWeightPet;
    }
}