namespace PatientCareSystem
{
    partial class formPatientDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblpName = new System.Windows.Forms.Label();
            this.lblpInfo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fileLbox = new System.Windows.Forms.ListBox();
            this.mNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRoute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAccumulated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpName
            // 
            this.lblpName.AutoSize = true;
            this.lblpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpName.Location = new System.Drawing.Point(28, 18);
            this.lblpName.Name = "lblpName";
            this.lblpName.Size = new System.Drawing.Size(51, 29);
            this.lblpName.TabIndex = 0;
            this.lblpName.Text = "이름";
            // 
            // lblpInfo
            // 
            this.lblpInfo.AutoSize = true;
            this.lblpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpInfo.Location = new System.Drawing.Point(94, 28);
            this.lblpInfo.Name = "lblpInfo";
            this.lblpInfo.Size = new System.Drawing.Size(29, 16);
            this.lblpInfo.TabIndex = 1;
            this.lblpInfo.Text = "정보";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(80)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(80)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mNo,
            this.mName,
            this.mStart,
            this.mEnd,
            this.mRoute,
            this.mCapacity,
            this.mUnit,
            this.mAccumulated});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(33, 99);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(723, 133);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Medicaiton";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current Medicaiton";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(344, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(380, 62);
            this.textBox1.TabIndex = 7;
            // 
            // fileLbox
            // 
            this.fileLbox.FormattingEnabled = true;
            this.fileLbox.ItemHeight = 12;
            this.fileLbox.Location = new System.Drawing.Point(33, 279);
            this.fileLbox.Name = "fileLbox";
            this.fileLbox.Size = new System.Drawing.Size(310, 208);
            this.fileLbox.TabIndex = 8;
            this.fileLbox.DoubleClick += new System.EventHandler(this.fileLbox_DoubleClick);
            // 
            // mNo
            // 
            this.mNo.HeaderText = "No.";
            this.mNo.Name = "mNo";
            this.mNo.Width = 50;
            // 
            // mName
            // 
            this.mName.HeaderText = "처방명";
            this.mName.Name = "mName";
            this.mName.Width = 120;
            // 
            // mStart
            // 
            this.mStart.HeaderText = "투여시작일";
            this.mStart.Name = "mStart";
            this.mStart.Width = 90;
            // 
            // mEnd
            // 
            this.mEnd.HeaderText = "투여종료일";
            this.mEnd.Name = "mEnd";
            this.mEnd.Width = 90;
            // 
            // mRoute
            // 
            this.mRoute.HeaderText = "투여경로";
            this.mRoute.Name = "mRoute";
            this.mRoute.Width = 80;
            // 
            // mCapacity
            // 
            this.mCapacity.HeaderText = "1일용량";
            this.mCapacity.Name = "mCapacity";
            this.mCapacity.Width = 80;
            // 
            // mUnit
            // 
            this.mUnit.HeaderText = "단위";
            this.mUnit.Name = "mUnit";
            this.mUnit.Width = 80;
            // 
            // mAccumulated
            // 
            this.mAccumulated.HeaderText = "누적용량";
            this.mAccumulated.Name = "mAccumulated";
            this.mAccumulated.Width = 80;
            // 
            // formPatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(765, 510);
            this.Controls.Add(this.fileLbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblpInfo);
            this.Controls.Add(this.lblpName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPatientDetails";
            this.Text = "formPatientDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblpName;
        internal System.Windows.Forms.Label lblpInfo;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.ListBox fileLbox;
        internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRoute;
        private System.Windows.Forms.DataGridViewTextBoxColumn mCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAccumulated;
    }
}