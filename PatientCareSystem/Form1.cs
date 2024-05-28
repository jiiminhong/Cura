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
using System.Windows.Forms.VisualStyles;
using System.Drawing.Drawing2D;

namespace PatientCareSystem
{
    public partial class Form1 : Form
    {
        private bool mouseOn;
        private Point startPoint = new Point(0, 0);

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
            txtSearch.Padding = new Padding(10, 0, 0, 0);

            lblTitle.Text = "Dashboard";
            this.pnlFormContainer.Controls.Clear();
            formDashboard FormDashboard_ct = new formDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormDashboard_ct.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormContainer.Controls.Add(FormDashboard_ct);
            FormDashboard_ct.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {
            Color firstColor = System.Drawing.ColorTranslator.FromHtml("#00A8F1");
            Color SecontColor = System.Drawing.ColorTranslator.FromHtml("#00E1A5");
            LinearGradientBrush br = new LinearGradientBrush(this.ClientRectangle, firstColor, SecontColor, 45, false);
            e.Graphics.FillRectangle(br, this.ClientRectangle);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(244, 244, 239);

            lblTitle.Text = "Dashboard";
            this.pnlFormContainer.Controls.Clear();
            formDashboard FormDashboard_ct = new formDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormDashboard_ct.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormContainer.Controls.Add(FormDashboard_ct);
            FormDashboard_ct.Show();
        }

        private void btnPatientList_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPatientList.Height;
            pnlNav.Top = btnPatientList.Top;
            btnPatientList.BackColor = Color.FromArgb(244, 244, 239);

            lblTitle.Text = "Patient List";
            this.pnlFormContainer.Controls.Clear();
            formPatientList FormPatientList_ct = new formPatientList() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormPatientList_ct.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormContainer.Controls.Add(FormPatientList_ct);
            FormPatientList_ct.Show();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAppointment.Height;
            pnlNav.Top = btnAppointment.Top;
            btnAppointment.BackColor = Color.FromArgb(244, 244, 239);

            lblTitle.Text = "Appointment";
            this.pnlFormContainer.Controls.Clear();
            formAppointment FormAppointment_ct = new formAppointment() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormAppointment_ct.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormContainer.Controls.Add(FormAppointment_ct);
            FormAppointment_ct.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(244, 244, 239);

            lblTitle.Text = "Settings";
            this.pnlFormContainer.Controls.Clear();
            formSettings FormSettings_ct = new formSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormSettings_ct.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormContainer.Controls.Add(FormSettings_ct);
            FormSettings_ct.Show();
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

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            mouseOn = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void pnlTitle_MouseUp(object sender, MouseEventArgs e)
        {
            mouseOn = false;
        }

        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseOn)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
