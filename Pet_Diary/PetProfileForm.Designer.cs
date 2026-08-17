namespace Pet_Diary
{
    partial class PetProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetProfileForm));
            this.pbPetPhoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPetBirth = new System.Windows.Forms.Label();
            this.labelPetGender = new System.Windows.Forms.Label();
            this.labelPetBreed = new System.Windows.Forms.Label();
            this.labelPetName = new System.Windows.Forms.Label();
            this.labelOwner = new System.Windows.Forms.Label();
            this.btnMedical = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDocuments = new System.Windows.Forms.Button();
            this.lblPetNameValue = new System.Windows.Forms.Label();
            this.lblPetBreedValue = new System.Windows.Forms.Label();
            this.lblPetGenderValue = new System.Windows.Forms.Label();
            this.lblPetBirthValue = new System.Windows.Forms.Label();
            this.lblOwnerValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPetPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPetPhoto
            // 
            this.pbPetPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPetPhoto.Location = new System.Drawing.Point(12, 31);
            this.pbPetPhoto.Name = "pbPetPhoto";
            this.pbPetPhoto.Size = new System.Drawing.Size(152, 167);
            this.pbPetPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPetPhoto.TabIndex = 0;
            this.pbPetPhoto.TabStop = false;
            this.pbPetPhoto.DoubleClick += new System.EventHandler(this.pbPetPhoto_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Досье питомца";
            // 
            // labelPetBirth
            // 
            this.labelPetBirth.AutoSize = true;
            this.labelPetBirth.Location = new System.Drawing.Point(170, 113);
            this.labelPetBirth.Name = "labelPetBirth";
            this.labelPetBirth.Size = new System.Drawing.Size(90, 13);
            this.labelPetBirth.TabIndex = 7;
            this.labelPetBirth.Text = "День рождение:";
            // 
            // labelPetGender
            // 
            this.labelPetGender.AutoSize = true;
            this.labelPetGender.Location = new System.Drawing.Point(170, 90);
            this.labelPetGender.Name = "labelPetGender";
            this.labelPetGender.Size = new System.Drawing.Size(30, 13);
            this.labelPetGender.TabIndex = 6;
            this.labelPetGender.Text = "Пол:";
            // 
            // labelPetBreed
            // 
            this.labelPetBreed.AutoSize = true;
            this.labelPetBreed.Location = new System.Drawing.Point(170, 67);
            this.labelPetBreed.Name = "labelPetBreed";
            this.labelPetBreed.Size = new System.Drawing.Size(45, 13);
            this.labelPetBreed.TabIndex = 5;
            this.labelPetBreed.Text = "Порода";
            // 
            // labelPetName
            // 
            this.labelPetName.AutoSize = true;
            this.labelPetName.Location = new System.Drawing.Point(170, 44);
            this.labelPetName.Name = "labelPetName";
            this.labelPetName.Size = new System.Drawing.Size(32, 13);
            this.labelPetName.TabIndex = 4;
            this.labelPetName.Text = "Имя:";
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Location = new System.Drawing.Point(170, 136);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(59, 13);
            this.labelOwner.TabIndex = 8;
            this.labelOwner.Text = "Владелец:";
            // 
            // btnMedical
            // 
            this.btnMedical.Location = new System.Drawing.Point(35, 239);
            this.btnMedical.Name = "btnMedical";
            this.btnMedical.Size = new System.Drawing.Size(135, 46);
            this.btnMedical.TabIndex = 9;
            this.btnMedical.Text = "Мед. карта";
            this.btnMedical.UseVisualStyleBackColor = true;
            this.btnMedical.Click += new System.EventHandler(this.btnMedical_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(185, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 46);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Назад";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDocuments
            // 
            this.btnDocuments.Location = new System.Drawing.Point(335, 239);
            this.btnDocuments.Name = "btnDocuments";
            this.btnDocuments.Size = new System.Drawing.Size(135, 46);
            this.btnDocuments.TabIndex = 11;
            this.btnDocuments.Text = "Документы";
            this.btnDocuments.UseVisualStyleBackColor = true;
            // 
            // lblPetNameValue
            // 
            this.lblPetNameValue.AutoSize = true;
            this.lblPetNameValue.Location = new System.Drawing.Point(373, 44);
            this.lblPetNameValue.Name = "lblPetNameValue";
            this.lblPetNameValue.Size = new System.Drawing.Size(10, 13);
            this.lblPetNameValue.TabIndex = 14;
            this.lblPetNameValue.Text = "-";
            // 
            // lblPetBreedValue
            // 
            this.lblPetBreedValue.AutoSize = true;
            this.lblPetBreedValue.Location = new System.Drawing.Point(373, 67);
            this.lblPetBreedValue.Name = "lblPetBreedValue";
            this.lblPetBreedValue.Size = new System.Drawing.Size(10, 13);
            this.lblPetBreedValue.TabIndex = 15;
            this.lblPetBreedValue.Text = "-";
            // 
            // lblPetGenderValue
            // 
            this.lblPetGenderValue.AutoSize = true;
            this.lblPetGenderValue.Location = new System.Drawing.Point(373, 90);
            this.lblPetGenderValue.Name = "lblPetGenderValue";
            this.lblPetGenderValue.Size = new System.Drawing.Size(10, 13);
            this.lblPetGenderValue.TabIndex = 17;
            this.lblPetGenderValue.Text = "-";
            // 
            // lblPetBirthValue
            // 
            this.lblPetBirthValue.AutoSize = true;
            this.lblPetBirthValue.Location = new System.Drawing.Point(373, 113);
            this.lblPetBirthValue.Name = "lblPetBirthValue";
            this.lblPetBirthValue.Size = new System.Drawing.Size(10, 13);
            this.lblPetBirthValue.TabIndex = 16;
            this.lblPetBirthValue.Text = "-";
            // 
            // lblOwnerValue
            // 
            this.lblOwnerValue.AutoSize = true;
            this.lblOwnerValue.Location = new System.Drawing.Point(373, 135);
            this.lblOwnerValue.Name = "lblOwnerValue";
            this.lblOwnerValue.Size = new System.Drawing.Size(10, 13);
            this.lblOwnerValue.TabIndex = 18;
            this.lblOwnerValue.Text = "-";
            // 
            // PetProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 297);
            this.Controls.Add(this.lblOwnerValue);
            this.Controls.Add(this.lblPetGenderValue);
            this.Controls.Add(this.lblPetBirthValue);
            this.Controls.Add(this.lblPetBreedValue);
            this.Controls.Add(this.lblPetNameValue);
            this.Controls.Add(this.btnDocuments);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMedical);
            this.Controls.Add(this.labelOwner);
            this.Controls.Add(this.labelPetBirth);
            this.Controls.Add(this.labelPetGender);
            this.Controls.Add(this.labelPetBreed);
            this.Controls.Add(this.labelPetName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPetPhoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PetProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetProfileForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbPetPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPetPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPetBirth;
        private System.Windows.Forms.Label labelPetGender;
        private System.Windows.Forms.Label labelPetBreed;
        private System.Windows.Forms.Label labelPetName;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.Button btnMedical;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDocuments;
        private System.Windows.Forms.Label lblPetNameValue;
        private System.Windows.Forms.Label lblPetBreedValue;
        private System.Windows.Forms.Label lblPetGenderValue;
        private System.Windows.Forms.Label lblPetBirthValue;
        private System.Windows.Forms.Label lblOwnerValue;
    }
}