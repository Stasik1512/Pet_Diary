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
    public partial class AddPetForm : Form
    {
        private readonly short ownerId;
        private readonly Query query;
        public AddPetForm(short ownerId)
        {
            InitializeComponent();

            this.ownerId = ownerId;

            DataBase dataBase = new DataBase();
            query = new Query(dataBase);


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int result = query.AddPet
            (
                tbPetName.Text,
                tbPetBreed.Text,
                cbPetGender.Text,
                dtpPetBirth.Value,
                ownerId
            );

            if(result > 0)
            {
                MessageBox.Show
                (
                    "Питомец успешно добавлен!",
                    "Готово",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
