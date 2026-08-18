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
    public partial class WeightForm : Form
    {
        private readonly short petId;
        private readonly Query query;

        public WeightForm(short petId)
        {
            InitializeComponent();
            this.Font = new Font("Tahoma", 14);

            this.petId = petId;

            DataBase dataBase = new DataBase();
            query = new Query(dataBase);

            LoadWeightRecords();
        }
        private void LoadWeightRecords()
        {
            DataTable weights = query.GetWeightRecords(petId);

            dgvWeight.DataSource = weights;

            if (dgvWeight.Columns.Contains("date"))
            {
                dgvWeight.Columns["date"].HeaderText = "Дата";
                dgvWeight.Columns["date"].DefaultCellStyle.Format = "dd.MM.yyyy";
            }
            if (dgvWeight.Columns.Contains("weight"))
            {
                dgvWeight.Columns["weight"].HeaderText = "Вес (кг)";
                dgvWeight.Columns["weight"].DefaultCellStyle.Format = "0.00";
            }

            if (weights.Rows.Count > 0)
            {
                DataRow lastWeight = weights.Rows[0];

                decimal weight = Convert.ToDecimal(lastWeight["weight"]);
                DateTime date = Convert.ToDateTime(lastWeight["date"]);

                lblLastWeight.Text = $"Последний вес: {weight:0.00} кг";
                lblLastWeightDate.Text = $"Измерен: {date:dd.MM.yyyy}";
            }
            else
            {
                lblLastWeight.Text = "Последний вес: -";
                lblLastWeightDate.Text = "Измерен: -";
            }

            //DataTable weights = query.GetWeightRecords(petId);

            //MessageBox.Show("Запрос выполнен");

            //dgvWeight.DataSource = weights;

            //MessageBox.Show("Таблица загружена");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string weightText = tbWeight.Text.Trim().Replace('.', ',');

            if(!decimal.TryParse(weightText, out decimal weight))
            {
                MessageBox.Show("Введите корректный вес");
                return;
            }
            if(weight <= 0 )
            {
                MessageBox.Show("Вес должен быть больше 0");
                return;
            }
            DateTime date = dtpWeightDate.Value.Date;
            query.AddWeightRecord(petId, weight, date);

            MessageBox.Show("Вес успешно сохранен");

            tbWeight.Clear();
            LoadWeightRecords();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
