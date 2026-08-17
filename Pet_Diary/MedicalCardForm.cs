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

            this.petId = petId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWeight_Click(object sender, EventArgs e)
        {
            WeightForm form = new WeightForm();
            form.ShowDialog();
        }
    }
}
