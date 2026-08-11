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
    public partial class MainForm : Form
    {
        private readonly Query query;
        public MainForm()
        {
            InitializeComponent();
            this.Font = new Font("Tahoma", 14);

            DataBase dataBase = new DataBase();
            query = new Query(dataBase);

            LoadOwners();
        }
        private void LoadOwners()
        {
            DataTable owners = query.GetAllOwners();

            cbOwner.DataSource = owners;
            cbOwner  .DisplayMember = "owner_name";
            cbOwner.ValueMember = "owner_id";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOwnerForm form = new AddOwnerForm();
            if (form.ShowDialog() == DialogResult.OK)
            { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(cbOwner.SelectedValue == null)
            {
                MessageBox.Show
                (
                    "Сначала веберите владелца",
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            short ownerId = Convert.ToInt16( cbOwner.SelectedValue );
            //MessageBox.Show($"Выбран owner_id: {ownerId}");

            DialogResult result = MessageBox.Show
            (
                "Вы действительно хотите удалить выбранного владельца?",
                "Удаление владельца",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.No)
                return;

            int rownAffected = query.DeleteOwner( ownerId );

            if( rownAffected > 0 )
            {
                MessageBox.Show
                (
                    "Владелец успешно удален!",
                    "Готово",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadOwners();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if( cbOwner.SelectedValue == null)
            {
                MessageBox.Show
                (
                    "Сначала выберите владельца",
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            short ownerId = Convert.ToInt16(cbOwner.SelectedValue);

            PetsForm form = new PetsForm(ownerId);
            form.ShowDialog();
        }
    }
}
