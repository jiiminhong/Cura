using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PatientCareSystem
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public Form1()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(244, 244, 239);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(244, 244, 239);
        }

        private void btnPatientList_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPatientList.Height;
            pnlNav.Top = btnPatientList.Top;
            btnPatientList.BackColor = Color.FromArgb(244, 244, 239);
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAppointment.Height;
            pnlNav.Top = btnAppointment.Top;
            btnAppointment.BackColor = Color.FromArgb(244, 244, 239);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(244, 244, 239);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPatientList_Leave(object sender, EventArgs e)
        {
            btnPatientList.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAppointment_Leave(object sender, EventArgs e)
        {
            btnAppointment.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
