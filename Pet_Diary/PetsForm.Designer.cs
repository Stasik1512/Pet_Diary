namespace Pet_Diary
{
    partial class PetsForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelPets = new System.Windows.Forms.Label();
            this.cbPets = new System.Windows.Forms.ComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDeletePet = new System.Windows.Forms.Button();
            this.btnAddPet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(235, 90);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 28);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Назад";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // labelPets
            // 
            this.labelPets.AutoSize = true;
            this.labelPets.Location = new System.Drawing.Point(13, 13);
            this.labelPets.Name = "labelPets";
            this.labelPets.Size = new System.Drawing.Size(106, 13);
            this.labelPets.TabIndex = 1;
            this.labelPets.Text = "Выберите питомца:";
            // 
            // cbPets
            // 
            this.cbPets.FormattingEnabled = true;
            this.cbPets.Location = new System.Drawing.Point(16, 46);
            this.cbPets.Name = "cbPets";
            this.cbPets.Size = new System.Drawing.Size(377, 21);
            this.cbPets.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(317, 90);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(76, 28);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Дальше";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnDeletePet
            // 
            this.btnDeletePet.Location = new System.Drawing.Point(153, 90);
            this.btnDeletePet.Name = "btnDeletePet";
            this.btnDeletePet.Size = new System.Drawing.Size(76, 28);
            this.btnDeletePet.TabIndex = 4;
            this.btnDeletePet.Text = "Удалить";
            this.btnDeletePet.UseVisualStyleBackColor = true;
            this.btnDeletePet.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddPet
            // 
            this.btnAddPet.Location = new System.Drawing.Point(69, 90);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(76, 28);
            this.btnAddPet.TabIndex = 3;
            this.btnAddPet.Text = "Добавить";
            this.btnAddPet.UseVisualStyleBackColor = true;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // PetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 130);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnDeletePet);
            this.Controls.Add(this.btnAddPet);
            this.Controls.Add(this.cbPets);
            this.Controls.Add(this.labelPets);
            this.Controls.Add(this.btnCancel);
            this.Name = "PetsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelPets;
        private System.Windows.Forms.ComboBox cbPets;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnDeletePet;
        private System.Windows.Forms.Button btnAddPet;
    }
}