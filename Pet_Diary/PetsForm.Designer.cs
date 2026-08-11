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
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(317, 90);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 28);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Назад";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            // PetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 130);
            this.Controls.Add(this.cbPets);
            this.Controls.Add(this.labelPets);
            this.Controls.Add(this.btnCancel);
            this.Name = "PetsForm";
            this.Text = "PetsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelPets;
        private System.Windows.Forms.ComboBox cbPets;
    }
}