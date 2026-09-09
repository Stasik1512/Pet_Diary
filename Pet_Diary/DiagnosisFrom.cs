using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Diary
{
    public partial class DiagnosisFrom : Form
    {
        private readonly short petId;
        private readonly Query query;
        public DiagnosisFrom(short petId)
        {
            InitializeComponent();

            this.Font = new Font("Tahoma", 14);
            this.petId = petId;
            
            DataBase dataBase = new DataBase();
            query = new Query(dataBase);

            LoadDiagnosisRecords();
        }
        private void LoadDiagnosisRecords()
        {
            try
            {
                DataTable diagnoses = query.GetDiagnosisRecords(petId);
                dgvDiagnosis.DataSource = diagnoses;
                dgvDiagnosis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDiagnosis.BackgroundColor = Color.White;
                if(dgvDiagnosis.Columns.Contains("diagnosis_date"))
                {
                    dgvDiagnosis.Columns["diagnosis_date"].HeaderText = "Дата";
                    dgvDiagnosis.Columns["diagnosis_date"].DefaultCellStyle.Format = "dd.MM.yyyy";
                }
                if(dgvDiagnosis.Columns.Contains("diagnosis"))
                {
                    dgvDiagnosis.Columns["diagnosis"].HeaderText = "Диагноз";
                }
                if(dgvDiagnosis.Columns.Contains("comment"))
                {
                    dgvDiagnosis.Columns["comment"].HeaderText = "Комментарий";
                }
                if(diagnoses.Rows.Count > 0)
                {
                    DataRow lastDiagnosis = diagnoses.Rows[0];
                    lblLastDiagnosisName.Text = "Диагноз: " + lastDiagnosis["diagnosis"].ToString();

                    DateTime diagnosisDate = Convert.ToDateTime(lastDiagnosis["diagnosis_date"]);

                    lblLastDiagnosisDate.Text = "Дата: " + diagnosisDate.ToString("dd.MM.yyyy");
                }
                else
                {
                    lblLastDiagnosisName.Text = "Диагноз: -";
                    lblLastDiagnosisDate.Text = "Дата:-";
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
            string diagnosis = tbDiagnosis.Text.Trim();
            if (string.IsNullOrWhiteSpace(diagnosis))
            {
                MessageBox.Show("Введите диагноз");
                return;
            }
            DateTime diagnosisDate = dtpDiagnosisDate.Value.Date;

            string comment = tbDiagnosisComment.Text.Trim();

            query.AddDiagnosisRecord(petId, diagnosis, diagnosisDate, comment);

            MessageBox.Show("Диагноз успешно добавлен!");

            tbDiagnosis.Clear();
            tbDiagnosisComment.Clear();

            LoadDiagnosisRecords();



        }
    }
}
