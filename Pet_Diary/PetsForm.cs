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
    }
}
