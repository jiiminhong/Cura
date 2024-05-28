using FellowOakDicom.Imaging;
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
    public partial class dicomViewForm : Form
    {
        private PictureBox pictureBox;

        public dicomViewForm(string dicomFilePath)
        {
            InitializeComponent();
            InitializePictureBox();
            LoadDicomFile(dicomFilePath);
        }

        private void InitializePictureBox()
        {
            pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            this.Controls.Add(pictureBox);
        }

        private void LoadDicomFile(string dicomFilePath)
        {
            try
            {
                var dicomImage = new DicomImage(dicomFilePath);
                using (var bitmap = dicomImage.RenderImage().As<Bitmap>())
                {
                    pictureBox.Image = bitmap;
                    //pictureBox.Image = dicomImage.RenderImage().As<Bitmap>().Save(@"test.jpg");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading DICOM file: " + ex.Message);
            }
        }
    }
}
