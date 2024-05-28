using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PatientCareSystem
{
    public partial class formPatientList : Form
    {
        string _server = ""; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 0; //DB 서버 포트
        string _database = ""; //DB 이름
        string _id = ""; //계정 아이디
        string _pw = ""; //계정 비밀번호
        string _connectionAddress = "";

        public formPatientList()
        {
            InitializeComponent();

            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);

            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    //mysql.Open();
                    //accounts_table의 전체 데이터를 조회합니다.            
                    string selectQuery = string.Format("SELECT * FROM patient");
                    mysql.Open();

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    while (table.Read())
                    {
                        dataGridView1.Rows.Add(table["pNo"], table["pName"], table["pBirth"], table["pGender"], table["pPhone"]);
                    }
                    mysql.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.pnlPatient.Controls.Clear();
            formPatientDetails FormPatientDetails_ct = new formPatientDetails(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormPatientDetails_ct.FormBorderStyle = FormBorderStyle.None;
            this.pnlPatient.Controls.Add(FormPatientDetails_ct);

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string data1 = row.Cells[1].Value.ToString();
            string data2 = "( " + row.Cells[3].Value.ToString() + " / " + row.Cells[2].Value.ToString() + " )";
            FormPatientDetails_ct.lblpName.Text = data1;
            FormPatientDetails_ct.lblpInfo.Text = data2;


            //if (FormPatientDetails_ct.fileLbox.SelectedItem.ToString().Contains(data1))
            //{
            //    FormPatientDetails_ct.fileLbox.Items.Clear();
            //    FormPatientDetails_ct.fileLbox.Items.Add("20240404_박지훈_born");
            //    FormPatientDetails_ct.fileLbox.Items.Add("20240412_박지훈_born2");
            //    FormPatientDetails_ct.fileLbox.SelectedIndex = 0;
            //}

            FormPatientDetails_ct.Show();
        }
    }
}
