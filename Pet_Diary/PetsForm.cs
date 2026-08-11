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
        public PetsForm()
        {
            InitializeComponent();
        }
        public PetsForm(short ownerId)
        {
            InitializeComponent();
            this.ownerId = ownerId;
        }

    }
}
