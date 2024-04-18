using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeHospitalKov
{
    public partial class FormData : Form
    {
        public FormData()
        {
            InitializeComponent();
        }

        private void FormData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'practicHospitalDataSet.Request' table. You can move, or remove it, as needed.
            this.requestTableAdapter.Fill(this.practicHospitalDataSet.Request);

        }
    }
}
