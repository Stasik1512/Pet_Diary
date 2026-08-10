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
            cbOwner.DisplayMember = "owner_name";
            cbOwner.ValueMember = "owner_id";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOwnerForm form = new AddOwnerForm();
            if (form.ShowDialog() == DialogResult.OK)
            { }
        }

       
    }
}
