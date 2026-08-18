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
    public partial class FoodForm : Form
    {
        private readonly short petId;
        private readonly Query query;

        public FoodForm(short petId)
        {
            InitializeComponent();
            this.Font = new Font("Tahoma", 14);
            this.petId = petId;

            DataBase dataBase = new DataBase();
            query = new Query(dataBase);

            LoadNutritionRecords();
        }

        public void LoadNutritionRecords()
        {
            DataTable nutrition = query.GetNutritionRecords(petId);

            dgvFood.DataSource = nutrition;

            if(dgvFood.Columns.Contains("date"))
            {
                dgvFood.Columns["date"].HeaderText = "Дата";
                dgvFood.Columns["date"].DefaultCellStyle.Format = "dd.MM.yyyy";
            }

            if(dgvFood.Columns.Contains("food_name"))
            {
                dgvFood.Columns["food_name"].HeaderText = "Фирма";
            }

            if (dgvFood.Columns.Contains("food_type"))
            {
                dgvFood.Columns["food_type"].HeaderText = "Тип корма";
            }

            if (nutrition.Rows.Count > 0)
            {
                DataRow lastFood = nutrition.Rows[0];
                string foodName = Convert.ToString(lastFood["food_name"]);
                string foodType = Convert.ToString(lastFood["food_type"]);
                DateTime date = Convert.ToDateTime(lastFood["date"]);

                lblLastFood.Text = $"Последнйи корм: {foodName}";
                lblLastFoodType.Text = $"Тип: {foodType}";
                lblLastFoodDate.Text = $"Записан: {date:dd.MM.yyyy}";
            }
            else
            {
                lblLastFood.Text = "Последний корм: -";
                lblLastFoodType.Text = "Тип: -";
                lblLastFoodDate.Text = "Дата: -";

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string foodName = tbFoodBrand.Text.Trim();

            if (string.IsNullOrWhiteSpace(foodName))
            {
                MessageBox.Show("Введите название фирмы корма.");
                return;
            }
            if(cbFoodType.SelectedItem == null)
            {
                MessageBox.Show("Питание успешно сохранннено");
                return;
            }

            string foodType = cbFoodType.SelectedItem.ToString();
            DateTime date = dtpFoodDate.Value.Date;

            query.AddNutritionsRecord(petId, foodName, foodType, date);
            MessageBox.Show("Питание успешно сохраннено");

            tbFoodBrand.Clear();
            cbFoodType.SelectedIndex = -1;

            LoadNutritionRecords();


        }
    }
}
