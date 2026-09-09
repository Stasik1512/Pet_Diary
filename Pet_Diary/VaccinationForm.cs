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
    public partial class VaccinationForm : Form
    {
        private readonly short petId;
        private readonly Query query;
        public VaccinationForm(short petId)
        {
            InitializeComponent();
            this.Font = new Font("Tahoma", 14);
            this.petId = petId;

            DataBase dataBase = new DataBase();
            query = new Query(dataBase);

            LoadVaccinationRecords();

        }
        private void LoadVaccinationRecords()
        {
            try
            {
                DataTable vaccinations = query.GetVaccinationRecords(petId);

                dgvVaccination.DataSource = vaccinations;
                dgvVaccination.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvVaccination.BackgroundColor = Color.White;

                if (dgvVaccination.Columns.Contains("vac_name"))
                {
                    dgvVaccination.Columns["vac_name"].HeaderText = "Вакцина";
                }

                if (dgvVaccination.Columns.Contains("vac_date"))
                {
                    dgvVaccination.Columns["vac_date"].HeaderText = "Дата";
                    dgvVaccination.Columns["vac_date"].DefaultCellStyle.Format = "dd.MM.yyyy";
                }

                if (dgvVaccination.Columns.Contains("next_vac"))
                {
                    dgvVaccination.Columns["next_vac"].HeaderText = "Следующая вакцинация";
                    dgvVaccination.Columns["next_vac"].DefaultCellStyle.Format = "dd.MM.yyyy";
                }
                if(vaccinations.Rows.Count > 0)
                {
                    DataRow lastVaccination = vaccinations.Rows[0];
                    string vaccineName = Convert.ToString(lastVaccination["vac_name"]);
                    DateTime vaccinationDate = Convert.ToDateTime(lastVaccination["vac_date"]);

                    lblLastVaccineName.Text = $"Название:{vaccineName}";
                    lblLastVaccinationDate.Text = $"Дата: {vaccinationDate: dd.MM.yyyy}";
                }
                else
                {
                    lblLastVaccineName.Text = $"Название: -";
                    lblLastVaccinationDate.Text = $"Дата: -";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string vaccineName = tbVaccineName.Text.Trim();

            if(string.IsNullOrWhiteSpace(vaccineName))
            {
                MessageBox.Show("Введите название вакцины");
                return;
            }
            DateTime vaccinationDate = dtpVaccinationDate.Value.Date;
            DateTime nextVaccinationDate = dtpNextVaccinationDate.Value.Date;
            query.AddVaccinationRecord(
                petId,
                vaccineName,
                vaccinationDate,
                nextVaccinationDate);

            MessageBox.Show("Вакцинация успешно добавлена");

            tbVaccineName.Clear();
            LoadVaccinationRecords();


        }
    }
}
