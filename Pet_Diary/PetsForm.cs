using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Diary
{
    public partial class PetsForm : Form
    {
        private readonly short ownerId;

        private readonly Query query;
        public PetsForm(short ownerId)
        {
            InitializeComponent();
            this.ownerId = ownerId;

            DataBase dataBase = new DataBase();
            query = new Query(dataBase);

            LoadPets();
        }
        private void LoadPets()
        {
            DataTable pets = query.GetPetsByOwner(ownerId);

            cbPets.DataSource = null;
            cbPets.DataSource = pets;

            cbPets.DisplayMember = "pet_name";
            cbPets.ValueMember = "pet_id";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            AddPetForm form = new AddPetForm(ownerId);
            if(form.ShowDialog() == DialogResult.OK)
            {
                LoadPets();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbPets.SelectedValue == null)
            {
                MessageBox.Show
                (
                    "Сначала выберите питомца",
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            short petId = Convert.ToInt16(cbPets.SelectedValue);
            //MessageBox.Show($"Выбран owner_id: {ownerId}");

            DialogResult result = MessageBox.Show
            (
                "Вы действительно хотите удалить выбранного питомца?",
                "Удаление питомца",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.No)
                return;

            int rownAffected = query.DeletePet(petId);

            if (rownAffected > 0)
            {
                MessageBox.Show
                (
                    "Питомец успешно удален!",
                    "Готово",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadPets();
            }
        }
    }
}
