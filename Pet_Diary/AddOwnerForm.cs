using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pet_Diary
{
    public partial class AddOwnerForm : Form
    {
        private readonly Query query;
        public AddOwnerForm()
        {
            InitializeComponent();

            DataBase dataBase = new DataBase();
            query = new Query(dataBase);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveOwner_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbOwnerName.Text))
            {
                MessageBox.Show(
                    "Введите имя владельца",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int result = query.AddOwner(
            tbOwnerName.Text.Trim(),
            tbPhone.Text.Trim(),
            tbEmail.Text.Trim());

            if (result > 0)
            {
                MessageBox.Show(
                    "Владелец успешно добавлен!",
                    "Готово",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Не удалось добавить владельца",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }
    }
}
