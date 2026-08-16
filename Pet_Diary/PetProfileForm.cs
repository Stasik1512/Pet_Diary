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
            if (row["pet_birth"] != DBNull.Value)
            {
                DateTime birthDate = Convert.ToDateTime(row["pet_birth"]);
                lblPetBirthValue.Text = birthDate.ToString("dd.MM.yyyy");


            }
            else
            {
                lblPetBirthValue.Text = "-";
            }
            
        }
    }
}
