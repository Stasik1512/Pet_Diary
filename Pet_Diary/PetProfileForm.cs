using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Diary
{
    public partial class PetProfileForm : Form
    {
        private readonly short petId;
        private readonly Query query;
        public PetProfileForm(short petId)
        {
            InitializeComponent();
            this.petId = petId;
            
            DataBase dataBase = new DataBase();
            query = new Query(dataBase);

            LoadPetProfile();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadPetProfile()
        {
            DataTable pet = query.GetPetProfile(petId);

            if (pet.Rows.Count == 0)
                return;

            DataRow row = pet.Rows[0];

            lblPetNameValue.Text = row["pet_name"].ToString();
            lblPetBreedValue.Text = row["pet_breed"].ToString();
            lblPetGenderValue.Text = row["pet_gender"].ToString();
            lblOwnerValue.Text = row["owner_name"].ToString();

            if (row["pet_birth"] != DBNull.Value)
            {
                DateTime birthDate = Convert.ToDateTime(row["pet_birth"]);
                lblPetBirthValue.Text = birthDate.ToString("dd.MM.yyyy");
            }
            else
            {
                lblPetBirthValue.Text = "-";
            }

            // Загрузка фотографии
            if (row["pet_photo"] != DBNull.Value)
            {
                byte[] photo = (byte[])row["pet_photo"];

                using (MemoryStream stream = new MemoryStream(photo))
                using (Image image = Image.FromStream(stream))
                {
                    pbPetPhoto.Image = new Bitmap(image);
                }
            }
            else
            {
                pbPetPhoto.Image = null;
            }
        }

        private void pbPetPhoto_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Выберите фотографию питомца";
                dialog.Filter = "Изображение|*.jpg;*.jpeg;*.png;*.bmp;*.img;*.helf|Все файлы|*.*";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                byte[] photo = File.ReadAllBytes(dialog.FileName);
                int result = query.UpdatePetPhoto(petId, photo);

                if(result > 0)
                {
                    using(MemoryStream stream = new MemoryStream(photo))
                    {
                        pbPetPhoto.Image = Image.FromStream(stream);
                    }

                    MessageBox.Show
                    (
                        "Фотография успешно добавлена!",
                        "Готово",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

            }
        }

        private void btnMedical_Click(object sender, EventArgs e)
        {
            MedicalCardForm form = new MedicalCardForm(petId);
            form.ShowDialog();
        }
    }
}
