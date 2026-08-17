namespace Pet_Diary
{
    partial class AddPetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPetForm));
            this.labelName = new System.Windows.Forms.Label();
            this.labelBreed = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirth = new System.Windows.Forms.Label();
            this.tbPetName = new System.Windows.Forms.TextBox();
            this.tbPetBreed = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpPetBirth = new System.Windows.Forms.DateTimePicker();
            this.cbPetGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Имя:";
            // 
            // labelBreed
            // 
            this.labelBreed.AutoSize = true;
            this.labelBreed.Location = new System.Drawing.Point(16, 58);
            this.labelBreed.Name = "labelBreed";
            this.labelBreed.Size = new System.Drawing.Size(45, 13);
            this.labelBreed.TabIndex = 1;
            this.labelBreed.Text = "Порода";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(16, 91);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(30, 13);
            this.labelGender.TabIndex = 2;
            this.labelGender.Text = "Пол:";
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Location = new System.Drawing.Point(16, 122);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(90, 13);
            this.labelBirth.TabIndex = 3;
            this.labelBirth.Text = "День рождение:";
            // 
            // tbPetName
            // 
            this.tbPetName.Location = new System.Drawing.Point(119, 21);
            this.tbPetName.Name = "tbPetName";
            this.tbPetName.Size = new System.Drawing.Size(181, 20);
            this.tbPetName.TabIndex = 4;
            // 
            // tbPetBreed
            // 
            this.tbPetBreed.Location = new System.Drawing.Point(119, 54);
            this.tbPetBreed.Name = "tbPetBreed";
            this.tbPetBreed.Size = new System.Drawing.Size(181, 20);
            this.tbPetBreed.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(224, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 28);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Назад";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(142, 196);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpPetBirth
            // 
            this.dtpPetBirth.Location = new System.Drawing.Point(119, 118);
            this.dtpPetBirth.Name = "dtpPetBirth";
            this.dtpPetBirth.Size = new System.Drawing.Size(181, 20);
            this.dtpPetBirth.TabIndex = 10;
            // 
            // cbPetGender
            // 
            this.cbPetGender.FormattingEnabled = true;
            this.cbPetGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.cbPetGender.Location = new System.Drawing.Point(119, 87);
            this.cbPetGender.Name = "cbPetGender";
            this.cbPetGender.Size = new System.Drawing.Size(181, 21);
            this.cbPetGender.TabIndex = 11;
            // 
            // AddPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 236);
            this.Controls.Add(this.cbPetGender);
            this.Controls.Add(this.dtpPetBirth);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbPetBreed);
            this.Controls.Add(this.tbPetName);
            this.Controls.Add(this.labelBirth);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelBreed);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBreed;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.TextBox tbPetName;
        private System.Windows.Forms.TextBox tbPetBreed;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpPetBirth;
        private System.Windows.Forms.ComboBox cbPetGender;
    }
}