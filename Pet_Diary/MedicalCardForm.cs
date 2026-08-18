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
    public partial class MedicalCardForm : Form
    {
        private readonly short petId;
        public MedicalCardForm(short petId)
        {
            InitializeComponent();
            this.Font = new Font("Tahoma", 14);

            this.petId = petId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWeight_Click(object sender, EventArgs e)
        {
            WeightForm weightForm = new WeightForm(petId);
            weightForm.ShowDialog();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            FoodForm foodForm = new FoodForm(petId);
            foodForm.ShowDialog();
        }
    }
}
// все спасибо большое
// Ю ар велкам))) выхожу
