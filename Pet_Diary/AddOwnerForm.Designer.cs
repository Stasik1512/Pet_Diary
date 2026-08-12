namespace Pet_Diary
{
    partial class AddOwnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOwnerForm));
            this.labelName = new System.Windows.Forms.Label();
            this.tbOwnerName = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveOwner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Имя:";
            // 
            // tbOwnerName
            // 
            this.tbOwnerName.Location = new System.Drawing.Point(124, 16);
            this.tbOwnerName.Name = "tbOwnerName";
            this.tbOwnerName.Size = new System.Drawing.Size(173, 20);
            this.tbOwnerName.TabIndex = 1;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(16, 63);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(61, 13);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Телелфон:";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(124, 59);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(173, 20);
            this.tbPhone.TabIndex = 3;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(16, 110);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(124, 106);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(173, 20);
            this.tbEmail.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(222, 136);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveOwner
            // 
            this.btnSaveOwner.Location = new System.Drawing.Point(140, 136);
            this.btnSaveOwner.Name = "btnSaveOwner";
            this.btnSaveOwner.Size = new System.Drawing.Size(76, 28);
            this.btnSaveOwner.TabIndex = 10;
            this.btnSaveOwner.Text = "Сохранить";
            this.btnSaveOwner.UseVisualStyleBackColor = true;
            this.btnSaveOwner.Click += new System.EventHandler(this.btnSaveOwner_Click_1);
            // 
            // AddOwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 177);
            this.Controls.Add(this.btnSaveOwner);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.tbOwnerName);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddOwnerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOwnerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox tbOwnerName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveOwner;
    }
}