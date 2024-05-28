using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            fileLbox.Items.Add("20240528_Mrbrain");
            fileLbox.Items.Add("20240429_Ultrasound");
            fileLbox.SelectedIndex = 0;
        }

        private void fileLbox_DoubleClick(object sender, EventArgs e)
        {
            if (fileLbox.SelectedItem != null)
            {
                string dicomFileName = fileLbox.SelectedItem.ToString();
                string dicomFilePath = Path.Combine(Application.StartupPath, "DicomFiles", dicomFileName + ".DCM");
                if (File.Exists(dicomFilePath))
                {
                    dicomViewForm viewerForm = new dicomViewForm(dicomFilePath);
                    viewerForm.Show();
                }
                else
                {
                    MessageBox.Show("DICOM file not found: " + dicomFilePath);
                }
            }
        }
    }
}
