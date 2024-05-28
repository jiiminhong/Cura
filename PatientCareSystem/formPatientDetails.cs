using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientCareSystem
{
    public partial class formPatientDetails : Form
    {
        formPatientList fpl;

        public formPatientDetails()
        {
            InitializeComponent();
        }

        public formPatientDetails(formPatientList fpl)
        {
            InitializeComponent();

            this.fpl = fpl;

            fileLbox.Items.Add("20240404_박지훈_born");
            fileLbox.Items.Add("20240412_박지훈_born2");
            fileLbox.SelectedIndex = 0;

        }
    }
}
