namespace QuanLyChuyenBay
{
    partial class frmPassenger
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtTen_Hanh_Khach = new System.Windows.Forms.TextBox();
            this.txtDia_Chi = new System.Windows.Forms.TextBox();
            this.txtPassport_No = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.dTNgay_Sinh = new System.Windows.Forms.DateTimePicker();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Passenger_Passport_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passenger_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passenger_Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passenger_BirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passenger_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(220, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quản lý hành khách";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTen_Hanh_Khach
            // 
            this.txtTen_Hanh_Khach.Location = new System.Drawing.Point(184, 110);
            this.txtTen_Hanh_Khach.Name = "txtTen_Hanh_Khach";
            this.txtTen_Hanh_Khach.Size = new System.Drawing.Size(148, 20);
            this.txtTen_Hanh_Khach.TabIndex = 20;
            // 
            // txtDia_Chi
            // 
            this.txtDia_Chi.Location = new System.Drawing.Point(454, 110);
            this.txtDia_Chi.Name = "txtDia_Chi";
            this.txtDia_Chi.Size = new System.Drawing.Size(148, 20);
            this.txtDia_Chi.TabIndex = 22;
            // 
            // txtPassport_No
            // 
            this.txtPassport_No.Location = new System.Drawing.Point(184, 76);
            this.txtPassport_No.Name = "txtPassport_No";
            this.txtPassport_No.Size = new System.Drawing.Size(148, 20);
            this.txtPassport_No.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tên hành khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pasenger Passport No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Điện thoại ";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(454, 153);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(148, 20);
            this.txtDienThoai.TabIndex = 22;
            // 
            // dTNgay_Sinh
            // 
            this.dTNgay_Sinh.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dTNgay_Sinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTNgay_Sinh.Location = new System.Drawing.Point(454, 73);
            this.dTNgay_Sinh.Name = "dTNgay_Sinh";
            this.dTNgay_Sinh.Size = new System.Drawing.Size(148, 20);
            this.dTNgay_Sinh.TabIndex = 25;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Checked = true;
            this.rdoNam.Location = new System.Drawing.Point(184, 153);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(47, 17);
            this.rdoNam.TabIndex = 26;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(237, 153);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(39, 17);
            this.rdoNu.TabIndex = 26;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Passenger_Passport_No,
            this.Passenger_Name,
            this.Passenger_Sex,
            this.Passenger_BirthDay,
            this.Passenger_Phone});
            this.dataGridView1.Location = new System.Drawing.Point(65, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 150);
            this.dataGridView1.TabIndex = 27;
            // 
            // Passenger_Passport_No
            // 
            this.Passenger_Passport_No.HeaderText = "Passenger Passport No";
            this.Passenger_Passport_No.Name = "Passenger_Passport_No";
            // 
            // Passenger_Name
            // 
            this.Passenger_Name.HeaderText = "Hành khách";
            this.Passenger_Name.Name = "Passenger_Name";
            // 
            // Passenger_Sex
            // 
            this.Passenger_Sex.HeaderText = "Giới tính";
            this.Passenger_Sex.Name = "Passenger_Sex";
            // 
            // Passenger_BirthDay
            // 
            this.Passenger_BirthDay.HeaderText = "Ngày sinh";
            this.Passenger_BirthDay.Name = "Passenger_BirthDay";
            // 
            // Passenger_Phone
            // 
            this.Passenger_Phone.HeaderText = "Điện thoại";
            this.Passenger_Phone.Name = "Passenger_Phone";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(475, 381);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(355, 381);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 29;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(236, 381);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 30;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(115, 381);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // frmPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 420);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rdoNu);
            this.Controls.Add(this.rdoNam);
            this.Controls.Add(this.dTNgay_Sinh);
            this.Controls.Add(this.txtTen_Hanh_Khach);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtDia_Chi);
            this.Controls.Add(this.txtPassport_No);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "frmPassenger";
            this.Text = "Quản lý hành khách";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTen_Hanh_Khach;
        private System.Windows.Forms.TextBox txtDia_Chi;
        private System.Windows.Forms.TextBox txtPassport_No;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.DateTimePicker dTNgay_Sinh;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passenger_Passport_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passenger_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passenger_Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passenger_BirthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passenger_Phone;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnReset;
    }
}